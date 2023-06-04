namespace StudentWindowsApplication
{
    partial class ctrlExamTest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtPassingMarks = new System.Windows.Forms.TextBox();
            this.lblPassingMarks = new System.Windows.Forms.Label();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.cbxSection = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpTest = new System.Windows.Forms.DateTimePicker();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblTestName = new System.Windows.Forms.Label();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeadingClasses = new System.Windows.Forms.Label();
            this.btnReset = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnView = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnInsert = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnUpdate = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnRefresh = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToAddRows = false;
            this.dgvTest.AllowUserToDeleteRows = false;
            this.dgvTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTest.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Cursor = System.Windows.Forms.Cursors.PanNW;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTest.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTest.Location = new System.Drawing.Point(3, 267);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTest.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTest.Size = new System.Drawing.Size(1084, 411);
            this.dgvTest.TabIndex = 1;
            this.dgvTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTest_CellClick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(399, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 200);
            this.label1.TabIndex = 25;
            // 
            // txtDesc
            // 
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDesc.Location = new System.Drawing.Point(101, 3);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(583, 61);
            this.txtDesc.TabIndex = 0;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDesc.Location = new System.Drawing.Point(3, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(89, 20);
            this.lblDesc.TabIndex = 21;
            this.lblDesc.Text = "Description";
            // 
            // txtPassingMarks
            // 
            this.txtPassingMarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassingMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassingMarks.Location = new System.Drawing.Point(441, 57);
            this.txtPassingMarks.Name = "txtPassingMarks";
            this.txtPassingMarks.Size = new System.Drawing.Size(243, 26);
            this.txtPassingMarks.TabIndex = 9;
            // 
            // lblPassingMarks
            // 
            this.lblPassingMarks.AutoSize = true;
            this.lblPassingMarks.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPassingMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassingMarks.Location = new System.Drawing.Point(366, 54);
            this.lblPassingMarks.Name = "lblPassingMarks";
            this.lblPassingMarks.Size = new System.Drawing.Size(69, 55);
            this.lblPassingMarks.TabIndex = 15;
            this.lblPassingMarks.Text = "Passing Marks";
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTotalMarks.Location = new System.Drawing.Point(101, 57);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(244, 26);
            this.txtTotalMarks.TabIndex = 8;
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalMarks.Location = new System.Drawing.Point(4, 54);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(91, 55);
            this.lblTotalMarks.TabIndex = 13;
            this.lblTotalMarks.Text = "Total Marks";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSection.Location = new System.Drawing.Point(86, 100);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(63, 38);
            this.lblSection.TabIndex = 10;
            this.lblSection.Text = "Section";
            // 
            // cbxSection
            // 
            this.cbxSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxSection.FormattingEnabled = true;
            this.cbxSection.Location = new System.Drawing.Point(155, 103);
            this.cbxSection.Name = "cbxSection";
            this.cbxSection.Size = new System.Drawing.Size(238, 28);
            this.cbxSection.TabIndex = 1;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSubject.Location = new System.Drawing.Point(86, 138);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(63, 67);
            this.lblSubject.TabIndex = 8;
            this.lblSubject.Text = "Subject";
            // 
            // cbxSubject
            // 
            this.cbxSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(155, 141);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(238, 28);
            this.cbxSubject.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDate.Location = new System.Drawing.Point(391, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 54);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // dtpTest
            // 
            this.dtpTest.CustomFormat = "yyyy-MM-dd";
            this.dtpTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpTest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTest.Location = new System.Drawing.Point(441, 3);
            this.dtpTest.Name = "dtpTest";
            this.dtpTest.Size = new System.Drawing.Size(243, 26);
            this.dtpTest.TabIndex = 7;
            // 
            // txtTestName
            // 
            this.txtTestName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTestName.Location = new System.Drawing.Point(101, 3);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(244, 26);
            this.txtTestName.TabIndex = 6;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClass.Location = new System.Drawing.Point(101, 60);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(48, 40);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Class";
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTestName.Location = new System.Drawing.Point(9, 0);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(86, 54);
            this.lblTestName.TabIndex = 0;
            this.lblTestName.Text = "Test Name";
            // 
            // cbxClass
            // 
            this.cbxClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(155, 63);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(238, 28);
            this.cbxClass.TabIndex = 0;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxClass_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.42202F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.733945F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.93578F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1090, 264);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.63636F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.36364F));
            this.tableLayoutPanel2.Controls.Add(this.lblHeadingClasses, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnReset, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnView, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbxSubject, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblSubject, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbxSection, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblSection, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbxClass, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblClass, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.4375F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.625F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.84375F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.03773F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.50943F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(396, 264);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblHeadingClasses
            // 
            this.lblHeadingClasses.AutoSize = true;
            this.lblHeadingClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeadingClasses.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeadingClasses.Location = new System.Drawing.Point(5, 10);
            this.lblHeadingClasses.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.lblHeadingClasses.Name = "lblHeadingClasses";
            this.lblHeadingClasses.Size = new System.Drawing.Size(87, 31);
            this.lblHeadingClasses.TabIndex = 26;
            this.lblHeadingClasses.Text = "Tests";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.BackgroundColor = System.Drawing.Color.White;
            this.btnReset.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_RefreshLogo1;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 0;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(155, 208);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(44, 44);
            this.btnReset.TabIndex = 4;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.BackgroundColor = System.Drawing.Color.White;
            this.btnView.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_SearchLogo__2_;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnView.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnView.BorderRadius = 0;
            this.btnView.BorderSize = 0;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(105, 208);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(44, 44);
            this.btnView.TabIndex = 3;
            this.btnView.TextColor = System.Drawing.Color.White;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(403, 30);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.875F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.93617F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.25532F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(687, 234);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.btnDelete, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnInsert, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnUpdate, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnRefresh, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(473, 176);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(214, 58);
            this.tableLayoutPanel6.TabIndex = 2;
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
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(162, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_SaveLogo;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsert.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInsert.BorderRadius = 0;
            this.btnInsert.BorderSize = 0;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(3, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(44, 44);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_DetailsLogo;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(109, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(44, 44);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BackgroundColor = System.Drawing.Color.White;
            this.btnRefresh.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_RefreshLogo1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRefresh.BorderRadius = 0;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(56, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(44, 44);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.26492F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.73508F));
            this.tableLayoutPanel5.Controls.Add(this.lblDesc, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtDesc, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 109);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(687, 67);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.41048F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.53566F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.10044F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.95342F));
            this.tableLayoutPanel3.Controls.Add(this.lblTestName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtTestName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblDate, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpTest, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTotalMarks, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtTotalMarks, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtPassingMarks, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblPassingMarks, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(687, 109);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ColumnCount = 1;
            this.panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel1.Controls.Add(this.dgvTest, 0, 1);
            this.panel1.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.RowCount = 2;
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.91336F));
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.08664F));
            this.panel1.Size = new System.Drawing.Size(1090, 681);
            this.panel1.TabIndex = 0;
            // 
            // ctrlExamTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "ctrlExamTest";
            this.Size = new System.Drawing.Size(1090, 681);
            this.Load += new System.EventHandler(this.ExamTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtPassingMarks;
        private System.Windows.Forms.Label lblPassingMarks;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cbxSection;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbxSubject;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpTest;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CustomControls.SMSButtons btnReset;
        private CustomControls.SMSButtons btnView;
        private CustomControls.SMSButtons btnDelete;
        private CustomControls.SMSButtons btnUpdate;
        private CustomControls.SMSButtons btnRefresh;
        private CustomControls.SMSButtons btnInsert;
        private System.Windows.Forms.Label lblHeadingClasses;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel panel1;
    }
}
