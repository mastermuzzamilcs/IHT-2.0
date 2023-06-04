namespace StudentWindowsApplication
{
    partial class FeeByClass
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
            this.btnInsert = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.lblRoll = new System.Windows.Forms.Label();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.dgvClassFeeCnfg = new System.Windows.Forms.DataGridView();
            this.txtFeeAmount = new System.Windows.Forms.TextBox();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassFeeCnfg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.lblRoll);
            this.panel1.Controls.Add(this.txtRoll);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSection);
            this.panel1.Controls.Add(this.dgvClassFeeCnfg);
            this.panel1.Controls.Add(this.txtFeeAmount);
            this.panel1.Controls.Add(this.cbxClass);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 565);
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
            this.btnDelete.Location = new System.Drawing.Point(584, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 44);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnInsert.Location = new System.Drawing.Point(584, 135);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(44, 44);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRoll.Location = new System.Drawing.Point(337, 68);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(49, 20);
            this.lblRoll.TabIndex = 35;
            this.lblRoll.Text = "Roll #";
            // 
            // txtRoll
            // 
            this.txtRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRoll.Location = new System.Drawing.Point(406, 65);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(203, 26);
            this.txtRoll.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(22, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(80, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 26);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Configure Fee";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(49, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(540, 1);
            this.label3.TabIndex = 27;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSection.Location = new System.Drawing.Point(305, 97);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(97, 20);
            this.lblSection.TabIndex = 26;
            this.lblSection.Text = "Fee Amount";
            // 
            // dgvClassFeeCnfg
            // 
            this.dgvClassFeeCnfg.AllowUserToAddRows = false;
            this.dgvClassFeeCnfg.AllowUserToDeleteRows = false;
            this.dgvClassFeeCnfg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClassFeeCnfg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClassFeeCnfg.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClassFeeCnfg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClassFeeCnfg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClassFeeCnfg.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClassFeeCnfg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClassFeeCnfg.Location = new System.Drawing.Point(12, 135);
            this.dgvClassFeeCnfg.MultiSelect = false;
            this.dgvClassFeeCnfg.Name = "dgvClassFeeCnfg";
            this.dgvClassFeeCnfg.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClassFeeCnfg.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClassFeeCnfg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClassFeeCnfg.Size = new System.Drawing.Size(566, 418);
            this.dgvClassFeeCnfg.TabIndex = 6;
            this.dgvClassFeeCnfg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassFeeCnfg_CellClick);
            // 
            // txtFeeAmount
            // 
            this.txtFeeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFeeAmount.Location = new System.Drawing.Point(406, 94);
            this.txtFeeAmount.Name = "txtFeeAmount";
            this.txtFeeAmount.Size = new System.Drawing.Size(203, 26);
            this.txtFeeAmount.TabIndex = 3;
            // 
            // cbxClass
            // 
            this.cbxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(80, 94);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(215, 28);
            this.cbxClass.TabIndex = 2;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClass.Location = new System.Drawing.Point(22, 97);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(48, 20);
            this.lblClass.TabIndex = 22;
            this.lblClass.Text = "Class";
            // 
            // FeeByClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 565);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(656, 604);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(656, 604);
            this.Name = "FeeByClass";
            this.Text = "FeeByClass";
            this.Load += new System.EventHandler(this.FeeByClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassFeeCnfg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.DataGridView dgvClassFeeCnfg;
        private System.Windows.Forms.TextBox txtFeeAmount;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private CustomControls.SMSButtons btnDelete;
        private CustomControls.SMSButtons btnInsert;
    }
}