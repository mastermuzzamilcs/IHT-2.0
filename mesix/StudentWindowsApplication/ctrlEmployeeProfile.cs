using DAL;
using DataTransferObjects;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlEmployeeProfile : UserControl
    {
        public Roles EmpProfileObj = new Roles();

        public ctrlEmployeeProfile()
        {
            InitializeComponent();
        }

        private void ctrlEmployeeProfile_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            if (EmpProfileObj.LoginId > 0)
            {
                EmployeeClass FetchViewData = new EmployeeClass();
                EmployeeProp FetchedDetail = new EmployeeProp();
                FetchedDetail = FetchViewData.GetEmployeeProfile(EmpProfileObj.LoginId);

                lblViewName.Text = FetchedDetail.FirstName + " " + FetchedDetail.LastName;
                lblViewTag.Text = FetchedDetail.Type;
                lblViewCNIC.Text = Convert.ToString(FetchedDetail.CNIC);
                lblViewPhone.Text = Convert.ToString(FetchedDetail.Phone);
                lblViewDOB.Text = Convert.ToString(FetchedDetail.DOB);
                lblViewEmail.Text = FetchedDetail.Email;
                lblFirstName.Text = FetchedDetail.FirstName;
                lblLastName.Text = FetchedDetail.LastName;
                lblTag.Text = FetchedDetail.Type;
                lblCity.Text = FetchedDetail.CityName;
                lblPhone.Text = Convert.ToString(FetchedDetail.Phone);
                lblEmail.Text = FetchedDetail.Email;
                lblCNIC.Text = Convert.ToString(FetchedDetail.CNIC);
                lblEmpId.Text = Convert.ToString(FetchedDetail.EmpId);
                lblBloodGroup.Text = FetchedDetail.BloodGroup;
                lblGender.Text = FetchedDetail.Gender;
                lblDOB.Text = Convert.ToString(FetchedDetail.DOB);
                lblQualification.Text = FetchedDetail.Qualification;
                lblDept.Text = FetchedDetail.Dept;
                lblSalary.Text = Convert.ToString(FetchedDetail.Salary);
                lblDesc.Text = FetchedDetail.Desc;

                if (File.Exists(ConfigurationManager.AppSettings["ImageEmployeeDir"] + FetchedDetail.PictureName))
                {
                    picViewImage.Image = Image.FromFile(ConfigurationManager.AppSettings["ImageEmployeeDir"] + FetchedDetail.PictureName);
                    picViewImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
