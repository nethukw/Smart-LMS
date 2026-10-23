using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLMS
{
    public partial class MaterialUploadForm : Form
    {
        public MaterialUploadForm()
        {
            InitializeComponent();
            LoadCourseList();
            LoadMaterials();
        }

        private void MaterialUploadForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadCourseList()
        {
            comboBoxCourse.Items.Clear();

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                string query = "SELECT Title FROM Courses";

                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBoxCourse.Items.Add(reader.GetString("Title"));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading course titles: " + ex.Message);
                }
            }
        }

        private void LoadMaterials()
        {
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                string query = "SELECT MaterialID, Title, Description, Course, FilePath, UploadedBy, UploadDate FROM Materials";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvMaterials.DataSource = dt;
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string description = rtbDescription.Text.Trim();
            string course = comboBoxCourse.SelectedItem?.ToString();
            string filePath = txtFilePath.Text.Trim();
            string uploadedBy = txtUploadedBy.Text.Trim();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(course) || string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Please fill all required fields: Title, Course, and File.");
                return;
            }

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                string query = @"INSERT INTO Materials 
                         (Title, Description, Course, FilePath, UploadedBy, UploadDate)
                         VALUES (@Title, @Description, @Course, @FilePath, @UploadedBy, NOW())";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Course", course);
                cmd.Parameters.AddWithValue("@FilePath", filePath);
                cmd.Parameters.AddWithValue("@UploadedBy", uploadedBy);

                conn.Open();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Material uploaded successfully!");
                    ClearFields();
                    LoadMaterials();
                }
                else
                {
                    MessageBox.Show("Upload failed. Try again.");
                }
            }
        }

        private void ClearFields()
        {
            txtTitle.Clear();
            rtbDescription.Clear();
            comboBoxCourse.SelectedIndex = -1;
            txtFilePath.Clear();
            txtUploadedBy.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
