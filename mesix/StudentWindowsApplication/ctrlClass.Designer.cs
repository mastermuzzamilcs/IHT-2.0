namespace StudentWindowsApplication
{
    partial class ctrlClass
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
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblHeadingClasses = new System.Windows.Forms.Label();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.lblClassName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnView = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnInsert = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnUpdate = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnRefresh = new StudentWindowsApplication.CustomControls.SMSButtons();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClassName
            // 
            this.txtClassName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtClassName.Location = new System.Drawing.Point(115, 14);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(717, 26);
            this.txtClassName.TabIndex = 0;
            // 
            // lblHeadingClasses
            // 
            this.lblHeadingClasses.AutoSize = true;
            this.lblHeadingClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeadingClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeadingClasses.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeadingClasses.Location = new System.Drawing.Point(5, 10);
            this.lblHeadingClasses.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.lblHeadingClasses.Name = "lblHeadingClasses";
            this.lblHeadingClasses.Size = new System.Drawing.Size(833, 47);
            this.lblHeadingClasses.TabIndex = 11;
            this.lblHeadingClasses.Text = "Classes";
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClass.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClass.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClass.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClass.Location = new System.Drawing.Point(3, 121);
            this.dgvClass.MultiSelect = false;
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClass.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.Size = new System.Drawing.Size(1005, 513);
            this.dgvClass.TabIndex = 3;
            this.dgvClass.TabStop = false;
            this.dgvClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellClick);
            // 
            // lblClassName
            // 
            this.lblClassName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClassName.Location = new System.Drawing.Point(15, 17);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(94, 20);
            this.lblClassName.TabIndex = 12;
            this.lblClassName.Text = "Class Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvClass, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.61252F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.38748F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1011, 637);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.19149F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.80851F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1011, 118);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblHeadingClasses, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.62385F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.37615F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(841, 118);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.53093F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.46907F));
            this.tableLayoutPanel4.Controls.Add(this.txtClassName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblClassName, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(835, 55);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.21476F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.88591F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.22819F));
            this.tableLayoutPanel5.Controls.Add(this.btnDelete, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.btnView, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnInsert, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.btnUpdate, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnRefresh, 2, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(844, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.08719F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.29104F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.62136F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.45631F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(164, 112);
            this.tableLayoutPanel5.TabIndex = 6;
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
            this.btnDelete.Location = new System.Drawing.Point(56, 58);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 44);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = " ";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnView.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnView.BorderRadius = 0;
            this.btnView.BorderSize = 0;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(56, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(36, 9);
            this.btnView.TabIndex = 31;
            this.btnView.TabStop = false;
            this.btnView.Text = "View";
            this.btnView.TextColor = System.Drawing.Color.White;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
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
            this.btnInsert.Location = new System.Drawing.Point(3, 58);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(44, 44);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = " ";
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(56, 43);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(36, 7);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(110, 58);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(44, 44);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = " ";
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // ctrlClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ctrlClass";
            this.Size = new System.Drawing.Size(1011, 637);
            this.Load += new System.EventHandler(this.ctrlClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHeadingClasses;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private CustomControls.SMSButtons btnView;
        private CustomControls.SMSButtons btnRefresh;
        private CustomControls.SMSButtons btnDelete;
        private CustomControls.SMSButtons btnInsert;
        private CustomControls.SMSButtons btnUpdate;
    }
}
