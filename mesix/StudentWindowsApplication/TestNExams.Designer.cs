namespace StudentWindowsApplication
{
    partial class TestNExams
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtPassingMarks = new System.Windows.Forms.TextBox();
            this.lblPassingMarks = new System.Windows.Forms.Label();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.cbxTeacher = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.cbxSection = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpTest = new System.Windows.Forms.DateTimePicker();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblTestName = new System.Windows.Forms.Label();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.txtPassingMarks);
            this.panel1.Controls.Add(this.lblPassingMarks);
            this.panel1.Controls.Add(this.txtTotalMarks);
            this.panel1.Controls.Add(this.lblTotalMarks);
            this.panel1.Controls.Add(this.lblTeacher);
            this.panel1.Controls.Add(this.cbxTeacher);
            this.panel1.Controls.Add(this.lblSection);
            this.panel1.Controls.Add(this.cbxSection);
            this.panel1.Controls.Add(this.lblSubject);
            this.panel1.Controls.Add(this.cbxSubject);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.dtpTest);
            this.panel1.Controls.Add(this.txtTestName);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Controls.Add(this.lblTestName);
            this.panel1.Controls.Add(this.cbxClass);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 284);
            this.panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(734, 234);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(648, 234);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(556, 234);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(462, 234);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtPassingMarks
            // 
            this.txtPassingMarks.Location = new System.Drawing.Point(701, 60);
            this.txtPassingMarks.Name = "txtPassingMarks";
            this.txtPassingMarks.Size = new System.Drawing.Size(152, 20);
            this.txtPassingMarks.TabIndex = 9;
            // 
            // lblPassingMarks
            // 
            this.lblPassingMarks.AutoSize = true;
            this.lblPassingMarks.Location = new System.Drawing.Point(622, 63);
            this.lblPassingMarks.Name = "lblPassingMarks";
            this.lblPassingMarks.Size = new System.Drawing.Size(76, 13);
            this.lblPassingMarks.TabIndex = 15;
            this.lblPassingMarks.Text = "Passing Marks";
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Location = new System.Drawing.Point(446, 61);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(152, 20);
            this.txtTotalMarks.TabIndex = 8;
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Location = new System.Drawing.Point(377, 64);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(63, 13);
            this.lblTotalMarks.TabIndex = 13;
            this.lblTotalMarks.Text = "Total Marks";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(635, 89);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(47, 13);
            this.lblTeacher.TabIndex = 12;
            this.lblTeacher.Text = "Teacher";
            // 
            // cbxTeacher
            // 
            this.cbxTeacher.FormattingEnabled = true;
            this.cbxTeacher.Location = new System.Drawing.Point(701, 86);
            this.cbxTeacher.Name = "cbxTeacher";
            this.cbxTeacher.Size = new System.Drawing.Size(152, 21);
            this.cbxTeacher.TabIndex = 10;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(31, 89);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(43, 13);
            this.lblSection.TabIndex = 10;
            this.lblSection.Text = "Section";
            // 
            // cbxSection
            // 
            this.cbxSection.FormattingEnabled = true;
            this.cbxSection.Location = new System.Drawing.Point(90, 86);
            this.cbxSection.Name = "cbxSection";
            this.cbxSection.Size = new System.Drawing.Size(152, 21);
            this.cbxSection.TabIndex = 2;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(24, 116);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 8;
            this.lblSubject.Text = "Subject";
            // 
            // cbxSubject
            // 
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(90, 113);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(152, 21);
            this.cbxSubject.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(635, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // dtpTest
            // 
            this.dtpTest.CustomFormat = "yyyy-MM-dd";
            this.dtpTest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTest.Location = new System.Drawing.Point(701, 34);
            this.dtpTest.Name = "dtpTest";
            this.dtpTest.Size = new System.Drawing.Size(152, 20);
            this.dtpTest.TabIndex = 7;
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(446, 34);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(152, 20);
            this.txtTestName.TabIndex = 6;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(31, 62);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Class";
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Location = new System.Drawing.Point(387, 37);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(28, 13);
            this.lblTestName.TabIndex = 0;
            this.lblTestName.Text = "Test";
            // 
            // cbxClass
            // 
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(90, 59);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(152, 21);
            this.cbxClass.TabIndex = 1;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxClass_SelectedIndexChanged);
            // 
            // dgvTest
            // 
            this.dgvTest.BackgroundColor = System.Drawing.Color.White;
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.dgvTest.Location = new System.Drawing.Point(12, 304);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTest.Size = new System.Drawing.Size(887, 329);
            this.dgvTest.TabIndex = 2;
            this.dgvTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTest_CellClick);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(446, 113);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(405, 75);
            this.txtDesc.TabIndex = 11;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(377, 100);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 21;
            this.lblDesc.Text = "Description";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(53, 234);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(151, 234);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(306, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 246);
            this.label1.TabIndex = 25;
            // 
            // TestNExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 643);
            this.Controls.Add(this.dgvTest);
            this.Controls.Add(this.panel1);
            this.Name = "TestNExams";
            this.Text = "TestNExams";
            this.Load += new System.EventHandler(this.TestNExams_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.DateTimePicker dtpTest;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.ComboBox cbxTeacher;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cbxSection;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbxSubject;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtPassingMarks;
        private System.Windows.Forms.Label lblPassingMarks;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
    }
}