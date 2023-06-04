using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlStudentHome : UserControl
    {
        public ctrlStudentHome()
        {
            InitializeComponent();
        }
        public Roles homeStudentObj = new Roles();
        public List<string> Notices { get; set; }
        private void ctrlStudentHome_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            lblHeadingName.Text = Convert.ToString(homeStudentObj.Name);
            lblNotice1.Text = null;

            Notices = new List<string>();
            Notices.Add("\tAhmad joined our school today\n");
            Notices.Add("\tToday is his first Day\n");
            Notices.Add("\tAT 9:00 you have a Session with students\n");
            Notices.Add("\tAt 10 you have meeting with Teachers\n");

            //
            foreach (var item in Notices)
            {
                lblNotice1.Text += " " + item;
            }
            lblMessage.Text = Convert.ToString("We are here to provide Excellent Level of Education. We Know what do you want. A symbol of Excellence.");
        }
    }
}
