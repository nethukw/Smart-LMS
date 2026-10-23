namespace SmartLMS
{
    partial class CourseManagementScreenForm
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
            this.gradientPanel1 = new GradientPanel();
            this.dataGridViewCourseMng = new System.Windows.Forms.DataGridView();
            this.CourseCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionsCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.txtAddCourse = new System.Windows.Forms.TextBox();
            this.comboBoxFilterDropdown = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseMng)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.LightSkyBlue;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Pink;
            this.gradientPanel1.Controls.Add(this.dataGridViewCourseMng);
            this.gradientPanel1.Controls.Add(this.panel);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1016, 659);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // dataGridViewCourseMng
            // 
            this.dataGridViewCourseMng.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCourseMng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourseMng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseCodeCol,
            this.CourseNameCol,
            this.TeacherCol,
            this.ScheduleCol,
            this.CapacityCol,
            this.ActionsCol});
            this.dataGridViewCourseMng.Location = new System.Drawing.Point(106, 146);
            this.dataGridViewCourseMng.Name = "dataGridViewCourseMng";
            this.dataGridViewCourseMng.RowHeadersWidth = 51;
            this.dataGridViewCourseMng.RowTemplate.Height = 24;
            this.dataGridViewCourseMng.Size = new System.Drawing.Size(799, 394);
            this.dataGridViewCourseMng.TabIndex = 1;
            this.dataGridViewCourseMng.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourseMng_CellContentClick);
            // 
            // CourseCodeCol
            // 
            this.CourseCodeCol.HeaderText = "🏷️ Course Code";
            this.CourseCodeCol.MinimumWidth = 6;
            this.CourseCodeCol.Name = "CourseCodeCol";
            this.CourseCodeCol.Width = 125;
            // 
            // CourseNameCol
            // 
            this.CourseNameCol.HeaderText = "📘 Course Name";
            this.CourseNameCol.MinimumWidth = 6;
            this.CourseNameCol.Name = "CourseNameCol";
            this.CourseNameCol.Width = 125;
            // 
            // TeacherCol
            // 
            this.TeacherCol.HeaderText = "👩‍🏫 Teacher(s)";
            this.TeacherCol.MinimumWidth = 6;
            this.TeacherCol.Name = "TeacherCol";
            this.TeacherCol.Width = 125;
            // 
            // ScheduleCol
            // 
            this.ScheduleCol.HeaderText = "📅 Schedule";
            this.ScheduleCol.MinimumWidth = 6;
            this.ScheduleCol.Name = "ScheduleCol";
            this.ScheduleCol.Width = 125;
            // 
            // CapacityCol
            // 
            this.CapacityCol.HeaderText = "👥 Capacity";
            this.CapacityCol.MinimumWidth = 6;
            this.CapacityCol.Name = "CapacityCol";
            this.CapacityCol.Width = 125;
            // 
            // ActionsCol
            // 
            this.ActionsCol.HeaderText = "🛠 Actions";
            this.ActionsCol.MinimumWidth = 6;
            this.ActionsCol.Name = "ActionsCol";
            this.ActionsCol.Width = 125;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.Controls.Add(this.BtnAdd);
            this.panel.Controls.Add(this.txtAddCourse);
            this.panel.Controls.Add(this.comboBoxFilterDropdown);
            this.panel.Controls.Add(this.BtnSearch);
            this.panel.Controls.Add(this.txtSearchInput);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1016, 100);
            this.panel.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(865, 32);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(40, 27);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "➕";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtAddCourse
            // 
            this.txtAddCourse.BackColor = System.Drawing.Color.Khaki;
            this.txtAddCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCourse.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAddCourse.Location = new System.Drawing.Point(716, 31);
            this.txtAddCourse.Name = "txtAddCourse";
            this.txtAddCourse.Size = new System.Drawing.Size(143, 27);
            this.txtAddCourse.TabIndex = 3;
            this.txtAddCourse.Text = "Add course…";
            this.txtAddCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAddCourse.TextChanged += new System.EventHandler(this.txtAddCourse_TextChanged);
            // 
            // comboBoxFilterDropdown
            // 
            this.comboBoxFilterDropdown.BackColor = System.Drawing.Color.Khaki;
            this.comboBoxFilterDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterDropdown.FormattingEnabled = true;
            this.comboBoxFilterDropdown.Items.AddRange(new object[] {
            "Lecturer",
            "Student"});
            this.comboBoxFilterDropdown.Location = new System.Drawing.Point(377, 35);
            this.comboBoxFilterDropdown.Name = "comboBoxFilterDropdown";
            this.comboBoxFilterDropdown.Size = new System.Drawing.Size(214, 24);
            this.comboBoxFilterDropdown.TabIndex = 2;
            this.comboBoxFilterDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterDropdown_SelectedIndexChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(191, 31);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(40, 27);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "🔍";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.BackColor = System.Drawing.Color.Khaki;
            this.txtSearchInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInput.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearchInput.Location = new System.Drawing.Point(42, 31);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(143, 27);
            this.txtSearchInput.TabIndex = 0;
            this.txtSearchInput.Text = "Search course…";
            this.txtSearchInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearchInput.TextChanged += new System.EventHandler(this.txtSearchInput_TextChanged);
            // 
            // CourseManagementScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 659);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "CourseManagementScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Management Screen Form";
            this.Load += new System.EventHandler(this.CourseManagementScreenForm_Load);
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseMng)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox comboBoxFilterDropdown;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox txtAddCourse;
        private System.Windows.Forms.DataGridView dataGridViewCourseMng;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacityCol;
        private System.Windows.Forms.DataGridViewButtonColumn ActionsCol;
    }
}