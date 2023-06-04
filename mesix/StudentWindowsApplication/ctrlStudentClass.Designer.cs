namespace StudentWindowsApplication
{
    partial class ctrlStudentClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudentClasses = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEndPage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnlBack = new System.Windows.Forms.LinkLabel();
            this.lnkForward = new System.Windows.Forms.LinkLabel();
            this.lblStartPage = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeadingClass = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblHeadingSection = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentClasses)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudentClasses
            // 
            this.dgvStudentClasses.AllowUserToAddRows = false;
            this.dgvStudentClasses.AllowUserToDeleteRows = false;
            this.dgvStudentClasses.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentClasses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudentClasses.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudentClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudentClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentClasses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStudentClasses.Location = new System.Drawing.Point(3, 119);
            this.dgvStudentClasses.Name = "dgvStudentClasses";
            this.dgvStudentClasses.ReadOnly = true;
            this.dgvStudentClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentClasses.Size = new System.Drawing.Size(945, 580);
            this.dgvStudentClasses.TabIndex = 0;
            this.dgvStudentClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentClasses_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Controls.Add(this.lblHeadingSection);
            this.panel1.Controls.Add(this.lblSection);
            this.panel1.Controls.Add(this.lblEndPage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lnlBack);
            this.panel1.Controls.Add(this.lnkForward);
            this.panel1.Controls.Add(this.lblStartPage);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblHeadingClass);
            this.panel1.Controls.Add(this.dgvStudentClasses);
            this.panel1.Location = new System.Drawing.Point(11, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 729);
            this.panel1.TabIndex = 1;
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
            this.btnRefresh.Location = new System.Drawing.Point(795, 91);
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
            this.label1.Location = new System.Drawing.Point(44, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(860, 1);
            this.label1.TabIndex = 6;
            // 
            // lblHeadingClass
            // 
            this.lblHeadingClass.AutoSize = true;
            this.lblHeadingClass.Location = new System.Drawing.Point(60, 91);
            this.lblHeadingClass.Name = "lblHeadingClass";
            this.lblHeadingClass.Size = new System.Drawing.Size(38, 13);
            this.lblHeadingClass.TabIndex = 3;
            this.lblHeadingClass.Text = "Class :";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(296, 91);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(41, 13);
            this.lblSection.TabIndex = 14;
            this.lblSection.Text = "section";
            // 
            // lblHeadingSection
            // 
            this.lblHeadingSection.AutoSize = true;
            this.lblHeadingSection.Location = new System.Drawing.Point(237, 91);
            this.lblHeadingSection.Name = "lblHeadingSection";
            this.lblHeadingSection.Size = new System.Drawing.Size(49, 13);
            this.lblHeadingSection.TabIndex = 15;
            this.lblHeadingSection.Text = "Section :";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(113, 91);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 16;
            this.lblClass.Text = "Class";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblName.Location = new System.Drawing.Point(41, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 31);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name";
            // 
            // ctrlStudentClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ctrlStudentClass";
            this.Size = new System.Drawing.Size(974, 776);
            this.Load += new System.EventHandler(this.ctrlStudentClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentClasses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentClasses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblHeadingSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblEndPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnlBack;
        private System.Windows.Forms.LinkLabel lnkForward;
        private System.Windows.Forms.Label lblStartPage;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeadingClass;
    }
}
