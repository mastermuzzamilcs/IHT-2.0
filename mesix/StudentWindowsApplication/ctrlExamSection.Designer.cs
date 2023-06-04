namespace StudentWindowsApplication
{
    partial class ctrlExamSection
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSecTitle = new System.Windows.Forms.Label();
            this.btnAddQues = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDelete = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.38996F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.61004F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1015, 518);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Panel1
            // 
            this.Panel1.AutoScroll = true;
            this.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(4, 63);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1007, 451);
            this.Panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.90831F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.09169F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSecTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddQues, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1007, 52);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSecTitle
            // 
            this.lblSecTitle.AutoSize = true;
            this.lblSecTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecTitle.Location = new System.Drawing.Point(3, 20);
            this.lblSecTitle.Margin = new System.Windows.Forms.Padding(3, 20, 5, 0);
            this.lblSecTitle.Name = "lblSecTitle";
            this.lblSecTitle.Size = new System.Drawing.Size(57, 20);
            this.lblSecTitle.TabIndex = 0;
            this.lblSecTitle.Text = "label1";
            // 
            // btnAddQues
            // 
            this.btnAddQues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQues.BackColor = System.Drawing.Color.White;
            this.btnAddQues.BackgroundColor = System.Drawing.Color.White;
            this.btnAddQues.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_AddLogo;
            this.btnAddQues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddQues.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddQues.BorderRadius = 0;
            this.btnAddQues.BorderSize = 0;
            this.btnAddQues.FlatAppearance.BorderSize = 0;
            this.btnAddQues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQues.ForeColor = System.Drawing.Color.White;
            this.btnAddQues.Location = new System.Drawing.Point(960, 3);
            this.btnAddQues.Name = "btnAddQues";
            this.btnAddQues.Size = new System.Drawing.Size(44, 44);
            this.btnAddQues.TabIndex = 0;
            this.btnAddQues.TextColor = System.Drawing.Color.White;
            this.btnAddQues.UseVisualStyleBackColor = false;
            this.btnAddQues.Click += new System.EventHandler(this.button1_Click);
            this.btnAddQues.MouseEnter += new System.EventHandler(this.btnAddQues_MouseEnter);
            this.btnAddQues.MouseLeave += new System.EventHandler(this.btnAddQues_MouseLeave);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1075, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Section";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_CloseLogo1;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1082, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 44);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Deletes Whole Section";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ctrlExamSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ctrlExamSection";
            this.Size = new System.Drawing.Size(1129, 541);
            this.Load += new System.EventHandler(this.ctrlExamSection_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSecTitle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel Panel1;
        private CustomControls.SMSButtons btnAddQues;
        private CustomControls.SMSButtons btnDelete;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
