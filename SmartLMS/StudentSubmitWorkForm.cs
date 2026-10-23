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
    public partial class StudentSubmitWorkForm : BaseForm
    {
        string selectedFilePath = "";
        int loggedInStudentId = 5; 
        


        private string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";
        private int userId;

        public StudentSubmitWorkForm()
        {
            InitializeComponent();
            LoadAssignments(); 
        }

        private void LoadAssignments()
        {
            assignmentComboBox.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT DISTINCT a.AssignmentId, a.Title
            FROM Enrollments e
            JOIN Assignments a ON e.CourseId = a.CourseId
            WHERE e.StudentId = @studentId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", loggedInStudentId); 

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int assignmentId = reader.GetInt32("AssignmentId");
                            string title = reader.GetString("Title");
                            assignmentComboBox.Items.Add(new ComboBoxItem(title, assignmentId));
                        }
                    }
                }
            }
        }


        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }



        private void lblFile_Click(object sender, EventArgs e)
        {

        }

        private void lblComments_Click(object sender, EventArgs e)
        {

        }

        private void SubmissionForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|Word Docs (*.docx)|*.docx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                label2.Text = Path.GetFileName(selectedFilePath);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (assignmentComboBox.SelectedItem == null || string.IsNullOrEmpty(selectedFilePath))
            {
                statusLabel.Text = "❌ Please select an assignment and a file.";
                statusLabel.ForeColor = Color.Red;
                return;
            }

            var selectedItem = (ComboBoxItem)assignmentComboBox.SelectedItem;
            int assignmentId = selectedItem.Value;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if already submitted
                    string checkQuery = @"
                SELECT SubmittedAt FROM StudentAssignments 
                WHERE StudentId = @studentId AND AssignmentId = @assignmentId AND Status = 'Submitted'";

                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@studentId", loggedInStudentId);
                        checkCmd.Parameters.AddWithValue("@assignmentId", assignmentId);
                        object result = checkCmd.ExecuteScalar();
                        if (result != null)
                        {
                            statusLabel.Text = "⚠️ Already submitted this assignment.";
                            statusLabel.ForeColor = Color.Orange;
                            return;
                        }
                    }

                    // Check due date
                    string dueDateQuery = "SELECT DueDate FROM Assignments WHERE AssignmentId = @assignmentId";
                    using (MySqlCommand dueCmd = new MySqlCommand(dueDateQuery, conn))
                    {
                        dueCmd.Parameters.AddWithValue("@assignmentId", assignmentId);
                        object dueObj = dueCmd.ExecuteScalar();

                        if (dueObj != null && Convert.ToDateTime(dueObj) < DateTime.Now)
                        {
                            statusLabel.Text = "❌ Due date has already passed.";
                            statusLabel.ForeColor = Color.Red;
                            return;
                        }
                    }

                    // Save file
                    string submissionFolder = Path.Combine(Application.StartupPath, "Submissions");
                    if (!Directory.Exists(submissionFolder))
                        Directory.CreateDirectory(submissionFolder);

                    string fileName = $"Student{loggedInStudentId}_Assignment{assignmentId}_{Path.GetFileName(selectedFilePath)}";
                    string targetPath = Path.Combine(submissionFolder, fileName);
                    File.Copy(selectedFilePath, targetPath, true);

                    // Check if submission row exists
                    string existsQuery = @"
                SELECT COUNT(*) FROM StudentAssignments 
                WHERE StudentId = @studentId AND AssignmentId = @assignmentId";

                    int exists = 0;
                    using (MySqlCommand existsCmd = new MySqlCommand(existsQuery, conn))
                    {
                        existsCmd.Parameters.AddWithValue("@studentId", loggedInStudentId);
                        existsCmd.Parameters.AddWithValue("@assignmentId", assignmentId);
                        exists = Convert.ToInt32(existsCmd.ExecuteScalar());
                    }

                    if (exists == 0)
                    {
                        // INSERT new submission
                        string insertQuery = @"
                    INSERT INTO StudentAssignments (StudentId, AssignmentId, FilePath, SubmittedAt, Status)
                    VALUES (@studentId, @assignmentId, @path, NOW(), 'Submitted')";

                        using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@studentId", loggedInStudentId);
                            insertCmd.Parameters.AddWithValue("@assignmentId", assignmentId);
                            insertCmd.Parameters.AddWithValue("@path", targetPath);

                            int insertResult = insertCmd.ExecuteNonQuery();
                            if (insertResult > 0)
                            {
                                statusLabel.Text = "✅ Submission Successful.";
                                statusLabel.ForeColor = Color.Green;

                                // Append to CSV
                                string csvPath = Path.Combine(Application.StartupPath, "submissions.csv");
                                string csvLine = $"{loggedInStudentId},{assignmentId},{Path.GetFileName(targetPath)},{DateTime.Now}";
                                File.AppendAllText(csvPath, csvLine + Environment.NewLine);
                            }
                            else
                            {
                                statusLabel.Text = "⚠️ Submission failed. Please try again.";
                                statusLabel.ForeColor = Color.OrangeRed;
                            }
                        }
                    }
                    else
                    {
                        // Update existing submission if needed
                        string updateQuery = @"
                    UPDATE StudentAssignments
                    SET FilePath = @path,
                        SubmittedAt = NOW(),
                        Status = 'Submitted'
                    WHERE StudentId = @studentId AND AssignmentId = @assignmentId";

                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@path", targetPath);
                            updateCmd.Parameters.AddWithValue("@studentId", loggedInStudentId);
                            updateCmd.Parameters.AddWithValue("@assignmentId", assignmentId);

                            int updateResult = updateCmd.ExecuteNonQuery();
                            if (updateResult > 0)
                            {
                                statusLabel.Text = "✅ Submission Updated Successfully.";
                                statusLabel.ForeColor = Color.Green;
                            }
                            else
                            {
                                statusLabel.Text = "⚠️ Update failed. Please try again.";
                                statusLabel.ForeColor = Color.OrangeRed;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Error: " + ex.Message;
                statusLabel.ForeColor = Color.Red;
            }


        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            assignmentComboBox.SelectedIndex = -1;
            label2.Text = "No file selected";
            commentTextBox.Clear();
            statusLabel.Text = "";
            selectedFilePath = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
