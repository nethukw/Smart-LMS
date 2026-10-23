namespace SmartLMS
{
    partial class CourseForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLecturer = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lstMaterials = new System.Windows.Forms.ListView();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtLecturer = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnlCourseDetails = new System.Windows.Forms.Panel();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLecturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtwlcm = new System.Windows.Forms.TextBox();
            this.gradientPanel1 = new GradientPanel();
            this.pnlCourseDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(139, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(139, 190);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblLecturer
            // 
            this.lblLecturer.AutoSize = true;
            this.lblLecturer.Location = new System.Drawing.Point(139, 138);
            this.lblLecturer.Name = "lblLecturer";
            this.lblLecturer.Size = new System.Drawing.Size(55, 16);
            this.lblLecturer.TabIndex = 3;
            this.lblLecturer.Text = "Lecturer";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(139, 82);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lstMaterials
            // 
            this.lstMaterials.HideSelection = false;
            this.lstMaterials.Location = new System.Drawing.Point(142, 235);
            this.lstMaterials.Name = "lstMaterials";
            this.lstMaterials.Size = new System.Drawing.Size(121, 97);
            this.lstMaterials.TabIndex = 5;
            this.lstMaterials.UseCompatibleStateImageBehavior = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(151, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(244, 21);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
            this.txtTitle.TabIndex = 7;
            // 
            // txtLecturer
            // 
            this.txtLecturer.Location = new System.Drawing.Point(244, 132);
            this.txtLecturer.Name = "txtLecturer";
            this.txtLecturer.Size = new System.Drawing.Size(100, 22);
            this.txtLecturer.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(244, 76);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // pnlCourseDetails
            // 
            this.pnlCourseDetails.Controls.Add(this.dateTimePicker1);
            this.pnlCourseDetails.Controls.Add(this.txtDescription);
            this.pnlCourseDetails.Controls.Add(this.txtLecturer);
            this.pnlCourseDetails.Controls.Add(this.txtTitle);
            this.pnlCourseDetails.Controls.Add(this.btnBack);
            this.pnlCourseDetails.Controls.Add(this.lstMaterials);
            this.pnlCourseDetails.Controls.Add(this.lblDescription);
            this.pnlCourseDetails.Controls.Add(this.lblLecturer);
            this.pnlCourseDetails.Controls.Add(this.lblDate);
            this.pnlCourseDetails.Controls.Add(this.lblTitle);
            this.pnlCourseDetails.Location = new System.Drawing.Point(35, 218);
            this.pnlCourseDetails.Name = "pnlCourseDetails";
            this.pnlCourseDetails.Size = new System.Drawing.Size(829, 424);
            this.pnlCourseDetails.TabIndex = 2;
            // 
            // colAction
            // 
            this.colAction.HeaderText = "View";
            this.colAction.MinimumWidth = 6;
            this.colAction.Name = "colAction";
            this.colAction.Width = 125;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Enrolled Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.Width = 125;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.MinimumWidth = 6;
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 125;
            // 
            // colLecturer
            // 
            this.colLecturer.HeaderText = "Lecturer Name";
            this.colLecturer.MinimumWidth = 6;
            this.colLecturer.Name = "colLecturer";
            this.colLecturer.Width = 125;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Course Title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.Width = 125;
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colLecturer,
            this.colDescription,
            this.colDate,
            this.colAction});
            this.dgvCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourses.Location = new System.Drawing.Point(0, 100);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 24;
            this.dgvCourses.Size = new System.Drawing.Size(908, 573);
            this.dgvCourses.TabIndex = 1;
            this.dgvCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome, [Student Name]";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtwlcm
            // 
            this.txtwlcm.Location = new System.Drawing.Point(325, 53);
            this.txtwlcm.Multiline = true;
            this.txtwlcm.Name = "txtwlcm";
            this.txtwlcm.Size = new System.Drawing.Size(217, 37);
            this.txtwlcm.TabIndex = 2;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.HotPink;
            this.gradientPanel1.ColorTop = System.Drawing.Color.LightBlue;
            this.gradientPanel1.Controls.Add(this.txtwlcm);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(908, 100);
            this.gradientPanel1.TabIndex = 0;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 673);
            this.Controls.Add(this.pnlCourseDetails);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.pnlCourseDetails.ResumeLayout(false);
            this.pnlCourseDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLecturer;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ListView lstMaterials;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtLecturer;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnlCourseDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLecturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtwlcm;
        private GradientPanel gradientPanel1;
    }
}