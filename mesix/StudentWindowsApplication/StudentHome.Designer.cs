namespace StudentWindowsApplication
{
    partial class StudentHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentHome));
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.AttendanceTSItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TestsTSItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlModule = new System.Windows.Forms.Panel();
            this.pnlHorizentalMenu = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblSchoolMangement = new System.Windows.Forms.Label();
            this.lblWellcome = new System.Windows.Forms.Label();
            this.pnlSchoolName = new System.Windows.Forms.Panel();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlVerticalMenu = new System.Windows.Forms.Panel();
            this.menuStrip10 = new System.Windows.Forms.MenuStrip();
            this.ClassesTSItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip11 = new System.Windows.Forms.MenuStrip();
            this.ProfileTSItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeTSItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.SettingsTSItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.LogoutTSItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlStudentProfile1 = new StudentWindowsApplication.ctrlStudentProfile();
            this.ctrlStudentClass1 = new StudentWindowsApplication.ctrlStudentClass();
            this.ctrlStudentTestNExam1 = new StudentWindowsApplication.ctrlStudentTestNExam();
            this.ctrlStudentAttendanceReport1 = new StudentWindowsApplication.ctrlStudentAttendanceReport();
            this.ctrlStudentHome1 = new StudentWindowsApplication.ctrlStudentHome();
            this.menuStrip3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.pnlModule.SuspendLayout();
            this.pnlHorizentalMenu.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlSchoolName.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlVerticalMenu.SuspendLayout();
            this.menuStrip10.SuspendLayout();
            this.menuStrip11.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.menuStrip5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AttendanceTSItem1});
            this.menuStrip3.Location = new System.Drawing.Point(0, 196);
            this.menuStrip3.Margin = new System.Windows.Forms.Padding(100);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(270, 49);
            this.menuStrip3.TabIndex = 13;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // AttendanceTSItem1
            // 
            this.AttendanceTSItem1.BackColor = System.Drawing.Color.Transparent;
            this.AttendanceTSItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceTSItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AttendanceTSItem1.Margin = new System.Windows.Forms.Padding(10);
            this.AttendanceTSItem1.Name = "AttendanceTSItem1";
            this.AttendanceTSItem1.Size = new System.Drawing.Size(107, 25);
            this.AttendanceTSItem1.Text = "Attendance";
            this.AttendanceTSItem1.Click += new System.EventHandler(this.AttendanceTSItem1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestsTSItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 147);
            this.menuStrip2.Margin = new System.Windows.Forms.Padding(100);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(270, 49);
            this.menuStrip2.TabIndex = 12;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // TestsTSItem1
            // 
            this.TestsTSItem1.BackColor = System.Drawing.Color.Transparent;
            this.TestsTSItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestsTSItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TestsTSItem1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.TestsTSItem1.Name = "TestsTSItem1";
            this.TestsTSItem1.Size = new System.Drawing.Size(97, 25);
            this.TestsTSItem1.Text = "Test & Exam";
            this.TestsTSItem1.Click += new System.EventHandler(this.TestsTSItem1_Click);
            // 
            // pnlModule
            // 
            this.pnlModule.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlModule.Controls.Add(this.ctrlStudentHome1);
            this.pnlModule.Controls.Add(this.ctrlStudentProfile1);
            this.pnlModule.Controls.Add(this.ctrlStudentClass1);
            this.pnlModule.Controls.Add(this.ctrlStudentTestNExam1);
            this.pnlModule.Controls.Add(this.ctrlStudentAttendanceReport1);
            this.pnlModule.Location = new System.Drawing.Point(271, 79);
            this.pnlModule.Name = "pnlModule";
            this.pnlModule.Size = new System.Drawing.Size(1197, 800);
            this.pnlModule.TabIndex = 7;
            // 
            // pnlHorizentalMenu
            // 
            this.pnlHorizentalMenu.BackColor = System.Drawing.Color.White;
            this.pnlHorizentalMenu.Controls.Add(this.pnlSearch);
            this.pnlHorizentalMenu.Controls.Add(this.pnlSchoolName);
            this.pnlHorizentalMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHorizentalMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlHorizentalMenu.Name = "pnlHorizentalMenu";
            this.pnlHorizentalMenu.Size = new System.Drawing.Size(1464, 78);
            this.pnlHorizentalMenu.TabIndex = 6;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Controls.Add(this.lblAdmin);
            this.pnlSearch.Controls.Add(this.lblSchoolMangement);
            this.pnlSearch.Controls.Add(this.lblWellcome);
            this.pnlSearch.Location = new System.Drawing.Point(269, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(966, 78);
            this.pnlSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(288, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 51);
            this.label1.TabIndex = 8;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(-286, 40);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(36, 13);
            this.lblAdmin.TabIndex = 7;
            this.lblAdmin.Text = "Admin";
            // 
            // lblSchoolMangement
            // 
            this.lblSchoolMangement.AutoSize = true;
            this.lblSchoolMangement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolMangement.Location = new System.Drawing.Point(415, 30);
            this.lblSchoolMangement.Name = "lblSchoolMangement";
            this.lblSchoolMangement.Size = new System.Drawing.Size(281, 26);
            this.lblSchoolMangement.TabIndex = 4;
            this.lblSchoolMangement.Text = "School Management Sytem";
            // 
            // lblWellcome
            // 
            this.lblWellcome.AutoSize = true;
            this.lblWellcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWellcome.Location = new System.Drawing.Point(87, 29);
            this.lblWellcome.Name = "lblWellcome";
            this.lblWellcome.Size = new System.Drawing.Size(117, 26);
            this.lblWellcome.TabIndex = 3;
            this.lblWellcome.Text = "Wellcome";
            // 
            // pnlSchoolName
            // 
            this.pnlSchoolName.BackColor = System.Drawing.Color.Orange;
            this.pnlSchoolName.Controls.Add(this.lblSchoolName);
            this.pnlSchoolName.Location = new System.Drawing.Point(0, 0);
            this.pnlSchoolName.Name = "pnlSchoolName";
            this.pnlSchoolName.Size = new System.Drawing.Size(270, 78);
            this.pnlSchoolName.TabIndex = 0;
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSchoolName.Location = new System.Drawing.Point(-9, 15);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(279, 47);
            this.lblSchoolName.TabIndex = 0;
            this.lblSchoolName.Text = "School Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.pnlModule);
            this.panel3.Controls.Add(this.pnlHorizentalMenu);
            this.panel3.Controls.Add(this.pnlVerticalMenu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1464, 771);
            this.panel3.TabIndex = 15;
            // 
            // pnlVerticalMenu
            // 
            this.pnlVerticalMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlVerticalMenu.Controls.Add(this.menuStrip5);
            this.pnlVerticalMenu.Controls.Add(this.menuStrip4);
            this.pnlVerticalMenu.Controls.Add(this.menuStrip3);
            this.pnlVerticalMenu.Controls.Add(this.menuStrip2);
            this.pnlVerticalMenu.Controls.Add(this.menuStrip10);
            this.pnlVerticalMenu.Controls.Add(this.menuStrip11);
            this.pnlVerticalMenu.Controls.Add(this.menuStrip1);
            this.pnlVerticalMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlVerticalMenu.Location = new System.Drawing.Point(0, 78);
            this.pnlVerticalMenu.Name = "pnlVerticalMenu";
            this.pnlVerticalMenu.Size = new System.Drawing.Size(270, 879);
            this.pnlVerticalMenu.TabIndex = 5;
            // 
            // menuStrip10
            // 
            this.menuStrip10.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip10.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClassesTSItem1});
            this.menuStrip10.Location = new System.Drawing.Point(0, 98);
            this.menuStrip10.Margin = new System.Windows.Forms.Padding(100);
            this.menuStrip10.Name = "menuStrip10";
            this.menuStrip10.Size = new System.Drawing.Size(270, 49);
            this.menuStrip10.TabIndex = 9;
            this.menuStrip10.Text = "menuStrip10";
            // 
            // ClassesTSItem1
            // 
            this.ClassesTSItem1.BackColor = System.Drawing.Color.Transparent;
            this.ClassesTSItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassesTSItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClassesTSItem1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.ClassesTSItem1.Name = "ClassesTSItem1";
            this.ClassesTSItem1.Size = new System.Drawing.Size(74, 25);
            this.ClassesTSItem1.Text = "Classes";
            this.ClassesTSItem1.Click += new System.EventHandler(this.ClassesTSItem1_Click);
            // 
            // menuStrip11
            // 
            this.menuStrip11.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip11.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfileTSItem1});
            this.menuStrip11.Location = new System.Drawing.Point(0, 49);
            this.menuStrip11.Margin = new System.Windows.Forms.Padding(100);
            this.menuStrip11.Name = "menuStrip11";
            this.menuStrip11.Size = new System.Drawing.Size(270, 49);
            this.menuStrip11.TabIndex = 10;
            this.menuStrip11.Text = "new test";
            // 
            // ProfileTSItem1
            // 
            this.ProfileTSItem1.BackColor = System.Drawing.Color.Transparent;
            this.ProfileTSItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileTSItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ProfileTSItem1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.ProfileTSItem1.Name = "ProfileTSItem1";
            this.ProfileTSItem1.Size = new System.Drawing.Size(70, 25);
            this.ProfileTSItem1.Text = "Profile";
            this.ProfileTSItem1.Click += new System.EventHandler(this.ProfileTSItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeTSItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(270, 49);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomeTSItem1
            // 
            this.HomeTSItem1.BackColor = System.Drawing.Color.Transparent;
            this.HomeTSItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTSItem1.ForeColor = System.Drawing.Color.White;
            this.HomeTSItem1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.HomeTSItem1.Name = "HomeTSItem1";
            this.HomeTSItem1.Size = new System.Drawing.Size(67, 25);
            this.HomeTSItem1.Text = "Home";
            this.HomeTSItem1.Click += new System.EventHandler(this.HomeTSItem1_Click);
            // 
            // menuStrip4
            // 
            this.menuStrip4.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsTSItem1});
            this.menuStrip4.Location = new System.Drawing.Point(0, 245);
            this.menuStrip4.Margin = new System.Windows.Forms.Padding(100);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(270, 49);
            this.menuStrip4.TabIndex = 14;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // SettingsTSItem1
            // 
            this.SettingsTSItem1.BackColor = System.Drawing.Color.Transparent;
            this.SettingsTSItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTSItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SettingsTSItem1.Margin = new System.Windows.Forms.Padding(10);
            this.SettingsTSItem1.Name = "SettingsTSItem1";
            this.SettingsTSItem1.Size = new System.Drawing.Size(82, 25);
            this.SettingsTSItem1.Text = "Settings";
            this.SettingsTSItem1.Click += new System.EventHandler(this.SettingsTSItem1_Click);
            // 
            // menuStrip5
            // 
            this.menuStrip5.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutTSItem1});
            this.menuStrip5.Location = new System.Drawing.Point(0, 294);
            this.menuStrip5.Margin = new System.Windows.Forms.Padding(100);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(270, 49);
            this.menuStrip5.TabIndex = 15;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // LogoutTSItem1
            // 
            this.LogoutTSItem1.BackColor = System.Drawing.Color.Transparent;
            this.LogoutTSItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutTSItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LogoutTSItem1.Margin = new System.Windows.Forms.Padding(10);
            this.LogoutTSItem1.Name = "LogoutTSItem1";
            this.LogoutTSItem1.Size = new System.Drawing.Size(75, 25);
            this.LogoutTSItem1.Text = "Logout";
            this.LogoutTSItem1.Click += new System.EventHandler(this.LogoutTSItem1_Click);
            // 
            // ctrlStudentProfile1
            // 
            this.ctrlStudentProfile1.Location = new System.Drawing.Point(-2, -2);
            //this.ctrlStudentProfile1.LoginId = 6;
            this.ctrlStudentProfile1.Name = "ctrlStudentProfile1";
            this.ctrlStudentProfile1.Size = new System.Drawing.Size(1197, 685);
            this.ctrlStudentProfile1.TabIndex = 3;
            // 
            // ctrlStudentClass1
            // 
            this.ctrlStudentClass1.Location = new System.Drawing.Point(-2, -2);
            this.ctrlStudentClass1.Name = "ctrlStudentClass1";
            this.ctrlStudentClass1.Size = new System.Drawing.Size(974, 776);
            this.ctrlStudentClass1.TabIndex = 2;
            // 
            // ctrlStudentTestNExam1
            // 
            this.ctrlStudentTestNExam1.escapeSelectedIndexChangeEvent = false;
            this.ctrlStudentTestNExam1.Location = new System.Drawing.Point(-2, -2);
            this.ctrlStudentTestNExam1.Name = "ctrlStudentTestNExam1";
            this.ctrlStudentTestNExam1.Size = new System.Drawing.Size(927, 682);
            this.ctrlStudentTestNExam1.TabIndex = 1;
            // 
            // ctrlStudentAttendanceReport1
            // 
            this.ctrlStudentAttendanceReport1.escapeSelectedIndexChangeEvent = false;
            this.ctrlStudentAttendanceReport1.Location = new System.Drawing.Point(0, -2);
            this.ctrlStudentAttendanceReport1.Name = "ctrlStudentAttendanceReport1";
            this.ctrlStudentAttendanceReport1.Size = new System.Drawing.Size(927, 682);
            this.ctrlStudentAttendanceReport1.TabIndex = 0;
            // 
            // ctrlStudentHome1
            // 
            this.ctrlStudentHome1.Location = new System.Drawing.Point(-2, -2);
            this.ctrlStudentHome1.Name = "ctrlStudentHome1";
            this.ctrlStudentHome1.Notices = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrlStudentHome1.Notices")));
            this.ctrlStudentHome1.Size = new System.Drawing.Size(1197, 685);
            this.ctrlStudentHome1.TabIndex = 4;
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 771);
            this.Controls.Add(this.panel3);
            this.Name = "StudentHome";
            this.Text = "StudentHome";
            this.Load += new System.EventHandler(this.StudentHome_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.pnlModule.ResumeLayout(false);
            this.pnlHorizentalMenu.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlSchoolName.ResumeLayout(false);
            this.pnlSchoolName.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlVerticalMenu.ResumeLayout(false);
            this.pnlVerticalMenu.PerformLayout();
            this.menuStrip10.ResumeLayout(false);
            this.menuStrip10.PerformLayout();
            this.menuStrip11.ResumeLayout(false);
            this.menuStrip11.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem AttendanceTSItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem TestsTSItem1;
        private System.Windows.Forms.Panel pnlModule;
        private System.Windows.Forms.Panel pnlHorizentalMenu;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblSchoolMangement;
        private System.Windows.Forms.Label lblWellcome;
        private System.Windows.Forms.Panel pnlSchoolName;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlVerticalMenu;
        private System.Windows.Forms.MenuStrip menuStrip10;
        private System.Windows.Forms.ToolStripMenuItem ClassesTSItem1;
        private System.Windows.Forms.MenuStrip menuStrip11;
        private System.Windows.Forms.ToolStripMenuItem ProfileTSItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeTSItem1;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem LogoutTSItem1;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem SettingsTSItem1;
        private ctrlStudentProfile ctrlStudentProfile1;
        private ctrlStudentClass ctrlStudentClass1;
        private ctrlStudentTestNExam ctrlStudentTestNExam1;
        private ctrlStudentAttendanceReport ctrlStudentAttendanceReport1;
        private ctrlStudentHome ctrlStudentHome1;
    }
}