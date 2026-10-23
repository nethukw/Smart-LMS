namespace SmartLMS
{
    partial class ProfileForm
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
            this.btnChangePic = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.Label();
            this.textphone = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.Label();
            this.textgender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textaddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangePic
            // 
            this.btnChangePic.BackColor = System.Drawing.Color.LightCoral;
            this.btnChangePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePic.Location = new System.Drawing.Point(180, 79);
            this.btnChangePic.Name = "btnChangePic";
            this.btnChangePic.Size = new System.Drawing.Size(181, 39);
            this.btnChangePic.TabIndex = 1;
            this.btnChangePic.Text = "Change Picture";
            this.btnChangePic.UseVisualStyleBackColor = false;
            this.btnChangePic.Click += new System.EventHandler(this.btnChangePic_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(20, 243);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(20, 471);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 20);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Role";
            this.lblRole.Click += new System.EventHandler(this.lblRole_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(421, 326);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(104, 20);
            this.lblNewPassword.TabIndex = 4;
            this.lblNewPassword.Text = "New Password";
            this.lblNewPassword.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(20, 299);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(76, 20);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(158, 243);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(174, 22);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(158, 299);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(174, 22);
            this.txtFullName.TabIndex = 7;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(570, 324);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.ReadOnly = true;
            this.txtNewPassword.Size = new System.Drawing.Size(161, 22);
            this.txtNewPassword.TabIndex = 8;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(158, 471);
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(174, 22);
            this.txtRole.TabIndex = 9;
            this.txtRole.TextChanged += new System.EventHandler(this.txtRole_TextChanged);
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.Color.Khaki;
            this.picProfile.Location = new System.Drawing.Point(24, 79);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(125, 116);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 0;
            this.picProfile.TabStop = false;
            this.picProfile.Click += new System.EventHandler(this.picProfile_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(485, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(604, 636);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 39);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(20, 412);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(40, 20);
            this.lblDOB.TabIndex = 12;
            this.lblDOB.Text = "DOB";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(158, 410);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(174, 22);
            this.txtDOB.TabIndex = 13;
            this.txtDOB.TextChanged += new System.EventHandler(this.txtDOB_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(20, 529);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(50, 20);
            this.txtPhone.TabIndex = 14;
            this.txtPhone.Text = "Phone";
            // 
            // textphone
            // 
            this.textphone.Location = new System.Drawing.Point(158, 527);
            this.textphone.Name = "textphone";
            this.textphone.ReadOnly = true;
            this.textphone.Size = new System.Drawing.Size(174, 22);
            this.textphone.TabIndex = 15;
            this.textphone.TextChanged += new System.EventHandler(this.textphone_TextChanged);
            // 
            // txtGender
            // 
            this.txtGender.AutoSize = true;
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(20, 583);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(57, 20);
            this.txtGender.TabIndex = 16;
            this.txtGender.Text = "Gender";
            // 
            // textgender
            // 
            this.textgender.Location = new System.Drawing.Point(158, 581);
            this.textgender.Name = "textgender";
            this.textgender.ReadOnly = true;
            this.textgender.Size = new System.Drawing.Size(174, 22);
            this.textgender.TabIndex = 17;
            this.textgender.TextChanged += new System.EventHandler(this.textgender_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 642);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Address";
            // 
            // textaddress
            // 
            this.textaddress.Location = new System.Drawing.Point(158, 623);
            this.textaddress.Multiline = true;
            this.textaddress.Name = "textaddress";
            this.textaddress.ReadOnly = true;
            this.textaddress.Size = new System.Drawing.Size(174, 52);
            this.textaddress.TabIndex = 19;
            this.textaddress.TextChanged += new System.EventHandler(this.textaddress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(570, 371);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.ReadOnly = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(161, 22);
            this.txtConfirmPassword.TabIndex = 21;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(20, 357);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Password";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(158, 355);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.ReadOnly = true;
            this.txtCurrentPassword.Size = new System.Drawing.Size(174, 22);
            this.txtCurrentPassword.TabIndex = 23;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.txtCurrentPassword_TextChanged);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Green;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Location = new System.Drawing.Point(180, 156);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(181, 39);
            this.btnUpload.TabIndex = 24;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 61);
            this.panel1.TabIndex = 25;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textaddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textgender);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.textphone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnChangePic);
            this.Controls.Add(this.picProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Profile";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Button btnChangePic;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.TextBox textphone;
        private System.Windows.Forms.Label txtGender;
        private System.Windows.Forms.TextBox textgender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textaddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Panel panel1;
    }
}