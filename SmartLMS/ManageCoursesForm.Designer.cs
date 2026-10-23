namespace SmartLMS
{
    partial class ManageCoursesForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbDepartmentFilter = new System.Windows.Forms.ComboBox();
            this.cmbLecturerFilter = new System.Windows.Forms.ComboBox();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnAssignLecturer = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTotalCourses = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelHeader.Controls.Add(this.label3);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.btnSearch);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.txtSearch);
            this.panelHeader.Controls.Add(this.cmbDepartmentFilter);
            this.panelHeader.Controls.Add(this.cmbLecturerFilter);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1022, 94);
            this.panelHeader.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Crimson;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(903, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Courses";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(710, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(175, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbDepartmentFilter
            // 
            this.cmbDepartmentFilter.FormattingEnabled = true;
            this.cmbDepartmentFilter.Location = new System.Drawing.Point(468, 49);
            this.cmbDepartmentFilter.Name = "cmbDepartmentFilter";
            this.cmbDepartmentFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbDepartmentFilter.TabIndex = 1;
            this.cmbDepartmentFilter.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmentFilter_SelectedIndexChanged);
            // 
            // cmbLecturerFilter
            // 
            this.cmbLecturerFilter.FormattingEnabled = true;
            this.cmbLecturerFilter.Location = new System.Drawing.Point(468, 19);
            this.cmbLecturerFilter.Name = "cmbLecturerFilter";
            this.cmbLecturerFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbLecturerFilter.TabIndex = 2;
            this.cmbLecturerFilter.SelectedIndexChanged += new System.EventHandler(this.cmbLecturerFilter_SelectedIndexChanged);
            // 
            // dgvCourses
            // 
            this.dgvCourses.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(2, 118);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 24;
            this.dgvCourses.Size = new System.Drawing.Size(1021, 381);
            this.dgvCourses.TabIndex = 1;
            this.dgvCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellContentClick);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.Green;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Location = new System.Drawing.Point(26, 20);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(143, 49);
            this.btnAddCourse.TabIndex = 2;
            this.btnAddCourse.Text = "➕ Add New Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.BackColor = System.Drawing.Color.Blue;
            this.btnEditCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCourse.Location = new System.Drawing.Point(220, 20);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(143, 49);
            this.btnEditCourse.TabIndex = 3;
            this.btnEditCourse.Text = "✏️ Edit Course";
            this.btnEditCourse.UseVisualStyleBackColor = false;
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCourse.Location = new System.Drawing.Point(628, 20);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(143, 49);
            this.btnDeleteCourse.TabIndex = 4;
            this.btnDeleteCourse.Text = "🗑️ Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnAssignLecturer
            // 
            this.btnAssignLecturer.BackColor = System.Drawing.Color.Orange;
            this.btnAssignLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignLecturer.Location = new System.Drawing.Point(416, 20);
            this.btnAssignLecturer.Name = "btnAssignLecturer";
            this.btnAssignLecturer.Size = new System.Drawing.Size(143, 49);
            this.btnAssignLecturer.TabIndex = 5;
            this.btnAssignLecturer.Text = "👤 Assign Lecturer";
            this.btnAssignLecturer.UseVisualStyleBackColor = false;
            this.btnAssignLecturer.Click += new System.EventHandler(this.btnAssignLecturer_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(844, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(143, 49);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTotalCourses
            // 
            this.lblTotalCourses.AutoSize = true;
            this.lblTotalCourses.Location = new System.Drawing.Point(205, 422);
            this.lblTotalCourses.Name = "lblTotalCourses";
            this.lblTotalCourses.Size = new System.Drawing.Size(0, 16);
            this.lblTotalCourses.TabIndex = 7;
            this.lblTotalCourses.Click += new System.EventHandler(this.lblTotalCourses_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter by Lecturer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter by Department :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btnAddCourse);
            this.panel1.Controls.Add(this.btnEditCourse);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDeleteCourse);
            this.panel1.Controls.Add(this.btnAssignLecturer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 94);
            this.panel1.TabIndex = 8;
            // 
            // ManageCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotalCourses);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageCoursesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCoursesForm";
            this.Load += new System.EventHandler(this.ManageCoursesForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbDepartmentFilter;
        private System.Windows.Forms.ComboBox cmbLecturerFilter;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnAssignLecturer;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTotalCourses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}