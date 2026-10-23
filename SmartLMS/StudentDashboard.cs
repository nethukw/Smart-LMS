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
using static SmartLMS.SettingsForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace SmartLMS
{
    public partial class StudentDashboard : BaseForm
    {
        private string fullName;
        private int loggedInUserId;
        private string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";
        private string userName;
        private int userId;
        private int currentUserId;
        private string currentUserName;
        private int studentId;
        private int loggedInStudentId;

        public StudentDashboard(int userId, string fullName)
        {
            InitializeComponent();
            this.loggedInUserId = userId;  
            this.fullName = fullName;
            currentUserId = userId;

           listBoxCourses.SelectedIndexChanged += listBoxCourses_SelectedIndexChanged;
            listBoxAssignments.SelectedIndexChanged += listBoxAssignments_SelectedIndexChanged;
            listBoxGrades.SelectedIndexChanged += listBoxGrades_SelectedIndexChanged;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            StudentAssignmentForm af = new StudentAssignmentForm(loggedInUserId);
            af.Show();


        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            textName.Text = fullName;
            LoadCourses();
            LoadAssignments();
            LoadGrades();
            CalculateAndShowGPA();  //Update GPA progress bar

        }


        private void LoadNotifications()
        {
            
        }

        private void LoadCourses()
        {
            listBoxCourses.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"
            SELECT c.Title, CONCAT(u.FirstName, ' ', u.LastName) AS Lecturer
            FROM Enrollments e
            JOIN Courses c ON e.CourseId = c.CourseId
            JOIN Users u ON c.LecturerId = u.UserId
            WHERE e.StudentId = @StudentId;
        ";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", loggedInUserId);

                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string courseTitle = reader.GetString("Title");
                                string lecturer = reader.GetString("Lecturer");
                                listBoxCourses.Items.Add($"{courseTitle} (by {lecturer})");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading courses: " + ex.Message);
                    }
                }
            }
        }

        private void LoadAssignments()
        {
            listBoxAssignments.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"
                    SELECT a.Title, c.Title AS Course, a.DueDate
                    FROM Enrollments e
                    JOIN Assignments a ON e.CourseId = a.CourseId
                    JOIN Courses c ON a.CourseId = c.CourseId
                    WHERE e.StudentId = @StudentId AND a.DueDate >= CURDATE()
                    ORDER BY a.DueDate ASC;
                ";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", loggedInUserId);

                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string title = reader.GetString("Title");
                                string course = reader.GetString("Course");
                                DateTime due = reader.GetDateTime("DueDate");

                                listBoxAssignments.Items.Add($"{title} ({course}) - Due: {due:MMM dd}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading assignments: " + ex.Message);
                    }
                }
            }
        }


        private void LoadGrades()
        {
            listBoxGrades.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"
                    SELECT c.Title AS Course, a.Title AS Assignment, g.Grade
                    FROM Grades g
                    JOIN Submissions s ON g.SubmissionId = s.SubmissionId
                    JOIN Assignments a ON s.AssignmentId = a.AssignmentId
                    JOIN Courses c ON a.CourseId = c.CourseId
                    WHERE s.StudentId = @StudentId;
                ";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", loggedInUserId);

                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string course = reader.GetString("Course");
                                string assignment = reader.GetString("Assignment");
                                float grade = reader.GetFloat("Grade");

                                listBoxGrades.Items.Add($"{assignment} ({course}) - Grade: {grade}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading grades: " + ex.Message);
                    }
                }
            }
        }

        private void CalculateAndShowGPA()
        {
            float totalGrades = 0;
            int gradeCount = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"
            SELECT g.Grade
            FROM Grades g
            JOIN Submissions s ON g.SubmissionId = s.SubmissionId
            WHERE s.StudentId = @StudentId;
        ";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", loggedInUserId);

                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                float grade = reader.GetFloat("Grade");
                                totalGrades += grade;
                                gradeCount++;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error calculating GPA: " + ex.Message);
                    }
                }
            }

            if (gradeCount > 0)
            {
                float average = totalGrades / gradeCount;

                // Convert average to 4.0 scale
                float gpa = (average / 100f) * 4.0f;
                gpa = Math.Min(gpa, 4.0f); // Cap at 4.0

                // Update progress bar & label
                progressGPA.Value = (int)(gpa * 100);  
                labelGPA.Text = $"Your GPA: {gpa:F2} / 4.0";
            }
            else
            {
                progressGPA.Value = 0;
                labelGPA.Text = "No grades available.";
            }
        }



        private void BtnName_Click(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm(loggedInUserId);
            pf.Show();
        }

        private void BtnNotification_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Notifications feature coming soon!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            StudentAssignmentForm af = new StudentAssignmentForm(userId);
            af.Show();
            
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            StudentSubmitWorkForm studentSubmitWorkForm = new StudentSubmitWorkForm();
            studentSubmitWorkForm.Show();
        }

        private void BtnGrade_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forum feature coming soon!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void BtnCourses_Click(object sender, EventArgs e)
        {
            StudentCourseViewForm courseForm = new StudentCourseViewForm(loggedInUserId);
            courseForm.Show();
        }

        private void BtnSubmitWork_Click(object sender, EventArgs e)
        {

           /* StudentSubmitWorkForm sf = new StudentSubmitWorkForm();
            sf.Show();*/
           StudentSubmitWorkForm studentSubmitWorkForm = new StudentSubmitWorkForm();
            studentSubmitWorkForm.Show();

        }

        private void BtnLecturers_Click(object sender, EventArgs e)
        {
            /*LecturerListForm LF = new LecturerListForm(loggedInStudentId);
            LF.Show();*/
             // or get dynamically from current logged-in user
            LecturerListForm form = new LecturerListForm(studentId);
            form.Show();
        }

       
        private void OpenLecturerListForStudent(int studentId)
        {
            LecturerListForm form = new LecturerListForm(studentId);
            form.Show();
        }


        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // Confirm logout
            var confirm = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
              
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        private void BtnExportGrades_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"grades.csv"; // it saves next to your .exe
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Course,Assignment,Grade");
                    foreach (var item in listBoxGrades.Items)
                    {
                        writer.WriteLine(item.ToString()); // Save each grade line
                    }
                }
                MessageBox.Show("Grades saved to grades.csv!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void listBoxGrades_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = listBoxGrades.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    var result = MessageBox.Show("Delete this grade?", "Delete", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        listBoxGrades.Items.RemoveAt(index); 
                    }
                }
            }
        }

        

        private void listBoxAssignments_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (listBoxAssignments.SelectedItem != null)
            {
                MessageBox.Show(listBoxAssignments.SelectedItem.ToString(), "Assignment Details");
            }*/
            if (listBoxAssignments.Items.Count > 0)
            {
                StringBuilder allItems = new StringBuilder();
                foreach (var item in listBoxAssignments.Items)
                {
                    allItems.AppendLine(item.ToString());
                }
                MessageBox.Show(allItems.ToString(), "All Assignments");
            }
            else
            {
                MessageBox.Show("No assignments available.", "Info");
            }
        }

        private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (listBoxCourses.SelectedItem != null)
            {
                MessageBox.Show(listBoxCourses.SelectedItem.ToString(), "Course Details");
            }*/
            if (listBoxCourses.Items.Count > 0)
            {
                StringBuilder allItems = new StringBuilder();
                foreach (var item in listBoxCourses.Items)
                {
                    allItems.AppendLine(item.ToString());
                }
                MessageBox.Show(allItems.ToString(), "All Courses");
            }
            else
            {
                MessageBox.Show("No courses available.", "Info");
            }
        }

        private void listBoxGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (listBoxGrades.SelectedItem != null)
            {
                MessageBox.Show(listBoxGrades.SelectedItem.ToString(), "Grade Details");
            }*/
            if (listBoxGrades.Items.Count > 0)
            {
                StringBuilder allItems = new StringBuilder();
                foreach (var item in listBoxGrades.Items)
                {
                    allItems.AppendLine(item.ToString());
                }
                MessageBox.Show(allItems.ToString(), "All Grades");
            }
            else
            {
                MessageBox.Show("No grades available.", "Info");
            }
        }
    }
}
