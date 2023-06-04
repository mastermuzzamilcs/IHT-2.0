namespace StudentWindowsApplication
{
    partial class NoticesForm
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
            this.txtDSCR = new System.Windows.Forms.RichTextBox();
            this.lblHeadingClasses = new System.Windows.Forms.Label();
            this.btnDelete = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnSave = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblHeadingClasses, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDSCR, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.12742F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.63712F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.95845F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(621, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 309);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(137, 48);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtDSCR
            // 
            this.txtDSCR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDSCR.Location = new System.Drawing.Point(30, 54);
            this.txtDSCR.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.txtDSCR.Name = "txtDSCR";
            this.txtDSCR.Size = new System.Drawing.Size(561, 249);
            this.txtDSCR.TabIndex = 2;
            this.txtDSCR.Text = "";
            // 
            // lblHeadingClasses
            // 
            this.lblHeadingClasses.AutoSize = true;
            this.lblHeadingClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeadingClasses.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeadingClasses.Location = new System.Drawing.Point(5, 10);
            this.lblHeadingClasses.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.lblHeadingClasses.Name = "lblHeadingClasses";
            this.lblHeadingClasses.Size = new System.Drawing.Size(162, 31);
            this.lblHeadingClasses.TabIndex = 7;
            this.lblHeadingClasses.Text = "Notification";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_CloseLogo1;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(71, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_SaveLogo;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 0;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(48, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NoticesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(637, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(637, 400);
            this.Name = "NoticesForm";
            this.Text = "NoticesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NoticesForm_FormClosed);
            this.Load += new System.EventHandler(this.NoticesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox txtDSCR;
        private System.Windows.Forms.Label lblHeadingClasses;
        private CustomControls.SMSButtons btnDelete;
        private CustomControls.SMSButtons btnSave;
    }
}