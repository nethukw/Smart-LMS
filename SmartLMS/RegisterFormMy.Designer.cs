namespace SmartLMS
{
    partial class RegisterFormMy
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
            this.transparentPanel1 = new TransparentPanel();
            this.linkLogin = new GradientButton();
            this.BtnRegister = new GradientButton();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.textConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.LblWlcm = new System.Windows.Forms.Label();
            this.LblFullName = new System.Windows.Forms.Label();
            this.transparentPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.transparentPanel1.Controls.Add(this.linkLogin);
            this.transparentPanel1.Controls.Add(this.BtnRegister);
            this.transparentPanel1.Controls.Add(this.cmbRole);
            this.transparentPanel1.Controls.Add(this.textConfirm);
            this.transparentPanel1.Controls.Add(this.label1);
            this.transparentPanel1.Controls.Add(this.textPassword);
            this.transparentPanel1.Controls.Add(this.LblPassword);
            this.transparentPanel1.Controls.Add(this.txtUsername);
            this.transparentPanel1.Controls.Add(this.LblUsername);
            this.transparentPanel1.Controls.Add(this.txtFullName);
            this.transparentPanel1.Controls.Add(this.LblFullName);
            this.transparentPanel1.Controls.Add(this.LblWlcm);
            this.transparentPanel1.Location = new System.Drawing.Point(319, 62);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(350, 500);
            this.transparentPanel1.TabIndex = 0;
            // 
            // linkLogin
            // 
            this.linkLogin.ColorBottom = System.Drawing.Color.Thistle;
            this.linkLogin.ColorTop = System.Drawing.Color.LightSteelBlue;
            this.linkLogin.FlatAppearance.BorderSize = 0;
            this.linkLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkLogin.ForeColor = System.Drawing.Color.White;
            this.linkLogin.Location = new System.Drawing.Point(67, 404);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(209, 23);
            this.linkLogin.TabIndex = 11;
            this.linkLogin.Text = "Already have an account? Login";
            this.linkLogin.UseVisualStyleBackColor = true;
            this.linkLogin.Click += new System.EventHandler(this.linkLogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.ColorBottom = System.Drawing.Color.Violet;
            this.BtnRegister.ColorTop = System.Drawing.Color.Pink;
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(99, 365);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(144, 23);
            this.BtnRegister.TabIndex = 10;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Lecturer",
            "Student"});
            this.cmbRole.Location = new System.Drawing.Point(99, 321);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(144, 24);
            this.cmbRole.TabIndex = 9;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // textConfirm
            // 
            this.textConfirm.Location = new System.Drawing.Point(169, 274);
            this.textConfirm.Name = "textConfirm";
            this.textConfirm.Size = new System.Drawing.Size(154, 22);
            this.textConfirm.TabIndex = 8;
            this.textConfirm.UseSystemPasswordChar = true;
            this.textConfirm.TextChanged += new System.EventHandler(this.textConfirm_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Confirm Password:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(118, 221);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(205, 22);
            this.textPassword.TabIndex = 6;
            this.textPassword.UseSystemPasswordChar = true;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(13, 219);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(84, 23);
            this.LblPassword.TabIndex = 5;
            this.LblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(118, 160);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(205, 22);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(13, 160);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(91, 23);
            this.LblUsername.TabIndex = 3;
            this.LblUsername.Text = "Username:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(118, 96);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(205, 22);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // LblWlcm
            // 
            this.LblWlcm.AutoSize = true;
            this.LblWlcm.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWlcm.Location = new System.Drawing.Point(61, 31);
            this.LblWlcm.Name = "LblWlcm";
            this.LblWlcm.Size = new System.Drawing.Size(248, 31);
            this.LblWlcm.TabIndex = 0;
            this.LblWlcm.Text = "Create an Account ✨";
            this.LblWlcm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblFullName
            // 
            this.LblFullName.AutoSize = true;
            this.LblFullName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFullName.Location = new System.Drawing.Point(13, 96);
            this.LblFullName.Name = "LblFullName";
            this.LblFullName.Size = new System.Drawing.Size(91, 23);
            this.LblFullName.TabIndex = 1;
            this.LblFullName.Text = "Full Name:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartLMS.Properties.Resources.Register2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 635);
            this.Controls.Add(this.transparentPanel1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Form";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.transparentPanel1.ResumeLayout(false);
            this.transparentPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Label LblWlcm;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox textConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label LblUsername;
        private GradientButton BtnRegister;
        private System.Windows.Forms.ComboBox cmbRole;
        private GradientButton linkLogin;
        private System.Windows.Forms.Label LblFullName;
    }
}