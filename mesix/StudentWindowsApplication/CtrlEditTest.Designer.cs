namespace StudentWindowsApplication
{
    partial class CtrlEditTest
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
            this.btnSaveTest = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblSecType = new System.Windows.Forms.Label();
            this.cbxSecType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnAddNew = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnClose = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHeadingClasses = new System.Windows.Forms.Label();
            this.btnCloseTest = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveTest
            // 
            this.btnSaveTest.Location = new System.Drawing.Point(1021, 39);
            this.btnSaveTest.Name = "btnSaveTest";
            this.btnSaveTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSaveTest.Size = new System.Drawing.Size(70, 23);
            this.btnSaveTest.TabIndex = 0;
            this.btnSaveTest.Text = "Save";
            this.btnSaveTest.UseVisualStyleBackColor = true;
            this.btnSaveTest.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1091, 628);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Panel1
            // 
            this.Panel1.AutoScroll = true;
            this.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(3, 119);
            this.Panel1.Name = "Panel1";
            this.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Panel1.Size = new System.Drawing.Size(1085, 506);
            this.Panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.17798F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.24748F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.499542F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.55545F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.76535F));
            this.tableLayoutPanel2.Controls.Add(this.txtTitle, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSecType, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbxSecType, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTitle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblHeadingClasses, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1091, 116);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTitle.Location = new System.Drawing.Point(157, 63);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTitle.Size = new System.Drawing.Size(323, 26);
            this.txtTitle.TabIndex = 0;
            // 
            // lblSecType
            // 
            this.lblSecType.AutoSize = true;
            this.lblSecType.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSecType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSecType.Location = new System.Drawing.Point(496, 60);
            this.lblSecType.Name = "lblSecType";
            this.lblSecType.Size = new System.Drawing.Size(43, 56);
            this.lblSecType.TabIndex = 6;
            this.lblSecType.Text = "Type";
            // 
            // cbxSecType
            // 
            this.cbxSecType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSecType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxSecType.FormattingEnabled = true;
            this.cbxSecType.Items.AddRange(new object[] {
            "<Please Select>",
            "Objective",
            "Subjective"});
            this.cbxSecType.Location = new System.Drawing.Point(545, 63);
            this.cbxSecType.Name = "cbxSecType";
            this.cbxSecType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxSecType.Size = new System.Drawing.Size(370, 28);
            this.cbxSecType.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.95062F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.95062F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.79012F));
            this.tableLayoutPanel3.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAddNew, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(931, 63);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(157, 50);
            this.tableLayoutPanel3.TabIndex = 2;
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
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(56, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 44);
            this.btnSave.TabIndex = 1;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.White;
            this.btnAddNew.BackgroundColor = System.Drawing.Color.White;
            this.btnAddNew.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_AddLogo;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNew.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddNew.BorderRadius = 0;
            this.btnAddNew.BorderSize = 0;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(3, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(44, 44);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.TextColor = System.Drawing.Color.White;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.button1_Click);
            this.btnAddNew.MouseEnter += new System.EventHandler(this.btnAddNew_MouseEnter);
            this.btnAddNew.MouseLeave += new System.EventHandler(this.btnAddNew_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_BackLogo;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(109, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 44);
            this.btnClose.TabIndex = 2;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitle.Location = new System.Drawing.Point(113, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 56);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title";
            // 
            // lblHeadingClasses
            // 
            this.lblHeadingClasses.AutoSize = true;
            this.lblHeadingClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeadingClasses.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeadingClasses.Location = new System.Drawing.Point(5, 10);
            this.lblHeadingClasses.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.lblHeadingClasses.Name = "lblHeadingClasses";
            this.lblHeadingClasses.Size = new System.Drawing.Size(105, 50);
            this.lblHeadingClasses.TabIndex = 27;
            this.lblHeadingClasses.Text = "Test Details";
            // 
            // btnCloseTest
            // 
            this.btnCloseTest.Location = new System.Drawing.Point(191, 3);
            this.btnCloseTest.Name = "btnCloseTest";
            this.btnCloseTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCloseTest.Size = new System.Drawing.Size(60, 23);
            this.btnCloseTest.TabIndex = 6;
            this.btnCloseTest.Text = "Close";
            this.btnCloseTest.UseVisualStyleBackColor = true;
            this.btnCloseTest.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1024, 68);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "AddNewSection";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Deletes Whole Section";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // CtrlEditTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCloseTest);
            this.Controls.Add(this.btnSaveTest);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CtrlEditTest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1091, 628);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveTest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel Panel1;
        private System.Windows.Forms.ComboBox cbxSecType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCloseTest;
        private System.Windows.Forms.Label lblSecType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CustomControls.SMSButtons btnClose;
        private CustomControls.SMSButtons btnSave;
        private CustomControls.SMSButtons btnAddNew;
        private System.Windows.Forms.Label lblHeadingClasses;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
