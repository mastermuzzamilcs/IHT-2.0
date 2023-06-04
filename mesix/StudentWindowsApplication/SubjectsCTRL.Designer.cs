namespace StudentWindowsApplication
{
    partial class SubjectsCTRL
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblHeadingSubjects = new System.Windows.Forms.Label();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnInsert = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnRefresh = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1027, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 21);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblHeadingSubjects
            // 
            this.lblHeadingSubjects.AutoSize = true;
            this.lblHeadingSubjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeadingSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeadingSubjects.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeadingSubjects.Location = new System.Drawing.Point(5, 10);
            this.lblHeadingSubjects.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.lblHeadingSubjects.Name = "lblHeadingSubjects";
            this.lblHeadingSubjects.Size = new System.Drawing.Size(127, 38);
            this.lblHeadingSubjects.TabIndex = 12;
            this.lblHeadingSubjects.Text = "Subjects";
            // 
            // dgvSubject
            // 
            this.dgvSubject.AllowUserToAddRows = false;
            this.dgvSubject.AllowUserToDeleteRows = false;
            this.dgvSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubject.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSubject.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubject.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubject.Location = new System.Drawing.Point(3, 108);
            this.dgvSubject.MultiSelect = false;
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubject.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubject.Size = new System.Drawing.Size(1005, 526);
            this.dgvSubject.TabIndex = 5;
            this.dgvSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubject_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblHeadingSubjects, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgvSubject, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.948195F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.3595F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1011, 637);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.870647F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.46766F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.43781F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.60199F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.074627F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.273632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.074627F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInsert, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblClass, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxClass, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSubject, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSubject, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1005, 51);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_CloseLogo1;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(902, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_SaveLogo;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsert.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInsert.BorderRadius = 0;
            this.btnInsert.BorderSize = 0;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(851, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(44, 44);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // lblClass
            // 
            this.lblClass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClass.Location = new System.Drawing.Point(8, 15);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(48, 20);
            this.lblClass.TabIndex = 11;
            this.lblClass.Text = "Class";
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
            this.btnRefresh.Location = new System.Drawing.Point(955, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(44, 44);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbxClass
            // 
            this.cbxClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(62, 11);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(260, 28);
            this.cbxClass.TabIndex = 0;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxClass_SelectedIndexChanged);
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSubject.Location = new System.Drawing.Point(453, 12);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(392, 26);
            this.txtSubject.TabIndex = 1;
            // 
            // lblSubject
            // 
            this.lblSubject.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSubject.Location = new System.Drawing.Point(338, 15);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(109, 20);
            this.lblSubject.TabIndex = 13;
            this.lblSubject.Text = "Subject Name";
            // 
            // SubjectsCTRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnUpdate);
            this.Name = "SubjectsCTRL";
            this.Size = new System.Drawing.Size(1011, 637);
            this.Load += new System.EventHandler(this.SubjectsCTRL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblHeadingSubjects;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomControls.SMSButtons btnInsert;
        private CustomControls.SMSButtons btnDelete;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.Label lblClass;
        private CustomControls.SMSButtons btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
