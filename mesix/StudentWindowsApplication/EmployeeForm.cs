using DAL;
using DataTransferObjects;
using DataTransferObjects.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            this._e = new EmployeeProp();
            //this._e.ClassId = 0;
            this.isNew = true;
            InitializeComponent();
        }
        public EmployeeForm(int _id)
        {
            this._e = new EmployeeProp();
            //this._e.ClassId = 0;
            this.ID = _id;
            this.isNew = false;
            InitializeComponent();
        }
        public EmployeeProp _e;
        public bool isNew;
        public int ID { get; set; }
        private void Employee_Load(object sender, EventArgs e)
        {
            GetEmployeeRecords();
            btnRefresh.Visible = false;
            btnUpdate.Visible = false;
            btnEdit.Visible = false;
            btnBrowse.Visible = false;
            btnSetSalary.Visible = false;
            lblSalary.Visible = false;
            txtSalary.Visible = false;
            if (isNew)
            {
                btnDelete.Visible = false;
                var savepos = tableLayoutPanel2.GetColumn(btnInsert);
                var deletepos = tableLayoutPanel2.GetColumn(btnDelete);
                tableLayoutPanel2.SetColumn(btnDelete, savepos);
                tableLayoutPanel2.SetColumn(btnInsert, deletepos);
            }
            lblEmail.Visible = false;
            txtEmail.Visible = false;
            lblEmpId.Visible = false;
            txtEmpId.Visible = false;
            lblUserName.Visible = false;
            txtUserName.Visible = false;
            lblCity.Visible = false;
            cbxCity.Visible = false;
            lblViewHeadingEmail.Visible = false;
            lblViewEmail.Visible = false;
            btnInsert.Text = "Save";
        }
        private void GetEmployeeRecords()
        {
            //EmployeeClass emp = new EmployeeClass();

            //CityDAL citydal = new CityDAL();
            //List<Cities> city1 = citydal.GetCities();
            //cbxCity.DataSource = city1;
            //cbxCity.DisplayMember = "CityName";
            //cbxCity.ValueMember = "Id";

            EmployeeClass Emp = new EmployeeClass();
            List<EmpTag> Tags = Emp.GetTags();
            cbxTag.DataSource = Tags;
            cbxTag.DisplayMember = "TagName";
            cbxTag.ValueMember = "Id";

            txtFirstName.Focus();

            RefreshFormControls();
            if (ID > 0)
            {
                //btnInsert.Enabled = false;
                //btnUpdate.Enabled = true;

                //EmployeeClass FetchViewData = new EmployeeClass();
                //EmployeeProp FetchedData = new EmployeeProp();
                this._e = Emp.GetEmployeeInfo(ID);

                txtFirstName.Text = _e.FirstName;
                txtLastName.Text = _e.LastName;
                txtCNIC.Text = Convert.ToString(_e.CNIC);
                cbxBloodGroup.SelectedIndex = _e.BloodID - 1;
                //txtEmail.Text = FetchedData.Email;
                txtSalary.Text = Convert.ToString(_e.Salary);
                cbxGend.SelectedIndex = _e.GenderID - 1;
                txtDept.Text = _e.Dept;
                txtQualification.Text = _e.Qualification;
                //txtEmpId.Text = Convert.ToString(FetchedData.EmpId);
                datepickerDOB.Value = _e.DOB;
                //cbxCity.SelectedValue = FetchedData.City;
                txtphone.Text = Convert.ToString(_e.Phone);
                cbxTag.SelectedValue = _e.Tag;
                txtAddress.Text = _e.Address;
                txtDesc.Text = _e.Desc;
                isActive.Checked = Convert.ToBoolean(_e.isActive);
                //if (File.Exists(ConfigurationManager.AppSettings["ImageEmployeeDir"] + FetchedData.PictureName))
                //{
                //    PicForUpdate.Image = Image.FromFile(ConfigurationManager.AppSettings["ImageEmployeeDir"] + FetchedData.PictureName);
                //    PicForUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
                //}









                //EmployeeClass FetchViewData = new EmployeeClass();
                //EmployeeView FetchedData = new EmployeeView();
                //FetchedData = FetchViewData.ViewEmployeeInfo(ID);

                lblViewName.Text = _e.FirstName + " " + _e.LastName;
                lblViewTag.Text = _e.Title.ToString();
                lblViewCNIC.Text = _e.CNIC.ToString();
                lblViewPhone.Text = _e.Phone.ToString();
                lblViewDOB.Text = _e.DOB.ToShortDateString().ToString();
                lblViewEmail.Text = _e.Email;
                txtSalary.Visible = false;
                lblSalary.Visible = false;
                //if (File.Exists(ConfigurationManager.AppSettings["ImageEmployeeDir"] + FetchedData.PictureName))
                //{
                //    picViewImage.Image = Image.FromFile(ConfigurationManager.AppSettings["ImageEmployeeDir"] + FetchedData.PictureName);
                //    picViewImage.SizeMode = PictureBoxSizeMode.StretchImage;
                //}
            }
        }
        private void RefreshFormControls()
        {
            //btnInsert.Enabled = true;
            //btnUpdate.Enabled = false;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCNIC.Clear();
            cbxBloodGroup.SelectedIndex = -1;
            //txtEmail.Clear();
            txtSalary.Clear();
            cbxGend.SelectedIndex = -1;
            txtDept.Clear();
            txtQualification.Clear();
            //txtEmpId.Clear();
            datepickerDOB.Text = string.Empty;
            //cbxCity.SelectedIndex = -1;
            txtphone.Clear();
            cbxTag.SelectedIndex = -1;
            txtAddress.Clear();
            txtDesc.Clear();
            //PicForUpdate.Image = null;
            isActive.Checked = false;

            txtFirstName.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EditPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    Bitmap bit = new Bitmap(ofd.FileName);
            //    PicForUpdate.Image = bit;
            //    PicForUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
            //    picViewImage.Image = bit;
            //    picViewImage.SizeMode = PictureBoxSizeMode.StretchImage;
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //btnInsert.Enabled = false;
            //btnUpdate.Enabled = true;

            //EmployeeClass FetchViewData = new EmployeeClass();
            //EmployeeProp FetchedData = new EmployeeProp();
            //FetchedData = FetchViewData.GetEmployeeInfo(ID);

            //txtFirstName.Text = FetchedData.FirstName;
            //txtLastName.Text = FetchedData.LastName;
            //txtCNIC.Text = Convert.ToString(FetchedData.CNIC);
            //cbxBloodGroup.Text = FetchedData.BloodGroup;
            ////txtEmail.Text = FetchedData.Email;
            //txtSalary.Text = Convert.ToString(FetchedData.Salary);
            //cbxGend.Text = FetchedData.Gender;
            //txtDept.Text = FetchedData.Dept;
            //txtQualification.Text = FetchedData.Qualification;
            ////txtEmpId.Text = Convert.ToString(FetchedData.EmpId);
            //datepickerDOB.Value = FetchedData.DOB;
            ////cbxCity.SelectedValue = FetchedData.City;
            //txtphone.Text = Convert.ToString(FetchedData.Phone);
            //cbxTag.SelectedValue = FetchedData.Tag;
            //txtAddress.Text = FetchedData.Address;
            //txtDesc.Text = FetchedData.Desc;
            //isActive.Checked = Convert.ToBoolean(FetchedData.isActive);
            //if (File.Exists(ConfigurationManager.AppSettings["ImageEmployeeDir"] + FetchedData.PictureName))
            //{
            //    PicForUpdate.Image = Image.FromFile(ConfigurationManager.AppSettings["ImageEmployeeDir"] + FetchedData.PictureName);
            //    PicForUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
            //}
        }
        private void AddNewEmployee()
        {
            if (IsValid())
            {
                this.ID = 0;
                _e.FirstName = txtFirstName.Text;
                _e.LastName = txtLastName.Text;

                _e.CNIC = Convert.ToInt64(txtCNIC.Text);
                if (cbxBloodGroup.SelectedIndex <= 0)
                {
                    _e.BloodID = 0;
                }
                else
                {
                    _e.BloodID = (int)(EnumHelper.ParseEnum<BloodGroup>(EnumHelper.GetBloodName(cbxBloodGroup.SelectedItem.ToString())));
                }
                _e.isActive = Convert.ToBoolean(isActive.Checked);
                //_e.Salary = Convert.ToInt32(txtSalary.Text);
                if (cbxGend.SelectedIndex <= 0)
                {
                    _e.GenderID = 0;
                }
                else
                {
                    _e.GenderID = (int)(EnumHelper.ParseEnum<Gender>(cbxGend.SelectedItem.ToString()));
                }
                _e.Qualification = txtQualification.Text;
                _e.Dept = txtDept.Text;
                _e.DOB = Convert.ToDateTime(datepickerDOB.Value.ToShortDateString());
                _e.Tag = (int)cbxTag.SelectedValue;
                _e.Phone = Convert.ToInt64(txtphone.Text);
                _e.Address = txtAddress.Text;
                _e.Desc = txtDesc.Text;
                _e.user.UserName = txtFirstName.Text + txtLastName.Text + txtCNIC.Text;
                _e.user.school = SessionBean.GlobalSessionUser.school;
                //_e.Salary = Convert.ToDecimal( txtSalary.Text);
                //_e.Qualification = txtQualification.Text;
                //_e.Dept = txtDept.Text;

                //EmpObj.Email = txtEmail.Text;
                //EmpObj.EmpId = Convert.ToString(txtEmpId.Text);
                //EmpObj.City = Convert.ToInt32(cbxCity.SelectedValue);
                //EmpObj.PictureName = EmpObj.FirstName + "" + EmpObj.Phone;// Asad+923000000000

                //if (EmpObj.PictureName != null)
                //{
                //    SavePic();
                //}
                EmployeeClass nEmp = new EmployeeClass();
                nEmp.InsertEmployee(_e);

                GetEmployeeRecords();
            }
        }
        private void UpdateEmployee()
        {
            if (IsValid())
            {
                _e.FirstName = txtFirstName.Text;
                _e.LastName = txtLastName.Text;
                _e.CNIC = Convert.ToInt64(txtCNIC.Text);
                if (cbxBloodGroup.SelectedIndex <= 0)
                {
                    _e.BloodID = 0;
                }
                else
                {
                    _e.BloodID = (int)(EnumHelper.ParseEnum<BloodGroup>(EnumHelper.GetBloodName(cbxBloodGroup.SelectedItem.ToString())));
                }
                _e.isActive = Convert.ToBoolean(isActive.Checked);
                //EmpObj.Email = txtEmail.Text;
                if (cbxGend.SelectedIndex <= 0)
                {
                    _e.GenderID = 0;
                }
                else
                {
                    _e.GenderID = (int)(EnumHelper.ParseEnum<Gender>(cbxGend.SelectedItem.ToString()));
                }
                _e.Qualification = txtQualification.Text;
                //EmpObj.Salary = Convert.ToInt32(txtSalary.Text);
                _e.Dept = txtDept.Text;
                //EmpObj.EmpId = Convert.ToString(txtEmpId.Text);
                _e.DOB = Convert.ToDateTime(datepickerDOB.Value.ToShortDateString());
                //EmpObj.City = Convert.ToInt32(cbxCity.SelectedValue);
                _e.Phone = Convert.ToInt64(txtphone.Text);
                _e.Tag = Convert.ToInt32(cbxTag.SelectedValue);
                _e.Address = txtAddress.Text;
                _e.Desc = txtDesc.Text;
                //EmpObj.user.UserName = txtUserName.Text;
                //EmpObj.PictureName = EmpObj.FirstName + "" + EmpObj.Phone;// Asad+923000000000

                //if (EmpObj.PictureName != null)
                //{
                //    SavePic();
                //}

                EmployeeClass nEmp = new EmployeeClass();
                nEmp.UpdateStudent(_e, ID);

                GetEmployeeRecords();
            }
            else
            {
                MessageBox.Show("please Select Atleast One Row", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                AddNewEmployee();
            }
            else
            {
                UpdateEmployee();
            }
        }
        private int chek(CheckBox isActive)
        {
            if (Validate(isActive.Checked))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void SavePic()
        {
            EmployeeProp Emp = new EmployeeProp();
            Emp.FirstName = txtFirstName.Text;
            Emp.Phone = Convert.ToInt64(txtphone.Text);

            Image img = PicForUpdate.Image;
            Emp.PictureName = Emp.FirstName + "" + Emp.Phone;// Asad+9230000000
            string path = ConfigurationManager.AppSettings["ImageEmployeeDir"];// +stu.PictureName;
            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}
            path = ConfigurationManager.AppSettings["ImageEmployeeDir"] + Emp.PictureName;

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            if (PicForUpdate.Image != null)
            {
                img.Save(path);
            }

        }

        private bool IsValid()
        {
            if (txtFirstName.Text == null || txtFirstName.Text == string.Empty
                || txtLastName.Text == null || txtLastName.Text == string.Empty
                || txtCNIC.Text == null || txtCNIC.Text == string.Empty
                || cbxTag.SelectedIndex < 0 || Convert.ToInt32(cbxTag.SelectedValue) <= 0)
            {
                MessageBox.Show("Must Fill the required Field", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshFormControls();
        }
        private bool isFeeCnfgSet()
        {
            EmployeeClass empClass = new EmployeeClass();
            var result = empClass.GetSalaryCnfg(this.ID);
            var res = result.Where(x => x.Status == true && x.SalaryCnfgID > 1).FirstOrDefault();
            if (res != null)
            {
                return true;
            }
            return false;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //UpdateEmployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                EmployeeClass nEmp = new EmployeeClass();
                nEmp.DeleteEmployee(ID);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Select atleast One Row", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public event EventHandler CloseEmployeeFormEvent;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetSalary_Click(object sender, EventArgs e)
        {
            SalaryCnfgForm scf = new SalaryCnfgForm(_e);
            scf.TopMost = true;
            scf.Show();
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CloseEmployeeFormEvent != null)
            {
                CloseEmployeeFormEvent(sender, new EventArgs());
            }
        }

        private void txtCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCNIC.Text.Length == 13)
            {
                if (!(e.KeyChar == '\b'))
                {
                    e.Handled = true;
                }
            }
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
            }
            else
            {
                if (!(e.KeyChar == '\b'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '+'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '+') && ((sender as TextBox).Text.IndexOf('+') > -1))
            {
                e.Handled = true;
            }
            if (txtphone.Text.Length == 13)
            {
                if (!(e.KeyChar == '\b'))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
