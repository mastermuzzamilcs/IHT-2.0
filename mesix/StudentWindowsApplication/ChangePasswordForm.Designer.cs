namespace StudentWindowsApplication
{
    partial class ChangePasswordForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtConfirmNewPass = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblRoll = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnGntnInvc = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnGntnInvc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.382F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 300);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.6087F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.3913F));
            this.tableLayoutPanel2.Controls.Add(this.txtConfirmNewPass, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNewPass, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRoll, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtOldPass, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAmount, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 43);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(388, 206);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtConfirmNewPass
            // 
            this.txtConfirmNewPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfirmNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConfirmNewPass.Location = new System.Drawing.Point(110, 139);
            this.txtConfirmNewPass.Name = "txtConfirmNewPass";
            this.txtConfirmNewPass.PasswordChar = '*';
            this.txtConfirmNewPass.Size = new System.Drawing.Size(275, 26);
            this.txtConfirmNewPass.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(26, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 68);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Old Passowrd";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNewPass.Location = new System.Drawing.Point(110, 71);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(275, 26);
            this.txtNewPass.TabIndex = 1;
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRoll.Location = new System.Drawing.Point(26, 68);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(78, 68);
            this.lblRoll.TabIndex = 3;
            this.lblRoll.Text = "New Password";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtOldPass.Location = new System.Drawing.Point(110, 3);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(275, 26);
            this.txtOldPass.TabIndex = 0;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAmount.Location = new System.Drawing.Point(5, 136);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(99, 70);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Confirm New Password";
            // 
            // btnGntnInvc
            // 
            this.btnGntnInvc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGntnInvc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnGntnInvc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnGntnInvc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGntnInvc.BorderRadius = 0;
            this.btnGntnInvc.BorderSize = 0;
            this.btnGntnInvc.FlatAppearance.BorderSize = 0;
            this.btnGntnInvc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGntnInvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGntnInvc.ForeColor = System.Drawing.Color.White;
            this.btnGntnInvc.Location = new System.Drawing.Point(169, 255);
            this.btnGntnInvc.Name = "btnGntnInvc";
            this.btnGntnInvc.Size = new System.Drawing.Size(109, 35);
            this.btnGntnInvc.TabIndex = 1;
            this.btnGntnInvc.Text = "Proceed";
            this.btnGntnInvc.TextColor = System.Drawing.Color.White;
            this.btnGntnInvc.UseVisualStyleBackColor = false;
            this.btnGntnInvc.Click += new System.EventHandler(this.btnGntnInvc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "Change Password";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 308);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(474, 347);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(474, 347);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangePasswordForm_FormClosed);
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtConfirmNewPass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label lblAmount;
        private CustomControls.SMSButtons btnGntnInvc;
        private System.Windows.Forms.Label label1;
    }
}