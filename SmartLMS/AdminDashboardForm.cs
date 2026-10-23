using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace SmartLMS
{
    public partial class AdminDashboardForm : BaseForm
    {
        private string connectionString = "server=localhost;user id=root;password= ;database=smartlms;";
        private string loggedInAdminUsername;
        private int loggedInUserId;

        public AdminDashboardForm(string username)
        {
            InitializeComponent();
            loggedInAdminUsername = username;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadAdminName();
            LoadTotalStats();
            LoadRecentActivities();
        }

        private void LoadRecentActivities()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    a.LogId,CONCAT(u.FirstName, ' ', u.LastName) AS FullName, a.Action, a.Timestamp
                FROM Analytics a
                JOIN Users u ON a.UserId = u.UserId
                ORDER BY a.Timestamp DESC
                LIMIT 20";  

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewRecentActivities.DataSource = dt;

                    // set column headers
                    dataGridViewRecentActivities.Columns["LogId"].Visible = false;
                    dataGridViewRecentActivities.Columns["FullName"].HeaderText = "User";
                    dataGridViewRecentActivities.Columns["Action"].HeaderText = "Activity";
                    dataGridViewRecentActivities.Columns["Timestamp"].HeaderText = "Date/Time";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading recent activities: " + ex.Message);
                }
            }
        }


        private void LoadAdminName()
        {
           
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = @"SELECT CONCAT(u.FirstName, ' ', u.LastName) AS FullName 
                         FROM Users u
                         JOIN Roles r ON u.RoleId = r.RoleId
                         WHERE u.Username = @username AND r.RoleName = 'Admin'";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", loggedInAdminUsername);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            BtnName.Text = result.ToString(); 
                        }
                        else
                        {
                            BtnName.Text = "Unknown Admin";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                // Get UserId of the logged-in admin
                string userIdQuery = "SELECT UserId FROM Users WHERE Username = @username";
                using (MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn))
                {
                    userIdCmd.Parameters.AddWithValue("@username", loggedInAdminUsername);
                    object userIdResult = userIdCmd.ExecuteScalar();
                    if (userIdResult != null)
                    {
                        loggedInUserId = Convert.ToInt32(userIdResult);
                    }
                }

            }
        }

        private void LoadTotalStats()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand userCmd = new MySqlCommand("SELECT COUNT(*) FROM users", conn);
                    int totalUsers = Convert.ToInt32(userCmd.ExecuteScalar());
                    groupBoxTotalUsers.Text = "Total Users: " + totalUsers;

                    MySqlCommand courseCmd = new MySqlCommand("SELECT COUNT(*) FROM courses", conn);
                    int totalCourses = Convert.ToInt32(courseCmd.ExecuteScalar());
                    groupBoxTotalCourses.Text = "Total Courses: " + totalCourses;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void BtnName_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxTotalUsers_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxTotalCourses_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxTotalAssignments_Enter(object sender, EventArgs e)
        {

        }

        private void BtnViewAllUsers_Click(object sender, EventArgs e)
        {
            //ManageUsersForm manageUsersForm = new ManageUsersForm();
            //manageUsersForm.Show();
        }

        private void BtnAddNewUser_Click(object sender, EventArgs e)
        {
            //AddUserForm addUserForm = new AddUserForm();
            //addUserForm.Show();
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            //ReportsForm reportsForm = new ReportsForm();
            //reportsForm.Show();
        }

        private void gradientButtonManageRoles_Click(object sender, EventArgs e)
        {
            //ManageRolesForm manageRolesForm = new ManageRolesForm();
            //manageRolesForm.Show();
        }

        private void dataGridViewRecentActivities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewRecentActivities.Rows[e.RowIndex];
                    string user = row.Cells["FullName"].Value.ToString();
                    string action = row.Cells["Action"].Value.ToString();
                    string timestamp = row.Cells["Timestamp"].Value.ToString();

                    MessageBox.Show($"User: {user}\nAction: {action}\nTime: {timestamp}", "Activity Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        

        private void BtnUser_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm(loggedInUserId);

            pf.Show();
        }

        private void BtnNotification_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notifications feature coming soon!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            LoadTotalStats();
            LoadAdminName();
        }

        private void BtnManageUsers_Click(object sender, EventArgs e)
        {
           ManageUsersForm manageUsersForm = new ManageUsersForm();
            manageUsersForm.Show();
        }

        private void BtnManageCourses_Click(object sender, EventArgs e)
        {
           ManageCoursesForm manageCoursesForm = new ManageCoursesForm();
            manageCoursesForm.Show();
        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            AdminAnalyticsForm adminAnalyticsForm = new AdminAnalyticsForm();
            adminAnalyticsForm.Show();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            //ReportsForm reportsForm = new ReportsForm();
            //reportsForm.Show();
            MessageBox.Show("This feature is to be implemented.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsersForm manageUsersForm = new ManageUsersForm();
            manageUsersForm.Show();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCoursesForm manageCoursesForm = new ManageCoursesForm();
            manageCoursesForm.Show();
        }

        private void analyticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAnalyticsForm adminAnalyticsForm = new AdminAnalyticsForm();
            adminAnalyticsForm.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }
    }
}
