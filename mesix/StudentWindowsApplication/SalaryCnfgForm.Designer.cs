namespace StudentWindowsApplication
{
    partial class SalaryCnfgForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnInsert = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblViewName = new System.Windows.Forms.Label();
            this.lblCtrlTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSalaryCnfg = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryCnfg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblViewName);
            this.panel1.Controls.Add(this.lblCtrlTitle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgvSalaryCnfg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 566);
            this.panel1.TabIndex = 0;
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
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(566, 183);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 44);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAmount.Location = new System.Drawing.Point(152, 93);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(231, 26);
            this.txtAmount.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_AddLogo;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsert.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInsert.BorderRadius = 0;
            this.btnInsert.BorderSize = 0;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(566, 135);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(44, 44);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAmount.Location = new System.Drawing.Point(77, 94);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 35;
            this.lblAmount.Text = "Amount";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(152, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "Name";
            // 
            // lblViewName
            // 
            this.lblViewName.AutoSize = true;
            this.lblViewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblViewName.Location = new System.Drawing.Point(77, 62);
            this.lblViewName.Name = "lblViewName";
            this.lblViewName.Size = new System.Drawing.Size(51, 20);
            this.lblViewName.TabIndex = 33;
            this.lblViewName.Text = "Name";
            // 
            // lblCtrlTitle
            // 
            this.lblCtrlTitle.AutoSize = true;
            this.lblCtrlTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblCtrlTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCtrlTitle.Location = new System.Drawing.Point(14, 11);
            this.lblCtrlTitle.Name = "lblCtrlTitle";
            this.lblCtrlTitle.Size = new System.Drawing.Size(232, 31);
            this.lblCtrlTitle.TabIndex = 28;
            this.lblCtrlTitle.Text = "Configure Salary";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(49, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(520, 1);
            this.label3.TabIndex = 27;
            // 
            // dgvSalaryCnfg
            // 
            this.dgvSalaryCnfg.AllowUserToAddRows = false;
            this.dgvSalaryCnfg.AllowUserToDeleteRows = false;
            this.dgvSalaryCnfg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalaryCnfg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSalaryCnfg.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalaryCnfg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalaryCnfg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalaryCnfg.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalaryCnfg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSalaryCnfg.Location = new System.Drawing.Point(11, 135);
            this.dgvSalaryCnfg.MultiSelect = false;
            this.dgvSalaryCnfg.Name = "dgvSalaryCnfg";
            this.dgvSalaryCnfg.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalaryCnfg.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalaryCnfg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaryCnfg.Size = new System.Drawing.Size(547, 420);
            this.dgvSalaryCnfg.TabIndex = 3;
            this.dgvSalaryCnfg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalaryCnfg_CellClick);
            // 
            // SalaryCnfgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 566);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(638, 605);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(638, 605);
            this.Name = "SalaryCnfgForm";
            this.Text = "SalaryCnfgForm";
            this.Load += new System.EventHandler(this.SalaryCnfgForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryCnfg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblViewName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSalaryCnfg;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCtrlTitle;
        private CustomControls.SMSButtons btnDelete;
        private CustomControls.SMSButtons btnInsert;
    }
}