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
    public partial class StudentAssignmentForm : BaseForm
    {
        private int studentId; 

        private string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";
        private string fullName;
        private int userId;

        public static class DB
        {
            public static string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";

        }


        public StudentAssignmentForm(int userId)
        {
            InitializeComponent();
            studentId = userId;
            LoadCourses();

            int? courseId = null;
            if (cmbFilterCourse.SelectedValue != null && int.TryParse(cmbFilterCourse.SelectedValue.ToString(), out int val))
            {
                courseId = val;
            }
            LoadAssignments(courseId: courseId);
        }

        private void LoadCourses()
        {
            using (var con = new MySqlConnection(DB.connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"
                SELECT c.CourseId, c.Title
                FROM Enrollments e
                JOIN Courses c ON e.CourseId = c.CourseId
                WHERE e.StudentId = @StudentId";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StudentId", studentId);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cmbFilterCourse.DisplayMember = "Title";
                    cmbFilterCourse.ValueMember = "CourseId";
                    cmbFilterCourse.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading courses: " + ex.Message);
                }
            }
        }


        private void cmbFilterCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? courseId = null;
            if (cmbFilterCourse.SelectedValue != null && int.TryParse(cmbFilterCourse.SelectedValue.ToString(), out int val))
            {
                courseId = val;
            }
            LoadAssignments(courseId: courseId);
        }


        private void LoadAssignments(string keyword = "", int? courseId = null)
        {
            string query = @"
        SELECT 
            a.AssignmentId,
            a.Title,
            c.Title AS Course,
            a.DueDate,
            a.FilePath,
            CASE 
                WHEN s.SubmissionId IS NOT NULL THEN 'Submitted'
                WHEN a.DueDate >= NOW() THEN 'Pending'
                ELSE 'Past Due'
            END AS Status
        FROM Assignments a
        JOIN Courses c ON a.CourseId = c.CourseId
        JOIN Enrollments e ON a.CourseId = e.CourseId
        LEFT JOIN Submissions s ON s.AssignmentId = a.AssignmentId AND s.StudentId = @studentId
        WHERE e.StudentId = @studentId
    ";

            if (!string.IsNullOrEmpty(keyword))
                query += " AND c.Title LIKE @keyword";

            if (courseId.HasValue)
                query += " AND a.CourseId = @courseId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@studentId", studentId);

                    if (!string.IsNullOrEmpty(keyword))
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    if (courseId.HasValue)
                        cmd.Parameters.AddWithValue("@courseId", courseId.Value);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvAssignments.DataSource = dt;

                    CheckDeadlineAlerts(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading assignments: " + ex.Message);
                }
            }
        }



        private void CheckDeadlineAlerts(DataTable dt)
        {
            var upcoming = dt.AsEnumerable()
                .Where(row => DateTime.TryParse(row["DueDate"].ToString(), out DateTime dueDate)
                    && dueDate <= DateTime.Now.AddDays(3)
                    && dueDate >= DateTime.Now);

            if (upcoming.Any())
            {
                MessageBox.Show($"You have {upcoming.Count()} assignment(s) due soon!", "Deadline Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadAssignmentsFromCSV(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Assignments CSV not found.");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            dt.Columns.Add("Course");
            dt.Columns.Add("DueDate");
            dt.Columns.Add("Status");

            foreach (var line in lines.Skip(1)) // Skip header line
            {
                var parts = line.Split(',');
                // assuming CSV columns: Title,Course,DueDate,Status
                if (parts.Length >= 4)
                {
                    dt.Rows.Add(parts[0], parts[1], parts[2], parts[3]);
                }
            }

            dgvAssignments.DataSource = dt;
        }






        private void AssignmentForm_Load(object sender, EventArgs e)
        {
            dgvAssignments.AutoGenerateColumns = false;

            LoadAssignments();

        }

        private void dgvAssignments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAssignments.Columns["Download"].Index && e.RowIndex >= 0)
            {
                string filePath = dgvAssignments.Rows[e.RowIndex].Cells["FilePath"].Value?.ToString();
                if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(filePath); // open default viewer
                }
                else
                {
                    MessageBox.Show("File not found.");
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }


        private void gbDetails_Enter(object sender, EventArgs e)
        {

        }

        private void gbUpload_Enter(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            int? courseId = null;

            if (cmbFilterCourse.SelectedValue != null && int.TryParse(cmbFilterCourse.SelectedValue.ToString(), out int parsedId))
            {
                courseId = parsedId;
            }

            LoadAssignments(keyword, courseId);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbFilterCourse.SelectedIndex = -1;
            LoadAssignments();
        }

        private void btnSubmitWork_Click(object sender, EventArgs e)
        {
            StudentSubmitWorkForm studentSubmitWorkForm = new StudentSubmitWorkForm();
            studentSubmitWorkForm.Show();
        }

        private void btnDiscussion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forum feature coming soon!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dgvAssignments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAssignments.Columns[e.ColumnIndex].Name == "Status")
            {
                string status = e.Value.ToString();
                if (status == "Submitted")
                    e.CellStyle.ForeColor = Color.Green;
                else if (status == "Pending")
                    e.CellStyle.ForeColor = Color.OrangeRed;
            }
        }

        private void dgvAssignments_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAssignments.Columns[e.ColumnIndex].Name == "Download")
            {
                string filePath = dgvAssignments.Rows[e.RowIndex].Cells["FilePath"].Value?.ToString();

                if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = filePath,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot open file: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("File not found or path is invalid.");
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}