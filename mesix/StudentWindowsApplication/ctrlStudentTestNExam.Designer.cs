namespace StudentWindowsApplication
{
    partial class ctrlStudentTestNExam
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
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(758, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(29, 67);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 8;
            this.lblSubject.Text = "Subject";
            // 
            // cbxSubject
            // 
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(95, 64);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(152, 21);
            this.cbxSubject.TabIndex = 3;
            this.cbxSubject.SelectedIndexChanged += new System.EventHandler(this.cbxSubject_SelectedIndexChanged);
            // 
            // dgvTest
            // 
            this.dgvTest.BackgroundColor = System.Drawing.Color.White;
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.dgvTest.Location = new System.Drawing.Point(20, 144);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTest.Size = new System.Drawing.Size(887, 508);
            this.dgvTest.TabIndex = 4;
            this.dgvTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTest_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.lblSubject);
            this.panel1.Controls.Add(this.cbxSubject);
            this.panel1.Location = new System.Drawing.Point(20, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 107);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tests";
            // 
            // ctrlStudentTestNExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTest);
            this.Controls.Add(this.panel1);
            this.Name = "ctrlStudentTestNExam";
            this.Size = new System.Drawing.Size(927, 682);
            this.Load += new System.EventHandler(this.ctrlStudentTestNExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbxSubject;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
