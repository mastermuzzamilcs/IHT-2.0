using DAL;
using DataTransferObjects;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlClass : UserControl
    {
        public ctrlClass()
        {
            InitializeComponent();
        }
        private static ctrlClass _instance;
        public static ctrlClass Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrlClass();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new ctrlClass();
        }
        public int id;

        #region Events


        public int ID;
        public bool escapeSelectedIndexChangeEvent { get; set; }

        private void ctrlClass_Load(object sender, EventArgs e)
        {
            //GetcbxTeachers();
            RefreshFormControls();
            this.btnView.Visible = false;
            this.btnUpdate.Visible = false;
            //this.btnRefresh.Visible = false;
            //btnInsert.Text = "Save";
            txtClassName.Focus();
        }
        private void GetcbxTeachers()
        {
            EmployeeClass cdal = new EmployeeClass();
            escapeSelectedIndexChangeEvent = true;
            //cbxTeacherName.DataSource = cdal.GetTeachers();
            //cbxTeacherName.DisplayMember = "empName";
            //cbxTeacherName.ValueMember = "ID";
            //cbxTeacherName.SelectedIndex = -1;
            //escapeSelectedIndexChangeEvent = false;

            RefreshFormControls();
        }
        private void RefreshFormControls()
        {
            dgvClass.DataSource = null;
            //cbxTeacherName.SelectedIndex = -1;
            txtClassName.Text = null;
            ClassDAL cDal = new ClassDAL();
            dgvClass.DataSource = cDal.GetClasses();
            if (dgvClass.DataSource != null)
            {
                dgvClass.Columns["Id"].Visible = false;
            dgvClass.Columns["TID"].Visible = false;
            dgvClass.Columns["ClassFee"].Visible = false;
            dgvClass.Columns["CName"].HeaderText = "Class Name";

            }
            this.id = 0;
            //txtClassFee.Text = null;
        }
        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #region Other commented Helper Methods
        //private void RefreshClass()
        //{
        //    txtAddClass.Clear();
        //}
        //private bool CheckValidity()
        //{
        //    if (txtAddClass.Text == "")
        //    {
        //        MessageBox.Show("Please Add some Data");
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}


        //private void txtClassFee_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    int fee;
        //    if (!int.TryParse(txtClassFee.Text, out fee))
        //    {
        //        txtClassFee.Text = string.Empty;
        //    }

        //}

        //private void txtClassFee_KeyUp(object sender, KeyEventArgs e)
        //{
        //    int fee;
        //    if (!int.TryParse(txtClassFee.Text, out fee))
        //    {
        //        txtClassFee.Text = string.Empty;
        //    }
        //}
        #endregion

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            RefreshFormControls();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //Remove it - implement classname value change search 

            //ClassDAL Cdal = new ClassDAL();
            //if (cbxTeacherName.SelectedIndex < 0)
            //{
            //dgvClass.DataSource = Cdal.GetClasses();
            ////this.dgvClass.Columns["Tid"].Visible = false;
            //this.dgvClass.Columns["Id"].Visible = false;
            //}
            //else
            //{
            //    int TID = (int)cbxTeacherName.SelectedValue;
            //    dgvClass.DataSource = Cdal.GetClasses(TID);
            //     = c;
            //    //this.dgvClass.Columns["Tid"].Visible = false;
            //    this.dgvClass.Columns["ClassId"].Visible = false;
            //}

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (id > 0)
                {
                    SchoolClass s = new SchoolClass();
                    //s.TID = (int)cbxTeacherName.SelectedValue;
                    s.CName = txtClassName.Text;
                    //s.ClassFee = Convert.ToInt32(txtClassFee.Text);

                    ClassDAL cdal = new ClassDAL();
                    cdal.UpdateClass(s, id);
                    RefreshFormControls();
                }
                else
                {
                    this.id = 0;
                    SchoolClass c = new SchoolClass();
                    //c.TID = (int)cbxTeacherName.SelectedValue;
                    c.CName = txtClassName.Text;
                    //c.ClassFee = Convert.ToInt32(txtClassFee.Text);

                    ClassDAL cdal = new ClassDAL();
                    cdal.InsertClass(c);

                    GetcbxTeachers();
                }
            }
        }
        private bool IsValid()
        {
            if (txtClassName.Text == null || txtClassName.Text == String.Empty)
            {
                MessageBox.Show("Can't Accept Empty Fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (this.id > 0)
            {
                ClassDAL ctdal = new ClassDAL();
                ctdal.UpdateClass(this.id);

                GetcbxTeachers();
            }
            else
            {
                MessageBox.Show("please Select Atleast One Row", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshFormControls();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                SchoolClass s = new SchoolClass();
                //s.TID = (int)cbxTeacherName.SelectedValue;
                s.CName = txtClassName.Text;
                //s.ClassFee = Convert.ToInt32(txtClassFee.Text);

                ClassDAL cdal = new ClassDAL();
                cdal.UpdateClass(s, id);
                RefreshFormControls();
            }
            else
            {
                MessageBox.Show("please Select Atleast One Row", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClass.SelectedRows.Count > 0)
            {
                this.id = Convert.ToInt32(dgvClass.SelectedRows[0].Cells["Id"].Value);
                txtClassName.Text = dgvClass.SelectedRows[0].Cells["CName"].Value.ToString();
                //cbxTeacherName.SelectedValue = Convert.ToInt32(dgvClass.SelectedRows[0].Cells[0].Value);
                //txtClassFee.Text = dgvClass.SelectedRows[0].Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
        }
    }
}
