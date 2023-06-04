namespace StudentWindowsApplication
{
    partial class QuestionPaperForm
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
            this.pnlObjective = new System.Windows.Forms.Panel();
            this.lblChoiceD = new System.Windows.Forms.Label();
            this.lblChoiceC = new System.Windows.Forms.Label();
            this.lblChoiceB = new System.Windows.Forms.Label();
            this.lblChoiceA = new System.Windows.Forms.Label();
            this.txtChoiceD = new System.Windows.Forms.TextBox();
            this.txtChoiceC = new System.Windows.Forms.TextBox();
            this.txtChoiceB = new System.Windows.Forms.TextBox();
            this.txtChoiceA = new System.Windows.Forms.TextBox();
            this.lblChoices = new System.Windows.Forms.Label();
            this.pnlSubjective = new System.Windows.Forms.Panel();
            this.btnDelete = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnSubmit = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.lblHeadingClasses = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.lblSrNo = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.txtSrNo = new System.Windows.Forms.TextBox();
            this.pnlObjective.SuspendLayout();
            this.pnlSubjective.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlObjective
            // 
            this.pnlObjective.Controls.Add(this.lblChoiceD);
            this.pnlObjective.Controls.Add(this.lblChoiceC);
            this.pnlObjective.Controls.Add(this.lblChoiceB);
            this.pnlObjective.Controls.Add(this.lblChoiceA);
            this.pnlObjective.Controls.Add(this.txtChoiceD);
            this.pnlObjective.Controls.Add(this.txtChoiceC);
            this.pnlObjective.Controls.Add(this.txtChoiceB);
            this.pnlObjective.Controls.Add(this.txtChoiceA);
            this.pnlObjective.Controls.Add(this.lblChoices);
            this.pnlObjective.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlObjective.Location = new System.Drawing.Point(7, 310);
            this.pnlObjective.Name = "pnlObjective";
            this.pnlObjective.Size = new System.Drawing.Size(886, 160);
            this.pnlObjective.TabIndex = 1;
            // 
            // lblChoiceD
            // 
            this.lblChoiceD.AutoSize = true;
            this.lblChoiceD.Location = new System.Drawing.Point(126, 126);
            this.lblChoiceD.Name = "lblChoiceD";
            this.lblChoiceD.Size = new System.Drawing.Size(31, 20);
            this.lblChoiceD.TabIndex = 42;
            this.lblChoiceD.Text = "(D)";
            // 
            // lblChoiceC
            // 
            this.lblChoiceC.AutoSize = true;
            this.lblChoiceC.Location = new System.Drawing.Point(126, 93);
            this.lblChoiceC.Name = "lblChoiceC";
            this.lblChoiceC.Size = new System.Drawing.Size(30, 20);
            this.lblChoiceC.TabIndex = 41;
            this.lblChoiceC.Text = "(C)";
            // 
            // lblChoiceB
            // 
            this.lblChoiceB.AutoSize = true;
            this.lblChoiceB.Location = new System.Drawing.Point(126, 60);
            this.lblChoiceB.Name = "lblChoiceB";
            this.lblChoiceB.Size = new System.Drawing.Size(30, 20);
            this.lblChoiceB.TabIndex = 40;
            this.lblChoiceB.Text = "(B)";
            // 
            // lblChoiceA
            // 
            this.lblChoiceA.AutoSize = true;
            this.lblChoiceA.Location = new System.Drawing.Point(126, 28);
            this.lblChoiceA.Name = "lblChoiceA";
            this.lblChoiceA.Size = new System.Drawing.Size(30, 20);
            this.lblChoiceA.TabIndex = 39;
            this.lblChoiceA.Text = "(A)";
            // 
            // txtChoiceD
            // 
            this.txtChoiceD.Location = new System.Drawing.Point(163, 127);
            this.txtChoiceD.Name = "txtChoiceD";
            this.txtChoiceD.Size = new System.Drawing.Size(720, 26);
            this.txtChoiceD.TabIndex = 3;
            // 
            // txtChoiceC
            // 
            this.txtChoiceC.Location = new System.Drawing.Point(163, 94);
            this.txtChoiceC.Name = "txtChoiceC";
            this.txtChoiceC.Size = new System.Drawing.Size(720, 26);
            this.txtChoiceC.TabIndex = 2;
            // 
            // txtChoiceB
            // 
            this.txtChoiceB.Location = new System.Drawing.Point(163, 61);
            this.txtChoiceB.Name = "txtChoiceB";
            this.txtChoiceB.Size = new System.Drawing.Size(720, 26);
            this.txtChoiceB.TabIndex = 1;
            // 
            // txtChoiceA
            // 
            this.txtChoiceA.Location = new System.Drawing.Point(163, 28);
            this.txtChoiceA.Name = "txtChoiceA";
            this.txtChoiceA.Size = new System.Drawing.Size(720, 26);
            this.txtChoiceA.TabIndex = 0;
            // 
            // lblChoices
            // 
            this.lblChoices.AutoSize = true;
            this.lblChoices.Location = new System.Drawing.Point(68, 0);
            this.lblChoices.Name = "lblChoices";
            this.lblChoices.Size = new System.Drawing.Size(66, 20);
            this.lblChoices.TabIndex = 34;
            this.lblChoices.Text = "Choices";
            // 
            // pnlSubjective
            // 
            this.pnlSubjective.BackColor = System.Drawing.Color.White;
            this.pnlSubjective.Controls.Add(this.btnDelete);
            this.pnlSubjective.Controls.Add(this.btnSubmit);
            this.pnlSubjective.Controls.Add(this.lblHeadingClasses);
            this.pnlSubjective.Controls.Add(this.lblMarks);
            this.pnlSubjective.Controls.Add(this.pnlObjective);
            this.pnlSubjective.Controls.Add(this.txtMarks);
            this.pnlSubjective.Controls.Add(this.lblSrNo);
            this.pnlSubjective.Controls.Add(this.lblDesc);
            this.pnlSubjective.Controls.Add(this.txtDesc);
            this.pnlSubjective.Controls.Add(this.txtSrNo);
            this.pnlSubjective.Location = new System.Drawing.Point(8, 7);
            this.pnlSubjective.Name = "pnlSubjective";
            this.pnlSubjective.Size = new System.Drawing.Size(939, 543);
            this.pnlSubjective.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(241, 507);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Remove";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnSubmit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnSubmit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSubmit.BorderRadius = 0;
            this.btnSubmit.BorderSize = 0;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(137, 507);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 30);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextColor = System.Drawing.Color.White;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblHeadingClasses
            // 
            this.lblHeadingClasses.AutoSize = true;
            this.lblHeadingClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeadingClasses.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeadingClasses.Location = new System.Drawing.Point(6, 10);
            this.lblHeadingClasses.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.lblHeadingClasses.Name = "lblHeadingClasses";
            this.lblHeadingClasses.Size = new System.Drawing.Size(230, 31);
            this.lblHeadingClasses.TabIndex = 34;
            this.lblHeadingClasses.Text = "Question Details";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMarks.Location = new System.Drawing.Point(278, 71);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(52, 20);
            this.lblMarks.TabIndex = 33;
            this.lblMarks.Text = "Marks";
            // 
            // txtMarks
            // 
            this.txtMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMarks.Location = new System.Drawing.Point(350, 68);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(100, 26);
            this.txtMarks.TabIndex = 3;
            // 
            // lblSrNo
            // 
            this.lblSrNo.AutoSize = true;
            this.lblSrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSrNo.Location = new System.Drawing.Point(75, 68);
            this.lblSrNo.Name = "lblSrNo";
            this.lblSrNo.Size = new System.Drawing.Size(56, 20);
            this.lblSrNo.TabIndex = 27;
            this.lblSrNo.Text = "Sr. NO";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDesc.Location = new System.Drawing.Point(75, 115);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(46, 20);
            this.lblDesc.TabIndex = 26;
            this.lblDesc.Text = "Desc";
            // 
            // txtDesc
            // 
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDesc.Location = new System.Drawing.Point(137, 115);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(756, 189);
            this.txtDesc.TabIndex = 0;
            this.txtDesc.Text = "";
            // 
            // txtSrNo
            // 
            this.txtSrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSrNo.Location = new System.Drawing.Point(137, 68);
            this.txtSrNo.Name = "txtSrNo";
            this.txtSrNo.Size = new System.Drawing.Size(100, 26);
            this.txtSrNo.TabIndex = 2;
            this.txtSrNo.TabStop = false;
            // 
            // QuestionPaperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 557);
            this.Controls.Add(this.pnlSubjective);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(971, 596);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(971, 596);
            this.Name = "QuestionPaperForm";
            this.Text = "QuestionPaperForm";
            this.Load += new System.EventHandler(this.QuestionPaperForm_Load);
            this.pnlObjective.ResumeLayout(false);
            this.pnlObjective.PerformLayout();
            this.pnlSubjective.ResumeLayout(false);
            this.pnlSubjective.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlObjective;
        private System.Windows.Forms.Panel pnlSubjective;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.Label lblSrNo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.TextBox txtSrNo;
        private System.Windows.Forms.Label lblChoiceD;
        private System.Windows.Forms.Label lblChoiceC;
        private System.Windows.Forms.Label lblChoiceB;
        private System.Windows.Forms.Label lblChoiceA;
        private System.Windows.Forms.TextBox txtChoiceD;
        private System.Windows.Forms.TextBox txtChoiceC;
        private System.Windows.Forms.TextBox txtChoiceB;
        private System.Windows.Forms.TextBox txtChoiceA;
        private System.Windows.Forms.Label lblChoices;
        private System.Windows.Forms.Label lblHeadingClasses;
        private CustomControls.SMSButtons btnDelete;
        private CustomControls.SMSButtons btnSubmit;
    }
}