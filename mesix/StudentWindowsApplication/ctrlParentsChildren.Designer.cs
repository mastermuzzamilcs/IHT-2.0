namespace StudentWindowsApplication
{
    partial class ctrlParentsChildren
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
            this.dgvChildren = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblChildren = new System.Windows.Forms.Label();
            this.lblEndPage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnlBack = new System.Windows.Forms.LinkLabel();
            this.lnkForward = new System.Windows.Forms.LinkLabel();
            this.lblStartPage = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildren)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChildren
            // 
            this.dgvChildren.AllowUserToAddRows = false;
            this.dgvChildren.AllowUserToDeleteRows = false;
            this.dgvChildren.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChildren.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChildren.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChildren.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChildren.BackgroundColor = System.Drawing.Color.White;
            this.dgvChildren.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChildren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChildren.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChildren.Location = new System.Drawing.Point(3, 119);
            this.dgvChildren.Name = "dgvChildren";
            this.dgvChildren.ReadOnly = true;
            this.dgvChildren.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChildren.Size = new System.Drawing.Size(945, 580);
            this.dgvChildren.TabIndex = 0;
            this.dgvChildren.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChildren_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblChildren);
            this.panel1.Controls.Add(this.lblEndPage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lnlBack);
            this.panel1.Controls.Add(this.lnkForward);
            this.panel1.Controls.Add(this.lblStartPage);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvChildren);
            this.panel1.Location = new System.Drawing.Point(11, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 729);
            this.panel1.TabIndex = 2;
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildren.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblChildren.Location = new System.Drawing.Point(38, 15);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(119, 31);
            this.lblChildren.TabIndex = 30;
            this.lblChildren.Text = "Children";
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
            this.label2.Location = new System.Drawing.Point(440, 712);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "to";
            // 
            // lnlBack
            // 
            this.lnlBack.AutoSize = true;
            this.lnlBack.Location = new System.Drawing.Point(417, 711);
            this.lnlBack.Name = "lnlBack";
            this.lnlBack.Size = new System.Drawing.Size(13, 13);
            this.lnlBack.TabIndex = 11;
            this.lnlBack.TabStop = true;
            this.lnlBack.Text = "<";
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
            // 
            // lblStartPage
            // 
            this.lblStartPage.AutoSize = true;
            this.lblStartPage.Location = new System.Drawing.Point(430, 712);
            this.lblStartPage.Name = "lblStartPage";
            this.lblStartPage.Size = new System.Drawing.Size(13, 13);
            this.lblStartPage.TabIndex = 9;
            this.lblStartPage.Text = "1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(894, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(54, 20);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(44, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(860, 1);
            this.label1.TabIndex = 6;
            // 
            // ctrlParentsChildren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ctrlParentsChildren";
            this.Size = new System.Drawing.Size(974, 776);
            this.Load += new System.EventHandler(this.ctrlParentsChildren_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildren)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChildren;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Label lblEndPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnlBack;
        private System.Windows.Forms.LinkLabel lnkForward;
        private System.Windows.Forms.Label lblStartPage;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
    }
}
