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
    public partial class StudentCourseViewForm : BaseForm
    {
        private int studentId;  // Store student ID
        private string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";


        public StudentCourseViewForm(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void StudentCourseViewForm_Load(object sender, EventArgs e)
        {
            cmbSemester.Items.Clear();
            cmbSemester.Items.Add("All");
            cmbSemester.Items.Add("Semester 1");
            cmbSemester.Items.Add("Semester 2");
            cmbSemester.Items.Add("Semester 3");
            cmbSemester.SelectedIndex = 0;

            LoadStudentName();
            LoadCourses();           // My Courses
            LoadAvailableCourses();  // Courses to Enroll
        }

        private void LoadStudentName()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT FirstName, LastName FROM Users WHERE UserId = @StudentId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader.GetString("FirstName");
                                string lastName = reader.GetString("LastName");
                                lblStudentName.Text = $"{firstName} {lastName}";
                            }
                            else
                            {
                                lblStudentName.Text = "Unknown Student";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading student name: " + ex.Message);
                        lblStudentName.Text = "Unknown Student";
                    }
                }
            }
        }

        private void LoadCourses()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                // Base query
                string query = @"
            SELECT c.CourseCode, c.Title, c.Teacher, c.Schedule, c.Semester,
                   CONCAT(u.FirstName, ' ', u.LastName) AS LecturerName
            FROM Enrollments e
            JOIN Courses c ON e.CourseId = c.CourseId
            JOIN Users u ON c.LecturerId = u.UserId
            WHERE e.StudentId = @StudentId";

                // Get search and semester values
                string search = txtSearch.Text.Trim();
                string selectedSemester = cmbSemester.SelectedItem?.ToString();

                // Add filters to the query if needed
                if (!string.IsNullOrEmpty(search))
                {
                    query += " AND (c.Title LIKE @Search OR u.FirstName LIKE @Search OR u.LastName LIKE @Search)";
                }

                if (!string.IsNullOrEmpty(selectedSemester) && selectedSemester != "All")
                {
                    query += " AND c.Semester = @Semester";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);

                    if (!string.IsNullOrEmpty(search))
                    {
                        cmd.Parameters.AddWithValue("@Search", "%" + search + "%");
                    }

                    if (!string.IsNullOrEmpty(selectedSemester) && selectedSemester != "All")
                    {
                        cmd.Parameters.AddWithValue("@Semester", selectedSemester);
                    }

                    try
                    {
                        conn.Open();
                        DataTable dt = new DataTable();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                        CoursesDataGridView.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading courses: " + ex.Message);
                    }
                }
            }
        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void lblSemester_Click(object sender, EventArgs e)
        {

        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void CoursesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbSemester.SelectedIndex = 0;
            LoadCourses();
        }

        private void CourseDetailsButton_Click(object sender, EventArgs e)
        {
            if (CoursesDataGridView.CurrentRow != null)
            {
                // Retrieve all relevant fields from the selected row
                var row = CoursesDataGridView.CurrentRow;
                string courseCode = row.Cells["CourseCode"].Value?.ToString() ?? "";
                string title = row.Cells["Title"].Value?.ToString() ?? "";
                string teacher = row.Cells["Teacher"].Value?.ToString() ?? "";
                string schedule = row.Cells["Schedule"].Value?.ToString() ?? "";
                string semester = row.Cells["Semester"].Value?.ToString() ?? "";
                string lecturer = row.Cells["LecturerName"].Value?.ToString() ?? "";

                // Format the message string
                string message =
                    $"Course Code: {courseCode}\n" +
                    $"Title: {title}\n" +
                    $"Teacher: {teacher}\n" +
                    $"Schedule: {schedule}\n" +
                    $"Semester: {semester}\n" +
                    $"Lecturer: {lecturer}";

                MessageBox.Show(message, "Course Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a course first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AvailableCoursesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CoursesDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadAvailableCourses()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"
            SELECT c.CourseId, c.CourseCode, c.Title, c.Teacher, c.Schedule, c.Semester,
                   CONCAT(u.FirstName, ' ', u.LastName) AS LecturerName
            FROM Courses c
            JOIN Users u ON c.LecturerId = u.UserId
            WHERE c.CourseId NOT IN (
                SELECT CourseId FROM Enrollments WHERE StudentId = @StudentId
            )";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);

                    try
                    {
                        conn.Open();
                        DataTable dt = new DataTable();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                        AvailableCoursesDataGridView.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading available courses: " + ex.Message);
                    }
                }
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (AvailableCoursesDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a course to enroll.");
                return;
            }

            int courseId = Convert.ToInt32(AvailableCoursesDataGridView.CurrentRow.Cells["CourseId"].Value);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Enrollments (StudentId, CourseId) VALUES (@StudentId, @CourseId)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    cmd.Parameters.AddWithValue("@CourseId", courseId);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Enrolled successfully!");

                        // Refresh both lists
                        LoadCourses(); // My Courses
                        LoadAvailableCourses(); // Unenrolled courses
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error enrolling: " + ex.Message);
                    }
                }
            }
        }
    }
}
