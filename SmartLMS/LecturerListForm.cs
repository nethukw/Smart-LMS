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
    public partial class LecturerListForm : BaseForm
    {
        private string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";
        private int loggedInStudentId;

        public LecturerListForm(int studentId)
        {
            InitializeComponent();
            loggedInStudentId = studentId;
            dgvLecturers.AutoGenerateColumns = true;
            LoadLecturers();
           

        }

        private void LoadLecturers(string searchCourse = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"
            SELECT DISTINCT
                CONCAT(u.FirstName, ' ', u.LastName) AS 'Lecturer Name',
                u.Username AS Email,
                c.Title AS Course
            FROM Enrollments e
            JOIN Courses c ON e.CourseId = c.CourseId
            JOIN Users u ON c.LecturerId = u.UserId
            WHERE e.StudentId = @studentId";

                    if (!string.IsNullOrEmpty(searchCourse))
                    {
                        sql += " AND c.Title LIKE @searchCourse ";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", loggedInStudentId);
                        if (!string.IsNullOrEmpty(searchCourse))
                        {
                            cmd.Parameters.AddWithValue("@searchCourse", $"%{searchCourse}%");
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No lecturers found for this student.");
                            }

                            dgvLecturers.AutoGenerateColumns = true;
                            dgvLecturers.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading lecturers: " + ex.Message);
            }
        }



        private void LecturerListForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadLecturers(txtSearch.Text.Trim());
        }

        private void dgvLecturers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
