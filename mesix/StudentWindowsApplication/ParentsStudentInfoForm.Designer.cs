namespace StudentWindowsApplication
{
    partial class ParentsStudentInfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnExamReports = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblHeadingClass = new System.Windows.Forms.Label();
            this.lblSubjectHeadingSubject = new System.Windows.Forms.Label();
            this.lblHeadingTeacher = new System.Windows.Forms.Label();
            this.lblHeadingSection = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblChildrenName = new System.Windows.Forms.Label();
            this.lblEndPage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnlBack = new System.Windows.Forms.LinkLabel();
            this.lnkForward = new System.Windows.Forms.LinkLabel();
            this.lblStartPage = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSubjects.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubjects.Location = new System.Drawing.Point(3, 198);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(945, 501);
            this.dgvSubjects.TabIndex = 0;
            this.dgvSubjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubject_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTip);
            this.panel1.Controls.Add(this.btnExamReports);
            this.panel1.Controls.Add(this.btnAttendance);
            this.panel1.Controls.Add(this.lblSubject);
            this.panel1.Controls.Add(this.lblSection);
            this.panel1.Controls.Add(this.lblTeacher);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Controls.Add(this.lblHeadingClass);
            this.panel1.Controls.Add(this.lblSubjectHeadingSubject);
            this.panel1.Controls.Add(this.lblHeadingTeacher);
            this.panel1.Controls.Add(this.lblHeadingSection);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblChildrenName);
            this.panel1.Controls.Add(this.lblEndPage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lnlBack);
            this.panel1.Controls.Add(this.lnkForward);
            this.panel1.Controls.Add(this.lblStartPage);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvSubjects);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 729);
            this.panel1.TabIndex = 2;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTip.Location = new System.Drawing.Point(41, 147);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(306, 17);
            this.lblTip.TabIndex = 54;
            this.lblTip.Text = "*Select any Subject to view Attendance and Reports*";
            // 
            // btnExamReports
            // 
            this.btnExamReports.Location = new System.Drawing.Point(825, 147);
            this.btnExamReports.Name = "btnExamReports";
            this.btnExamReports.Size = new System.Drawing.Size(79, 20);
            this.btnExamReports.TabIndex = 53;
            this.btnExamReports.Text = "ExamReports";
            this.btnExamReports.UseVisualStyleBackColor = true;
            this.btnExamReports.Click += new System.EventHandler(this.btnExamReports_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Location = new System.Drawing.Point(713, 147);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(106, 20);
            this.btnAttendance.TabIndex = 52;
            this.btnAttendance.Text = "View Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(575, 117);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(0, 17);
            this.lblSubject.TabIndex = 51;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(575, 79);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(0, 17);
            this.lblSection.TabIndex = 50;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.Location = new System.Drawing.Point(259, 117);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(0, 17);
            this.lblTeacher.TabIndex = 49;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(259, 79);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(0, 17);
            this.lblClass.TabIndex = 48;
            // 
            // lblHeadingClass
            // 
            this.lblHeadingClass.AutoSize = true;
            this.lblHeadingClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingClass.Location = new System.Drawing.Point(193, 79);
            this.lblHeadingClass.Name = "lblHeadingClass";
            this.lblHeadingClass.Size = new System.Drawing.Size(46, 17);
            this.lblHeadingClass.TabIndex = 47;
            this.lblHeadingClass.Text = "Class:";
            // 
            // lblSubjectHeadingSubject
            // 
            this.lblSubjectHeadingSubject.AutoSize = true;
            this.lblSubjectHeadingSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectHeadingSubject.Location = new System.Drawing.Point(495, 117);
            this.lblSubjectHeadingSubject.Name = "lblSubjectHeadingSubject";
            this.lblSubjectHeadingSubject.Size = new System.Drawing.Size(63, 17);
            this.lblSubjectHeadingSubject.TabIndex = 46;
            this.lblSubjectHeadingSubject.Text = "Subject :";
            // 
            // lblHeadingTeacher
            // 
            this.lblHeadingTeacher.AutoSize = true;
            this.lblHeadingTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingTeacher.Location = new System.Drawing.Point(184, 117);
            this.lblHeadingTeacher.Name = "lblHeadingTeacher";
            this.lblHeadingTeacher.Size = new System.Drawing.Size(69, 17);
            this.lblHeadingTeacher.TabIndex = 45;
            this.lblHeadingTeacher.Text = "Teacher :";
            // 
            // lblHeadingSection
            // 
            this.lblHeadingSection.AutoSize = true;
            this.lblHeadingSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingSection.Location = new System.Drawing.Point(494, 79);
            this.lblHeadingSection.Name = "lblHeadingSection";
            this.lblHeadingSection.Size = new System.Drawing.Size(63, 17);
            this.lblHeadingSection.TabIndex = 44;
            this.lblHeadingSection.Text = "Section :";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(893, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 20);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblChildrenName
            // 
            this.lblChildrenName.AutoSize = true;
            this.lblChildrenName.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildrenName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblChildrenName.Location = new System.Drawing.Point(38, 15);
            this.lblChildrenName.Name = "lblChildrenName";
            this.lblChildrenName.Size = new System.Drawing.Size(217, 31);
            this.lblChildrenName.TabIndex = 30;
            this.lblChildrenName.Text = "<ChildrenName>";
            // 
            // lblEndPage
            // 
            this.lblEndPage.AutoSize = true;
            this.lblEndPage.Location = new System.Drawing.Point(451, 713);
            this.lblEndPage.Name = "lblEndPage";
            this.lblEndPage.Size = new System.Drawing.Size(19, 13);
            this.lblEndPage.TabIndex = 13;
            this.lblEndPage.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 712);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "to";
            // 
            // lnlBack
            // 
            this.lnlBack.AutoSize = true;
            this.lnlBack.Location = new System.Drawing.Point(417, 711);
            this.lnlBack.Name = "lnlBack";
            this.lnlBack.Size = new System.Drawing.Size(13, 13);
            this.lnlBack.TabIndex = 11;
            this.lnlBack.TabStop = true;
            this.lnlBack.Text = "<";
            // 
            // lnkForward
            // 
            this.lnkForward.AutoSize = true;
            this.lnkForward.Location = new System.Drawing.Point(471, 713);
            this.lnkForward.Name = "lnkForward";
            this.lnkForward.Size = new System.Drawing.Size(13, 13);
            this.lnkForward.TabIndex = 10;
            this.lnkForward.TabStop = true;
            this.lnkForward.Text = ">";
            // 
            // lblStartPage
            // 
            this.lblStartPage.AutoSize = true;
            this.lblStartPage.Location = new System.Drawing.Point(430, 712);
            this.lblStartPage.Name = "lblStartPage";
            this.lblStartPage.Size = new System.Drawing.Size(13, 13);
            this.lblStartPage.TabIndex = 9;
            this.lblStartPage.Text = "1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(833, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(54, 20);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(44, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(860, 1);
            this.label1.TabIndex = 6;
            // 
            // ParentsStudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 737);
            this.Controls.Add(this.panel1);
            this.Name = "ParentsStudentInfoForm";
            this.Text = "ParentsStudentInfoForm";
            this.Load += new System.EventHandler(this.ParentsStudentInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChildrenName;
        private System.Windows.Forms.Label lblEndPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnlBack;
        private System.Windows.Forms.LinkLabel lnkForward;
        private System.Windows.Forms.Label lblStartPage;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblHeadingClass;
        private System.Windows.Forms.Label lblSubjectHeadingSubject;
        private System.Windows.Forms.Label lblHeadingTeacher;
        private System.Windows.Forms.Label lblHeadingSection;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Button btnExamReports;
        private System.Windows.Forms.Button btnAttendance;
    }
}