using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLMS
{
    public partial class LecturerSubmissionsForm : BaseForm
    {
        private string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";
        private int lecturerId = 2; // Set the logged-in lecturer's ID here
        private int selectedSubmissionId = -1;
        private string lecturerEmail;

        public LecturerSubmissionsForm()
        {
            InitializeComponent();
            LoadSubmissions();
            panelGrading.Visible = false;
        }

        private void LoadSubmissions()
        {
            try
            {
                string query = @"
        SELECT 
            sa.StudentAssignmentId AS SubmissionId,
            CONCAT(u.FirstName, ' ', u.LastName) AS StudentName,
            a.Title AS AssignmentName,
            sa.SubmittedAt AS SubmittedOn,
            sa.FilePath,
            g.Grade,
            g.Feedback
        FROM StudentAssignments sa
        JOIN Users u ON sa.StudentId = u.UserId
        JOIN Assignments a ON sa.AssignmentId = a.AssignmentId
        LEFT JOIN Grades g ON g.SubmissionId = sa.StudentAssignmentId
        WHERE a.CreatedBy = @LecturerId";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LecturerId", lecturerId);
                    conn.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSubmissions.DataSource = dt;
                }

                if (!dgvSubmissions.Columns.Contains("Download"))
                {
                    DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn
                    {
                        Name = "Download",
                        HeaderText = "Download",
                        Text = "📂 Open File",
                        UseColumnTextForButtonValue = true
                    };
                    dgvSubmissions.Columns.Add(btnCol);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading submissions: " + ex.Message);
            }
        }



        private void dgvSubmissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSubmissions.Columns[e.ColumnIndex].Name == "Download" && e.RowIndex >= 0)
            {
                var cellValue = dgvSubmissions.Rows[e.RowIndex].Cells["FilePath"].Value;

                if (cellValue != null && cellValue != DBNull.Value)
                {
                    string filePath = cellValue.ToString();

                    if (File.Exists(filePath))
                    {
                        try
                        {
                            Process.Start(new ProcessStartInfo()
                            {
                                FileName = filePath,
                                UseShellExecute = true
                            });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error opening file: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("File not found at: " + filePath);
                    }
                }
                else
                {
                    MessageBox.Show("No file path for this submission.");
                }
            }
        }

        private void panelGrading_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFeedback_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveGrade_Click(object sender, EventArgs e)
        {
            if (selectedSubmissionId == -1) return;

            string grade = txtGrade.Text.Trim();
            string feedback = txtFeedback.Text.Trim();

            string query = @"INSERT INTO Grades (SubmissionId, Grade, Feedback, GradedBy) 
                             VALUES (@SubmissionId, @Grade, @Feedback, @GradedBy)
                             ON DUPLICATE KEY UPDATE Grade = @Grade, Feedback = @Feedback, GradedAt = CURRENT_TIMESTAMP";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SubmissionId", selectedSubmissionId);
                cmd.Parameters.AddWithValue("@Grade", grade);
                cmd.Parameters.AddWithValue("@Feedback", feedback);
                cmd.Parameters.AddWithValue("@GradedBy", lecturerId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            panelGrading.Visible = false;
            LoadSubmissions();
            MessageBox.Show("Grade saved successfully.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelGrading.Visible = false;
        }

        private void btnDownloadFile_Click(object sender, EventArgs e)
        {
            if (dgvSubmissions.CurrentRow != null)
            {
                // Check if the column exists
                if (dgvSubmissions.Columns.Contains("FilePath"))
                {
                    var cellValue = dgvSubmissions.CurrentRow.Cells["FilePath"].Value;

                    if (cellValue != null && cellValue != DBNull.Value)
                    {
                        string filePath = cellValue.ToString();

                        if (File.Exists(filePath))
                        {
                            try
                            {
                                Process.Start(new ProcessStartInfo()
                                {
                                    FileName = filePath,
                                    UseShellExecute = true
                                });
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error opening file: " + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("File not found at: " + filePath);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No file path found for this submission.");
                    }
                }
                else
                {
                    MessageBox.Show("FilePath column not found.");
                }
            }
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            if (dgvSubmissions.CurrentRow != null)
            {
                selectedSubmissionId = Convert.ToInt32(dgvSubmissions.CurrentRow.Cells["SubmissionId"].Value);
                txtGrade.Text = dgvSubmissions.CurrentRow.Cells["Grade"].Value?.ToString();
                txtFeedback.Text = dgvSubmissions.CurrentRow.Cells["Feedback"].Value?.ToString();
                panelGrading.Visible = true;
            }
        }

        private void LecturerSubmissionsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
