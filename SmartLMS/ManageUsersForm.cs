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
    public partial class ManageUsersForm : BaseForm
    {
        private static string connectionString = "server=localhost;user=root;database=SmartLMS;password=;";
        private int selectedUserId = -1;
        private byte[] selectedImageBytes;

        public ManageUsersForm()
        {
            InitializeComponent();
        }



        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadRoles();
        }

        private void LoadUsers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT u.UserId, u.FirstName, u.LastName, u.Username, u.Phone, u.DOB, u.Gender, u.Address, r.RoleName
                                 FROM Users u
                                 JOIN Roles r ON u.RoleId = r.RoleId";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvUsers.DataSource = dt;
            }
        }

        private void LoadRoles()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT RoleName FROM Roles", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                cmbRole.Items.Clear();
                while (reader.Read())
                {
                    cmbRole.Items.Add(reader.GetString(0));
                }
                conn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string searchText = txtSearch.Text.Trim();
                string query = @"SELECT u.UserId, u.FirstName, u.LastName, u.Username, u.Phone, u.DOB, u.Gender, u.Address, r.RoleName
                                 FROM Users u
                                 JOIN Roles r ON u.RoleId = r.RoleId
                                 WHERE u.FirstName LIKE @search OR u.LastName LIKE @search OR u.Username LIKE @search";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchText + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvUsers.DataSource = dt;
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedUserId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["UserId"].Value);
                txtFirstName.Text = dgvUsers.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                txtLastName.Text = dgvUsers.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                txtUsername.Text = dgvUsers.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                txtPhone.Text = dgvUsers.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                cmbGender.Text = dgvUsers.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                txtAddress.Text = dgvUsers.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                cmbRole.Text = dgvUsers.Rows[e.RowIndex].Cells["RoleName"].Value.ToString();
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImageBytes = File.ReadAllBytes(ofd.FileName);
                    pbProfile.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateUserInput()
        {
            // First Name validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            // Last Name validation
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            // Username validation
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter Username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            // Password validation (only if adding a user)
            // For update, password may be optional
            if (string.IsNullOrWhiteSpace(txtPassword.Text) && selectedUserId == -1)
            {
                MessageBox.Show("Please enter Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            // Phone number validation (basic)
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter Phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }
            else
            {
                // Optional: check if phone is numeric
                if (!long.TryParse(txtPhone.Text, out _))
                {
                    MessageBox.Show("Phone number must contain only digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    return false;
                }
            }

            // Gender validation
            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.Focus();
                return false;
            }

            // Role validation
            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return false;
            }

            // DOB validation (example: user must be at least 12 years old)
            if (dtpDOB.Value > DateTime.Now.AddYears(-12))
            {
                MessageBox.Show("User must be at least 12 years old.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDOB.Focus();
                return false;
            }

            return true; // All validations passed
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateUserInput())
            {
                return; // Stop if validation fails
            }

            string passwordHash = ComputeSha256Hash(txtPassword.Text);
            

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string insertQuery = @"INSERT INTO Users 
                    (FirstName, LastName, Phone, Username, PasswordHash, DOB, Gender, Address, RoleId, ProfileImage)
                    VALUES (@FirstName, @LastName, @Phone, @Username, @PasswordHash, @DOB, @Gender, @Address, 
                            (SELECT RoleId FROM Roles WHERE RoleName = @RoleName), @ProfileImage)";
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@RoleName", cmbRole.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@ProfileImage", selectedImageBytes ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("User added successfully.");
                LoadUsers();
                ClearFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cmbGender.SelectedIndex = -1;
            cmbRole.SelectedIndex = -1;
            pbProfile.Image = null;
            selectedImageBytes = null;
            selectedUserId = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Select a user to update.");
                return;
            }

            if (!ValidateUserInput())
            {
                return; // Stop if validation fails
            }

            

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string updateQuery = @"UPDATE Users SET 
                    FirstName = @FirstName,
                    LastName = @LastName,
                    Phone = @Phone,
                    DOB = @DOB,
                    Gender = @Gender,
                    Address = @Address,
                    RoleId = (SELECT RoleId FROM Roles WHERE RoleName = @RoleName),
                    ProfileImage = @ProfileImage
                    WHERE UserId = @UserId";

                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@RoleName", cmbRole.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@ProfileImage", selectedImageBytes ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@UserId", selectedUserId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("User updated successfully.");
                LoadUsers();
                ClearFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Select a user to delete.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string deleteQuery = "DELETE FROM Users WHERE UserId = @UserId";
                MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@UserId", selectedUserId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("User deleted.");
                LoadUsers();
                ClearFields();
            }
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder sb = new StringBuilder();
                foreach (var b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}
