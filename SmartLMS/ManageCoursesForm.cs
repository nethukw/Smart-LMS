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
    public partial class ManageCoursesForm : BaseForm
    {
        private string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";
        public ManageCoursesForm()
        {
            InitializeComponent();
            LoadCourses();
            LoadLecturers();
        }

        private void LoadCourses(string keyword = "")
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        c.CourseId,
                        c.CourseCode,
                        c.Title AS CourseName,
                        CONCAT(u.FirstName, ' ', u.LastName) AS LecturerName,
                        c.Semester,
                        c.Capacity,
                        c.Teacher,
                        c.Schedule
                    FROM Courses c
                    JOIN Users u ON c.LecturerId = u.UserId
                    WHERE c.Title LIKE @Keyword
                ";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCourses.DataSource = dt;
                    lblTotalCourses.Text = "Total Courses: " + dt.Rows.Count;
                }
            }
        }



        private void LoadLecturers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT UserId, CONCAT(FirstName, ' ', LastName) AS FullName
                    FROM Users
                    WHERE RoleId = (SELECT RoleId FROM Roles WHERE RoleName = 'Lecturer')
                ";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cmbLecturerFilter.DataSource = dt;
                    cmbLecturerFilter.DisplayMember = "FullName";
                    cmbLecturerFilter.ValueMember = "UserId";
                }
            }
        }

        private void cmbDepartmentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLecturerFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCourses(txtSearch.Text);
        }

        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            new AddCourseForm().ShowDialog();
            LoadCourses();
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            /*if (dgvCourses.CurrentRow != null)
            {
                int courseId = Convert.ToInt32(dgvCourses.CurrentRow.Cells["CourseId"].Value);
                new EditCourseForm(courseId).ShowDialog();
                LoadCourses();
            }
            else MessageBox.Show("Please select a course to edit.");*/
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (dgvCourses.CurrentRow != null)
            {
                int courseId = Convert.ToInt32(dgvCourses.CurrentRow.Cells["CourseId"].Value);
                DialogResult result = MessageBox.Show("Are you sure to delete this course?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Courses WHERE CourseId = @CourseId";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@CourseId", courseId);
                            cmd.ExecuteNonQuery();
                            LoadCourses();
                        }
                    }
                }
            }
            else MessageBox.Show("Please select a course to delete.");
        }

        private void btnAssignLecturer_Click(object sender, EventArgs e)
        {
            if (dgvCourses.CurrentRow != null && cmbLecturerFilter.SelectedValue != null)
            {
                int courseId = Convert.ToInt32(dgvCourses.CurrentRow.Cells["CourseId"].Value);
                int lecturerId = Convert.ToInt32(cmbLecturerFilter.SelectedValue);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Courses SET LecturerId = @LecturerId WHERE CourseId = @CourseId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LecturerId", lecturerId);
                        cmd.Parameters.AddWithValue("@CourseId", courseId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lecturer assigned successfully.");
                        LoadCourses();
                    }
                }
            }
            else MessageBox.Show("Please select a course and a lecturer to assign.");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCourses();
            txtSearch.Clear();
        }

        private void lblTotalCourses_Click(object sender, EventArgs e)
        {

        }

        private void ManageCoursesForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }
    }
}
