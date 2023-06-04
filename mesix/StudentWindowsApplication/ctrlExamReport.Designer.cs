namespace StudentWindowsApplication
{
    partial class ctrlExamReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvExamReport = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.cbxTest = new System.Windows.Forms.ComboBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.cbxSection = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnView = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnRefresh = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamReport)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExamReport
            // 
            this.dgvExamReport.AllowUserToAddRows = false;
            this.dgvExamReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExamReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExamReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExamReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamReport.Cursor = System.Windows.Forms.Cursors.PanNW;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExamReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExamReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExamReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvExamReport.Location = new System.Drawing.Point(3, 249);
            this.dgvExamReport.Name = "dgvExamReport";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExamReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvExamReport.Size = new System.Drawing.Size(1074, 422);
            this.dgvExamReport.TabIndex = 2;
            this.dgvExamReport.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExamReport_CellValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Exam Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(967, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Created By : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDate.Location = new System.Drawing.Point(658, 76);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 40);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Date";
            // 
            // lblShowDate
            // 
            this.lblShowDate.AutoSize = true;
            this.lblShowDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblShowDate.Location = new System.Drawing.Point(708, 76);
            this.lblShowDate.Name = "lblShowDate";
            this.lblShowDate.Size = new System.Drawing.Size(357, 40);
            this.lblShowDate.TabIndex = 13;
            this.lblShowDate.Text = "Date";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(1041, 13);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(56, 13);
            this.lblTeacherName.TabIndex = 12;
            this.lblTeacherName.Text = "CreatedBy";
            // 
            // cbxTest
            // 
            this.cbxTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxTest.FormattingEnabled = true;
            this.cbxTest.Location = new System.Drawing.Point(708, 41);
            this.cbxTest.Name = "cbxTest";
            this.cbxTest.Size = new System.Drawing.Size(357, 28);
            this.cbxTest.TabIndex = 3;
            this.cbxTest.SelectedIndexChanged += new System.EventHandler(this.cbxTest_SelectedIndexChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTest.Location = new System.Drawing.Point(618, 38);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(84, 38);
            this.lblTest.TabIndex = 9;
            this.lblTest.Text = "Test/Exam";
            // 
            // cbxSection
            // 
            this.cbxSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxSection.FormattingEnabled = true;
            this.cbxSection.Location = new System.Drawing.Point(708, 3);
            this.cbxSection.Name = "cbxSection";
            this.cbxSection.Size = new System.Drawing.Size(357, 28);
            this.cbxSection.TabIndex = 1;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSection.Location = new System.Drawing.Point(639, 0);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(63, 38);
            this.lblSection.TabIndex = 7;
            this.lblSection.Text = "Section";
            // 
            // cbxSubject
            // 
            this.cbxSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(140, 41);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(388, 28);
            this.cbxSubject.TabIndex = 2;
            this.cbxSubject.SelectedIndexChanged += new System.EventHandler(this.cbxSubject_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSubject.Location = new System.Drawing.Point(71, 38);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(63, 38);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subject";
            // 
            // cbxClass
            // 
            this.cbxClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(140, 3);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(388, 28);
            this.cbxClass.TabIndex = 0;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxClass_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClass.Location = new System.Drawing.Point(86, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(48, 38);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Class";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.62338F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1074, 240);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRefresh, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(967, 188);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(104, 49);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.BackgroundColor = System.Drawing.Color.White;
            this.btnView.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_SearchLogo__2_;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnView.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnView.BorderRadius = 0;
            this.btnView.BorderSize = 0;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(3, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(44, 43);
            this.btnView.TabIndex = 0;
            this.btnView.TextColor = System.Drawing.Color.White;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BackgroundColor = System.Drawing.Color.White;
            this.btnRefresh.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_RefreshLogo1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRefresh.BorderRadius = 0;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(55, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(44, 43);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.85211F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.97183F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.37324F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.80282F));
            this.tableLayoutPanel3.Controls.Add(this.lblShowDate, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblDate, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblClass, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbxClass, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbxTest, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblSection, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTest, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbxSection, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbxSubject, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblSubject, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 66);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1068, 116);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dgvExamReport, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.49852F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.50148F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1080, 674);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // ctrlExamReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTeacherName);
            this.Name = "ctrlExamReport";
            this.Size = new System.Drawing.Size(1080, 674);
            this.Load += new System.EventHandler(this.ctrlExamReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamReport)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExamReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblShowDate;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.ComboBox cbxTest;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.ComboBox cbxSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cbxSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomControls.SMSButtons btnView;
        private CustomControls.SMSButtons btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}
