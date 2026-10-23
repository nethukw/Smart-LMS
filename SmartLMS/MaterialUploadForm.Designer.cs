namespace SmartLMS
{
    partial class MaterialUploadForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.lblUploadedBy = new System.Windows.Forms.Label();
            this.txtUploadedBy = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(138, 81);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(274, 74);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(141, 123);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(274, 123);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(153, 61);
            this.rtbDescription.TabIndex = 3;
            this.rtbDescription.Text = "";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(141, 204);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(50, 16);
            this.lblCourse.TabIndex = 4;
            this.lblCourse.Text = "Course";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(269, 205);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCourse.TabIndex = 5;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(141, 256);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(29, 16);
            this.lblFile.TabIndex = 6;
            this.lblFile.Text = "File";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(269, 256);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(100, 22);
            this.txtFilePath.TabIndex = 7;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(510, 74);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFile.TabIndex = 8;
            this.btnBrowseFile.Text = "Browse";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // lblUploadedBy
            // 
            this.lblUploadedBy.AutoSize = true;
            this.lblUploadedBy.Location = new System.Drawing.Point(510, 123);
            this.lblUploadedBy.Name = "lblUploadedBy";
            this.lblUploadedBy.Size = new System.Drawing.Size(87, 16);
            this.lblUploadedBy.TabIndex = 9;
            this.lblUploadedBy.Text = "Uploaded By";
            // 
            // txtUploadedBy
            // 
            this.txtUploadedBy.Location = new System.Drawing.Point(648, 123);
            this.txtUploadedBy.Name = "txtUploadedBy";
            this.txtUploadedBy.Size = new System.Drawing.Size(100, 22);
            this.txtUploadedBy.TabIndex = 10;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(793, 60);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(793, 90);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterials.Location = new System.Drawing.Point(509, 256);
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.RowHeadersWidth = 51;
            this.dgvMaterials.RowTemplate.Height = 24;
            this.dgvMaterials.Size = new System.Drawing.Size(240, 150);
            this.dgvMaterials.TabIndex = 13;
            // 
            // MaterialUploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 669);
            this.Controls.Add(this.dgvMaterials);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtUploadedBy);
            this.Controls.Add(this.lblUploadedBy);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "MaterialUploadForm";
            this.Text = "MaterialUploadForm";
            this.Load += new System.EventHandler(this.MaterialUploadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Label lblUploadedBy;
        private System.Windows.Forms.TextBox txtUploadedBy;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvMaterials;
    }
}