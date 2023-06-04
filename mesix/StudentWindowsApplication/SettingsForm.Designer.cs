namespace StudentWindowsApplication
{
    partial class SettingsForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTheme = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtInstituteName = new System.Windows.Forms.TextBox();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.btnTheme = new StudentWindowsApplication.CustomControls.SwitchButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(499, 429);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.21569F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.78431F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.Controls.Add(this.lblTheme, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtInstituteName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSchoolName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTheme, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.77934F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.22066F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(496, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(3, 0);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(40, 13);
            this.lblTheme.TabIndex = 6;
            this.lblTheme.Text = "Theme";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(301, 82);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(58, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInstituteName
            // 
            this.txtInstituteName.Location = new System.Drawing.Point(120, 82);
            this.txtInstituteName.Name = "txtInstituteName";
            this.txtInstituteName.Size = new System.Drawing.Size(175, 20);
            this.txtInstituteName.TabIndex = 1;
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Location = new System.Drawing.Point(3, 79);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(75, 13);
            this.lblSchoolName.TabIndex = 4;
            this.lblSchoolName.Text = "Institute Name";
            // 
            // btnTheme
            // 
            this.btnTheme.AutoSize = true;
            this.btnTheme.Location = new System.Drawing.Point(120, 3);
            this.btnTheme.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.OffBackColor = System.Drawing.Color.Gray;
            this.btnTheme.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnTheme.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTheme.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnTheme.Size = new System.Drawing.Size(45, 22);
            this.btnTheme.TabIndex = 5;
            this.btnTheme.UseVisualStyleBackColor = true;
            this.btnTheme.CheckedChanged += new System.EventHandler(this.switchButton1_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 574);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtInstituteName;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Label lblTheme;
        private CustomControls.SwitchButton btnTheme;
    }
}