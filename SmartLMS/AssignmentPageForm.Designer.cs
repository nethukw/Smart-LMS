namespace SmartLMS
{
    partial class AssignmentPageForm
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
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadlineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlUpload = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlGrade = new System.Windows.Forms.Panel();
            this.btnSubmitGrade = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lnkDownload = new System.Windows.Forms.LinkLabel();
            this.lblFileText = new System.Windows.Forms.Label();
            this.gradientPanel1 = new GradientPanel();
            this.comboBoxFilterbyStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterbyCourse = new System.Windows.Forms.ComboBox();
            this.LblAssignments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.pnlUpload.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn,
            this.DeadlineColumn,
            this.StatusColumn,
            this.ActionColumn});
            this.dgvAssignments.Location = new System.Drawing.Point(202, 134);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.RowHeadersWidth = 51;
            this.dgvAssignments.RowTemplate.Height = 24;
            this.dgvAssignments.Size = new System.Drawing.Size(554, 150);
            this.dgvAssignments.TabIndex = 1;
            this.dgvAssignments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignments_CellContentClick);
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "📄 Title ";
            this.TitleColumn.MinimumWidth = 6;
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.Width = 125;
            // 
            // DeadlineColumn
            // 
            this.DeadlineColumn.HeaderText = "📅 Deadline";
            this.DeadlineColumn.MinimumWidth = 6;
            this.DeadlineColumn.Name = "DeadlineColumn";
            this.DeadlineColumn.Width = 125;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "⏱ Status";
            this.StatusColumn.MinimumWidth = 6;
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.Width = 125;
            // 
            // ActionColumn
            // 
            this.ActionColumn.HeaderText = "📤 Action";
            this.ActionColumn.MinimumWidth = 6;
            this.ActionColumn.Name = "ActionColumn";
            this.ActionColumn.Text = "Upload";
            this.ActionColumn.UseColumnTextForButtonValue = true;
            this.ActionColumn.Width = 125;
            // 
            // pnlUpload
            // 
            this.pnlUpload.Controls.Add(this.btnSubmit);
            this.pnlUpload.Controls.Add(this.txtNotes);
            this.pnlUpload.Controls.Add(this.btnBrowse);
            this.pnlUpload.Controls.Add(this.label1);
            this.pnlUpload.Location = new System.Drawing.Point(202, 325);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Size = new System.Drawing.Size(141, 184);
            this.pnlUpload.TabIndex = 2;
            this.pnlUpload.Visible = false;
            this.pnlUpload.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUpload_Paint);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(24, 141);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "✅ Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(15, 91);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(100, 22);
            this.txtNotes.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(15, 48);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(103, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse File";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "📎 Select File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.btnSubmitGrade);
            this.pnlGrade.Controls.Add(this.txtComment);
            this.pnlGrade.Controls.Add(this.lblComment);
            this.pnlGrade.Controls.Add(this.txtScore);
            this.pnlGrade.Controls.Add(this.lblScore);
            this.pnlGrade.Controls.Add(this.lnkDownload);
            this.pnlGrade.Controls.Add(this.lblFileText);
            this.pnlGrade.Location = new System.Drawing.Point(477, 325);
            this.pnlGrade.Name = "pnlGrade";
            this.pnlGrade.Size = new System.Drawing.Size(232, 237);
            this.pnlGrade.TabIndex = 3;
            this.pnlGrade.Visible = false;
            this.pnlGrade.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrade_Paint);
            // 
            // btnSubmitGrade
            // 
            this.btnSubmitGrade.Location = new System.Drawing.Point(69, 129);
            this.btnSubmitGrade.Name = "btnSubmitGrade";
            this.btnSubmitGrade.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitGrade.TabIndex = 6;
            this.btnSubmitGrade.Text = "✅ Grade";
            this.btnSubmitGrade.UseVisualStyleBackColor = true;
            this.btnSubmitGrade.Click += new System.EventHandler(this.btnSubmitGrade_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(118, 84);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(100, 22);
            this.txtComment.TabIndex = 5;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(16, 91);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(82, 16);
            this.lblComment.TabIndex = 4;
            this.lblComment.Text = "📝 Comment:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(83, 42);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 22);
            this.txtScore.TabIndex = 3;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            this.txtScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScore_KeyPress);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(16, 48);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(61, 16);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "🔢 Score:";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // lnkDownload
            // 
            this.lnkDownload.AutoSize = true;
            this.lnkDownload.Location = new System.Drawing.Point(66, 15);
            this.lnkDownload.Name = "lnkDownload";
            this.lnkDownload.Size = new System.Drawing.Size(124, 16);
            this.lnkDownload.TabIndex = 1;
            this.lnkDownload.TabStop = true;
            this.lnkDownload.Text = "Download quiz1.pdf";
            this.lnkDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDownload_LinkClicked);
            // 
            // lblFileText
            // 
            this.lblFileText.AutoSize = true;
            this.lblFileText.Location = new System.Drawing.Point(13, 15);
            this.lblFileText.Name = "lblFileText";
            this.lblFileText.Size = new System.Drawing.Size(47, 16);
            this.lblFileText.TabIndex = 0;
            this.lblFileText.Text = "📎 File:";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.LightSkyBlue;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Thistle;
            this.gradientPanel1.Controls.Add(this.comboBoxFilterbyStatus);
            this.gradientPanel1.Controls.Add(this.comboBoxFilterbyCourse);
            this.gradientPanel1.Controls.Add(this.LblAssignments);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(989, 92);
            this.gradientPanel1.TabIndex = 0;
            // 
            // comboBoxFilterbyStatus
            // 
            this.comboBoxFilterbyStatus.FormattingEnabled = true;
            this.comboBoxFilterbyStatus.Items.AddRange(new object[] {
            "All",
            "Pending ",
            "Submitted ",
            "Graded"});
            this.comboBoxFilterbyStatus.Location = new System.Drawing.Point(445, 35);
            this.comboBoxFilterbyStatus.Name = "comboBoxFilterbyStatus";
            this.comboBoxFilterbyStatus.Size = new System.Drawing.Size(134, 24);
            this.comboBoxFilterbyStatus.TabIndex = 2;
            this.comboBoxFilterbyStatus.Text = "Filter by Status";
            this.comboBoxFilterbyStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterbyStatus_SelectedIndexChanged);
            // 
            // comboBoxFilterbyCourse
            // 
            this.comboBoxFilterbyCourse.FormattingEnabled = true;
            this.comboBoxFilterbyCourse.Location = new System.Drawing.Point(701, 35);
            this.comboBoxFilterbyCourse.Name = "comboBoxFilterbyCourse";
            this.comboBoxFilterbyCourse.Size = new System.Drawing.Size(134, 24);
            this.comboBoxFilterbyCourse.TabIndex = 1;
            this.comboBoxFilterbyCourse.Text = "Filter by Course";
            this.comboBoxFilterbyCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterbyCourse_SelectedIndexChanged);
            // 
            // LblAssignments
            // 
            this.LblAssignments.AutoSize = true;
            this.LblAssignments.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAssignments.Location = new System.Drawing.Point(32, 18);
            this.LblAssignments.Name = "LblAssignments";
            this.LblAssignments.Size = new System.Drawing.Size(247, 41);
            this.LblAssignments.TabIndex = 0;
            this.LblAssignments.Text = "📄 Assignments";
            this.LblAssignments.Click += new System.EventHandler(this.LblAssignments_Click);
            // 
            // AssignmentPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 631);
            this.Controls.Add(this.pnlGrade);
            this.Controls.Add(this.pnlUpload);
            this.Controls.Add(this.dgvAssignments);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "AssignmentPageForm";
            this.Text = "Assignment Page Form";
            this.Load += new System.EventHandler(this.AssignmentPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.pnlUpload.ResumeLayout(false);
            this.pnlUpload.PerformLayout();
            this.pnlGrade.ResumeLayout(false);
            this.pnlGrade.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label LblAssignments;
        private System.Windows.Forms.ComboBox comboBoxFilterbyCourse;
        private System.Windows.Forms.ComboBox comboBoxFilterbyStatus;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.Panel pnlUpload;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadlineColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ActionColumn;
        private System.Windows.Forms.Panel pnlGrade;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.LinkLabel lnkDownload;
        private System.Windows.Forms.Label lblFileText;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Button btnSubmitGrade;
        private System.Windows.Forms.TextBox txtComment;
    }
}