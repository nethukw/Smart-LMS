using MySql.Data.MySqlClient;
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
using static SmartLMS.StudentSubmitWorkForm;

namespace SmartLMS
{
    public partial class LectureMaterialForm : BaseForm
    {
        private int loggedInStudentId;
        private string connectionString = "server=localhost;user id=root;password=;database=SmartLMS;";

        public LectureMaterialForm(int studentId)
        {
            InitializeComponent();
            loggedInStudentId = studentId;
            LoadCourses();
            LoadMaterials();
        }

        private void LoadCourses()
        {
            CourseComboBox.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT c.CourseId, c.CourseCode
                    FROM Courses c
                    JOIN Enrollments e ON e.CourseId = c.CourseId
                    WHERE e.StudentId = @StudentId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", loggedInStudentId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CourseComboBox.Items.Add(new ComboBoxItem(reader["CourseCode"].ToString(), Convert.ToInt32(reader["CourseId"])));
                        }
                    }
                }
            }
        }

        private void LoadMaterials(int? courseId = null)
        {
            MaterialDataGridView.Rows.Clear();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT cm.MaterialId, c.CourseCode, cm.MaterialTitle, u.FirstName, u.LastName, cm.FilePath, cm.UploadedDate
                    FROM CourseMaterials cm
                    JOIN Courses c ON c.CourseId = cm.CourseId
                    JOIN Users u ON u.UserId = c.LecturerId
                    JOIN Enrollments e ON e.CourseId = c.CourseId
                    WHERE e.StudentId = @StudentId";

                if (courseId.HasValue)
                    query += " AND c.CourseId = @CourseId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", loggedInStudentId);
                    if (courseId.HasValue)
                        cmd.Parameters.AddWithValue("@CourseId", courseId.Value);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MaterialDataGridView.Rows.Add(
                                reader["MaterialId"].ToString(),
                                reader["CourseCode"].ToString(),
                                reader["MaterialTitle"].ToString(),
                                Path.GetFileName(reader["FilePath"].ToString()),
                                reader["FirstName"].ToString() + " " + reader["LastName"].ToString(),
                                Convert.ToDateTime(reader["UploadedDate"]).ToString("yyyy-MM-dd"),
                                "Download"
                            );
                        }
                    }
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LectureMaterialForm_Load(object sender, EventArgs e)
        {

        }

        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = CourseComboBox.SelectedItem as ComboBoxItem;
            if (selectedItem != null)
                LoadMaterials(selectedItem.Value);
        }

        private void MaterialDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MaterialDataGridView.Columns[e.ColumnIndex].Name == "Action" && e.RowIndex >= 0)
            {
                string materialId = MaterialDataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                string filePath = GetFilePathByMaterialId(materialId);
                if (File.Exists(filePath))
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.FileName = Path.GetFileName(filePath);
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.Copy(filePath, sfd.FileName, true);
                        MessageBox.Show("✅ File downloaded successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("⚠️ File not found on server.");
                }
            }
        }

        private string GetFilePathByMaterialId(string materialId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT FilePath FROM CourseMaterials WHERE MaterialId = @MaterialId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaterialId", materialId);
                    return cmd.ExecuteScalar()?.ToString();
                }
            }
        
    }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewButtonColumn_Click(object sender, EventArgs e)
        {

        }
    }
}
