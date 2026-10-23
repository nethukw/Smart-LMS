namespace SmartLMS
{
    partial class StudentCourseViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CourseDetailsButton = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlCourses = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CoursesDataGridView = new System.Windows.Forms.DataGridView();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.AvailableCoursesDataGridView = new System.Windows.Forms.DataGridView();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControlCourses.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCoursesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(609, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Search:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Lavender;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(3, 37);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(252, 28);
            this.lblStudentName.TabIndex = 22;
            this.lblStudentName.Text = "Welcome, [Student Name]";
            this.lblStudentName.Click += new System.EventHandler(this.lblStudentName_Click);
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(668, 42);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(200, 24);
            this.cmbSemester.TabIndex = 21;
            this.cmbSemester.SelectedIndexChanged += new System.EventHandler(this.cmbSemester_SelectedIndexChanged);
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.BackColor = System.Drawing.Color.GhostWhite;
            this.lblSemester.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblSemester.Location = new System.Drawing.Point(519, 42);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(143, 23);
            this.lblSemester.TabIndex = 15;
            this.lblSemester.Text = "Filter by Semester:";
            this.lblSemester.Click += new System.EventHandler(this.lblSemester_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.Location = new System.Drawing.Point(444, 20);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(124, 38);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "🔄 Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Red;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(31, 20);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(124, 38);
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "⏪ Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CourseDetailsButton
            // 
            this.CourseDetailsButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.CourseDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseDetailsButton.ForeColor = System.Drawing.Color.White;
            this.CourseDetailsButton.Location = new System.Drawing.Point(833, 20);
            this.CourseDetailsButton.Name = "CourseDetailsButton";
            this.CourseDetailsButton.Size = new System.Drawing.Size(124, 38);
            this.CourseDetailsButton.TabIndex = 20;
            this.CourseDetailsButton.Text = "📘 View Details";
            this.CourseDetailsButton.UseVisualStyleBackColor = false;
            this.CourseDetailsButton.Click += new System.EventHandler(this.CourseDetailsButton_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(668, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 22);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Lavender;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.TitleLabel.Location = new System.Drawing.Point(-7, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(323, 37);
            this.TitleLabel.TabIndex = 19;
            this.TitleLabel.Text = "📚 My Enrolled Courses";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Controls.Add(this.lblStudentName);
            this.panel1.Controls.Add(this.cmbSemester);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblSemester);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 78);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.CourseDetailsButton);
            this.panel2.Controls.Add(this.RefreshButton);
            this.panel2.Controls.Add(this.BackButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 78);
            this.panel2.TabIndex = 25;
            // 
            // tabControlCourses
            // 
            this.tabControlCourses.Controls.Add(this.tabPage1);
            this.tabControlCourses.Controls.Add(this.tabPage2);
            this.tabControlCourses.Location = new System.Drawing.Point(0, 84);
            this.tabControlCourses.Name = "tabControlCourses";
            this.tabControlCourses.SelectedIndex = 0;
            this.tabControlCourses.Size = new System.Drawing.Size(995, 371);
            this.tabControlCourses.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CoursesDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(987, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Courses";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEnroll);
            this.tabPage2.Controls.Add(this.AvailableCoursesDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(987, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Available Courses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CoursesDataGridView
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.CoursesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.CoursesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CoursesDataGridView.ColumnHeadersHeight = 29;
            this.CoursesDataGridView.Location = new System.Drawing.Point(-6, 0);
            this.CoursesDataGridView.Name = "CoursesDataGridView";
            this.CoursesDataGridView.ReadOnly = true;
            this.CoursesDataGridView.RowHeadersWidth = 51;
            this.CoursesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CoursesDataGridView.Size = new System.Drawing.Size(997, 346);
            this.CoursesDataGridView.TabIndex = 15;
            this.CoursesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoursesDataGridView_CellContentClick_1);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // AvailableCoursesDataGridView
            // 
            this.AvailableCoursesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.AvailableCoursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableCoursesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.AvailableCoursesDataGridView.Name = "AvailableCoursesDataGridView";
            this.AvailableCoursesDataGridView.RowHeadersWidth = 51;
            this.AvailableCoursesDataGridView.RowTemplate.Height = 24;
            this.AvailableCoursesDataGridView.Size = new System.Drawing.Size(991, 346);
            this.AvailableCoursesDataGridView.TabIndex = 0;
            this.AvailableCoursesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AvailableCoursesDataGridView_CellContentClick);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(440, 323);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(75, 23);
            this.btnEnroll.TabIndex = 1;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // StudentCourseViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 539);
            this.Controls.Add(this.tabControlCourses);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentCourseViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseViewForm";
            this.Load += new System.EventHandler(this.StudentCourseViewForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControlCourses.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CoursesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCoursesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CourseDetailsButton;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControlCourses;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView CoursesDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.DataGridView AvailableCoursesDataGridView;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
    }
}