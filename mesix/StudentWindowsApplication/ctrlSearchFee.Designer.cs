namespace StudentWindowsApplication
{
    partial class ctrlSearchFee
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
            this.dgvSearchedStudents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchedStudents)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSearchedStudents
            // 
            this.dgvSearchedStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchedStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSearchedStudents.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchedStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearchedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchedStudents.Cursor = System.Windows.Forms.Cursors.PanNW;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearchedStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearchedStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchedStudents.Location = new System.Drawing.Point(3, 99);
            this.dgvSearchedStudents.Name = "dgvSearchedStudents";
            this.dgvSearchedStudents.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchedStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearchedStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchedStudents.Size = new System.Drawing.Size(966, 540);
            this.dgvSearchedStudents.TabIndex = 1;
            this.dgvSearchedStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchedStudents_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name / Roll Number";
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtsearch.Location = new System.Drawing.Point(173, 5);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(8, 5, 8, 0);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(791, 26);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.ColumnCount = 1;
            this.pnlSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSearch.Controls.Add(this.label3, 0, 0);
            this.pnlSearch.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.pnlSearch.Controls.Add(this.dgvSearchedStudents, 0, 2);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.RowCount = 3;
            this.pnlSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.pnlSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.761006F));
            this.pnlSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.90566F));
            this.pnlSearch.Size = new System.Drawing.Size(972, 642);
            this.pnlSearch.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search Students";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.97531F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.02469F));
            this.tableLayoutPanel2.Controls.Add(this.txtsearch, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(972, 43);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ctrlSearchFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSearch);
            this.Name = "ctrlSearchFee";
            this.Size = new System.Drawing.Size(972, 642);
            this.Load += new System.EventHandler(this.ctrlSearchFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchedStudents)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSearchedStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TableLayoutPanel pnlSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
    }
}
