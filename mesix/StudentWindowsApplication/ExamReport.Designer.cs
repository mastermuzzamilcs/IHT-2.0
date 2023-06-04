namespace StudentWindowsApplication
{
    partial class ExamReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.cbxTest = new System.Windows.Forms.ComboBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.cbxSection = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.dgvExamReport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblShowDate);
            this.panel1.Controls.Add(this.lblTeacherName);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.cbxTest);
            this.panel1.Controls.Add(this.lblTest);
            this.panel1.Controls.Add(this.cbxSection);
            this.panel1.Controls.Add(this.lblSection);
            this.panel1.Controls.Add(this.cbxSubject);
            this.panel1.Controls.Add(this.lblSubject);
            this.panel1.Controls.Add(this.cbxClass);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 185);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(537, 128);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Date";
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
            this.lblTeacherName.Location = new System.Drawing.Point(173, 24);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(0, 13);
            this.lblTeacherName.TabIndex = 12;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(287, 143);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(39, 21);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // cbxTest
            // 
            this.cbxTest.FormattingEnabled = true;
            this.cbxTest.Location = new System.Drawing.Point(595, 94);
            this.cbxTest.Name = "cbxTest";
            this.cbxTest.Size = new System.Drawing.Size(121, 21);
            this.cbxTest.TabIndex = 4;
            this.cbxTest.SelectedIndexChanged += new System.EventHandler(this.cbxTest_SelectedIndexChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(533, 96);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(59, 13);
            this.lblTest.TabIndex = 9;
            this.lblTest.Text = "Test/Exam";
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
            this.cbxSubject.SelectedIndexChanged += new System.EventHandler(this.cbxSubject_SelectedIndexChanged);
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
            this.dgvExamReport.TabIndex = 2;
            this.dgvExamReport.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExamReport_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Created By : ";
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
            // ExamReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 655);
            this.Controls.Add(this.dgvExamReport);
            this.Controls.Add(this.panel1);
            this.Name = "ExamReport";
            this.Text = "ExamReport";
            this.Load += new System.EventHandler(this.ExamReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvExamReport;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblShowDate;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox cbxTest;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.ComboBox cbxSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cbxSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
    }
}