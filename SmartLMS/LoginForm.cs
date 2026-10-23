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
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            // Center the panel
            LoginPanel.Location = new Point(
                (this.ClientSize.Width - LoginPanel.Width) / 2,
                (this.ClientSize.Height - LoginPanel.Height) / 2
            );

            // Keep centered on resize
            this.Resize += (s, ev) =>
            {
                LoginPanel.Location = new Point(
                    (this.ClientSize.Width - LoginPanel.Width) / 2,
                    (this.ClientSize.Height - LoginPanel.Height) / 2
                );
            };

            // Populate role selection
            cmbRole.Items.Clear();
            cmbRole.Items.AddRange(new string[] { "Admin", "Lecturer", "Student" });
            cmbRole.SelectedIndex = 0;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string username = txtUsername.Text.Trim();
                    string password = txtPassword.Text.Trim();
                    string selectedRole = cmbRole.SelectedItem.ToString();

                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Please enter both username and password.");
                        return;
                    }

                    string query = @"
                SELECT 
                    u.UserId, 
                    u.FirstName, 
                    u.LastName,
                    u.Username, 
                    r.RoleName 
                FROM 
                    Users u
                JOIN 
                    Roles r ON u.RoleId = r.RoleId
                WHERE 
                    u.Username = @Username AND u.PasswordHash = SHA2(@Password, 256);
            ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = reader.GetInt32("UserId");
                                string firstName = reader.GetString("FirstName");
                                string lastName = reader.GetString("LastName");
                                string fullName = firstName + " " + lastName;
                                string actualRole = reader.GetString("RoleName");

                                if (!string.Equals(selectedRole, actualRole, StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show(
                                        $"Role mismatch!\nYou are registered as '{actualRole}', not '{selectedRole}'.\nPlease select the correct role.",
                                        "Incorrect Role",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning
                                    );
                                    return;
                                }

                                // Successful login
                                MessageBox.Show($"Welcome {fullName} ({actualRole})!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();

                                Form dashboard = null;

                                switch (actualRole.ToLower())
                                {
                                    case "admin":
                                        dashboard = new AdminDashboardForm(username);
                                        break;
                                    case "lecturer":
                                        dashboard = new LecturerDashboardForm(username);
                                        break;
                                    case "student":
                                        dashboard = new StudentDashboard(userId, fullName);
                                        break;
                                    default:
                                        MessageBox.Show("Unable to load dashboard for this role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        this.Show();
                                        return;
                                }

                                dashboard.FormClosed += (s, args) => this.Close();
                                dashboard.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnFogot_Click(object sender, EventArgs e)
        {
            // Open PasswordChangeForm
            /*PasswordChangeForm pwdChangeForm = new PasswordChangeForm();
            pwdChangeForm.ShowDialog();  // Show as modal dialog*/
            MessageBox.Show("Password change feature is still under development.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Open RegisterForm
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();  // Show as modal dialog
        }
    }
}