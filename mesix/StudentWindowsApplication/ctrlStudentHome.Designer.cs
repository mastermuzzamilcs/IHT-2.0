namespace StudentWindowsApplication
{
    partial class ctrlStudentHome
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
            this.lblNotice1 = new System.Windows.Forms.Label();
            this.pnlNoticeBoard = new System.Windows.Forms.Panel();
            this.lblNotice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblHeadingMessage = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlCalender = new System.Windows.Forms.Panel();
            this.calander = new System.Windows.Forms.MonthCalendar();
            this.lblCalender = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHeadingName = new System.Windows.Forms.Label();
            this.pnlNoticeBoard.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlCalender.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNotice1
            // 
            this.lblNotice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice1.Location = new System.Drawing.Point(63, 54);
            this.lblNotice1.Name = "lblNotice1";
            this.lblNotice1.Size = new System.Drawing.Size(1034, 250);
            this.lblNotice1.TabIndex = 1;
            // 
            // pnlNoticeBoard
            // 
            this.pnlNoticeBoard.BackColor = System.Drawing.Color.White;
            this.pnlNoticeBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNoticeBoard.Controls.Add(this.lblNotice1);
            this.pnlNoticeBoard.Controls.Add(this.lblNotice);
            this.pnlNoticeBoard.Location = new System.Drawing.Point(19, 344);
            this.pnlNoticeBoard.Name = "pnlNoticeBoard";
            this.pnlNoticeBoard.Size = new System.Drawing.Size(1160, 325);
            this.pnlNoticeBoard.TabIndex = 12;
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblNotice.Location = new System.Drawing.Point(13, 9);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(98, 19);
            this.lblNotice.TabIndex = 0;
            this.lblNotice.Text = "Notice Board";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.lblHeadingMessage);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(19, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 222);
            this.panel1.TabIndex = 11;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMessage.Location = new System.Drawing.Point(75, 65);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(547, 141);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Message";
            // 
            // lblHeadingMessage
            // 
            this.lblHeadingMessage.AutoSize = true;
            this.lblHeadingMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeadingMessage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblHeadingMessage.Location = new System.Drawing.Point(22, 34);
            this.lblHeadingMessage.Name = "lblHeadingMessage";
            this.lblHeadingMessage.Size = new System.Drawing.Size(71, 19);
            this.lblHeadingMessage.TabIndex = 1;
            this.lblHeadingMessage.Text = "Message";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(658, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 189);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "";
            // 
            // pnlCalender
            // 
            this.pnlCalender.BackColor = System.Drawing.Color.White;
            this.pnlCalender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCalender.Controls.Add(this.calander);
            this.pnlCalender.Controls.Add(this.lblCalender);
            this.pnlCalender.Location = new System.Drawing.Point(880, 116);
            this.pnlCalender.Name = "pnlCalender";
            this.pnlCalender.Size = new System.Drawing.Size(299, 222);
            this.pnlCalender.TabIndex = 10;
            // 
            // calander
            // 
            this.calander.Location = new System.Drawing.Point(9, 34);
            this.calander.Name = "calander";
            this.calander.TabIndex = 1;
            // 
            // lblCalender
            // 
            this.lblCalender.AutoSize = true;
            this.lblCalender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblCalender.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCalender.Location = new System.Drawing.Point(21, 9);
            this.lblCalender.Name = "lblCalender";
            this.lblCalender.Size = new System.Drawing.Size(70, 19);
            this.lblCalender.TabIndex = 0;
            this.lblCalender.Text = "Calander";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblHeadingName);
            this.panel2.Location = new System.Drawing.Point(18, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 95);
            this.panel2.TabIndex = 13;
            // 
            // lblHeadingName
            // 
            this.lblHeadingName.AutoSize = true;
            this.lblHeadingName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeadingName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblHeadingName.Location = new System.Drawing.Point(47, 28);
            this.lblHeadingName.Name = "lblHeadingName";
            this.lblHeadingName.Size = new System.Drawing.Size(122, 19);
            this.lblHeadingName.TabIndex = 0;
            this.lblHeadingName.Text = "<Student Name>";
            // 
            // ctrlStudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlNoticeBoard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCalender);
            this.Controls.Add(this.panel2);
            this.Name = "ctrlStudentHome";
            this.Size = new System.Drawing.Size(1197, 685);
            this.Load += new System.EventHandler(this.ctrlStudentHome_Load);
            this.pnlNoticeBoard.ResumeLayout(false);
            this.pnlNoticeBoard.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlCalender.ResumeLayout(false);
            this.pnlCalender.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNotice1;
        private System.Windows.Forms.Panel pnlNoticeBoard;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblHeadingMessage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlCalender;
        private System.Windows.Forms.MonthCalendar calander;
        private System.Windows.Forms.Label lblCalender;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHeadingName;
    }
}
