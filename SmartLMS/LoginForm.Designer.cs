namespace SmartLMS
{
    partial class LoginForm
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
            this.LoginPanel = new TransparentPanel();
            this.BtnRegister = new GradientButton();
            this.BtnFogot = new GradientButton();
            this.btnLogin = new GradientButton();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblWlcm = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPanel.Controls.Add(this.BtnRegister);
            this.LoginPanel.Controls.Add(this.BtnFogot);
            this.LoginPanel.Controls.Add(this.btnLogin);
            this.LoginPanel.Controls.Add(this.cmbRole);
            this.LoginPanel.Controls.Add(this.txtPassword);
            this.LoginPanel.Controls.Add(this.LblPassword);
            this.LoginPanel.Controls.Add(this.txtUsername);
            this.LoginPanel.Controls.Add(this.LblUsername);
            this.LoginPanel.Controls.Add(this.LblWlcm);
            this.LoginPanel.Location = new System.Drawing.Point(323, 96);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(350, 400);
            this.LoginPanel.TabIndex = 0;
            // 
            // BtnRegister
            // 
            this.BtnRegister.ColorBottom = System.Drawing.Color.MistyRose;
            this.BtnRegister.ColorTop = System.Drawing.Color.SlateBlue;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRegister.Location = new System.Drawing.Point(66, 346);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(231, 23);
            this.BtnRegister.TabIndex = 8;
            this.BtnRegister.Text = "Don’t have an account? Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnFogot
            // 
            this.BtnFogot.ColorBottom = System.Drawing.Color.MistyRose;
            this.BtnFogot.ColorTop = System.Drawing.Color.SlateBlue;
            this.BtnFogot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFogot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFogot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnFogot.Location = new System.Drawing.Point(107, 308);
            this.BtnFogot.Name = "BtnFogot";
            this.BtnFogot.Size = new System.Drawing.Size(138, 23);
            this.BtnFogot.TabIndex = 7;
            this.BtnFogot.Text = "Forgot Password?";
            this.BtnFogot.UseVisualStyleBackColor = true;
            this.BtnFogot.Click += new System.EventHandler(this.BtnFogot_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ColorBottom = System.Drawing.Color.OrangeRed;
            this.btnLogin.ColorTop = System.Drawing.Color.LightSteelBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(107, 259);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(138, 28);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Lecturer",
            "Student"});
            this.cmbRole.Location = new System.Drawing.Point(107, 203);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(138, 36);
            this.cmbRole.TabIndex = 5;
            this.cmbRole.Text = "Select a Role";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(136, 148);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(187, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(13, 141);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(97, 28);
            this.LblPassword.TabIndex = 3;
            this.LblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(136, 81);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(187, 22);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(13, 76);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(103, 28);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "Username:";
            // 
            // LblWlcm
            // 
            this.LblWlcm.AutoSize = true;
            this.LblWlcm.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWlcm.Location = new System.Drawing.Point(44, 0);
            this.LblWlcm.Name = "LblWlcm";
            this.LblWlcm.Size = new System.Drawing.Size(264, 38);
            this.LblWlcm.TabIndex = 0;
            this.LblWlcm.Text = "Welcome Back! 👋";
            this.LblWlcm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartLMS.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 621);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentPanel LoginPanel;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblWlcm;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label LblPassword;
        private GradientButton btnLogin;
        private GradientButton BtnRegister;
        private GradientButton BtnFogot;
    }
}