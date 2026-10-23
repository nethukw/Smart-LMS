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

namespace SmartLMS
{
    public partial class ProfileForm : BaseForm

    {
        private int currentUserId;
        private string userRole;


        private string connectionString = "server=localhost;user id=root;password=;database=SmartLMS;";
        private string currentUsername = "student123";
        private string fullName;
        private int userId;
        private string lecturerEmail;
        private string username;

        public ProfileForm(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadProfileDetails();
        }

        private void LoadProfileDetails()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT 
                        u.FirstName, 
                        u.LastName, 
                        u.Username, 
                        u.PasswordHash,
                        u.Phone, 
                        u.Gender, 
                        u.Address, 
                        u.DOB, 
                        u.ProfileImage, 
                        r.RoleName 
                    FROM Users u
                    JOIN Roles r ON u.RoleId = r.RoleId
                    WHERE u.UserId = @userId;
                ";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtFullName.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                            txtUsername.Text = reader["Username"].ToString();
                            textphone.Text = reader["Phone"].ToString();
                            textgender.Text = reader["Gender"].ToString();
                            textaddress.Text = reader["Address"].ToString();
                            txtDOB.Text = Convert.ToDateTime(reader["DOB"]).ToString("yyyy-MM-dd");
                            txtRole.Text = reader["RoleName"].ToString();

                            // Show password placeholder (don't show actual password)
                            if (!string.IsNullOrEmpty(reader["PasswordHash"].ToString()))
                            {
                                txtCurrentPassword.Text = "********";  // just a placeholder
                            }
                            else
                            {
                                txtCurrentPassword.Text = "";
                            }

                            object imgObj = reader["ProfileImage"];
                            if (imgObj != DBNull.Value && imgObj is byte[] imageBytes && imageBytes.Length > 0)
                            {
                                try
                                {
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        picProfile.Image = Image.FromStream(ms);
                                        picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error loading image: " + ex.Message);
                                    picProfile.Image = null;
                                }
                            }
                            else
                            {
                                picProfile.Image = null;  // or a default image
                            }

                            userRole = reader["RoleName"].ToString();
                            txtRole.Text = userRole;


                        }

                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading profile: " + ex.Message);
                }
            }
        }


        private void picProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image selectedImage = Image.FromFile(ofd.FileName);
                picProfile.Image = selectedImage;
                picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadProfileDetails();

        }

        /*private void LoadUserData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    u.FullName, 
                    u.Email, 
                    r.RoleName 
                FROM 
                    Users u
                JOIN 
                    Roles r ON u.RoleId = r.RoleId
                WHERE 
                    u.UserId = @userId;
            ";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", this.currentUserId);  // <-- Use currentUserId

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblFullName.Text = reader["FullName"].ToString();
                        lblEmail.Text = reader["Email"].ToString();
                        lblRole.Text = reader["RoleName"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }*/



        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nameParts = txtFullName.Text.Trim().Split(' ');
            string firstName = nameParts.Length > 0 ? nameParts[0] : "";
            string lastName = nameParts.Length > 1 ? string.Join(" ", nameParts.Skip(1)) : "";

            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (!string.IsNullOrEmpty(newPassword) || !string.IsNullOrEmpty(confirmPassword))
            {
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match!");
                    return;
                }
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                int roleId = GetRoleIdByName(txtRole.Text.Trim(), conn);
                if (roleId == -1)
                {
                    MessageBox.Show("Invalid role.");
                    return;
                }

                string query;
                MySqlCommand cmd;

                if (!string.IsNullOrEmpty(newPassword))
                {
                    string hashedPassword = HashPassword(newPassword);  // hash method below

                    query = @"
                UPDATE Users 
                SET FirstName = @firstName, 
                    LastName = @lastName,
                    Username = @username,
                    Phone = @phone,
                    Gender = @gender,
                    Address = @address,
                    DOB = @dob,
                    RoleId = @roleId,
                    ProfileImage = @pic,
                    PasswordHash = @passwordHash
                WHERE UserId = @userId;
            ";

                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@passwordHash", hashedPassword);
                }
                else
                {
                    query = @"
                UPDATE Users 
                SET FirstName = @firstName, 
                    LastName = @lastName,
                    Username = @username,
                    Phone = @phone,
                    Gender = @gender,
                    Address = @address,
                    DOB = @dob,
                    RoleId = @roleId,
                    ProfileImage = @pic
                WHERE UserId = @userId;
            ";
                    cmd = new MySqlCommand(query, conn);
                }

                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@phone", textphone.Text);
                cmd.Parameters.AddWithValue("@gender", textgender.Text);
                cmd.Parameters.AddWithValue("@address", textaddress.Text);
                cmd.Parameters.AddWithValue("@dob", txtDOB.Text);
                cmd.Parameters.AddWithValue("@roleId", roleId);
                byte[] imageBytes = picProfile.Image != null ? ImageToByteArray(picProfile.Image) : null;
                cmd.Parameters.AddWithValue("@pic", imageBytes ?? (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@userId", currentUserId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Profile updated successfully!");

                // Clear password fields
                txtNewPassword.Text = "";
                txtConfirmPassword.Text = "";
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        private int GetRoleIdByName(string roleName, MySqlConnection conn)
        {
            string query = "SELECT RoleId FROM Roles WHERE RoleName = @roleName";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@roleName", roleName);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            /*if (userRole == "Student")
            {
                new StudentDashboard(currentUserId, fullName).Show();
            }
            else if (userRole == "Lecturer")
            {
                new LecturerDashboardForm(lecturerEmail).Show();
            }
            else if (userRole == "Admin")
            {
                new AdminDashboardForm(username).Show();
            }
            else
            {
                MessageBox.Show("Unknown role. Cannot redirect.");
                this.Show(); // Re-show this form in case of error
            }*/
        }

        private void txtDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textgender_TextChanged(object sender, EventArgs e)
        {

        }

        private void textaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Profile Picture";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picProfile.Image = new Bitmap(ofd.FileName);
                }
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
