namespace StudentWindowsApplication
{
    partial class ctrlFee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFeeSummary = new System.Windows.Forms.DataGridView();
            this.PaymentHeading = new System.Windows.Forms.Label();
            this.lblFeeName = new System.Windows.Forms.Label();
            this.lblMonthlyOutstandings = new System.Windows.Forms.Label();
            this.lblMonthlyPaid = new System.Windows.Forms.Label();
            this.lblMonthlyRecieveables = new System.Windows.Forms.Label();
            this.lblHeadingMonthlyOutstandings = new System.Windows.Forms.Label();
            this.lblHeadingMonthlyPaid = new System.Windows.Forms.Label();
            this.lblHeadingMonthlyRecieveables = new System.Windows.Forms.Label();
            this.lblTotalOutstandings = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.lblTotalRecieveables = new System.Windows.Forms.Label();
            this.lblHeadingTotalOutstandings = new System.Windows.Forms.Label();
            this.lblHeadingTotalPaid = new System.Windows.Forms.Label();
            this.lblHeadingTotalRecieveables = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnGntnInvc = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnRefresh = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnFeeCnfg = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnCollectFee = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeSummary)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFeeSummary
            // 
            this.dgvFeeSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFeeSummary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFeeSummary.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeeSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFeeSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFeeSummary.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFeeSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFeeSummary.Location = new System.Drawing.Point(3, 3);
            this.dgvFeeSummary.Name = "dgvFeeSummary";
            this.dgvFeeSummary.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeeSummary.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFeeSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeeSummary.Size = new System.Drawing.Size(698, 530);
            this.dgvFeeSummary.TabIndex = 0;
            this.dgvFeeSummary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeeSummary_CellClick);
            // 
            // PaymentHeading
            // 
            this.PaymentHeading.AutoSize = true;
            this.PaymentHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaymentHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.PaymentHeading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PaymentHeading.Location = new System.Drawing.Point(5, 10);
            this.PaymentHeading.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.PaymentHeading.Name = "PaymentHeading";
            this.PaymentHeading.Size = new System.Drawing.Size(690, 51);
            this.PaymentHeading.TabIndex = 62;
            this.PaymentHeading.Text = "Payment Summary :";
            // 
            // lblFeeName
            // 
            this.lblFeeName.AutoSize = true;
            this.lblFeeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFeeName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFeeName.Location = new System.Drawing.Point(5, 71);
            this.lblFeeName.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.lblFeeName.Name = "lblFeeName";
            this.lblFeeName.Size = new System.Drawing.Size(690, 39);
            this.lblFeeName.TabIndex = 64;
            this.lblFeeName.Text = "StudentName";
            // 
            // lblMonthlyOutstandings
            // 
            this.lblMonthlyOutstandings.AutoSize = true;
            this.lblMonthlyOutstandings.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMonthlyOutstandings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMonthlyOutstandings.Location = new System.Drawing.Point(162, 258);
            this.lblMonthlyOutstandings.Name = "lblMonthlyOutstandings";
            this.lblMonthlyOutstandings.Size = new System.Drawing.Size(151, 43);
            this.lblMonthlyOutstandings.TabIndex = 80;
            this.lblMonthlyOutstandings.Text = "Total Outstandings :";
            // 
            // lblMonthlyPaid
            // 
            this.lblMonthlyPaid.AutoSize = true;
            this.lblMonthlyPaid.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMonthlyPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMonthlyPaid.Location = new System.Drawing.Point(162, 215);
            this.lblMonthlyPaid.Name = "lblMonthlyPaid";
            this.lblMonthlyPaid.Size = new System.Drawing.Size(87, 43);
            this.lblMonthlyPaid.TabIndex = 79;
            this.lblMonthlyPaid.Text = "Total Paid :";
            // 
            // lblMonthlyRecieveables
            // 
            this.lblMonthlyRecieveables.AutoSize = true;
            this.lblMonthlyRecieveables.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMonthlyRecieveables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMonthlyRecieveables.Location = new System.Drawing.Point(162, 172);
            this.lblMonthlyRecieveables.Name = "lblMonthlyRecieveables";
            this.lblMonthlyRecieveables.Size = new System.Drawing.Size(142, 43);
            this.lblMonthlyRecieveables.TabIndex = 78;
            this.lblMonthlyRecieveables.Text = "Total Recievables :";
            // 
            // lblHeadingMonthlyOutstandings
            // 
            this.lblHeadingMonthlyOutstandings.AutoSize = true;
            this.lblHeadingMonthlyOutstandings.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHeadingMonthlyOutstandings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHeadingMonthlyOutstandings.Location = new System.Drawing.Point(44, 258);
            this.lblHeadingMonthlyOutstandings.Name = "lblHeadingMonthlyOutstandings";
            this.lblHeadingMonthlyOutstandings.Size = new System.Drawing.Size(112, 43);
            this.lblHeadingMonthlyOutstandings.TabIndex = 77;
            this.lblHeadingMonthlyOutstandings.Text = "Outstandings :";
            // 
            // lblHeadingMonthlyPaid
            // 
            this.lblHeadingMonthlyPaid.AutoSize = true;
            this.lblHeadingMonthlyPaid.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHeadingMonthlyPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHeadingMonthlyPaid.Location = new System.Drawing.Point(108, 215);
            this.lblHeadingMonthlyPaid.Name = "lblHeadingMonthlyPaid";
            this.lblHeadingMonthlyPaid.Size = new System.Drawing.Size(48, 43);
            this.lblHeadingMonthlyPaid.TabIndex = 76;
            this.lblHeadingMonthlyPaid.Text = "Paid :";
            // 
            // lblHeadingMonthlyRecieveables
            // 
            this.lblHeadingMonthlyRecieveables.AutoSize = true;
            this.lblHeadingMonthlyRecieveables.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHeadingMonthlyRecieveables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHeadingMonthlyRecieveables.Location = new System.Drawing.Point(53, 172);
            this.lblHeadingMonthlyRecieveables.Name = "lblHeadingMonthlyRecieveables";
            this.lblHeadingMonthlyRecieveables.Size = new System.Drawing.Size(103, 43);
            this.lblHeadingMonthlyRecieveables.TabIndex = 75;
            this.lblHeadingMonthlyRecieveables.Text = "Monthly Recievables :";
            // 
            // lblTotalOutstandings
            // 
            this.lblTotalOutstandings.AutoSize = true;
            this.lblTotalOutstandings.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalOutstandings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalOutstandings.Location = new System.Drawing.Point(162, 86);
            this.lblTotalOutstandings.Name = "lblTotalOutstandings";
            this.lblTotalOutstandings.Size = new System.Drawing.Size(151, 43);
            this.lblTotalOutstandings.TabIndex = 74;
            this.lblTotalOutstandings.Text = "Total Outstandings :";
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalPaid.Location = new System.Drawing.Point(162, 43);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(87, 43);
            this.lblTotalPaid.TabIndex = 73;
            this.lblTotalPaid.Text = "Total Paid :";
            // 
            // lblTotalRecieveables
            // 
            this.lblTotalRecieveables.AutoSize = true;
            this.lblTotalRecieveables.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalRecieveables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalRecieveables.Location = new System.Drawing.Point(162, 0);
            this.lblTotalRecieveables.Name = "lblTotalRecieveables";
            this.lblTotalRecieveables.Size = new System.Drawing.Size(142, 43);
            this.lblTotalRecieveables.TabIndex = 72;
            this.lblTotalRecieveables.Text = "Total Recievables :";
            // 
            // lblHeadingTotalOutstandings
            // 
            this.lblHeadingTotalOutstandings.AutoSize = true;
            this.lblHeadingTotalOutstandings.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHeadingTotalOutstandings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHeadingTotalOutstandings.Location = new System.Drawing.Point(5, 86);
            this.lblHeadingTotalOutstandings.Name = "lblHeadingTotalOutstandings";
            this.lblHeadingTotalOutstandings.Size = new System.Drawing.Size(151, 43);
            this.lblHeadingTotalOutstandings.TabIndex = 71;
            this.lblHeadingTotalOutstandings.Text = "Total Outstandings :";
            // 
            // lblHeadingTotalPaid
            // 
            this.lblHeadingTotalPaid.AutoSize = true;
            this.lblHeadingTotalPaid.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHeadingTotalPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHeadingTotalPaid.Location = new System.Drawing.Point(69, 43);
            this.lblHeadingTotalPaid.Name = "lblHeadingTotalPaid";
            this.lblHeadingTotalPaid.Size = new System.Drawing.Size(87, 43);
            this.lblHeadingTotalPaid.TabIndex = 70;
            this.lblHeadingTotalPaid.Text = "Total Paid :";
            // 
            // lblHeadingTotalRecieveables
            // 
            this.lblHeadingTotalRecieveables.AutoSize = true;
            this.lblHeadingTotalRecieveables.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHeadingTotalRecieveables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHeadingTotalRecieveables.Location = new System.Drawing.Point(14, 0);
            this.lblHeadingTotalRecieveables.Name = "lblHeadingTotalRecieveables";
            this.lblHeadingTotalRecieveables.Size = new System.Drawing.Size(142, 43);
            this.lblHeadingTotalRecieveables.TabIndex = 69;
            this.lblHeadingTotalRecieveables.Text = "Total Recievables :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.79141F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.20859F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1029, 652);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.2307F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.14369F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.36168F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.26393F));
            this.tableLayoutPanel2.Controls.Add(this.PaymentHeading, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClose, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGntnInvc, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblFeeName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnRefresh, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFeeCnfg, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCollectFee, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.09756F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.90244F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1023, 110);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::StudentWindowsApplication.Properties.Resources.IHT_CloseLogo1;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(919, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGntnInvc
            // 
            this.btnGntnInvc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnGntnInvc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnGntnInvc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGntnInvc.BorderRadius = 0;
            this.btnGntnInvc.BorderSize = 0;
            this.btnGntnInvc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGntnInvc.FlatAppearance.BorderSize = 0;
            this.btnGntnInvc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGntnInvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnGntnInvc.ForeColor = System.Drawing.Color.White;
            this.btnGntnInvc.Location = new System.Drawing.Point(919, 64);
            this.btnGntnInvc.Name = "btnGntnInvc";
            this.btnGntnInvc.Size = new System.Drawing.Size(101, 42);
            this.btnGntnInvc.TabIndex = 4;
            this.btnGntnInvc.Text = "Generate Invoice";
            this.btnGntnInvc.TextColor = System.Drawing.Color.White;
            this.btnGntnInvc.UseVisualStyleBackColor = false;
            this.btnGntnInvc.Click += new System.EventHandler(this.btnGntnInvc_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnRefresh.Location = new System.Drawing.Point(869, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(44, 44);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFeeCnfg
            // 
            this.btnFeeCnfg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnFeeCnfg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnFeeCnfg.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFeeCnfg.BorderRadius = 0;
            this.btnFeeCnfg.BorderSize = 0;
            this.btnFeeCnfg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFeeCnfg.FlatAppearance.BorderSize = 0;
            this.btnFeeCnfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeeCnfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeeCnfg.ForeColor = System.Drawing.Color.White;
            this.btnFeeCnfg.Location = new System.Drawing.Point(814, 64);
            this.btnFeeCnfg.Name = "btnFeeCnfg";
            this.btnFeeCnfg.Size = new System.Drawing.Size(99, 42);
            this.btnFeeCnfg.TabIndex = 3;
            this.btnFeeCnfg.Text = "Configure Fee";
            this.btnFeeCnfg.TextColor = System.Drawing.Color.White;
            this.btnFeeCnfg.UseVisualStyleBackColor = false;
            this.btnFeeCnfg.Click += new System.EventHandler(this.btnFeeCnfg_Click);
            // 
            // btnCollectFee
            // 
            this.btnCollectFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnCollectFee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnCollectFee.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCollectFee.BorderRadius = 0;
            this.btnCollectFee.BorderSize = 0;
            this.btnCollectFee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCollectFee.FlatAppearance.BorderSize = 0;
            this.btnCollectFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollectFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollectFee.ForeColor = System.Drawing.Color.White;
            this.btnCollectFee.Location = new System.Drawing.Point(701, 64);
            this.btnCollectFee.Name = "btnCollectFee";
            this.btnCollectFee.Size = new System.Drawing.Size(107, 42);
            this.btnCollectFee.TabIndex = 2;
            this.btnCollectFee.Text = "Collect Fee";
            this.btnCollectFee.TextColor = System.Drawing.Color.White;
            this.btnCollectFee.UseVisualStyleBackColor = false;
            this.btnCollectFee.Click += new System.EventHandler(this.btnCollectFee_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.41594F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.58406F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgvFeeSummary, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 116);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1029, 536);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lblHeadingTotalRecieveables, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblHeadingTotalPaid, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblTotalRecieveables, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTotalOutstandings, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblTotalPaid, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblMonthlyOutstandings, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.lblHeadingTotalOutstandings, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblMonthlyPaid, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.lblHeadingMonthlyRecieveables, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.lblMonthlyRecieveables, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.lblHeadingMonthlyPaid, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.lblHeadingMonthlyOutstandings, 0, 6);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(707, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(318, 301);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // ctrlFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ctrlFee";
            this.Size = new System.Drawing.Size(1029, 652);
            this.Load += new System.EventHandler(this.ctrlFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeSummary)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFeeSummary;
        private System.Windows.Forms.Label PaymentHeading;
        private System.Windows.Forms.Label lblFeeName;
        private System.Windows.Forms.Label lblHeadingTotalRecieveables;
        private System.Windows.Forms.Label lblMonthlyOutstandings;
        private System.Windows.Forms.Label lblMonthlyPaid;
        private System.Windows.Forms.Label lblMonthlyRecieveables;
        private System.Windows.Forms.Label lblHeadingMonthlyOutstandings;
        private System.Windows.Forms.Label lblHeadingMonthlyPaid;
        private System.Windows.Forms.Label lblHeadingMonthlyRecieveables;
        private System.Windows.Forms.Label lblTotalOutstandings;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label lblTotalRecieveables;
        private System.Windows.Forms.Label lblHeadingTotalOutstandings;
        private System.Windows.Forms.Label lblHeadingTotalPaid;
        private CustomControls.SMSButtons btnCollectFee;
        private CustomControls.SMSButtons btnRefresh;
        private CustomControls.SMSButtons btnFeeCnfg;
        private CustomControls.SMSButtons btnClose;
        private CustomControls.SMSButtons btnGntnInvc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}
