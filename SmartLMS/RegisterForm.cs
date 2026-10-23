using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLMS
{
    public partial class RegisterForm : BaseForm
    {
        private string connectionString = "server=localhost;user=root;password=;database=SmartLMS;";



        public RegisterForm()
        {
            InitializeComponent();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadRoles();
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void LoadRoles()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT RoleId, RoleName FROM Roles", con);
                var reader = cmd.ExecuteReader();
                var roles = new System.Data.DataTable();
                roles.Load(reader);

                cmbRole.DisplayMember = "RoleName";
                cmbRole.ValueMember = "RoleId";
                cmbRole.DataSource = roles;
                cmbRole.SelectedIndex = -1;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            DateTime dob = dobPicker.Value.Date;
            string gender = rbMale.Checked ? "Male" : rbFemale.Checked ? "Female" : "";
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Username, Password, and Role are required.");
                return;
            }

            int roleId = Convert.ToInt32(cmbRole.SelectedValue);
            string passwordHash = HashPassword(password);
            byte[] imageBytes = profilePictureBox.Image != null ? ImageToByteArray(profilePictureBox.Image) : null;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if username exists
                    MySqlCommand checkUser = new MySqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username", conn);
                    checkUser.Parameters.AddWithValue("@Username", username);
                    int count = Convert.ToInt32(checkUser.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists.");
                        return;
                    }

                    // Insert user
                    string query = @"INSERT INTO Users 
                        (FirstName, LastName, Phone, Username, PasswordHash, DOB, Gender, Address, ProfileImage, RoleId) 
                        VALUES 
                        (@FirstName, @LastName, @Phone, @Username, @PasswordHash, @DOB, @Gender, @Address, @ProfileImage, @RoleId)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                        cmd.Parameters.AddWithValue("@DOB", dob);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@ProfileImage", imageBytes ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@RoleId", roleId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User registered successfully!");

                        // Redirect to login form
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed: " + ex.Message);
            }


        }

        private byte[] ImageToByteArray(Image image)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Profile Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    profilePictureBox.Image = new Bitmap(ofd.FileName);
                }
            }
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblDOB_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
