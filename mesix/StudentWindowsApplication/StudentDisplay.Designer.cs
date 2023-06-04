namespace StudentWindowsApplication
{
    partial class StudentDisplay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClass = new System.Windows.Forms.Label();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.lblEndPage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnlBack = new System.Windows.Forms.LinkLabel();
            this.lnkForward = new System.Windows.Forms.LinkLabel();
            this.lblStartPage = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Controls.Add(this.cbxClass);
            this.panel1.Controls.Add(this.lblEndPage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lnlBack);
            this.panel1.Controls.Add(this.lnkForward);
            this.panel1.Controls.Add(this.lblStartPage);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.dgvStudents);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 729);
            this.panel1.TabIndex = 1;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(499, 94);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 15;
            this.lblClass.Text = "Class";
            // 
            // cbxClass
            // 
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(543, 87);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(121, 21);
            this.cbxClass.TabIndex = 14;
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
            this.label2.Location = new System.Drawing.Point(439, 712);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "to";
            // 
            // lnlBack
            // 
            this.lnlBack.AutoSize = true;
            this.lnlBack.Location = new System.Drawing.Point(409, 711);
            this.lnlBack.Name = "lnlBack";
            this.lnlBack.Size = new System.Drawing.Size(13, 13);
            this.lnlBack.TabIndex = 11;
            this.lnlBack.TabStop = true;
            this.lnlBack.Text = "<";
            this.lnlBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlBack_LinkClicked);
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
            this.lnkForward.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkForward_LinkClicked);
            // 
            // lblStartPage
            // 
            this.lblStartPage.AutoSize = true;
            this.lblStartPage.Location = new System.Drawing.Point(421, 712);
            this.lblStartPage.Name = "lblStartPage";
            this.lblStartPage.Size = new System.Drawing.Size(13, 13);
            this.lblStartPage.TabIndex = 9;
            this.lblStartPage.Text = "1";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(808, 87);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(60, 20);
            this.btnAddNew.TabIndex = 8;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(744, 88);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(54, 19);
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(685, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 19);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(60, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(364, 20);
            this.txtName.TabIndex = 1;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStudents.Location = new System.Drawing.Point(3, 123);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(945, 580);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // StudentDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 731);
            this.Controls.Add(this.panel1);
            this.Name = "StudentDisplay";
            this.Text = "StudentDisplay";
            this.Load += new System.EventHandler(this.StudentDisplay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEndPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnlBack;
        private System.Windows.Forms.LinkLabel lnkForward;
        private System.Windows.Forms.Label lblStartPage;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbxClass;
    }
}