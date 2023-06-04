namespace StudentWindowsApplication
{
    partial class ctrlEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNewCity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.btnPrev = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddNew = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnRefresh = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnSearch = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmployee.Location = new System.Drawing.Point(3, 113);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(1005, 473);
            this.dgvEmployee.TabIndex = 1;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblNewCity, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvEmployee, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.397171F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.948195F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.19624F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.389937F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1011, 637);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNewCity
            // 
            this.lblNewCity.AutoSize = true;
            this.lblNewCity.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNewCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblNewCity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNewCity.Location = new System.Drawing.Point(5, 10);
            this.lblNewCity.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.lblNewCity.Name = "lblNewCity";
            this.lblNewCity.Size = new System.Drawing.Size(143, 43);
            this.lblNewCity.TabIndex = 37;
            this.lblNewCity.Text = "Employees";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.txtPage);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 592);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 42);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Page";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 0;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(146, 7);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(20, 30);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtPage
            // 
            this.txtPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPage.Location = new System.Drawing.Point(101, 9);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(30, 26);
            this.txtPage.TabIndex = 1;
            this.txtPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPage_KeyPress);
            this.txtPage.Leave += new System.EventHandler(this.txtPage_Leave);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnPrev.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnPrev.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrev.BorderRadius = 0;
            this.btnPrev.BorderSize = 0;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(67, 7);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(20, 30);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "<";
            this.btnPrev.TextColor = System.Drawing.Color.White;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.714286F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.47619F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.51741F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.074627F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.074627F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.975124F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddNew, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRefresh, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbxFilter, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFilter, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1005, 51);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.White;
            this.btnAddNew.BackgroundColor = System.Drawing.Color.White;
            this.btnAddNew.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_AddLogo;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNew.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddNew.BorderRadius = 0;
            this.btnAddNew.BorderSize = 0;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(956, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(44, 44);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.TextColor = System.Drawing.Color.White;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(905, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(44, 44);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_SearchLogo__2_;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(854, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 44);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxFilter
            // 
            this.cbxFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Location = new System.Drawing.Point(487, 11);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(361, 28);
            this.cbxFilter.TabIndex = 1;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFilter.Location = new System.Drawing.Point(438, 15);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(43, 20);
            this.lblFilter.TabIndex = 29;
            this.lblFilter.Text = "Type";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(60, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(361, 26);
            this.txtName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // ctrlEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ctrlEmployee";
            this.Size = new System.Drawing.Size(1011, 637);
            this.Load += new System.EventHandler(this.ctrlEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNewCity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private CustomControls.SMSButtons btnNext;
        private System.Windows.Forms.TextBox txtPage;
        private CustomControls.SMSButtons btnPrev;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomControls.SMSButtons btnAddNew;
        private CustomControls.SMSButtons btnRefresh;
        private CustomControls.SMSButtons btnSearch;
        private System.Windows.Forms.ComboBox cbxFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
    }
}
