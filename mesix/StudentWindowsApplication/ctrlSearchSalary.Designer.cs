namespace StudentWindowsApplication
{
    partial class ctrlSearchSalary
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
            this.dgvSearchedEmployees = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchedEmployees)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSearchedEmployees
            // 
            this.dgvSearchedEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchedEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSearchedEmployees.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchedEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearchedEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchedEmployees.Cursor = System.Windows.Forms.Cursors.PanNW;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearchedEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearchedEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchedEmployees.Location = new System.Drawing.Point(3, 99);
            this.dgvSearchedEmployees.Name = "dgvSearchedEmployees";
            this.dgvSearchedEmployees.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchedEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearchedEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchedEmployees.Size = new System.Drawing.Size(904, 513);
            this.dgvSearchedEmployees.TabIndex = 1;
            this.dgvSearchedEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchedEmployees_CellClick);
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(70, 5);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(8, 5, 8, 0);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(832, 26);
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
            this.pnlSearch.Controls.Add(this.dgvSearchedEmployees, 0, 2);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.RowCount = 3;
            this.pnlSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.496732F));
            this.pnlSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.189542F));
            this.pnlSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.31373F));
            this.pnlSearch.Size = new System.Drawing.Size(910, 615);
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
            this.label3.Size = new System.Drawing.Size(232, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "Search Employees";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.813187F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.18681F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtsearch, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(910, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(8, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // ctrlSearchSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSearch);
            this.Name = "ctrlSearchSalary";
            this.Size = new System.Drawing.Size(910, 615);
            this.Load += new System.EventHandler(this.ctrlSearchFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchedEmployees)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSearchedEmployees;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TableLayoutPanel pnlSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
    }
}
