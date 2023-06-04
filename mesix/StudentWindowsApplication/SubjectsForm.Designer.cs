namespace StudentWindowsApplication
{
    partial class SubjectsForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblHeadingSubjects = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.lblHeadingSubjects);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSubject);
            this.panel1.Controls.Add(this.dgvSubject);
            this.panel1.Controls.Add(this.txtSubject);
            this.panel1.Controls.Add(this.cbxClass);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Location = new System.Drawing.Point(20, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 452);
            this.panel1.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(428, 196);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 21);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(428, 223);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 21);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(428, 250);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 21);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInsert.Location = new System.Drawing.Point(428, 169);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(70, 21);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // lblHeadingSubjects
            // 
            this.lblHeadingSubjects.AutoSize = true;
            this.lblHeadingSubjects.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingSubjects.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeadingSubjects.Location = new System.Drawing.Point(15, 16);
            this.lblHeadingSubjects.Name = "lblHeadingSubjects";
            this.lblHeadingSubjects.Size = new System.Drawing.Size(85, 24);
            this.lblHeadingSubjects.TabIndex = 6;
            this.lblHeadingSubjects.Text = "Subjects";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(48, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 1);
            this.label3.TabIndex = 5;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(300, 96);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(74, 13);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Subject Name";
            // 
            // dgvSubject
            // 
            this.dgvSubject.AllowUserToAddRows = false;
            this.dgvSubject.AllowUserToDeleteRows = false;
            this.dgvSubject.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubject.Location = new System.Drawing.Point(39, 152);
            this.dgvSubject.MultiSelect = false;
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.ReadOnly = true;
            this.dgvSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubject.Size = new System.Drawing.Size(383, 283);
            this.dgvSubject.TabIndex = 3;
            this.dgvSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubject_CellClick);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(398, 93);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(127, 20);
            this.txtSubject.TabIndex = 2;
            // 
            // cbxClass
            // 
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(134, 93);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(127, 21);
            this.cbxClass.TabIndex = 1;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxClass_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(76, 96);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Class";
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 506);
            this.Controls.Add(this.panel1);
            this.Name = "SubjectsForm";
            this.Text = "SubjectsForm";
            this.Load += new System.EventHandler(this.SubjectsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblHeadingSubjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.Label lblClass;
    }
}