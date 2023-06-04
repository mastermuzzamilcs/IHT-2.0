namespace StudentWindowsApplication
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxRoles = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.White;
            this.LoginPanel.Controls.Add(this.label4);
            this.LoginPanel.Controls.Add(this.label3);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.pictureBox1);
            this.LoginPanel.Controls.Add(this.cbxRoles);
            this.LoginPanel.Controls.Add(this.btnLogin);
            this.LoginPanel.Controls.Add(this.txtPassword);
            this.LoginPanel.Controls.Add(this.txtEmail);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(460, 427);
            this.LoginPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(48, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(49, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 1);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 1);
            this.label1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentWindowsApplication.Properties.Resources.IHT_APPLOGO_3;
            this.pictureBox1.Location = new System.Drawing.Point(109, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cbxRoles
            // 
            this.cbxRoles.FormattingEnabled = true;
            this.cbxRoles.Location = new System.Drawing.Point(197, 11);
            this.cbxRoles.Name = "cbxRoles";
            this.cbxRoles.Size = new System.Drawing.Size(199, 21);
            this.cbxRoles.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(207)))), ((int)(((byte)(228)))));
            this.btnLogin.Location = new System.Drawing.Point(53, 340);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(342, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(53, 268);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(342, 29);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleName = "Email";
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Location = new System.Drawing.Point(53, 202);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(342, 29);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Monster";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(460, 427);
            this.Controls.Add(this.LoginPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.ComboBox cbxRoles;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}