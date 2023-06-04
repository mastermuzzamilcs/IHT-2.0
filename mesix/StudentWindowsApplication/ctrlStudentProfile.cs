using DAL;
using DataTransferObjects;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlStudentProfile : UserControl
    {
        public Roles profileStudentObj = new Roles();
        public ctrlStudentProfile()
        {
            InitializeComponent();
        }
        private void ctrlStudentProfile_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            if (profileStudentObj.LoginId > 0)
            {
                StudentDAL FetchViewData = new StudentDAL();
                Student FetchedDetail = new Student();
                FetchedDetail = FetchViewData.GetStudentProfile(profileStudentObj.LoginId);

                lblViewName.Text = FetchedDetail.FirstName + " " + FetchedDetail.FatherName;
                lblViewRoll.Text = Convert.ToString(FetchedDetail.Roll);
                lblViewClass.Text = Convert.ToString(FetchedDetail.Class);
                lblViewSection.Text = Convert.ToString(FetchedDetail.Section);
                lblViewEmail.Text = FetchedDetail.Email;
                lblFirstName.Text = FetchedDetail.FirstName;
                lblLastName.Text = FetchedDetail.FatherName;
                lblParent.Text = FetchedDetail.Parent;
                lblCity.Text = FetchedDetail.City;
                lblRoll.Text = Convert.ToString(FetchedDetail.Roll);
                lblEmail.Text = FetchedDetail.Email;
                lblClass.Text = Convert.ToString(FetchedDetail.Class);
                lblSection.Text = Convert.ToString(FetchedDetail.Section);
                lblBloodGroup.Text = FetchedDetail.BloodGroup;
                lblAddress.Text = FetchedDetail.Address;
                lblAdmId.Text = Convert.ToString(FetchedDetail.AdmissionId);
                lblAdmDate.Text = FetchedDetail.AdmissionDate;

                if (File.Exists(ConfigurationManager.AppSettings["ImageRouteDir"] + FetchedDetail.PictureName))
                {
                    picViewImage.Image = Image.FromFile(ConfigurationManager.AppSettings["ImageRouteDir"] + FetchedDetail.PictureName);
                    picViewImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
