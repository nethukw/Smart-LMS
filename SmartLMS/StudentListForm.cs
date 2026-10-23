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

namespace SmartLMS
{
    public partial class StudentListForm : BaseForm
    {
        private string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";
        private string lecturerEmail;

        public StudentListForm()
        {
            InitializeComponent();
            
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        


        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbFilterByCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadStudents(txtSearch.Text, cmbFilterByCourse.SelectedItem.ToString());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbFilterByCourse.SelectedIndex = 0;
            LoadStudents();
        }

        private void dgvStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            /*AddStudentForm addForm = new AddStudentForm();
            addForm.ShowDialog();
            LoadStudents();*/
        }

        private void BtnExportList_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Export Student List";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    for (int i = 0; i < dgvStudents.Columns.Count; i++)
                    {
                        writer.Write(dgvStudents.Columns[i].HeaderText);
                        if (i < dgvStudents.Columns.Count - 1) writer.Write(",");
                    }
                    writer.WriteLine();

                    foreach (DataGridViewRow row in dgvStudents.Rows)
                    {
                        for (int i = 0; i < dgvStudents.Columns.Count; i++)
                        {
                            writer.Write(row.Cells[i].Value);
                            if (i < dgvStudents.Columns.Count - 1) writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }
                MessageBox.Show("Exported successfully.");
            }
        }

        private void bottomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadCourses();
        }

        private void LoadStudents(string keyword = "", string courseFilter = "All Courses")
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT 
                    u.UserId AS 'Student ID',
                    CONCAT(u.FirstName, ' ', u.LastName) AS 'Full Name',
                    u.Username,
                    u.Gender,
                    u.Phone,
                    u.Address,
                    c.Title AS 'Enrolled Course'
                FROM Users u
                LEFT JOIN Enrollments e ON u.UserId = e.StudentId
                LEFT JOIN Courses c ON e.CourseId = c.CourseId
                WHERE u.RoleId = (SELECT RoleId FROM Roles WHERE RoleName = 'Student')";

                if (!string.IsNullOrEmpty(keyword))
                {
                    query += " AND (u.FirstName LIKE @keyword OR u.LastName LIKE @keyword OR u.Username LIKE @keyword)";
                }

                if (courseFilter != "All Courses")
                {
                    query += " AND c.Title = @course";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(keyword))
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    if (courseFilter != "All Courses")
                        cmd.Parameters.AddWithValue("@course", courseFilter);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvStudents.DataSource = dt;
                    }
                }
            }
        }

        private void LoadCourses()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT DISTINCT Title FROM Courses";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    cmbFilterByCourse.Items.Clear();
                    cmbFilterByCourse.Items.Add("All Courses");
                    while (reader.Read())
                    {
                        cmbFilterByCourse.Items.Add(reader.GetString("Title"));
                    }
                    cmbFilterByCourse.SelectedIndex = 0;
                }
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
