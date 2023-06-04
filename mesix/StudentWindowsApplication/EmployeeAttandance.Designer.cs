namespace StudentWindowsApplication
{
    partial class EmployeeAttandance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblHeadingStatus = new System.Windows.Forms.Label();
            this.lblHeadingDate = new System.Windows.Forms.Label();
            this.lblHeadingEmpType = new System.Windows.Forms.Label();
            this.lblHeadingEmpId = new System.Windows.Forms.Label();
            this.lblHeadingDept = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHeadingEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.dgvAttendanceSummary = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblLoginEmail);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 236);
            this.panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(74, 81);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Check-In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 28);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.Location = new System.Drawing.Point(16, 31);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(32, 13);
            this.lblLoginEmail.TabIndex = 0;
            this.lblLoginEmail.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSummary);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTag);
            this.panel2.Controls.Add(this.lblEmpId);
            this.panel2.Controls.Add(this.lblDept);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lblHeadingStatus);
            this.panel2.Controls.Add(this.lblHeadingDate);
            this.panel2.Controls.Add(this.lblHeadingEmpType);
            this.panel2.Controls.Add(this.lblHeadingEmpId);
            this.panel2.Controls.Add(this.lblHeadingDept);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.lblHeadingEmail);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(213, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 236);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(322, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 195);
            this.label3.TabIndex = 16;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTag.Location = new System.Drawing.Point(185, 194);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(0, 13);
            this.lblTag.TabIndex = 15;
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmpId.Location = new System.Drawing.Point(185, 157);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(0, 13);
            this.lblEmpId.TabIndex = 14;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDept.Location = new System.Drawing.Point(185, 128);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(0, 13);
            this.lblDept.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(185, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 13);
            this.lblEmail.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDate.Location = new System.Drawing.Point(425, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStatus.Location = new System.Drawing.Point(425, 91);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 10;
            // 
            // lblHeadingStatus
            // 
            this.lblHeadingStatus.AutoSize = true;
            this.lblHeadingStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeadingStatus.Location = new System.Drawing.Point(358, 91);
            this.lblHeadingStatus.Name = "lblHeadingStatus";
            this.lblHeadingStatus.Size = new System.Drawing.Size(43, 13);
            this.lblHeadingStatus.TabIndex = 9;
            this.lblHeadingStatus.Text = "Status :";
            // 
            // lblHeadingDate
            // 
            this.lblHeadingDate.AutoSize = true;
            this.lblHeadingDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeadingDate.Location = new System.Drawing.Point(361, 51);
            this.lblHeadingDate.Name = "lblHeadingDate";
            this.lblHeadingDate.Size = new System.Drawing.Size(36, 13);
            this.lblHeadingDate.TabIndex = 8;
            this.lblHeadingDate.Text = "Date :";
            // 
            // lblHeadingEmpType
            // 
            this.lblHeadingEmpType.AutoSize = true;
            this.lblHeadingEmpType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeadingEmpType.Location = new System.Drawing.Point(130, 194);
            this.lblHeadingEmpType.Name = "lblHeadingEmpType";
            this.lblHeadingEmpType.Size = new System.Drawing.Size(32, 13);
            this.lblHeadingEmpType.TabIndex = 7;
            this.lblHeadingEmpType.Text = "Tag :";
            // 
            // lblHeadingEmpId
            // 
            this.lblHeadingEmpId.AutoSize = true;
            this.lblHeadingEmpId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeadingEmpId.Location = new System.Drawing.Point(94, 157);
            this.lblHeadingEmpId.Name = "lblHeadingEmpId";
            this.lblHeadingEmpId.Size = new System.Drawing.Size(71, 13);
            this.lblHeadingEmpId.TabIndex = 6;
            this.lblHeadingEmpId.Text = "Employee Id :";
            // 
            // lblHeadingDept
            // 
            this.lblHeadingDept.AutoSize = true;
            this.lblHeadingDept.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeadingDept.Location = new System.Drawing.Point(94, 128);
            this.lblHeadingDept.Name = "lblHeadingDept";
            this.lblHeadingDept.Size = new System.Drawing.Size(68, 13);
            this.lblHeadingDept.TabIndex = 5;
            this.lblHeadingDept.Text = "Department :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(443, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Post";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblHeadingEmail
            // 
            this.lblHeadingEmail.AutoSize = true;
            this.lblHeadingEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeadingEmail.Location = new System.Drawing.Point(106, 94);
            this.lblHeadingEmail.Name = "lblHeadingEmail";
            this.lblHeadingEmail.Size = new System.Drawing.Size(38, 13);
            this.lblHeadingEmail.TabIndex = 2;
            this.lblHeadingEmail.Text = "Email :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblName.Location = new System.Drawing.Point(45, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(443, 194);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(75, 23);
            this.btnSummary.TabIndex = 5;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // dgvAttendanceSummary
            // 
            this.dgvAttendanceSummary.AllowUserToAddRows = false;
            this.dgvAttendanceSummary.AllowUserToDeleteRows = false;
            this.dgvAttendanceSummary.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendanceSummary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAttendanceSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendanceSummary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAttendanceSummary.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendanceSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendanceSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceSummary.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAttendanceSummary.Location = new System.Drawing.Point(12, 254);
            this.dgvAttendanceSummary.Name = "dgvAttendanceSummary";
            this.dgvAttendanceSummary.ReadOnly = true;
            this.dgvAttendanceSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendanceSummary.Size = new System.Drawing.Size(776, 486);
            this.dgvAttendanceSummary.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(74, 107);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // EmployeeAttandance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 752);
            this.Controls.Add(this.dgvAttendanceSummary);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeAttandance";
            this.Text = "EmployeeAttandance";
            this.Load += new System.EventHandler(this.EmployeeAttandance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblHeadingStatus;
        private System.Windows.Forms.Label lblHeadingDate;
        private System.Windows.Forms.Label lblHeadingEmpType;
        private System.Windows.Forms.Label lblHeadingEmpId;
        private System.Windows.Forms.Label lblHeadingDept;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblHeadingEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.DataGridView dgvAttendanceSummary;
        private System.Windows.Forms.Button btnReset;
    }
}