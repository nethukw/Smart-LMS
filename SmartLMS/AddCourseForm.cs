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
    public partial class AddCourseForm : BaseForm
    {
        private string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT UserId, CONCAT(FirstName, ' ', LastName) AS FullName FROM Users WHERE RoleId = (SELECT RoleId FROM Roles WHERE RoleName = 'Lecturer')";


                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<int, string> lecturers = new Dictionary<int, string>();

                while (reader.Read())
                {
                    int id = reader.GetInt32("UserId");
                    string name = reader.GetString("FullName");
                    lecturers.Add(id, name);
                }

                cmbLecturer.DataSource = new BindingSource(lecturers, null);
                cmbLecturer.DisplayMember = "Value";
                cmbLecturer.ValueMember = "Key";
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string teacher = txtTeacher.Text.Trim();
            string schedule = txtSchedule.Text.Trim();
            int capacity = (int)numCapacity.Value;
            int lecturerId = ((KeyValuePair<int, string>)cmbLecturer.SelectedItem).Key;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string insertQuery = @"INSERT INTO Courses (Title, Teacher, Schedule, Capacity, LecturerId)
                               VALUES (@Title, @Teacher, @Schedule, @Capacity, @LecturerId)";

                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Teacher", teacher);
                cmd.Parameters.AddWithValue("@Schedule", schedule);
                cmd.Parameters.AddWithValue("@Capacity", capacity);
                cmd.Parameters.AddWithValue("@LecturerId", lecturerId);

                cmd.ExecuteNonQuery();

                // auto-update CourseCode after insert
                string updateQuery = "UPDATE Courses SET CourseCode = CONCAT('CRS', LPAD(CourseId, 4, '0')) WHERE CourseId = LAST_INSERT_ID()";
                new MySqlCommand(updateQuery, conn).ExecuteNonQuery();
            }

            MessageBox.Show("Course added successfully!");
            this.Close(); 
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
