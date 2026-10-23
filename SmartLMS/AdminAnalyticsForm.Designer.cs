namespace SmartLMS
{
    partial class AdminAnalyticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelOverview = new System.Windows.Forms.Panel();
            this.panelTotalLecturers = new System.Windows.Forms.Panel();
            this.lblTotalLecturers = new System.Windows.Forms.Label();
            this.panelTotalCourses = new System.Windows.Forms.Panel();
            this.lblTotalCourses = new System.Windows.Forms.Label();
            this.panelTotalAssignments = new System.Windows.Forms.Panel();
            this.lblTotalAssignments = new System.Windows.Forms.Label();
            this.panelTotalSubmissions = new System.Windows.Forms.Panel();
            this.lblTotalSubmissions = new System.Windows.Forms.Label();
            this.panelTotalStudents = new System.Windows.Forms.Panel();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.panelCharts = new System.Windows.Forms.Panel();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbCourseFilter = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbChartType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelOverview.SuspendLayout();
            this.panelTotalLecturers.SuspendLayout();
            this.panelTotalCourses.SuspendLayout();
            this.panelTotalAssignments.SuspendLayout();
            this.panelTotalSubmissions.SuspendLayout();
            this.panelTotalStudents.SuspendLayout();
            this.panelCharts.SuspendLayout();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOverview
            // 
            this.panelOverview.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelOverview.Controls.Add(this.panelTotalLecturers);
            this.panelOverview.Controls.Add(this.panelTotalCourses);
            this.panelOverview.Controls.Add(this.panelTotalAssignments);
            this.panelOverview.Controls.Add(this.panelTotalSubmissions);
            this.panelOverview.Controls.Add(this.panelTotalStudents);
            this.panelOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOverview.Location = new System.Drawing.Point(0, 0);
            this.panelOverview.Name = "panelOverview";
            this.panelOverview.Size = new System.Drawing.Size(1182, 120);
            this.panelOverview.TabIndex = 0;
            this.panelOverview.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOverview_Paint);
            // 
            // panelTotalLecturers
            // 
            this.panelTotalLecturers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTotalLecturers.Controls.Add(this.lblTotalLecturers);
            this.panelTotalLecturers.Location = new System.Drawing.Point(282, 16);
            this.panelTotalLecturers.Name = "panelTotalLecturers";
            this.panelTotalLecturers.Size = new System.Drawing.Size(150, 90);
            this.panelTotalLecturers.TabIndex = 1;
            this.panelTotalLecturers.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblTotalLecturers
            // 
            this.lblTotalLecturers.AutoSize = true;
            this.lblTotalLecturers.Location = new System.Drawing.Point(17, 4);
            this.lblTotalLecturers.Name = "lblTotalLecturers";
            this.lblTotalLecturers.Size = new System.Drawing.Size(111, 16);
            this.lblTotalLecturers.TabIndex = 0;
            this.lblTotalLecturers.Text = "👨‍🏫 Total Lecturers";
            this.lblTotalLecturers.Click += new System.EventHandler(this.lblTotalLecturers_Click);
            // 
            // panelTotalCourses
            // 
            this.panelTotalCourses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTotalCourses.Controls.Add(this.lblTotalCourses);
            this.panelTotalCourses.Location = new System.Drawing.Point(526, 16);
            this.panelTotalCourses.Name = "panelTotalCourses";
            this.panelTotalCourses.Size = new System.Drawing.Size(150, 90);
            this.panelTotalCourses.TabIndex = 1;
            this.panelTotalCourses.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblTotalCourses
            // 
            this.lblTotalCourses.AutoSize = true;
            this.lblTotalCourses.Location = new System.Drawing.Point(25, 4);
            this.lblTotalCourses.Name = "lblTotalCourses";
            this.lblTotalCourses.Size = new System.Drawing.Size(106, 16);
            this.lblTotalCourses.TabIndex = 0;
            this.lblTotalCourses.Text = "📚 Total Courses";
            this.lblTotalCourses.Click += new System.EventHandler(this.lblTotalCourses_Click);
            // 
            // panelTotalAssignments
            // 
            this.panelTotalAssignments.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTotalAssignments.Controls.Add(this.lblTotalAssignments);
            this.panelTotalAssignments.Location = new System.Drawing.Point(756, 16);
            this.panelTotalAssignments.Name = "panelTotalAssignments";
            this.panelTotalAssignments.Size = new System.Drawing.Size(150, 90);
            this.panelTotalAssignments.TabIndex = 1;
            this.panelTotalAssignments.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lblTotalAssignments
            // 
            this.lblTotalAssignments.AutoSize = true;
            this.lblTotalAssignments.Location = new System.Drawing.Point(3, 4);
            this.lblTotalAssignments.Name = "lblTotalAssignments";
            this.lblTotalAssignments.Size = new System.Drawing.Size(133, 16);
            this.lblTotalAssignments.TabIndex = 0;
            this.lblTotalAssignments.Text = "📝 Total Assignments";
            this.lblTotalAssignments.Click += new System.EventHandler(this.lblTotalAssignments_Click);
            // 
            // panelTotalSubmissions
            // 
            this.panelTotalSubmissions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTotalSubmissions.Controls.Add(this.lblTotalSubmissions);
            this.panelTotalSubmissions.Location = new System.Drawing.Point(978, 16);
            this.panelTotalSubmissions.Name = "panelTotalSubmissions";
            this.panelTotalSubmissions.Size = new System.Drawing.Size(150, 90);
            this.panelTotalSubmissions.TabIndex = 1;
            this.panelTotalSubmissions.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lblTotalSubmissions
            // 
            this.lblTotalSubmissions.AutoSize = true;
            this.lblTotalSubmissions.Location = new System.Drawing.Point(14, 4);
            this.lblTotalSubmissions.Name = "lblTotalSubmissions";
            this.lblTotalSubmissions.Size = new System.Drawing.Size(133, 16);
            this.lblTotalSubmissions.TabIndex = 0;
            this.lblTotalSubmissions.Text = "📤 Total Submissions";
            this.lblTotalSubmissions.Click += new System.EventHandler(this.lblTotalSubmissions_Click);
            // 
            // panelTotalStudents
            // 
            this.panelTotalStudents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTotalStudents.Controls.Add(this.lblTotalStudents);
            this.panelTotalStudents.Location = new System.Drawing.Point(47, 16);
            this.panelTotalStudents.Name = "panelTotalStudents";
            this.panelTotalStudents.Size = new System.Drawing.Size(150, 90);
            this.panelTotalStudents.TabIndex = 0;
            this.panelTotalStudents.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Location = new System.Drawing.Point(20, 4);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(108, 16);
            this.lblTotalStudents.TabIndex = 0;
            this.lblTotalStudents.Text = "📘 Total Students";
            this.lblTotalStudents.Click += new System.EventHandler(this.lblTotalStudents_Click);
            // 
            // panelCharts
            // 
            this.panelCharts.AutoScroll = true;
            this.panelCharts.Controls.Add(this.panelFilters);
            this.panelCharts.Controls.Add(this.chart1);
            this.panelCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCharts.Location = new System.Drawing.Point(0, 120);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Size = new System.Drawing.Size(1182, 533);
            this.panelCharts.TabIndex = 1;
            this.panelCharts.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCharts_Paint);
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelFilters.Controls.Add(this.label2);
            this.panelFilters.Controls.Add(this.label1);
            this.panelFilters.Controls.Add(this.cmbChartType);
            this.panelFilters.Controls.Add(this.lblLastUpdated);
            this.panelFilters.Controls.Add(this.btnExport);
            this.panelFilters.Controls.Add(this.ProgressBar);
            this.panelFilters.Controls.Add(this.btnRefresh);
            this.panelFilters.Controls.Add(this.chkDarkMode);
            this.panelFilters.Controls.Add(this.dtTo);
            this.panelFilters.Controls.Add(this.dtFrom);
            this.panelFilters.Controls.Add(this.cmbCourseFilter);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFilters.Location = new System.Drawing.Point(0, 424);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(1179, 112);
            this.panelFilters.TabIndex = 1;
            this.panelFilters.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFilters_Paint);
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Location = new System.Drawing.Point(370, 55);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(0, 16);
            this.lblLastUpdated.TabIndex = 4;
            this.lblLastUpdated.Click += new System.EventHandler(this.lblLastUpdated_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1029, 16);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(47, 16);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 23);
            this.ProgressBar.TabIndex = 3;
            this.ProgressBar.Click += new System.EventHandler(this.ProgressBar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1029, 52);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkDarkMode.Location = new System.Drawing.Point(47, 68);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(96, 20);
            this.chkDarkMode.TabIndex = 2;
            this.chkDarkMode.Text = "Dark Mode";
            this.chkDarkMode.UseVisualStyleBackColor = false;
            this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(673, 14);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 22);
            this.dtTo.TabIndex = 2;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(348, 14);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 22);
            this.dtFrom.TabIndex = 1;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // cmbCourseFilter
            // 
            this.cmbCourseFilter.FormattingEnabled = true;
            this.cmbCourseFilter.Location = new System.Drawing.Point(673, 63);
            this.cmbCourseFilter.Name = "cmbCourseFilter";
            this.cmbCourseFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbCourseFilter.TabIndex = 0;
            this.cmbCourseFilter.SelectedIndexChanged += new System.EventHandler(this.cmbCourseFilter_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Plum;
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            chartArea3.Name = "ChartArea3";
            chartArea4.Name = "ChartArea4";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.ChartAreas.Add(chartArea4);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "chartStudentsPerCourse";
            series2.ChartArea = "ChartArea2";
            series2.Legend = "Legend1";
            series2.Name = "chartAssignmentsPerCourse";
            series3.ChartArea = "ChartArea3";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "chartSubmissionsPerWeek";
            series4.ChartArea = "ChartArea4";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "chartPassFailRatio";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1179, 424);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Students per Course (Pie)";
            title2.Name = "Assignments per Course(Column Chart) ";
            title3.Name = "Submissions per Week (Line Chart)";
            title4.Name = "Pass/Fail Ratio (Doughnut Chart)";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.Titles.Add(title3);
            this.chart1.Titles.Add(title4);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // cmbChartType
            // 
            this.cmbChartType.FormattingEnabled = true;
            this.cmbChartType.Items.AddRange(new object[] {
            "Column",
            "Pie",
            "Line",
            "Bar"});
            this.cmbChartType.Location = new System.Drawing.Point(348, 63);
            this.cmbChartType.Name = "cmbChartType";
            this.cmbChartType.Size = new System.Drawing.Size(121, 24);
            this.cmbChartType.TabIndex = 5;
            this.cmbChartType.SelectedIndexChanged += new System.EventHandler(this.cmbChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(295, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "From : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(637, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "To :";
            // 
            // AdminAnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.panelOverview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminAnalyticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAnalyticsForm";
            this.Load += new System.EventHandler(this.AdminAnalyticsForm_Load);
            this.panelOverview.ResumeLayout(false);
            this.panelTotalLecturers.ResumeLayout(false);
            this.panelTotalLecturers.PerformLayout();
            this.panelTotalCourses.ResumeLayout(false);
            this.panelTotalCourses.PerformLayout();
            this.panelTotalAssignments.ResumeLayout(false);
            this.panelTotalAssignments.PerformLayout();
            this.panelTotalSubmissions.ResumeLayout(false);
            this.panelTotalSubmissions.PerformLayout();
            this.panelTotalStudents.ResumeLayout(false);
            this.panelTotalStudents.PerformLayout();
            this.panelCharts.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOverview;
        private System.Windows.Forms.Panel panelTotalLecturers;
        private System.Windows.Forms.Label lblTotalLecturers;
        private System.Windows.Forms.Panel panelTotalCourses;
        private System.Windows.Forms.Panel panelTotalAssignments;
        private System.Windows.Forms.Panel panelTotalSubmissions;
        private System.Windows.Forms.Panel panelTotalStudents;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label lblTotalCourses;
        private System.Windows.Forms.Label lblTotalAssignments;
        private System.Windows.Forms.Label lblTotalSubmissions;
        private System.Windows.Forms.Panel panelCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.ComboBox cmbCourseFilter;
        private System.Windows.Forms.ComboBox cmbChartType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}