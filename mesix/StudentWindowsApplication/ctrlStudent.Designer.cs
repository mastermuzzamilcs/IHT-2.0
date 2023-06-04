namespace StudentWindowsApplication
{
    partial class ctrlStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblClass = new System.Windows.Forms.Label();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNewCity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNext = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnPrev = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnAddNew = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnRefresh = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnSearch = new StudentWindowsApplication.CustomControls.SMSButtons();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClass
            // 
            this.lblClass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClass.Location = new System.Drawing.Point(431, 15);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(48, 20);
            this.lblClass.TabIndex = 37;
            this.lblClass.Text = "Class";
            // 
            // cbxClass
            // 
            this.cbxClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(485, 11);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(363, 28);
            this.cbxClass.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(4, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(61, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(359, 26);
            this.txtName.TabIndex = 0;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStudents.Location = new System.Drawing.Point(3, 112);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1005, 473);
            this.dgvStudents.TabIndex = 1;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblNewCity, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvStudents, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.397171F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.862629F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.18464F));
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
            this.lblNewCity.Size = new System.Drawing.Size(115, 43);
            this.lblNewCity.TabIndex = 38;
            this.lblNewCity.Text = "Students";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.txtPage);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 591);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 43);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Page";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.809524F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.904762F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.71642F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.074627F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.975124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.074627F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddNew, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRefresh, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbxClass, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblClass, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1005, 50);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.btnAddNew.Location = new System.Drawing.Point(955, 3);
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
            // ctrlStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ctrlStudent";
            this.Size = new System.Drawing.Size(1011, 637);
            this.Load += new System.EventHandler(this.ctrlStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvStudents;
        private CustomControls.SMSButtons btnSearch;
        private CustomControls.SMSButtons btnRefresh;
        private CustomControls.SMSButtons btnAddNew;
        private CustomControls.SMSButtons btnNext;
        private CustomControls.SMSButtons btnPrev;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblNewCity;
    }
}
