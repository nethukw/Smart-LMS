namespace SmartLMS
{
    partial class LecturerAssignmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteAssignment = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnSaveAssignment = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddAssignment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.chkFilterDueDate = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFilterDueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilterCourse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteAssignment
            // 
            this.btnDeleteAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnDeleteAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAssignment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAssignment.Location = new System.Drawing.Point(806, 122);
            this.btnDeleteAssignment.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAssignment.Name = "btnDeleteAssignment";
            this.btnDeleteAssignment.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteAssignment.TabIndex = 12;
            this.btnDeleteAssignment.Text = "Delete";
            this.btnDeleteAssignment.UseVisualStyleBackColor = false;
            // 
            // btnClearForm
            // 
            this.btnClearForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearForm.ForeColor = System.Drawing.Color.White;
            this.btnClearForm.Location = new System.Drawing.Point(806, 85);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(94, 29);
            this.btnClearForm.TabIndex = 11;
            this.btnClearForm.Text = "Clear";
            this.btnClearForm.UseVisualStyleBackColor = false;
            // 
            // btnSaveAssignment
            // 
            this.btnSaveAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnSaveAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAssignment.ForeColor = System.Drawing.Color.White;
            this.btnSaveAssignment.Location = new System.Drawing.Point(806, 48);
            this.btnSaveAssignment.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAssignment.Name = "btnSaveAssignment";
            this.btnSaveAssignment.Size = new System.Drawing.Size(94, 29);
            this.btnSaveAssignment.TabIndex = 10;
            this.btnSaveAssignment.Text = "Save";
            this.btnSaveAssignment.UseVisualStyleBackColor = false;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(802, 16);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(126, 20);
            this.lblFileName.TabIndex = 9;
            this.lblFileName.Text = "No file attached";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.Teal;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadFile.ForeColor = System.Drawing.Color.White;
            this.btnUploadFile.Location = new System.Drawing.Point(284, 169);
            this.btnUploadFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(122, 29);
            this.btnUploadFile.TabIndex = 8;
            this.btnUploadFile.Text = "Upload File";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(116, 208);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(145, 26);
            this.dtpDueDate.TabIndex = 7;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(28, 215);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(81, 20);
            this.lblDueDate.TabIndex = 6;
            this.lblDueDate.Text = "Due Date";
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(95, 169);
            this.cmbCourse.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(150, 28);
            this.cmbCourse.TabIndex = 5;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(24, 169);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(63, 20);
            this.lblCourse.TabIndex = 4;
            this.lblCourse.Text = "Course";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(141, 58);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(599, 99);
            this.rtbDescription.TabIndex = 3;
            this.rtbDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 58);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(95, 20);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(16, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddAssignment);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.chkFilterDueDate);
            this.panel3.Controls.Add(this.btnDeleteAssignment);
            this.panel3.Controls.Add(this.btnClearForm);
            this.panel3.Controls.Add(this.btnSaveAssignment);
            this.panel3.Controls.Add(this.lblFileName);
            this.panel3.Controls.Add(this.btnUploadFile);
            this.panel3.Controls.Add(this.dtpDueDate);
            this.panel3.Controls.Add(this.lblDueDate);
            this.panel3.Controls.Add(this.cmbCourse);
            this.panel3.Controls.Add(this.lblCourse);
            this.panel3.Controls.Add(this.rtbDescription);
            this.panel3.Controls.Add(this.lblDescription);
            this.panel3.Controls.Add(this.txtTitle);
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 419);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1011, 250);
            this.panel3.TabIndex = 7;
            // 
            // btnAddAssignment
            // 
            this.btnAddAssignment.Location = new System.Drawing.Point(515, 169);
            this.btnAddAssignment.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAssignment.Name = "btnAddAssignment";
            this.btnAddAssignment.Size = new System.Drawing.Size(94, 29);
            this.btnAddAssignment.TabIndex = 15;
            this.btnAddAssignment.Text = "Add Assignment";
            this.btnAddAssignment.UseVisualStyleBackColor = true;
            this.btnAddAssignment.Click += new System.EventHandler(this.btnAddAssignment_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(806, 165);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chkFilterDueDate
            // 
            this.chkFilterDueDate.AutoSize = true;
            this.chkFilterDueDate.Location = new System.Drawing.Point(806, 208);
            this.chkFilterDueDate.Margin = new System.Windows.Forms.Padding(4);
            this.chkFilterDueDate.Name = "chkFilterDueDate";
            this.chkFilterDueDate.Size = new System.Drawing.Size(146, 24);
            this.chkFilterDueDate.TabIndex = 13;
            this.chkFilterDueDate.Text = "Filter Due Date";
            this.chkFilterDueDate.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitle.Location = new System.Drawing.Point(66, 9);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(312, 30);
            this.txtTitle.TabIndex = 1;
            // 
            // Actions
            // 
            this.Actions.HeaderText = "Actions";
            this.Actions.MinimumWidth = 6;
            this.Actions.Name = "Actions";
            this.Actions.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 6;
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.AllowUserToAddRows = false;
            this.dgvAssignments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.dgvAssignments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Course,
            this.DueDate,
            this.Status,
            this.Actions});
            this.dgvAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignments.Location = new System.Drawing.Point(0, 137);
            this.dgvAssignments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.ReadOnly = true;
            this.dgvAssignments.RowHeadersWidth = 51;
            this.dgvAssignments.RowTemplate.Height = 24;
            this.dgvAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignments.Size = new System.Drawing.Size(1011, 532);
            this.dgvAssignments.TabIndex = 6;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.MinimumWidth = 6;
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackColor = System.Drawing.Color.Teal;
            this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilters.ForeColor = System.Drawing.Color.White;
            this.btnClearFilters.Location = new System.Drawing.Point(888, 19);
            this.btnClearFilters.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(88, 29);
            this.btnClearFilters.TabIndex = 6;
            this.btnClearFilters.Text = "Clear";
            this.btnClearFilters.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(638, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 26);
            this.txtSearch.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Search:";
            // 
            // dtpFilterDueDate
            // 
            this.dtpFilterDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterDueDate.Location = new System.Drawing.Point(362, 19);
            this.dtpFilterDueDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFilterDueDate.Name = "dtpFilterDueDate";
            this.dtpFilterDueDate.Size = new System.Drawing.Size(136, 26);
            this.dtpFilterDueDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Due Date:";
            // 
            // cmbFilterCourse
            // 
            this.cmbFilterCourse.FormattingEnabled = true;
            this.cmbFilterCourse.Location = new System.Drawing.Point(88, 19);
            this.cmbFilterCourse.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFilterCourse.Name = "cmbFilterCourse";
            this.cmbFilterCourse.Size = new System.Drawing.Size(150, 28);
            this.cmbFilterCourse.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.btnClearFilters);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpFilterDueDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbFilterCourse);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 75);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Assignments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 62);
            this.panel1.TabIndex = 4;
            // 
            // LecturerAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 669);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvAssignments);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LecturerAssignmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LecturerAssignmentForm";
            this.Load += new System.EventHandler(this.LecturerAssignmentForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteAssignment;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnSaveAssignment;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFilterDueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilterCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkFilterDueDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddAssignment;
    }
}