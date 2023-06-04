namespace StudentWindowsApplication
{
    partial class ctrlCity
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
            this.txtRefresh = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.Button();
            this.dgvCities = new System.Windows.Forms.DataGridView();
            this.txtnewcity = new System.Windows.Forms.TextBox();
            this.lblNewCity = new System.Windows.Forms.Label();
            this.btnAddNewCity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRefresh
            // 
            this.txtRefresh.BackColor = System.Drawing.Color.White;
            this.txtRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefresh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRefresh.Location = new System.Drawing.Point(286, 86);
            this.txtRefresh.Name = "txtRefresh";
            this.txtRefresh.Size = new System.Drawing.Size(70, 21);
            this.txtRefresh.TabIndex = 11;
            this.txtRefresh.Text = "Refresh";
            this.txtRefresh.UseVisualStyleBackColor = false;
            this.txtRefresh.Click += new System.EventHandler(this.txtRefresh_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.BackColor = System.Drawing.Color.White;
            this.txtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDelete.Location = new System.Drawing.Point(216, 86);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(70, 21);
            this.txtDelete.TabIndex = 10;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = false;
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // dgvCities
            // 
            this.dgvCities.BackgroundColor = System.Drawing.Color.White;
            this.dgvCities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCities.Location = new System.Drawing.Point(3, 128);
            this.dgvCities.Name = "dgvCities";
            this.dgvCities.Size = new System.Drawing.Size(574, 281);
            this.dgvCities.TabIndex = 9;
            this.dgvCities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCities_CellContentClick);
            // 
            // txtnewcity
            // 
            this.txtnewcity.Location = new System.Drawing.Point(148, 56);
            this.txtnewcity.Name = "txtnewcity";
            this.txtnewcity.Size = new System.Drawing.Size(204, 20);
            this.txtnewcity.TabIndex = 8;
            // 
            // lblNewCity
            // 
            this.lblNewCity.AutoSize = true;
            this.lblNewCity.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNewCity.Location = new System.Drawing.Point(14, 11);
            this.lblNewCity.Name = "lblNewCity";
            this.lblNewCity.Size = new System.Drawing.Size(60, 24);
            this.lblNewCity.TabIndex = 7;
            this.lblNewCity.Text = "Cities";
            // 
            // btnAddNewCity
            // 
            this.btnAddNewCity.BackColor = System.Drawing.Color.White;
            this.btnAddNewCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddNewCity.Location = new System.Drawing.Point(146, 86);
            this.btnAddNewCity.Name = "btnAddNewCity";
            this.btnAddNewCity.Size = new System.Drawing.Size(70, 21);
            this.btnAddNewCity.TabIndex = 6;
            this.btnAddNewCity.Text = "Save";
            this.btnAddNewCity.UseVisualStyleBackColor = false;
            this.btnAddNewCity.Click += new System.EventHandler(this.btnAddNewCity_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 1);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(91, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // ctrlCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRefresh);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.dgvCities);
            this.Controls.Add(this.txtnewcity);
            this.Controls.Add(this.lblNewCity);
            this.Controls.Add(this.btnAddNewCity);
            this.Name = "ctrlCity";
            this.Size = new System.Drawing.Size(583, 414);
            this.Load += new System.EventHandler(this.ctrlCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtRefresh;
        private System.Windows.Forms.Button txtDelete;
        private System.Windows.Forms.DataGridView dgvCities;
        private System.Windows.Forms.TextBox txtnewcity;
        private System.Windows.Forms.Label lblNewCity;
        private System.Windows.Forms.Button btnAddNewCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
