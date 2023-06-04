namespace StudentWindowsApplication
{
    partial class ctrlInvoicePaidDetails
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeadingTotalRecieveables = new System.Windows.Forms.Label();
            this.lblHeadingTotalPaid = new System.Windows.Forms.Label();
            this.lblTotalRecieveables = new System.Windows.Forms.Label();
            this.lblTotalOutstandings = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.lblHeadingTotalOutstandings = new System.Windows.Forms.Label();
            this.PaymentHeading = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCollectFee = new StudentWindowsApplication.CustomControls.SMSButtons();
            this.btnClose = new StudentWindowsApplication.CustomControls.SMSButtons();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeSummary)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFeeSummary
            // 
            this.dgvFeeSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFeeSummary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFeeSummary.BackgroundColor = System.Drawing.Color.White;
            this.dgvFeeSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dgvFeeSummary.Location = new System.Drawing.Point(3, 60);
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
            this.dgvFeeSummary.Size = new System.Drawing.Size(724, 542);
            this.dgvFeeSummary.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.14286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.85714F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PaymentHeading, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvFeeSummary, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.51586F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.48414F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1056, 605);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tableLayoutPanel4.Controls.Add(this.lblHeadingTotalOutstandings, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(733, 60);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(320, 108);
            this.tableLayoutPanel4.TabIndex = 85;
            // 
            // lblHeadingTotalRecieveables
            // 
            this.lblHeadingTotalRecieveables.AutoSize = true;
            this.lblHeadingTotalRecieveables.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHeadingTotalRecieveables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHeadingTotalRecieveables.Location = new System.Drawing.Point(15, 0);
            this.lblHeadingTotalRecieveables.Name = "lblHeadingTotalRecieveables";
            this.lblHeadingTotalRecieveables.Size = new System.Drawing.Size(142, 36);
            this.lblHeadingTotalRecieveables.TabIndex = 69;
            this.lblHeadingTotalRecieveables.Text = "Total Recievables :";
            // 
            // lblHeadingTotalPaid
            // 
            this.lblHeadingTotalPaid.AutoSize = true;
            this.lblHeadingTotalPaid.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHeadingTotalPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHeadingTotalPaid.Location = new System.Drawing.Point(70, 36);
            this.lblHeadingTotalPaid.Name = "lblHeadingTotalPaid";
            this.lblHeadingTotalPaid.Size = new System.Drawing.Size(87, 36);
            this.lblHeadingTotalPaid.TabIndex = 70;
            this.lblHeadingTotalPaid.Text = "Total Paid :";
            // 
            // lblTotalRecieveables
            // 
            this.lblTotalRecieveables.AutoSize = true;
            this.lblTotalRecieveables.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalRecieveables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalRecieveables.Location = new System.Drawing.Point(163, 0);
            this.lblTotalRecieveables.Name = "lblTotalRecieveables";
            this.lblTotalRecieveables.Size = new System.Drawing.Size(142, 36);
            this.lblTotalRecieveables.TabIndex = 72;
            this.lblTotalRecieveables.Text = "Total Recievables :";
            // 
            // lblTotalOutstandings
            // 
            this.lblTotalOutstandings.AutoSize = true;
            this.lblTotalOutstandings.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalOutstandings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalOutstandings.Location = new System.Drawing.Point(163, 72);
            this.lblTotalOutstandings.Name = "lblTotalOutstandings";
            this.lblTotalOutstandings.Size = new System.Drawing.Size(151, 36);
            this.lblTotalOutstandings.TabIndex = 74;
            this.lblTotalOutstandings.Text = "Total Outstandings :";
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalPaid.Location = new System.Drawing.Point(163, 36);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(87, 36);
            this.lblTotalPaid.TabIndex = 73;
            this.lblTotalPaid.Text = "Total Paid :";
            // 
            // lblHeadingTotalOutstandings
            // 
            this.lblHeadingTotalOutstandings.AutoSize = true;
            this.lblHeadingTotalOutstandings.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHeadingTotalOutstandings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHeadingTotalOutstandings.Location = new System.Drawing.Point(6, 72);
            this.lblHeadingTotalOutstandings.Name = "lblHeadingTotalOutstandings";
            this.lblHeadingTotalOutstandings.Size = new System.Drawing.Size(151, 36);
            this.lblHeadingTotalOutstandings.TabIndex = 71;
            this.lblHeadingTotalOutstandings.Text = "Total Outstandings :";
            // 
            // PaymentHeading
            // 
            this.PaymentHeading.AutoSize = true;
            this.PaymentHeading.Dock = System.Windows.Forms.DockStyle.Left;
            this.PaymentHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.PaymentHeading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PaymentHeading.Location = new System.Drawing.Point(5, 10);
            this.PaymentHeading.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.PaymentHeading.Name = "PaymentHeading";
            this.PaymentHeading.Size = new System.Drawing.Size(275, 47);
            this.PaymentHeading.TabIndex = 72;
            this.PaymentHeading.Text = "Payment Summary :";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnCollectFee, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(807, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(246, 51);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnCollectFee
            // 
            this.btnCollectFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnCollectFee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnCollectFee.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCollectFee.BorderRadius = 0;
            this.btnCollectFee.BorderSize = 0;
            this.btnCollectFee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCollectFee.FlatAppearance.BorderSize = 0;
            this.btnCollectFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollectFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollectFee.ForeColor = System.Drawing.Color.White;
            this.btnCollectFee.Location = new System.Drawing.Point(3, 21);
            this.btnCollectFee.Name = "btnCollectFee";
            this.btnCollectFee.Size = new System.Drawing.Size(117, 27);
            this.btnCollectFee.TabIndex = 0;
            this.btnCollectFee.Text = "Settle Invoice";
            this.btnCollectFee.TextColor = System.Drawing.Color.White;
            this.btnCollectFee.UseVisualStyleBackColor = false;
            this.btnCollectFee.Click += new System.EventHandler(this.btnCollectFee_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(141)))));
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 0;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(126, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Back";
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlInvoicePaidDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ctrlInvoicePaidDetails";
            this.Size = new System.Drawing.Size(1056, 605);
            this.Load += new System.EventHandler(this.ctrlInvoicePaidDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeSummary)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFeeSummary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label PaymentHeading;
        private CustomControls.SMSButtons btnCollectFee;
        private CustomControls.SMSButtons btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblHeadingTotalRecieveables;
        private System.Windows.Forms.Label lblHeadingTotalPaid;
        private System.Windows.Forms.Label lblTotalRecieveables;
        private System.Windows.Forms.Label lblTotalOutstandings;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label lblHeadingTotalOutstandings;
    }
}
