using DAL;
using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlSettings : UserControl
    {
        //Declare Event with CustomArgs
        public event EventHandler changeParentTextWithCustomEvent;
        private static ctrlSettings _instance;
        public static ctrlSettings Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrlSettings();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new ctrlSettings();
        }
        public ctrlSettings()
        {
            InitializeComponent();
            this.isSave = false;
            txtInstituteName.Enabled = false;
            txtFirstName.Enabled = false;
            txtSecondName.Enabled = false;
            txtEmail.Enabled = false;
            txtUsername.Enabled = false;
            dtpDOB.Enabled = false;
            this.Controller = new HomeDAL();
        }
        
        public ctrlSettings(Users u)
        {
            InitializeComponent();
            this.isSave = false;
            txtInstituteName.Enabled = false;
            txtFirstName.Enabled = false;
            txtSecondName.Enabled = false;
            txtEmail.Enabled = false;
            txtUsername.Enabled = false;
            dtpDOB.Enabled = false;
            this.SessionUser = u;
            this.Controller = new HomeDAL();
        }
        public void loadData(Users u)
        {
            this.isSave = false;
            txtInstituteName.Enabled = false;
            txtFirstName.Enabled = false;
            txtSecondName.Enabled = false;
            txtEmail.Enabled = false;
            txtUsername.Enabled = false;
            dtpDOB.Enabled = false;
            this.SessionUser = u;
            GetFormData();
        }
        Users SessionUser;
        bool isSave;
        private void button1_Click(object sender, EventArgs e)
        {
            ChangeState();
            if (isSave)
            {
                if (IsValid())
                {
                    SaveUser();
                    saveSchool();
                    GetFormData();
                    if (changeParentTextWithCustomEvent != null)
                    {
                        changeParentTextWithCustomEvent(sender, new EventArgs());
                    }
                }
            }
        }
        public int SaveUser()
        {
            this.SessionUser.FirstName = txtFirstName.Text;
            this.SessionUser.SecondName = txtSecondName.Text;
            this.SessionUser.Email = txtEmail.Text;
            this.SessionUser.DOB = dtpDOB.Value.ToShortDateString();
            this.SessionUser.UserName = txtUsername.Text;
            var res = Controller.SaveUser(this.SessionUser);
            return res;
        }
        private bool IsValid()
        {
            bool isFormValid = true;
            List<string> ErrorMsgs = new List<string>();
            if (txtInstituteName == null || txtInstituteName.Text == String.Empty)
            {
                ErrorMsgs.Add("Institute Name cannot be Null or Empty");
                isFormValid = false;
            }
            if (txtFirstName.Text == null || txtFirstName.Text == String.Empty)
            {
                ErrorMsgs.Add("First Name cannot be Null or Empty");
                isFormValid = false;
            }
            if (dtpDOB.Value == null)
            {
                ErrorMsgs.Add("DOB cannot be Null or Empty");
                isFormValid = false;
            }
            if (txtEmail.Text == null || txtEmail.Text == String.Empty)
            {
                ErrorMsgs.Add("Email cannot be Null or Empty");
                isFormValid = false;
            }
            if (txtUsername.Text == null || txtUsername.Text == String.Empty)
            {
                ErrorMsgs.Add("Username cannot be Null or Empty");
                isFormValid = false;
            }
            if (!IsValidEmailUsername(ref ErrorMsgs))
            {
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
        public bool IsValidEmailUsername(ref List<string> errors)
        {
            bool ret = true;
            if (txtEmail.Text.IndexOf('@') == -1)
            {
                errors.Add("Email is not in Correct Format");
                return false;
            }
            if (txtEmail.Text.IndexOf('.') == -1)
            {
                errors.Add("Email is not in Correct Format");
                return false;
            }
            var res = Controller.CheckValidData(this.SessionUser);
            if (res[0] > 0)
            {
                errors.Add("username already Exists in the system");
                ret = false;
            }
            if (res[0] > 0)
            {
                errors.Add("Email already Exists in the system");
                ret = false;
            }
            return ret;
        }
        public HomeDAL Controller;
        public int saveSchool()
        {
            this.SessionUser.school.SchoolName = txtInstituteName.Text;
            var res = Controller.SaveSchool(this.SessionUser.school);
            return res;
        }
        private void ChangeState()
        {
            if (btnEdit.Text == "Save")
            {
                isSave = true;
                btnEdit.Text = "Edit";
                txtInstituteName.Enabled = false;
                txtFirstName.Enabled = false;
                txtSecondName.Enabled = false;
                txtEmail.Enabled = false;
                txtUsername.Enabled = false;
                dtpDOB.Enabled = false;
            }
            else
            {
                isSave = false;
                btnEdit.Text = "Save";
                txtInstituteName.Enabled = true;
                txtFirstName.Enabled = true;
                txtSecondName.Enabled = true;
                txtEmail.Enabled = true;
                txtUsername.Enabled = true;
                dtpDOB.Enabled = true;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            GetFormData();
        }
        void GetFormData()
        {
            HomeDAL hdal = new HomeDAL();
            this.SessionUser.school = hdal.GetSchool(this.SessionUser.UserID);
            txtInstituteName.Text = this.SessionUser.school.SchoolName;
            txtFirstName.Text = this.SessionUser.FirstName;
            txtSecondName.Text = this.SessionUser.SecondName;
            dtpDOB.Value = Convert.ToDateTime(this.SessionUser.DOB);
            txtEmail.Text = this.SessionUser.Email;
            txtUsername.Text = this.SessionUser.UserName;
        }

        private void switchButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnTheme.Checked)
            {
                System.Configuration.ConfigurationManager.AppSettings.Set("Theme", "Dark");
            }
            else
            {
                System.Configuration.ConfigurationManager.AppSettings.Set("Theme", "Light");
            }
            if (changeParentTextWithCustomEvent != null)
            {
                changeParentTextWithCustomEvent(sender, new EventArgs());
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm frm = new ChangePasswordForm();
            frm.PasswordUpdatedEvent += log_PasswordUpdatedEvent;
            frm.Show();
        }

        private void log_PasswordUpdatedEvent(object sender, PasswordChangedEventArgs e)
        {
            if(Controller.ChangePassword(this.SessionUser.UserID,e.OldPassword, e.NewPassword) > 0)
            {
                MessageBox.Show("Password Changed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Old Password is InCorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //var p = this.ParentForm as AdminHome;
        //p.SessionObject
    }
}
