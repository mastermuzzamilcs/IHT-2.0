namespace StudentWindowsApplication
{
    partial class ctrlTeacherClass1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblHeadingClasses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.lblHeadingClasses);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTeacherName);
            this.panel1.Controls.Add(this.dgvClass);
            this.panel1.Location = new System.Drawing.Point(16, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 671);
            this.panel1.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(701, 101);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 21);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblHeadingClasses
            // 
            this.lblHeadingClasses.AutoSize = true;
            this.lblHeadingClasses.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingClasses.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeadingClasses.Location = new System.Drawing.Point(15, 16);
            this.lblHeadingClasses.Name = "lblHeadingClasses";
            this.lblHeadingClasses.Size = new System.Drawing.Size(75, 24);
            this.lblHeadingClasses.TabIndex = 6;
            this.lblHeadingClasses.Text = "Classes";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(48, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(740, 1);
            this.label3.TabIndex = 5;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTeacherName.Location = new System.Drawing.Point(111, 58);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(142, 25);
            this.lblTeacherName.TabIndex = 4;
            this.lblTeacherName.Text = "TeacherName";
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.BackgroundColor = System.Drawing.Color.White;
            this.dgvClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClass.Location = new System.Drawing.Point(19, 152);
            this.dgvClass.MultiSelect = false;
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.Size = new System.Drawing.Size(802, 501);
            this.dgvClass.TabIndex = 3;
            this.dgvClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellContentClick);
            // 
            // ctrlTeacherClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ctrlTeacherClass";
            this.Size = new System.Drawing.Size(876, 692);
            this.Load += new System.EventHandler(this.ctrlTeacherClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblHeadingClasses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.DataGridView dgvClass;
    }
}
