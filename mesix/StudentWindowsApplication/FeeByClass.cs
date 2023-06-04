using DAL;
using DataTransferObjects;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class FeeByClass : Form
    {
        public FeeByClass()
        {
            InitializeComponent();
        }
        Student s;
        public FeeByClass(Student _s, bool setByClass)
        {
            InitializeComponent();
            s = new Student();
            s = _s;
            //this.StudentID = s.stdID;
            this.SetByClass = setByClass;
            //this.classid=s.ClassId;
            //this.Roll = s.Roll;
            //this.SName = "Implement - It";
        }
        public int ID;
        public string SName;
        public int StudentID;
        public int Roll;
        public bool SetByClass;
        public bool escapeSelectedIndexChangeEvent { get; set; }
        public int classid { get; set; }
        private void FeeByClass_Load(object sender, EventArgs e)
        {
            if (!this.SetByClass)
            {
                GetFormDataForStudent();
                btnDelete.Visible = false;
                txtName.Text = this.s.Name;
                txtRoll.Text = this.s.Roll.ToString();
                txtName.Enabled = false;
                txtRoll.Enabled = false;
                cbxClass.SelectedValue = this.s.ClassId;
                cbxClass.Enabled = false;
                //btnInsert.Text = "Submit";
            }
            else
            {
                btnDelete.Visible = false;
                GetFormDataForClass();
                lblName.Visible = false;
                txtName.Visible = false;
                lblRoll.Visible = false;
                txtRoll.Visible = false;
            }
            this.CenterToScreen();
        }
        private void GetFormDataForStudent()
        {
            GetcbxClasses();
            RefreshFormControls();
            UpdateDGVForStudent();
        }
        private void GetFormDataForClass()
        {
            GetcbxClasses();
            RefreshFormControls();
            UpdateDGVForClass();
        }
        private void UpdateDGVForStudent()
        {
            FeeDAL fdal = new FeeDAL();
            dgvClassFeeCnfg.DataSource = fdal.GetFeeCnfg(this.s.stdID);
            this.dgvClassFeeCnfg.Columns["FeeCnfgID"].Visible = false;
            this.dgvClassFeeCnfg.Columns["StudentID"].Visible = false;
        }
        private void UpdateDGVForClass()
        {
            FeeDAL fdal = new FeeDAL();
            dgvClassFeeCnfg.DataSource = fdal.GetClassFeeCnfg();
            this.dgvClassFeeCnfg.Columns["ClassFeeCnfgID"].Visible = false;
            this.dgvClassFeeCnfg.Columns["ClassID"].Visible = false;
            this.dgvClassFeeCnfg.Columns["Status"].Visible = false;
        }
        private void GetcbxClasses()
        {
            ClassDAL cdal = new ClassDAL();
            escapeSelectedIndexChangeEvent = true;
            cbxClass.DataSource = cdal.GetClasses();
            cbxClass.DisplayMember = "CName";
            cbxClass.ValueMember = "Id";
            cbxClass.SelectedIndex = -1;
            escapeSelectedIndexChangeEvent = false;
        }
        private void RefreshFormControls()
        {
            dgvClassFeeCnfg.DataSource = null;
            cbxClass.SelectedIndex = -1;
            txtFeeAmount.Text = null;
            this.ID = 0;
            txtName.Focus();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (SetByClass)
                {
                    this.ID = 0;
                    ClassFeeCnfg classFeeCnfg = new ClassFeeCnfg();
                    classFeeCnfg.ClassID = (int)cbxClass.SelectedValue;
                    classFeeCnfg.FeeAmount = Convert.ToDecimal(txtFeeAmount.Text);

                    FeeDAL fDal = new FeeDAL();
                    fDal.InsertClassFeeCnfg(classFeeCnfg);

                    GetFormDataForClass();
                }
                else
                {
                    this.ID = 0;
                    FeeCnfg feeCnfg = new FeeCnfg();
                    feeCnfg.StudentID = this.s.stdID;
                    feeCnfg.Amount = Convert.ToDecimal(txtFeeAmount.Text);
                    feeCnfg.Status = true;

                    FeeDAL fDal = new FeeDAL();
                    fDal.InsertFeeCnfg(feeCnfg);
                    //Generate Invoice for currentMonth
                    txtFeeAmount.Text = String.Empty;
                    UpdateDGVForStudent();
                }
            }
        }
        private bool IsValid()
        {
            if (txtFeeAmount.Text == null || txtFeeAmount.Text == String.Empty)
            {
                MessageBox.Show("Fee Amount cant be empty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Convert.ToInt32(cbxClass.SelectedValue.ToString()) == -1 || Convert.ToInt32(cbxClass.SelectedValue) < 1)
            {
                MessageBox.Show("Class cant be empty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                FeeDAL fdal = new FeeDAL();
                fdal.DeleteClassFeeCnfg(ID);

                GetFormDataForClass();
            }
            else
            {
                MessageBox.Show("please Select Atleast One Row", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClassFeeCnfg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (SetByClass)
            //{

            //    if (dgvClassFeeCnfg.SelectedRows.Count > 0)
            //    {
            //        ID = Convert.ToInt32(dgvClassFeeCnfg.SelectedRows[0].Cells["ClassFeeCnfgID"].Value);
            //    }
            //}
        }
    }
}
