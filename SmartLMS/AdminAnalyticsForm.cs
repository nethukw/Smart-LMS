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
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartLMS
{
    public partial class AdminAnalyticsForm : BaseForm
    {
        public static class Database
        {
            private static string connectionString = "server=localhost;user=root;password=;database=SmartLMS";

            public static MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }


        public AdminAnalyticsForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;

        }

        private void LoadCourses()
        {
            cmbCourseFilter.Items.Clear();
            cmbCourseFilter.Items.Add("All");

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT Title FROM Courses";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbCourseFilter.Items.Add(reader.GetString("Title"));
                    }
                }
            }

            cmbCourseFilter.SelectedIndex = 0; // Default to "All"
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelOverview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCharts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            bool isDark = chkDarkMode.Checked;
            this.BackColor = isDark ? Color.FromArgb(30, 30, 30) : Color.White;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label || ctrl is CheckBox || ctrl is ComboBox || ctrl is DateTimePicker)
                {
                    ctrl.ForeColor = isDark ? Color.White : Color.Black;
                    ctrl.BackColor = isDark ? Color.FromArgb(45, 45, 45) : Color.White;
                }
                else if (ctrl is Panel)
                {
                    ctrl.BackColor = isDark ? Color.FromArgb(45, 45, 45) : Color.WhiteSmoke;
                }
            }
        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {
            ProgressBar pb = sender as ProgressBar;
            if (pb != null)
            {
                MessageBox.Show($"Current progress: {pb.Value}%", "Progress Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblLastUpdated_Click(object sender, EventArgs e)
        {

        }

        private void panelFilters_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCourseFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = cmbCourseFilter.SelectedItem.ToString();

            if (selectedCourse == "All")
            {
                // Show all assignments count or reset label
                ShowAllAssignmentsCount();
            }
            else
            {
                ShowAssignmentCountForCourse(selectedCourse);
            }
        }

        private void ShowAssignmentCountForCourse(string courseTitle)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT COUNT(*) 
            FROM Assignments 
            WHERE CourseId = (
                SELECT CourseId FROM Courses WHERE Title = @Title
            )";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", courseTitle);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    lblTotalAssignments.Text = "Total Assignments = " + count;
                }
            }
        }

        private void ShowAllAssignmentsCount()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Assignments";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    lblTotalAssignments.Text = "Total Assignments = " + count;
                }
            }
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            ApplyDateFilter();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            ApplyDateFilter();
        }

        private void ApplyDateFilter()
        {
            DateTime fromDate = dtFrom.Value.Date;
            DateTime toDate = dtTo.Value.Date;

            if (fromDate > toDate)
            {
                MessageBox.Show("Start date cannot be after end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call your data loading method with filtered dates
            LoadSubmissionsByDate(fromDate, toDate);
        }

        private void LoadSubmissionsByDate(DateTime fromDate, DateTime toDate)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Submissions WHERE SubmittedAt BETWEEN @From AND @To";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@From", fromDate);
                    cmd.Parameters.AddWithValue("@To", toDate.AddDays(1).AddTicks(-1)); // include full day

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    lblTotalSubmissions.Text = "Total Submissions = " + count;
                }
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFilteredAnalytics();
        }

        private void LoadFilteredAnalytics()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Filtered Analytics");

            Series series = new Series("Actions");
            series.ChartType = SeriesChartType.Pie;

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"SELECT Action, COUNT(*) AS Count 
                         FROM Analytics 
                         WHERE Timestamp BETWEEN @from AND @to 
                         GROUP BY Action";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@from", dtFrom.Value.Date);
                    cmd.Parameters.AddWithValue("@to", dtTo.Value.Date.AddDays(1).AddTicks(-1));

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string action = reader.GetString("Action");
                            int count = reader.GetInt32("Count");
                            series.Points.AddXY(action, count);
                        }
                    }
                }
            }

            chart1.Series.Add(series);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine("Action,Count");

                    using (var conn = Database.GetConnection())
                    {
                        conn.Open();
                        string query = @"SELECT Action, COUNT(*) AS Count FROM Analytics GROUP BY Action";

                        using (var cmd = new MySqlCommand(query, conn))
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sw.WriteLine($"{reader.GetString("Action")},{reader.GetInt32("Count")}");
                            }
                        }
                    }
                }

                MessageBox.Show("Export completed.");
            }
        }

        private void AdminAnalyticsForm_Load(object sender, EventArgs e)
        {
            LoadAnalyticsChart();
            LoadCourses();
            LoadDashboardCounts();
            LoadCourseFilter();
        }

        private void LoadCourseFilter()
        {
            string connectionString = "server=localhost;user=root;password=;database=smartlms;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT Title FROM Courses";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbCourseFilter.Items.Add(reader["Title"].ToString());
                    }
                }
            }
        }


        private void LoadDashboardCounts()
        {
            string connectionString = "server=localhost;user=root;password=;database=smartlms;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                int studentCount = GetCount(conn, "SELECT COUNT(*) FROM Users u JOIN Roles r ON u.RoleId = r.RoleId WHERE r.RoleName = 'Student'");
                int lecturerCount = GetCount(conn, "SELECT COUNT(*) FROM Users u JOIN Roles r ON u.RoleId = r.RoleId WHERE r.RoleName = 'Lecturer'");
                int courseCount = GetCount(conn, "SELECT COUNT(*) FROM Courses");
                int assignmentCount = GetCount(conn, "SELECT COUNT(*) FROM Assignments");
                int submissionCount = GetCount(conn, "SELECT COUNT(*) FROM Submissions");

                lblTotalStudents.Text = "Total Students = " + studentCount;
                lblTotalLecturers.Text = "Total Lecturers = " + lecturerCount;
                lblTotalCourses.Text = "Total Courses = " + courseCount;
                lblTotalAssignments.Text = "Total Assignments = " + assignmentCount;
                lblTotalSubmissions.Text = "Total Submissions = " + submissionCount;
            }
        }



        private int GetCount(MySqlConnection conn, string query)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }



        private void LoadAnalyticsChart()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Admin Activity Overview");

            Series series = new Series("Actions");
            series.ChartType = SeriesChartType.Column;

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"SELECT Action, COUNT(*) AS Count FROM Analytics GROUP BY Action ORDER BY Count DESC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string action = reader.GetString("Action");
                        int count = reader.GetInt32("Count");
                        series.Points.AddXY(action, count);
                    }
                }
            }

            chart1.Series.Add(series);
        }

        private void cmbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chart1.Series.Count == 0) return;

            string selectedType = cmbChartType.SelectedItem.ToString();
            SeriesChartType chartType;

            if (Enum.TryParse(selectedType, out chartType))
            {
                chart1.Series[0].ChartType = chartType;
            }
        }

        private void lblTotalStudents_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalLecturers_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalCourses_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalAssignments_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalSubmissions_Click(object sender, EventArgs e)
        {

        }
    }
}
