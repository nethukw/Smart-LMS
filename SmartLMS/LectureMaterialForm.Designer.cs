namespace SmartLMS
{
    partial class LectureMaterialForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.MaterialDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UploadedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UploadedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DataGridViewButtonColumn = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(269, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(290, 38);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "📚 Lecture Materials";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(68, 74);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(121, 24);
            this.CourseComboBox.TabIndex = 1;
            this.CourseComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseComboBox_SelectedIndexChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(548, 77);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(199, 22);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // MaterialDataGridView
            // 
            this.MaterialDataGridView.AllowUserToAddRows = false;
            this.MaterialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CourseCode,
            this.MaterialTitle,
            this.FileName,
            this.UploadedBy,
            this.UploadedDate,
            this.Action});
            this.MaterialDataGridView.Location = new System.Drawing.Point(0, 104);
            this.MaterialDataGridView.Name = "MaterialDataGridView";
            this.MaterialDataGridView.ReadOnly = true;
            this.MaterialDataGridView.RowHeadersWidth = 51;
            this.MaterialDataGridView.RowTemplate.Height = 24;
            this.MaterialDataGridView.Size = new System.Drawing.Size(804, 378);
            this.MaterialDataGridView.TabIndex = 3;
            this.MaterialDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MaterialDataGridView_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // CourseCode
            // 
            this.CourseCode.HeaderText = "Course Code";
            this.CourseCode.MinimumWidth = 6;
            this.CourseCode.Name = "CourseCode";
            this.CourseCode.ReadOnly = true;
            this.CourseCode.Width = 125;
            // 
            // MaterialTitle
            // 
            this.MaterialTitle.HeaderText = "Topic Title";
            this.MaterialTitle.MinimumWidth = 6;
            this.MaterialTitle.Name = "MaterialTitle";
            this.MaterialTitle.ReadOnly = true;
            this.MaterialTitle.Width = 125;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File Name";
            this.FileName.MinimumWidth = 6;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 125;
            // 
            // UploadedBy
            // 
            this.UploadedBy.HeaderText = "Uploaded By";
            this.UploadedBy.MinimumWidth = 6;
            this.UploadedBy.Name = "UploadedBy";
            this.UploadedBy.ReadOnly = true;
            this.UploadedBy.Width = 125;
            // 
            // UploadedDate
            // 
            this.UploadedDate.HeaderText = "Uploaded Date";
            this.UploadedDate.MinimumWidth = 6;
            this.UploadedDate.Name = "UploadedDate";
            this.UploadedDate.ReadOnly = true;
            this.UploadedDate.Width = 125;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Download";
            this.Action.Width = 125;
            // 
            // DataGridViewButtonColumn
            // 
            this.DataGridViewButtonColumn.Location = new System.Drawing.Point(693, 237);
            this.DataGridViewButtonColumn.Name = "DataGridViewButtonColumn";
            this.DataGridViewButtonColumn.Size = new System.Drawing.Size(75, 23);
            this.DataGridViewButtonColumn.TabIndex = 4;
            this.DataGridViewButtonColumn.Text = "Download";
            this.DataGridViewButtonColumn.UseVisualStyleBackColor = true;
            this.DataGridViewButtonColumn.Click += new System.EventHandler(this.DataGridViewButtonColumn_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.OrangeRed;
            this.BackButton.Location = new System.Drawing.Point(617, 15);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(174, 23);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "← Back to Dashboard";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Course";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 60);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 60);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "📚 Lecture Materials";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 60);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "📚 Lecture Materials";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Controls.Add(this.BackButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 482);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(803, 60);
            this.panel4.TabIndex = 9;
            // 
            // LectureMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 542);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewButtonColumn);
            this.Controls.Add(this.MaterialDataGridView);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.CourseComboBox);
            this.Name = "LectureMaterialForm";
            this.Text = "LectureMaterialForm";
            this.Load += new System.EventHandler(this.LectureMaterialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView MaterialDataGridView;
        private System.Windows.Forms.Button DataGridViewButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadedDate;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
    }
}