namespace SmartLMS
{
    partial class CourseDetailPageForm
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
            this.gradientPanelCourse = new GradientPanel();
            this.gradientPanelOutput = new GradientPanel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOverview = new System.Windows.Forms.TabPage();
            this.tabPageResources = new System.Windows.Forms.TabPage();
            this.tabPageAnnouncements = new System.Windows.Forms.TabPage();
            this.tabPageAssignments = new System.Windows.Forms.TabPage();
            this.tabPageDiscussions = new System.Windows.Forms.TabPage();
            this.gradientPanelCourse.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanelCourse
            // 
            this.gradientPanelCourse.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gradientPanelCourse.ColorTop = System.Drawing.Color.LightBlue;
            this.gradientPanelCourse.Controls.Add(this.gradientPanelOutput);
            this.gradientPanelCourse.Controls.Add(this.BtnSearch);
            this.gradientPanelCourse.Controls.Add(this.txtSearch);
            this.gradientPanelCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanelCourse.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelCourse.Name = "gradientPanelCourse";
            this.gradientPanelCourse.Size = new System.Drawing.Size(985, 100);
            this.gradientPanelCourse.TabIndex = 0;
            this.gradientPanelCourse.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanelCourse_Paint);
            // 
            // gradientPanelOutput
            // 
            this.gradientPanelOutput.ColorBottom = System.Drawing.Color.MediumOrchid;
            this.gradientPanelOutput.ColorTop = System.Drawing.Color.PaleTurquoise;
            this.gradientPanelOutput.Location = new System.Drawing.Point(364, 49);
            this.gradientPanelOutput.Name = "gradientPanelOutput";
            this.gradientPanelOutput.Size = new System.Drawing.Size(222, 33);
            this.gradientPanelOutput.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(546, 15);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(40, 27);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "🔍";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSearch.Location = new System.Drawing.Point(364, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search Course...";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOverview);
            this.tabControl1.Controls.Add(this.tabPageResources);
            this.tabControl1.Controls.Add(this.tabPageAnnouncements);
            this.tabControl1.Controls.Add(this.tabPageAssignments);
            this.tabControl1.Controls.Add(this.tabPageDiscussions);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(985, 521);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.Location = new System.Drawing.Point(4, 32);
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverview.Size = new System.Drawing.Size(977, 485);
            this.tabPageOverview.TabIndex = 0;
            this.tabPageOverview.Text = "📄 Overview";
            this.tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // tabPageResources
            // 
            this.tabPageResources.Location = new System.Drawing.Point(4, 32);
            this.tabPageResources.Name = "tabPageResources";
            this.tabPageResources.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResources.Size = new System.Drawing.Size(977, 485);
            this.tabPageResources.TabIndex = 1;
            this.tabPageResources.Text = "📁 Resources";
            this.tabPageResources.UseVisualStyleBackColor = true;
            // 
            // tabPageAnnouncements
            // 
            this.tabPageAnnouncements.Location = new System.Drawing.Point(4, 32);
            this.tabPageAnnouncements.Name = "tabPageAnnouncements";
            this.tabPageAnnouncements.Size = new System.Drawing.Size(977, 485);
            this.tabPageAnnouncements.TabIndex = 2;
            this.tabPageAnnouncements.Text = "📢 Announcements";
            this.tabPageAnnouncements.UseVisualStyleBackColor = true;
            // 
            // tabPageAssignments
            // 
            this.tabPageAssignments.Location = new System.Drawing.Point(4, 32);
            this.tabPageAssignments.Name = "tabPageAssignments";
            this.tabPageAssignments.Size = new System.Drawing.Size(977, 485);
            this.tabPageAssignments.TabIndex = 3;
            this.tabPageAssignments.Text = "📝 Assignments";
            this.tabPageAssignments.UseVisualStyleBackColor = true;
            // 
            // tabPageDiscussions
            // 
            this.tabPageDiscussions.Location = new System.Drawing.Point(4, 32);
            this.tabPageDiscussions.Name = "tabPageDiscussions";
            this.tabPageDiscussions.Size = new System.Drawing.Size(977, 485);
            this.tabPageDiscussions.TabIndex = 4;
            this.tabPageDiscussions.Text = "💬 Discussions";
            this.tabPageDiscussions.UseVisualStyleBackColor = true;
            // 
            // CourseDetailPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 621);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gradientPanelCourse);
            this.Name = "CourseDetailPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Detail Page Form";
            this.Load += new System.EventHandler(this.CourseDetailPageForm_Load);
            this.gradientPanelCourse.ResumeLayout(false);
            this.gradientPanelCourse.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelCourse;
        private System.Windows.Forms.TextBox txtSearch;
        private GradientPanel gradientPanelOutput;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOverview;
        private System.Windows.Forms.TabPage tabPageResources;
        private System.Windows.Forms.TabPage tabPageAnnouncements;
        private System.Windows.Forms.TabPage tabPageAssignments;
        private System.Windows.Forms.TabPage tabPageDiscussions;
    }
}