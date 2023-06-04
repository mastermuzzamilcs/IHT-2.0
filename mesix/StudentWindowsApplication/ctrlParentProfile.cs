using DAL;
using DataTransferObjects;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlParentProfile : UserControl
    {
        public ctrlParentProfile()
        {
            InitializeComponent();
        }
        public Roles profileParentObj = new Roles();
        public int LoginId { get; set; }

        private void ctrlParentProfile_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            if (profileParentObj.LoginId > 0)
            {
                EmployeeClass FetchViewData = new EmployeeClass();
                ParentProp FetchedDetail = new ParentProp();
                FetchedDetail = FetchViewData.GetParentProfile(profileParentObj.LoginId);

                lblViewName.Text = FetchedDetail.FirstName + " " + FetchedDetail.LastName;
                lblFirstName.Text = FetchedDetail.FirstName;
                lblLastName.Text = FetchedDetail.LastName;
                lblCNIC.Text = Convert.ToString(FetchedDetail.CNIC);
                lblCity.Text = FetchedDetail.CityName;
                lblEmail.Text = FetchedDetail.Email;
                lblPhone.Text = Convert.ToString(FetchedDetail.Phone);
                lblGender.Text = FetchedDetail.Gender;
                lblAddress.Text = FetchedDetail.Address;
            }
        }
    }
}