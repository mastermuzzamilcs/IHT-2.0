namespace StudentWindowsApplication
{
    partial class FeeCnfgForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFeeInfo = new System.Windows.Forms.TextBox();
            this.btnSubmitFee = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRollNumber = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtFeeInfo);
            this.panel1.Controls.Add(this.btnSubmitFee);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblRollNumber);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTotalFee);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 311);
            this.panel1.TabIndex = 61;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtFeeInfo
            // 
            this.txtFeeInfo.Enabled = false;
            this.txtFeeInfo.Location = new System.Drawing.Point(157, 160);
            this.txtFeeInfo.Name = "txtFeeInfo";
            this.txtFeeInfo.Size = new System.Drawing.Size(121, 20);
            this.txtFeeInfo.TabIndex = 63;
            // 
            // btnSubmitFee
            // 
            this.btnSubmitFee.BackColor = System.Drawing.Color.White;
            this.btnSubmitFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitFee.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitFee.Location = new System.Drawing.Point(158, 186);
            this.btnSubmitFee.Name = "btnSubmitFee";
            this.btnSubmitFee.Size = new System.Drawing.Size(70, 21);
            this.btnSubmitFee.TabIndex = 42;
            this.btnSubmitFee.Text = "Save";
            this.btnSubmitFee.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblName.Location = new System.Drawing.Point(14, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 24);
            this.lblName.TabIndex = 31;
            // 
            // lblRollNumber
            // 
            this.lblRollNumber.AutoSize = true;
            this.lblRollNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollNumber.Location = new System.Drawing.Point(155, 80);
            this.lblRollNumber.Name = "lblRollNumber";
            this.lblRollNumber.Size = new System.Drawing.Size(0, 16);
            this.lblRollNumber.TabIndex = 32;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(155, 112);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(0, 16);
            this.lblClass.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Class   :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "RollNo    :";
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFee.Location = new System.Drawing.Point(75, 164);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(65, 16);
            this.lblTotalFee.TabIndex = 36;
            this.lblTotalFee.Text = "Total Fee";
            // 
            // FeeCnfgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 332);
            this.Controls.Add(this.panel1);
            this.Name = "FeeCnfgForm";
            this.Text = "FeeCnfgForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFeeInfo;
        private System.Windows.Forms.Button btnSubmitFee;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRollNumber;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalFee;
    }
}