namespace StudentWindowsApplication
{
    partial class UserControlTesterForm
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
            this.ctrlSettings1 = new StudentWindowsApplication.ctrlSettings();
            this.SuspendLayout();
            // 
            // ctrlSettings1
            // 
            this.ctrlSettings1.Location = new System.Drawing.Point(50, 30);
            this.ctrlSettings1.Name = "ctrlSettings1";
            this.ctrlSettings1.Size = new System.Drawing.Size(664, 392);
            this.ctrlSettings1.TabIndex = 0;
            // 
            // UserControlTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlSettings1);
            this.Name = "UserControlTesterForm";
            this.Text = "UserControlTesterForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSettings ctrlSettings1;
    }
}