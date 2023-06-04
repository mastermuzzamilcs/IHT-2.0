namespace StudentWindowsApplication
{
    partial class ctrlSection
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.dgvSections = new System.Windows.Forms.DataGridView();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInsert = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnRefresh = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnDelete = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnUpdate = new StudentWindowsApplication.CustomControls.SMSButtons();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sections";
            // 
            // lblSection
            // 
            this.lblSection.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSection.Location = new System.Drawing.Point(364, 15);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(109, 20);
            this.lblSection.TabIndex = 19;
            this.lblSection.Text = "Section Name";
            // 
            // dgvSections
            // 
            this.dgvSections.AllowUserToAddRows = false;
            this.dgvSections.AllowUserToDeleteRows = false;
            this.dgvSections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSections.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSections.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSections.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSections.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSections.Location = new System.Drawing.Point(3, 110);
            this.dgvSections.MultiSelect = false;
            this.dgvSections.Name = "dgvSections";
            this.dgvSections.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSections.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSections.Size = new System.Drawing.Size(1005, 524);
            this.dgvSections.TabIndex = 5;
            this.dgvSections.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSections_CellClick);
            // 
            // txtSection
            // 
            this.txtSection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSection.Location = new System.Drawing.Point(479, 12);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(360, 26);
            this.txtSection.TabIndex = 1;
            // 
            // cbxClass
            // 
            this.cbxClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(67, 11);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(284, 28);
            this.cbxClass.TabIndex = 0;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxClass_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClass.Location = new System.Drawing.Point(13, 15);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(48, 20);
            this.lblClass.TabIndex = 18;
            this.lblClass.Text = "Class";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvSections, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.874802F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.04552F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1011, 637);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.330366F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.78338F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.16617F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.30069F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.132542F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.945599F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.341246F));
            this.tableLayoutPanel2.Controls.Add(this.btnInsert, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRefresh, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSection, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSection, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbxClass, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblClass, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1011, 51);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnInsert.Location = new System.Drawing.Point(857, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(44, 44);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnRefresh.Location = new System.Drawing.Point(964, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(44, 44);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnDelete.Location = new System.Drawing.Point(907, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(888, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 27);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ctrlSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "ctrlSection";
            this.Size = new System.Drawing.Size(1011, 637);
            this.Load += new System.EventHandler(this.ctrlSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.DataGridView dgvSections;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.Label lblClass;
        private CustomControls.SMSButtons btnInsert;
        private CustomControls.SMSButtons btnUpdate;
        private CustomControls.SMSButtons btnDelete;
        private CustomControls.SMSButtons btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
