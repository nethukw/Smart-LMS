using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SmartLMS
{
    public partial class RegisterFormMy : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";
        public RegisterFormMy()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Populate role dropdown (make sure cmbRole exists)
            cmbRole.Items.Clear();
            cmbRole.Items.AddRange(new string[] { "Admin", "Lecturer", "Student" });
            cmbRole.SelectedIndex = 2; // Default to Student
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();  // assume username is email
            string password = textPassword.Text;
            string confirmPassword = textConfirm.Text;
            string role = cmbRole.SelectedItem?.ToString();

            // Basic validation
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if user already exists (by email)
                    string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email;";
                    using (MySqlCommand cmdCheck = new MySqlCommand(checkUserQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@Email", username);
                        int userCount = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("This email is already registered.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Get RoleId from Roles table
                    string roleIdQuery = "SELECT RoleId FROM Roles WHERE RoleName = @RoleName;";
                    int roleId = -1;
                    using (MySqlCommand cmdRole = new MySqlCommand(roleIdQuery, conn))
                    {
                        cmdRole.Parameters.AddWithValue("@RoleName", role);
                        object result = cmdRole.ExecuteScalar();
                        if (result != null)
                        {
                            roleId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Selected role is invalid.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user with hashed password (SHA2 256)
                    string insertQuery = @"
                        INSERT INTO Users (FullName, Email, PasswordHash, RoleId) 
                        VALUES (@FullName, @Email, SHA2(@Password, 256), @RoleId);
                    ";

                    using (MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@FullName", fullName);
                        cmdInsert.Parameters.AddWithValue("@Email", username);
                        cmdInsert.Parameters.AddWithValue("@Password", password);
                        cmdInsert.Parameters.AddWithValue("@RoleId", roleId);

                        int rowsAffected = cmdInsert.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful! You can now login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close registration form
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
