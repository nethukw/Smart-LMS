using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SmartLMS
{
    public partial class LecturerDashboardForm : BaseForm
    {
        private string connectionString = "server=localhost;user id=root;password=;database=smartlms;";
        private string loggedInLecturerEmail;
        private object lecturerId;
        private int currentLecturerId;
        private int userId;
        private int loggedInUserId;

        public LecturerDashboardForm(string lecturerEmail)
        {
            InitializeComponent();
            loggedInLecturerEmail = lecturerEmail;
        }
        private void LecturerDashboardForm_Load(object sender, EventArgs e)
        {
            LoadLecturerName();
            LoadLecturerStats();
            LoadLecturerInfo(); // this will set name and userId
            
        }

        private void LoadLecturerInfo()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT UserId, CONCAT(FirstName, ' ', LastName) AS FullName FROM Users WHERE Username = @Username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", loggedInLecturerEmail);

                try
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            loggedInUserId = Convert.ToInt32(reader["UserId"]);
                            BtnName.Text = reader["FullName"].ToString();
                        }
                        else
                        {
                            BtnName.Text = "Unknown Lecturer";
                            MessageBox.Show("User not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading lecturer info: " + ex.Message);
                }
            }
        }


        private void LoadLecturerName()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT CONCAT(FirstName, ' ', LastName) FROM Users WHERE Username = @Username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", loggedInLecturerEmail);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        BtnName.Text = result.ToString();
                    }
                    else
                    {
                        BtnName.Text = "Unknown Lecturer";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading lecturer name: " + ex.Message);
                }
            }
        }

        private void LoadLecturerStats()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT COUNT(*) 
                             FROM Courses c 
                             JOIN Users u ON c.LecturerId = u.UserId 
                             WHERE u.Username = @Username";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", loggedInLecturerEmail);

                    int totalCourses = Convert.ToInt32(cmd.ExecuteScalar());
                    groupBoxCourses.Text = $"My Courses: {totalCourses}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading stats: " + ex.Message);
                }
            }
        }


        private void BtnName_Click(object sender, EventArgs e)
        {

        }

        private void BtnNotification_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notifications feature coming soon!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm(loggedInUserId);

            pf.Show();
        }

        private void groupBoxCourses_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxAssignment_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxMyGrades_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAssignment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Assignments management form here.");
            // You can open AssignmentForm or similar here
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open submission review form here.");
        }

        private void BtnGrade_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open grading form here.");
        }

        private void BtnAssignments_Click(object sender, EventArgs e)
        {
            LecturerAssignmentForm assignmentForm = new LecturerAssignmentForm();
            assignmentForm.Show();
        }

        private void BtnCourses_Click(object sender, EventArgs e)
        {
            LecturerCourseForm cf = new LecturerCourseForm(loggedInLecturerEmail);

            cf.Show();
        }

        private void BtnSubmissions_Click(object sender, EventArgs e)
        {
            LecturerSubmissionsForm lecturerSubmissionsForm = new LecturerSubmissionsForm();
            lecturerSubmissionsForm.Show();
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            StudentListForm studentListForm = new StudentListForm();
            studentListForm.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // Confirm logout
            var confirm = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
                // Optionally show LoginForm again if needed:
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
