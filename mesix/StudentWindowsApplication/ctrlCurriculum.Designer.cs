namespace StudentWindowsApplication
{
    partial class ctrlCurriculum
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
            this.dgvCurriculum = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxSection = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCurriculum = new System.Windows.Forms.TextBox();
            this.lblCurriculum = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.cbxClassName = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurriculum)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCurriculum
            // 
            this.dgvCurriculum.AllowUserToAddRows = false;
            this.dgvCurriculum.AllowUserToDeleteRows = false;
            this.dgvCurriculum.AllowUserToOrderColumns = true;
            this.dgvCurriculum.AllowUserToResizeColumns = false;
            this.dgvCurriculum.AllowUserToResizeRows = false;
            this.dgvCurriculum.BackgroundColor = System.Drawing.Color.White;
            this.dgvCurriculum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurriculum.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCurriculum.Location = new System.Drawing.Point(13, 264);
            this.dgvCurriculum.MultiSelect = false;
            this.dgvCurriculum.Name = "dgvCurriculum";
            this.dgvCurriculum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurriculum.Size = new System.Drawing.Size(939, 328);
            this.dgvCurriculum.TabIndex = 14;
            this.dgvCurriculum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurriculum_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbxSection);
            this.panel1.Controls.Add(this.lblSection);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtCurriculum);
            this.panel1.Controls.Add(this.lblCurriculum);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cbxSubject);
            this.panel1.Controls.Add(this.cbxClassName);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.lblSubject);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 245);
            this.panel1.TabIndex = 28;
            // 
            // cbxSection
            // 
            this.cbxSection.FormattingEnabled = true;
            this.cbxSection.Location = new System.Drawing.Point(154, 121);
            this.cbxSection.Name = "cbxSection";
            this.cbxSection.Size = new System.Drawing.Size(121, 21);
            this.cbxSection.TabIndex = 43;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblSection.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblSection.Location = new System.Drawing.Point(59, 123);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(59, 19);
            this.lblSection.TabIndex = 42;
            this.lblSection.Text = "Section";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(372, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 158);
            this.label1.TabIndex = 41;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.Location = new System.Drawing.Point(781, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 21);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Location = new System.Drawing.Point(559, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 21);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCurriculum
            // 
            this.txtCurriculum.Location = new System.Drawing.Point(447, 51);
            this.txtCurriculum.Multiline = true;
            this.txtCurriculum.Name = "txtCurriculum";
            this.txtCurriculum.Size = new System.Drawing.Size(398, 100);
            this.txtCurriculum.TabIndex = 38;
            // 
            // lblCurriculum
            // 
            this.lblCurriculum.AutoSize = true;
            this.lblCurriculum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurriculum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCurriculum.Location = new System.Drawing.Point(443, 29);
            this.lblCurriculum.Name = "lblCurriculum";
            this.lblCurriculum.Size = new System.Drawing.Size(84, 19);
            this.lblCurriculum.TabIndex = 37;
            this.lblCurriculum.Text = "Curriculum";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Location = new System.Drawing.Point(707, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 21);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "INSERT";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxSubject
            // 
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(154, 91);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(121, 21);
            this.cbxSubject.TabIndex = 33;
            // 
            // cbxClassName
            // 
            this.cbxClassName.FormattingEnabled = true;
            this.cbxClassName.Location = new System.Drawing.Point(154, 63);
            this.cbxClassName.Name = "cbxClassName";
            this.cbxClassName.Size = new System.Drawing.Size(122, 21);
            this.cbxClassName.TabIndex = 32;
            this.cbxClassName.SelectedIndexChanged += new System.EventHandler(this.cbxClassName_SelectedIndexChanged_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh.Location = new System.Drawing.Point(633, 158);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 21);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnView.Location = new System.Drawing.Point(154, 159);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(70, 21);
            this.btnView.TabIndex = 30;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubject.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblSubject.Location = new System.Drawing.Point(59, 93);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(60, 19);
            this.lblSubject.TabIndex = 29;
            this.lblSubject.Text = "Subject";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblClass.Location = new System.Drawing.Point(49, 64);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(81, 19);
            this.lblClass.TabIndex = 28;
            this.lblClass.Text = "ClassName";
            // 
            // ctrlCurriculum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCurriculum);
            this.Name = "ctrlCurriculum";
            this.Size = new System.Drawing.Size(965, 650);
            this.Load += new System.EventHandler(this.ctrlCurriculum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurriculum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCurriculum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCurriculum;
        private System.Windows.Forms.Label lblCurriculum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxSubject;
        private System.Windows.Forms.ComboBox cbxClassName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblClass;
        protected internal System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSection;
        private System.Windows.Forms.Label lblSection;
    }
}
