namespace StudentWindowsApplication
{
    partial class TeacherStudentAttendanceForm
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
            this.dgvExamReport = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblHeadingDate = new System.Windows.Forms.Label();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cbxSection = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExamReport
            // 
            this.dgvExamReport.AllowUserToAddRows = false;
            this.dgvExamReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvExamReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvExamReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamReport.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.dgvExamReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvExamReport.Location = new System.Drawing.Point(12, 203);
            this.dgvExamReport.Name = "dgvExamReport";
            this.dgvExamReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvExamReport.Size = new System.Drawing.Size(965, 440);
            this.dgvExamReport.TabIndex = 4;
            this.dgvExamReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExamReport_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.lblHeadingDate);
            this.panel1.Controls.Add(this.lblShowDate);
            this.panel1.Controls.Add(this.lblTeacherName);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.cbxSection);
            this.panel1.Controls.Add(this.lblSection);
            this.panel1.Controls.Add(this.cbxSubject);
            this.panel1.Controls.Add(this.lblSubject);
            this.panel1.Controls.Add(this.cbxClass);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 185);
            this.panel1.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(597, 99);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(369, 143);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(55, 21);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblHeadingDate
            // 
            this.lblHeadingDate.AutoSize = true;
            this.lblHeadingDate.Location = new System.Drawing.Point(539, 99);
            this.lblHeadingDate.Name = "lblHeadingDate";
            this.lblHeadingDate.Size = new System.Drawing.Size(30, 13);
            this.lblHeadingDate.TabIndex = 14;
            this.lblHeadingDate.Text = "Date";
            // 
            // lblShowDate
            // 
            this.lblShowDate.AutoSize = true;
            this.lblShowDate.Location = new System.Drawing.Point(592, 128);
            this.lblShowDate.Name = "lblShowDate";
            this.lblShowDate.Size = new System.Drawing.Size(0, 13);
            this.lblShowDate.TabIndex = 13;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTeacherName.Location = new System.Drawing.Point(54, 24);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(0, 31);
            this.lblTeacherName.TabIndex = 12;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(287, 143);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(58, 21);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cbxSection
            // 
            this.cbxSection.FormattingEnabled = true;
            this.cbxSection.Location = new System.Drawing.Point(595, 67);
            this.cbxSection.Name = "cbxSection";
            this.cbxSection.Size = new System.Drawing.Size(121, 21);
            this.cbxSection.TabIndex = 2;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(534, 70);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(43, 13);
            this.lblSection.TabIndex = 7;
            this.lblSection.Text = "Section";
            // 
            // cbxSubject
            // 
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(287, 94);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(121, 21);
            this.cbxSubject.TabIndex = 3;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(229, 94);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subject";
            // 
            // cbxClass
            // 
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(287, 67);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(121, 21);
            this.cbxClass.TabIndex = 1;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxClass_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(229, 67);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Class";
            // 
            // TeacherStudentAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 655);
            this.Controls.Add(this.dgvExamReport);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherStudentAttendanceForm";
            this.Text = "TeacherStudentAttendanceForm";
            this.Load += new System.EventHandler(this.TeacherStudentAttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExamReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblHeadingDate;
        private System.Windows.Forms.Label lblShowDate;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbxSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cbxSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblDate;
    }
}