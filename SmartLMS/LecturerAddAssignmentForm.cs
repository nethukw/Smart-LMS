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
    public partial class LecturerAddAssignmentForm : Form
    {
        private string connectionString = "server=localhost;user id=root;password=;database=SmartLMS;";
        private int currentLecturerId;

        public LecturerAddAssignmentForm(int lecturerId)
        {
            InitializeComponent();
            currentLecturerId = lecturerId;
        }

        private void LecturerAddAssignmentForm_Load(object sender, EventArgs e)
        {
            LoadLecturerCourses();
            dtpDueDate.MinDate = DateTime.Today; //prevent selecting past dates
        }

        private void LoadLecturerCourses()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT CourseId, Title FROM Courses WHERE LecturerId = @LecturerId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LecturerId", currentLecturerId);
                    conn.Open();

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(table);

                    cmbCourses.DataSource = table;
                    cmbCourses.DisplayMember = "Title";
                    cmbCourses.ValueMember = "CourseId";
                    cmbCourses.SelectedIndex = -1;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please select a course and enter the assignment title.");
                return;
            }

            int courseId = (int)cmbCourses.SelectedValue;
            string title = txtTitle.Text.Trim();
            string description = rtbDesc.Text.Trim();
            DateTime dueDate = dtpDueDate.Value;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"INSERT INTO Assignments (CourseId, Title, Description, DueDate, CreatedBy, CreatedAt) 
                         VALUES (@CourseId, @Title, @Description, @DueDate, @CreatedBy, NOW())";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CourseId", courseId);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@DueDate", dueDate);
                    cmd.Parameters.AddWithValue("@CreatedBy", currentLecturerId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Assignment created successfully!");
            this.Close();
        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
