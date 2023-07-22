namespace StudentWindowsApplication
{
    partial class GntnInvcForm
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
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.lblInvcDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpInvcDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.RichTextBox();
            this.btnGntnInvc = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStudentName
            // 
            this.txtStudentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStudentName.Location = new System.Drawing.Point(110, 3);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(275, 26);
            this.txtStudentName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(34, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 54);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Student Name";
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRoll.Location = new System.Drawing.Point(40, 54);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(64, 54);
            this.lblRoll.TabIndex = 3;
            this.lblRoll.Text = "Roll No.";
            // 
            // txtRoll
            // 
            this.txtRoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRoll.Location = new System.Drawing.Point(110, 57);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(275, 26);
            this.txtRoll.TabIndex = 1;
            // 
            // lblInvcDate
            // 
            this.lblInvcDate.AutoSize = true;
            this.lblInvcDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblInvcDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInvcDate.Location = new System.Drawing.Point(6, 162);
            this.lblInvcDate.Name = "lblInvcDate";
            this.lblInvcDate.Size = new System.Drawing.Size(98, 54);
            this.lblInvcDate.TabIndex = 5;
            this.lblInvcDate.Text = "Invoice Date";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAmount.Location = new System.Drawing.Point(39, 108);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 54);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAmount.Location = new System.Drawing.Point(110, 111);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(275, 26);
            this.txtAmount.TabIndex = 2;
            // 
            // dtpInvcDate
            // 
            this.dtpInvcDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpInvcDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpInvcDate.Location = new System.Drawing.Point(110, 165);
            this.dtpInvcDate.Name = "dtpInvcDate";
            this.dtpInvcDate.Size = new System.Drawing.Size(275, 26);
            this.dtpInvcDate.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnGntnInvc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.382F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 390);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.6087F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.3913F));
            this.tableLayoutPanel2.Controls.Add(this.lblComments, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtAmount, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtpInvcDate, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblInvcDate, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtRoll, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRoll, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtStudentName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAmount, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtComments, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 55);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(388, 270);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Generate Invoice";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblComments.Location = new System.Drawing.Point(18, 216);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(86, 54);
            this.lblComments.TabIndex = 8;
            this.lblComments.Text = "Comments";
            // 
            // txtComments
            // 
            this.txtComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComments.Location = new System.Drawing.Point(110, 219);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(275, 48);
            this.txtComments.TabIndex = 9;
            this.txtComments.Text = "";
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
            this.btnGntnInvc.Location = new System.Drawing.Point(169, 331);
            this.btnGntnInvc.Name = "btnGntnInvc";
            this.btnGntnInvc.Size = new System.Drawing.Size(109, 35);
            this.btnGntnInvc.TabIndex = 1;
            this.btnGntnInvc.Text = "Generate";
            this.btnGntnInvc.TextColor = System.Drawing.Color.White;
            this.btnGntnInvc.UseVisualStyleBackColor = false;
            this.btnGntnInvc.Click += new System.EventHandler(this.btnGntnInvc_Click);
            // 
            // GntnInvcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 415);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(478, 454);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(478, 351);
            this.Name = "GntnInvcForm";
            this.Text = "GntnInvcForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GntnInvcForm_FormClosed);
            this.Load += new System.EventHandler(this.GntnInvcForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.Label lblInvcDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpInvcDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomControls.SMSButtons btnGntnInvc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.RichTextBox txtComments;
    }
}