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
    public partial class LecturerCourseForm : BaseForm
    {
        private string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";
        private string lecturerEmail;

        public LecturerCourseForm(string email)
        {
            InitializeComponent();
            lecturerEmail = email;
        }

        private void LecturerCourseForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    c.CourseId, 
                    c.CourseCode, 
                    c.Title AS CourseTitle, 
                    c.Description, 
                    c.Schedule, 
                    c.Capacity,
                    CONCAT(u.FirstName, ' ', u.LastName) AS Lecturer
                FROM Courses c
                JOIN Users u ON c.LecturerId = u.UserId
                WHERE u.Username = @LecturerEmail";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LecturerEmail", lecturerEmail);

                    try
                    {
                        conn.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvCourses.DataSource = table;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading courses: " + ex.Message);
                    }
                }
            }
            }

        

        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Open a form to add course (you can create LecturerAddCourseForm)
            /*var form = new LecturerAddCourseForm();
            form.ShowDialog();
            LoadCourses();*/
            MessageBox.Show("Add course - under implementation", "Notice");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            /* if (dgvCourses.SelectedRows.Count == 0)
             {
                 MessageBox.Show("Please select a course to edit.");
                 return;
             }

             int courseId = Convert.ToInt32(dgvCourses.SelectedRows[0].Cells["CourseId"].Value);
             var form = new LecturerEditCourseForm(courseId);
             form.ShowDialog();
             LoadCourses();*/
            if (dgvCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to edit.");
                return;
            }

            MessageBox.Show("Edit course - under implementation", "Notice");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a course to delete.");
                return;
            }

            int courseId = Convert.ToInt32(dgvCourses.SelectedRows[0].Cells["CourseId"].Value);

            var confirm = MessageBox.Show("Are you sure to delete this course?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Courses WHERE CourseId = @CourseId";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@CourseId", courseId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Course deleted.");
                            LoadCourses();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting course: " + ex.Message);
                }
            }
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            /*if (dgvCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a course to view students.");
                return;
            }

            int courseId = Convert.ToInt32(dgvCourses.SelectedRows[0].Cells["CourseId"].Value);
            var form = new LecturerCourseStudentsForm(courseId);
            form.ShowDialog();*/
            if (dgvCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a course to view students.");
                return;
            }

            MessageBox.Show("View enrolled students - under implementation", "Notice");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
