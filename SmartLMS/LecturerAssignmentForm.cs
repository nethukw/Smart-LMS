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
    public partial class LecturerAssignmentForm : BaseForm
    {
        private string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";

        // Current logged-in lecturer's ID (Set this dynamically in real app)
        private int currentLecturerId = 2; // Example lecturer id

        private int editingAssignmentId = -1; // For update mode
        private int selectedAssignmentId = -1; // For delete selection (optional)
        private string uploadedFilePath = null;
        public LecturerAssignmentForm()
        {
            

            InitializeComponent();

            // Wire form load event here if not done in designer
            this.Load += LecturerAssignmentForm_Load;

            LoadCoursesToComboBoxes();
            SetupDataGridViewButtons();

            // Placeholder text handlers for search box
            this.txtSearch.Enter += txtSearch_Enter;
            this.txtSearch.Leave += txtSearch_Leave;

            // Wire filter events
            this.cmbFilterCourse.SelectedIndexChanged += cmbFilterCourse_SelectedIndexChanged;
            this.chkFilterDueDate.CheckedChanged += chkFilterDueDate_CheckedChanged;
            this.dtpFilterDueDate.ValueChanged += dtpFilterDueDate_ValueChanged;
            this.txtSearch.TextChanged += txtSearch_TextChanged;
            this.btnClearFilters.Click += btnClearFilters_Click;

            // Wire DataGridView cell click for buttons
            this.dgvAssignments.CellClick += dgvAssignments_CellClick;

            // Wire buttons
            this.btnSaveAssignment.Click += btnSaveAssignment_Click;
            this.btnClearForm.Click += btnClearForm_Click;
            this.btnUploadFile.Click += btnUploadFile_Click;
        }

        private void LecturerAssignmentForm_Load(object sender, EventArgs e)
        {
            ResetFilters();
            ResetForm();
            LoadAssignments();
        }

        private void LoadCoursesToComboBoxes()
        {
            try
            {
                cmbFilterCourse.Items.Clear();
                cmbCourse.Items.Clear();

                cmbFilterCourse.Items.Add("All Courses");
                cmbFilterCourse.SelectedIndex = 0;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT CourseId, Title FROM Courses ORDER BY Title";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string title = reader.GetString("Title");
                            int id = reader.GetInt32("CourseId");
                            cmbFilterCourse.Items.Add(new ComboboxItem { Text = title, Value = id });
                            cmbCourse.Items.Add(new ComboboxItem { Text = title, Value = id });
                        }
                    }
                }
                cmbCourse.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        private void LoadAssignments()
        {
            try
            {
                dgvAssignments.Rows.Clear();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT a.AssignmentId, a.Title, c.Title AS CourseTitle, a.DueDate, a.Description 
                        FROM Assignments a
                        JOIN Courses c ON a.CourseId = c.CourseId
                        WHERE 1=1";

                    List<MySqlParameter> parameters = new List<MySqlParameter>();

                    // Filter: Course
                    if (cmbFilterCourse.SelectedIndex > 0) // skip "All Courses"
                    {
                        var courseItem = (ComboboxItem)cmbFilterCourse.SelectedItem;
                        query += " AND a.CourseId = @courseId";
                        parameters.Add(new MySqlParameter("@courseId", courseItem.Value));
                    }

                    // Filter: Due Date
                    if (chkFilterDueDate.Checked)
                    {
                        query += " AND DATE(a.DueDate) = @dueDate";
                        parameters.Add(new MySqlParameter("@dueDate", dtpFilterDueDate.Value.Date));
                    }

                    // Filter: Search text
                    if (!string.IsNullOrWhiteSpace(txtSearch.Text) && txtSearch.Text != "Search by title...")
                    {
                        query += " AND a.Title LIKE @search";
                        parameters.Add(new MySqlParameter("@search", "%" + txtSearch.Text.Trim() + "%"));
                    }

                    query += " ORDER BY a.DueDate ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("AssignmentId");
                                string title = reader.GetString("Title");
                                string course = reader.GetString("CourseTitle");
                                DateTime dueDate = reader.GetDateTime("DueDate");

                                string status = dueDate < DateTime.Now ? "Expired" : "Active";

                                dgvAssignments.Rows.Add(id, title, course, dueDate.ToShortDateString(), status);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assignments: " + ex.Message);
            }
        }

        private void SetupDataGridViewButtons()
        {
            // Clear all existing columns to avoid duplication
            dgvAssignments.Columns.Clear();

            // Add AssignmentId hidden column
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn
            {
                Name = "AssignmentId",
                Visible = false
            };
            dgvAssignments.Columns.Add(idCol);

            dgvAssignments.Columns.Add("Title", "Title");
            dgvAssignments.Columns.Add("Course", "Course");
            dgvAssignments.Columns.Add("DueDate", "Due Date");
            dgvAssignments.Columns.Add("Status", "Status");

            // Add Edit button column
            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn
            {
                Name = "EditBtn",
                HeaderText = "Edit",
                Text = "✎",
                UseColumnTextForButtonValue = true
            };
            dgvAssignments.Columns.Add(editBtn);

            // Add Delete button column
            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn
            {
                Name = "DeleteBtn",
                HeaderText = "Delete",
                Text = "🗑️",
                UseColumnTextForButtonValue = true
            };
            dgvAssignments.Columns.Add(deleteBtn);

            dgvAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // When user clicks Edit or Delete buttons in grid
        private void dgvAssignments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header row

            var grid = sender as DataGridView;

            if (grid.Columns[e.ColumnIndex].Name == "EditBtn")
            {
                int assignmentId = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["AssignmentId"].Value);
                LoadAssignmentForEditing(assignmentId);
            }
            else if (grid.Columns[e.ColumnIndex].Name == "DeleteBtn")
            {
                int assignmentId = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["AssignmentId"].Value);
                var confirm = MessageBox.Show("Are you sure you want to delete this assignment?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    DeleteAssignment(assignmentId);
                }
            }
        }

        private void LoadAssignmentForEditing(int assignmentId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT Title, Description, DueDate, FileName, CourseId
                                     FROM Assignments WHERE AssignmentId = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", assignmentId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtTitle.Text = reader.GetString("Title");
                                rtbDescription.Text = reader.IsDBNull(reader.GetOrdinal("Description")) ? "" : reader.GetString("Description");
                                dtpDueDate.Value = reader.GetDateTime("DueDate");

                                int courseId = reader.GetInt32("CourseId");

                                // Select course in combo box
                                foreach (var item in cmbCourse.Items)
                                {
                                    if (item is ComboboxItem ci && (int)ci.Value == courseId)
                                    {
                                        cmbCourse.SelectedItem = item;
                                        break;
                                    }
                                }

                                lblFileName.Text = reader.IsDBNull(reader.GetOrdinal("FileName")) ? "No file attached" : reader.GetString("FileName");

                                editingAssignmentId = assignmentId;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assignment: " + ex.Message);
            }
        }

        private void DeleteAssignment(int assignmentId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Assignments WHERE AssignmentId = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", assignmentId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Assignment deleted successfully.");
                LoadAssignments();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting assignment: " + ex.Message);
            }
        }

        private void btnSaveAssignment_Click(object sender, EventArgs e)
        {
            if (cmbCourse.SelectedItem == null)
            {
                MessageBox.Show("Please select a course.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter assignment title.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query;
                    if (editingAssignmentId == -1)
                    {
                        query = @"INSERT INTO Assignments (CourseId, Title, Description, DueDate, FileName, FileData, CreatedBy) 
                                  VALUES (@courseId, @title, @desc, @dueDate, @fileName, @fileData, @createdBy)";
                    }
                    else
                    {
                        query = @"UPDATE Assignments SET CourseId=@courseId, Title=@title, Description=@desc, DueDate=@dueDate, 
                                  FileName=@fileName, FileData=@fileData WHERE AssignmentId=@id";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        var courseItem = (ComboboxItem)cmbCourse.SelectedItem;
                        cmd.Parameters.AddWithValue("@courseId", courseItem.Value);
                        cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@desc", rtbDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@dueDate", dtpDueDate.Value);

                        string fileName = lblFileName.Text != "No file attached" ? lblFileName.Text : null;
                        byte[] fileData = null;
                        if (uploadedFilePath != null && File.Exists(uploadedFilePath))
                        {
                            fileData = File.ReadAllBytes(uploadedFilePath);
                        }
                        else if (editingAssignmentId != -1)
                        {
                            fileData = GetFileData(editingAssignmentId);
                        }

                        cmd.Parameters.AddWithValue("@fileName", fileName);
                        cmd.Parameters.AddWithValue("@fileData", fileData ?? (object)DBNull.Value);

                        if (editingAssignmentId == -1)
                        {
                            cmd.Parameters.AddWithValue("@createdBy", currentLecturerId);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@id", editingAssignmentId);
                        }

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Assignment saved successfully.");
                LoadAssignments();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving assignment: " + ex.Message);
            }
        }

        private byte[] GetFileData(int assignmentId)
        {
            byte[] fileData = null;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT FileData FROM Assignments WHERE AssignmentId = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", assignmentId);
                        fileData = cmd.ExecuteScalar() as byte[];
                    }
                }
            }
            catch { }
            return fileData;
        }

        private void ResetForm()
        {
            editingAssignmentId = -1;
            txtTitle.Clear();
            rtbDescription.Clear();
            cmbCourse.SelectedIndex = -1;
            dtpDueDate.Value = DateTime.Now;
            lblFileName.Text = "No file attached";
            uploadedFilePath = null;
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select assignment file";
            openFile.Filter = "All files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                uploadedFilePath = openFile.FileName;
                lblFileName.Text = Path.GetFileName(uploadedFilePath);
            }
        }

        private void ResetFilters()
        {
            cmbFilterCourse.SelectedIndex = 0;
            chkFilterDueDate.Checked = false;
            dtpFilterDueDate.Enabled = false;
            txtSearch.Text = "Search by title...";
            txtSearch.ForeColor = Color.Gray;
        }

        private void cmbFilterCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAssignments();
        }

        private void chkFilterDueDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFilterDueDate.Enabled = chkFilterDueDate.Checked;
            LoadAssignments();
        }

        private void dtpFilterDueDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAssignments();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.Gray) return; // ignore placeholder
            LoadAssignments();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            ResetFilters();
            LoadAssignments();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by title...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search by title...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddAssignment_Click(object sender, EventArgs e)
        {
            LecturerAddAssignmentForm addForm = new LecturerAddAssignmentForm(currentLecturerId);
            var result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Optional: Reload assignments after new assignment is added
                LoadAssignments();
            }
        }
    }
}
