using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SmartLMS
{
    public partial class CourseManagementScreenForm : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";
        public CourseManagementScreenForm()
        {
            InitializeComponent();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CourseManagementScreenForm_Load(object sender, EventArgs e)
        {

            LoadCourses();
            LoadDropdown();
        }

        private void LoadCourses(string keyword = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Courses";

                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        query += " WHERE Title LIKE @keyword OR CourseCode LIKE @keyword";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrWhiteSpace(keyword))
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewCourseMng.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        dataGridViewCourseMng.Rows.Add(
                            row["CourseCode"].ToString(),
                            row["Title"].ToString(),
                            row["Teacher"].ToString(),
                            row["Schedule"].ToString(),
                            row["Capacity"].ToString(),
                            "Edit/Delete" // Placeholder for ActionsCol
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        private void LoadDropdown()
        {
            comboBoxFilterDropdown.Items.Clear();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Title FROM Courses";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBoxFilterDropdown.Items.Add(reader.GetString("Title"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dropdown: " + ex.Message);
            }
        }


        private void txtSearchInput_TextChanged(object sender, EventArgs e)
        {
            // Optional: Live search while typing
            BtnSearch_Click(sender, e);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchInput.Text.Trim();
            LoadCourses(keyword);

        }

        private void comboBoxFilterDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = comboBoxFilterDropdown.SelectedItem.ToString();
            LoadCourses(selectedCourse);
        }

        private void txtAddCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddCourseForm form = new AddCourseForm();
            form.ShowDialog();

        }

        private void dataGridViewCourseMng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
