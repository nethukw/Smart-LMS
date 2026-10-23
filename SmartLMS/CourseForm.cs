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
    public partial class CourseForm : Form
    {
        private int currentUserId; // pass from login
        private string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";
     
        private string currentUserName;
        
        public CourseForm(int userId, string userName)
        {
            InitializeComponent();
            currentUserId = userId;       // ← check if this has correct value
            currentUserName = userName;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCourses.Columns["Action"].Index && e.RowIndex >= 0)
            {
                string courseTitle = dgvCourses.Rows[e.RowIndex].Cells["Course Title"].Value.ToString();
                ShowCourseDetails(courseTitle);
            }
        }

        private void ShowCourseDetails(string courseTitle)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT c.Title, c.Description, u.FullName AS LecturerName, e.EnrolledDate
                         FROM Courses c
                         JOIN Users u ON c.LecturerId = u.UserId
                         JOIN Enrollments e ON e.CourseId = c.CourseId
                         WHERE c.Title = @Title AND e.StudentId = @StudentId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", courseTitle);
                cmd.Parameters.AddWithValue("@StudentId", currentUserId);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblTitle.Text = reader["Title"].ToString();
                    lblDescription.Text = reader["Description"].ToString();
                    lblLecturer.Text = reader["LecturerName"].ToString();
                    lblDate.Text = Convert.ToDateTime(reader["EnrolledDate"]).ToString("yyyy-MM-dd");
                }
                conn.Close();
            }

            LoadMaterials(courseTitle); // Optional
            pnlCourseDetails.Visible = true;
            dgvCourses.Visible = false;
        }

        private void LoadMaterials(string courseTitle)
        {
            lstMaterials.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT MaterialTitle FROM CourseMaterials WHERE CourseId = (SELECT CourseId FROM Courses WHERE Title = @Title)";


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", courseTitle);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lstMaterials.Items.Add(reader["MaterialTitle"].ToString());
                }
                conn.Close();
            }
        }


        private void CourseForm_Load(object sender, EventArgs e)
        {
            txtwlcm.Text = currentUserName;
            LoadCourses();
        }

        private void LoadCourses()
        {
            dgvCourses.Rows.Clear(); // good
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT c.Title, c.Description, CONCAT(u.FirstName, ' ', u.LastName) AS LecturerName, e.EnrolledDate
                         FROM Courses c
                         JOIN Users u ON c.LecturerId = u.UserId
                         JOIN Enrollments e ON e.CourseId = c.CourseId
                         WHERE e.StudentId = @StudentId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentId", currentUserId);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvCourses.Rows.Add(
                        reader["Title"].ToString(),
                        reader["LecturerName"].ToString(),
                        reader["Description"].ToString(),
                        Convert.ToDateTime(reader["EnrolledDate"]).ToString("yyyy-MM-dd"),
                        "View"
                    );
                }
                conn.Close();
            }
            }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlCourseDetails.Visible = false;
            dgvCourses.Visible = true;
        }
    }
}
