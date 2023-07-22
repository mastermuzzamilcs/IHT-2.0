using DAL;
using DataTransferObjects;
using DataTransferObjects.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class Student_Adress : Form
    {
        public Student_Adress()
        {
            this._s = new Student();
            this._s.ClassId = 0;
            this.isNew = true;
            InitializeComponent();
        }
        public Student_Adress(int studentID)
        {
            this._s = new Student();
            this._s.stdID = studentID;
            this._s.ClassId = 0;
            this.isNew = false;
            InitializeComponent();
        }
        public int ID;
        public Student _s;
        public bool isNew;
        private void Student_Adress_Load(object sender, EventArgs e)
        {
            GetMandatoryData();
            GetStudentRecords();

        }
        public void GetMandatoryData()
        {
            ClassDAL cdal = new ClassDAL();
            escapeSelectedIndexChangeEvent = true;
            cbxClass.DataSource = cdal.GetClasses();
            cbxClass.DisplayMember = "CName";
            cbxClass.ValueMember = "Id";
            escapeSelectedIndexChangeEvent = false;

            //CityDAL citydal = new CityDAL();
            //List<Cities> city1 = citydal.GetCities();
            //cbxCity.DataSource = city1;
            //cbxCity.DisplayMember = "CityName";
            //cbxCity.ValueMember = "Id";

            //ClassDAL Ncdal = new ClassDAL();
            //cbxSection.DataSource = Ncdal.GetSections();
            //cbxSection.DisplayMember = "SecName";
            //cbxSection.ValueMember = "Id";
        }
        private void GetStudentRecords()
        {
            btnDelete.Visible = false;
            txtEmail.Visible = false;
            txtUserName.Visible = false;
            txtAdmId.Visible = false;
            AdmDatePicker.Visible = false;
            lblEmail.Visible = false;
            lblUsername.Visible = false;
            lblAdmId.Visible = false;
            lblAdmDate.Visible = false;
            btnView.Visible = false;
            btnBrowse.Visible = false;
            btnRefresh.Visible = false;
            lblViewAdmId.Visible = false;
            lblViewHeadingAdmId.Visible = false;
            txtName.Focus();

            RefreshFormControls();
            if (this._s.stdID > 0)
            {
                btnDelete.Visible = true;

                StudentDAL FetchViewData = new StudentDAL();
                Student FetchedData = new Student();
                var res = FetchViewData.ViewStudentInfo(_s.stdID);
                if (res.stdID > 0)
                {
                    this._s = res;
                    lblViewName.Text = this._s.userObj.FirstName;
                    lblViewFatherName.Text = this._s.FatherName;
                    lblViewRoll.Text = Convert.ToString(this._s.Roll);
                    lblViewClass.Text = Convert.ToString(this._s.Class);
                    lblViewSection.Text = Convert.ToString(this._s.Section);
                    lblViewAdmId.Text = Convert.ToString(this._s.AdmissionId);
                    //if (File.Exists(ConfigurationManager.AppSettings["ImageRouteDir"] + FetchedData.PictureName))
                    //{
                    //    picViewImage.Image = Image.FromFile(ConfigurationManager.AppSettings["ImageRouteDir"] + FetchedData.PictureName);
                    //    picViewImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    //}

                    txtName.Text = _s.Name;
                    txtFatherName.Text = _s.FatherName;
                    txtFOccupation.Text = _s.FOccupation;
                    txtRollNo.Text = Convert.ToString(_s.Roll);
                    cbxBloodGroup.SelectedIndex = _s.BloodID - 1;
                    cbxGender.SelectedIndex = _s.GenderID - 1;
                    cbxClass.SelectedValue = _s.ClassId;
                    cbxSection.SelectedValue = _s.SectionId;
                    txtHomeNo.Text = _s.Address;
                    try
                    {

                        dtpDOB.Value = Convert.ToDateTime(_s.DOB);
                    }
                    catch (Exception)
                    {
                        dtpDOB.Value = DateTime.Now;
                    }
                    txtContact.Text = _s.Contact1;
                    txtCNIC.Text = _s.CNIC;
                    checkIsCR.Checked = _s.IsCR;
                    //cbxCity.SelectedValue = _s.City;
                    //txtAdmId.Text = Convert.ToString(_s.AdmissionId);
                    //txtEmail.Text = _s.userObj.Email;
                    //txtContact.Text = _s.Contact1;
                    //txtCNIC.Text = _s.CNIC;
                    //checkIsCR.Checked = _s.IsCR;
                    //txtUserName.Text = _s.userObj.UserName;
                    //AdmDatePicker.Value = Convert.ToDateTime(_s.AdmissionDate);

                    //if (File.Exists(ConfigurationManager.AppSettings["ImageRouteDir"] + _s.PictureName))
                    //{
                    //    PicForUpdate.Image = Image.FromFile(ConfigurationManager.AppSettings["ImageRouteDir"] + _s.PictureName);
                    //    PicForUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
                    //}

                }
                else
                {
                    MessageBox.Show("Student Not Found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                var savepos = tableLayoutPanel2.GetColumn(btnSave);
                var deletepos = tableLayoutPanel2.GetColumn(btnDelete);
                tableLayoutPanel2.SetColumn(btnDelete, savepos);
                tableLayoutPanel2.SetColumn(btnSave, deletepos);
            }

        }

        private void btnSave_Click(object sender, EventArgs e) //Insert
        {
            if (isNew)
            {
                AddNewStudent();
            }
            else
            {
                UpdateStudent();
            }
        }
        public void UpdateStudent()
        {
            if (IsValid())
            {
                //implementation-pending
                Student stu = new Student();
                stu = this._s;
                stu.Name = txtName.Text;
                stu.FatherName = txtFatherName.Text;
                stu.FOccupation = txtFOccupation.Text;
                stu.Roll = Convert.ToInt32(txtRollNo.Text);
                if (cbxBloodGroup.SelectedIndex <= 0)
                {
                    stu.BloodID = 0;
                }
                else
                {
                    stu.BloodID = (int)(EnumHelper.ParseEnum<BloodGroup>(EnumHelper.GetBloodName(cbxBloodGroup.SelectedItem.ToString())));
                }
                if (cbxGender.SelectedIndex <= 0)
                {
                    stu.GenderID = 0;
                }
                else
                {
                    stu.GenderID = (int)(EnumHelper.ParseEnum<Gender>(cbxGender.SelectedItem.ToString()));
                }
                stu.ClassId = Convert.ToInt32(cbxClass.SelectedValue);
                stu.SectionId = Convert.ToInt32(cbxSection.SelectedValue);
                stu.Address = txtHomeNo.Text;
                stu.DOB = Convert.ToString(AdmDatePicker.Text);
                stu.Contact1 = txtContact.Text;
                stu.CNIC = txtCNIC.Text;

                //stu.CityId = Convert.ToInt32(cbxCity.SelectedValue);
                //stu.AdmissionId = Convert.ToInt32(txtAdmId.Text);
                stu.BloodGroup = Convert.ToString(cbxBloodGroup.SelectedItem);
                //stu.Email = txtEmail.Text;
                stu.IsCR = checkIsCR.Checked;
                stu.PictureName = stu.Name + "" + stu.Roll;
                stu.userObj.school = SessionBean.GlobalSessionUser.school;
                //if (stu.PictureName != null)
                //{
                //    SavePic();
                //}

                StudentDAL sdal = new StudentDAL();
                sdal.UpdateStudent(stu);

                GetStudentRecords();
            }
        }
        public void AddNewStudent()
        {
            if (IsValid())
            {
                this.ID = 0;
                Student stu = new Student();

                stu.Name = txtName.Text;
                //stu.userObj.UserName = txtUserName.Text;
                stu.userObj.UserName = txtName.Text + txtFatherName.Text + txtRollNo.Text;
                //stu.Email = txtEmail.Text;
                stu.Email = String.Empty;
                stu.FatherName = txtFatherName.Text;
                stu.FOccupation = txtFOccupation.Text;
                stu.Roll =  Convert.ToInt32(txtRollNo.Text);
                stu.ClassId = Convert.ToInt32(cbxClass.SelectedValue);
                stu.SectionId = Convert.ToInt32(cbxSection.SelectedValue);
                //stu.CityId = Convert.ToInt32(cbxCity.SelectedValue);//ENUM create kro
                stu.Contact1 = txtContact.Text;
                stu.CNIC = txtCNIC.Text;
                stu.Address = txtHomeNo.Text;
                //stu.AdmissionNum = txtAdmId.Text;
                //stu.AdmissionDate = Convert.ToStr ing(AdmDatePicker.Text);
                stu.DOB = Convert.ToString(dtpDOB.Text);
                stu.AdmissionDate = DateTime.Now.ToString();
                //stu.BloodGroup = Convert.ToString(cbxBloodGroup.SelectedItem);//ENUM create kro
                if (cbxBloodGroup.SelectedIndex <= 0)
                {
                    stu.BloodID = 0;
                }
                else
                {
                    stu.BloodID = (int)(EnumHelper.ParseEnum<BloodGroup>(EnumHelper.GetBloodName(cbxBloodGroup.SelectedItem.ToString())));
                }
                if (cbxGender.SelectedIndex <= 0)
                {
                    stu.GenderID = 0;
                }
                else
                {
                    stu.GenderID = (int)(EnumHelper.ParseEnum<Gender>(cbxGender.SelectedItem.ToString()));
                }
                stu.Email = txtEmail.Text;
                stu.IsCR = checkIsCR.Checked;
                stu.userObj.school = SessionBean.GlobalSessionUser.school;

                //stu.PictureName = stu.Name + "" + stu.Roll;// Asad14

                //if (stu.PictureName != null)
                //{
                //    SavePic();
                //}


                StudentDAL sdal = new StudentDAL();
                sdal.InsertStudent(stu);

                //GetStudentRecords();
                RefreshFormControls();

            }
        }
        private bool IsValid()
        {
            bool isFormValid = true;
            List<string> ErrorMsgs = new List<string>();
            if (txtName.Text == string.Empty || txtName.Text == null)
            {
                ErrorMsgs.Add("Student Name cannot be Null or Empty");
                isFormValid = false;
                //MessageBox.Show("Name must be required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            if (cbxClass.SelectedValue == null || Convert.ToInt32(cbxClass.SelectedValue) <= 0)
            {
                ErrorMsgs.Add("Student Class cannot be Null or Empty");
                isFormValid = false;
            }
            if (cbxSection.SelectedValue == null || Convert.ToInt32(cbxSection.SelectedValue) <= 0)
            {
                ErrorMsgs.Add("Student Section cannot be Null or Empty");
                isFormValid = false;
            }
            if (txtRollNo.Text == null || txtRollNo.Text==string.Empty)
            {
                ErrorMsgs.Add("Student Roll Number cannot be Null or Empty");
                isFormValid = false;
            }
            if (!isFormValid)
            {
                var message = string.Join(Environment.NewLine, ErrorMsgs);
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetStudentRecords();
            RefreshFormControls();

        }
        private void RefreshFormControls()
        {
            btnSave.Enabled = true;
            //btnEdit.Enabled = false;
            //ID = 0;
            txtName.Clear();
            txtFatherName.Clear();
            txtFOccupation.Clear();
            txtRollNo.Clear();
            cbxBloodGroup.SelectedIndex = -1;
            cbxGender.SelectedIndex = -1;
            cbxClass.SelectedIndex = -1;
            cbxSection.SelectedIndex = -1;
            txtHomeNo.Clear();
            dtpDOB.Value = DateTime.Now;
            txtContact.Clear();
            txtCNIC.Clear();
            checkIsCR.Checked = false;
            //txtEmail.Clear();
            ////cbxCity.SelectedIndex = -1;
            //txtAdmId.Clear();
            //AdmDatePicker.Text = string.Empty;
            //PicForUpdate.Image = null;

            txtName.Focus();


        }

        private void btnDelete_Click(object sender, EventArgs e) //Delete
        {
            if (this._s.stdID > 0)
            {
                StudentDAL SD = new StudentDAL();
                SD.DeleteStudent(this._s.stdID);
                MessageBox.Show("Data Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentRecords();
                RefreshFormControls();

                this.Close();
            }
            else
            {
                MessageBox.Show("please Select Atleast One Row", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SavePic()
        {
            Student stu = new Student();
            if (PicForUpdate != null)
            {
                stu.Name = txtName.Text;
                stu.Roll = Convert.ToInt32(txtRollNo.Text);
                Image img = PicForUpdate.Image;
                stu.PictureName = stu.Name + "" + stu.Roll;// Asad14
                string path = ConfigurationManager.AppSettings["ImageRouteDir"];// +stu.PictureName;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = ConfigurationManager.AppSettings["ImageRouteDir"] + stu.PictureName;

                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                if (img != null)
                    img.Save(path + stu.PictureName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lblViewHeadingSection_Click(object sender, EventArgs e)
        {

        }

        private void lblBloodGroup_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)  //Edit
        {
            //btnSave.Enabled = false;
            //btnEdit.Enabled = true;
            //StudentDAL FetchViewData = new StudentDAL();
            ////StudentProp FetchedData = new StudentProp();
            ////FetchedData = FetchViewData.GetStudentInfo(ID);

            //txtName.Text = _s.Name;
            //txtFatherName.Text = _s.FatherName;
            //txtRollNo.Text = Convert.ToString(_s.Roll);
            //cbxClass.SelectedValue = _s.ClassId;
            //cbxSection.SelectedValue = _s.SectionId;
            //txtHomeNo.Text = _s.Address;
            ////cbxCity.SelectedValue = _s.City;
            //cbxBloodGroup.Text = _s.BloodGroup;
            //txtAdmId.Text = Convert.ToString(_s.AdmissionId);
            //txtEmail.Text = _s.Email;
            ////AdmDatePicker.Value = Convert.ToDateTime(_s.AdmissionDate);

            ////if (File.Exists(ConfigurationManager.AppSettings["ImageRouteDir"] + _s.PictureName))
            ////{
            ////        PicForUpdate.Image = Image.FromFile(ConfigurationManager.AppSettings["ImageRouteDir"] + _s.PictureName);
            ////        PicForUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
            ////}
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
            MessageBox.Show("We are working at it. It will be Available Soon.", "Under Maintainance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool escapeSelectedIndexChangeEvent { get; set; }

        private void cbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!escapeSelectedIndexChangeEvent)
            {
                int classid = Convert.ToInt32(cbxClass.SelectedValue);
                ExamClass sDal = new ExamClass();
                List<SectionClass> sections = sDal.GetSectionsByClassId(classid);
                if (sections.Count > 0)
                {
                    cbxSection.DataSource = sections;
                    cbxSection.DisplayMember = "SecName";
                    cbxSection.ValueMember = "Id";
                }
                else
                {
                    cbxSection.DataSource = null;
                }
            }
        }

        private void btnSetFee_Click(object sender, EventArgs e)
        {

        }
        public event EventHandler CloseStudentFormEvent;

        private void EditPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Student_Adress_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CloseStudentFormEvent != null)
            {
                CloseStudentFormEvent(sender, new EventArgs());
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

            //// only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
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
            if (txtContact.Text.Length == 13)
            {
                if (!(e.KeyChar == '\b'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtRollNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '+'))
            {
                e.Handled = true;
            }

            if (txtRollNo.Text.Length == 10)
            {
                if (!(e.KeyChar == '\b'))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
