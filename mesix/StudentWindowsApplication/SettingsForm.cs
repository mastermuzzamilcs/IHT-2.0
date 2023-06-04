using DAL;
using DataTransferObjects;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.isSave = false;
            txtInstituteName.Enabled = false;
        }

        public SettingsForm(Users u)
        {
            InitializeComponent();
            this.isSave = false;
            txtInstituteName.Enabled = false;
            this.SessionUser = u;
        }
        Users SessionUser;
        bool isSave;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtInstituteName != null && txtInstituteName.Text != String.Empty)
            {
                ChangeState();
                if (isSave)
                {
                    this.SessionUser.school.SchoolName = txtInstituteName.Text;
                    saveSchool();
                }
            }
        }
        public void saveSchool()
        {
            HomeDAL hdal = new HomeDAL();
            hdal.SaveSchool(this.SessionUser.school);
            GetFormData();
        }
        private void ChangeState()
        {
            if (btnEdit.Text == "Save")
            {
                isSave = true;
                btnEdit.Text = "Edit";
                txtInstituteName.Enabled = false;
            }
            else
            {
                isSave = false;
                btnEdit.Text = "Save";
                txtInstituteName.Enabled = true;
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
            //ImplementationPending
        }

        private void switchButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnTheme.Checked)
            {
                ConfigurationManager.AppSettings.Set("Theme", "Dark");
            }
            else
            {
                ConfigurationManager.AppSettings.Set("Theme", "Light");
            }
        }
        //var p = this.ParentForm as AdminHome;
        //p.SessionObject
    }
}
