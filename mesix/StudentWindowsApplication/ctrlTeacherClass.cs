using DAL;
using DataTransferObjects;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlTeacherClass1 : UserControl
    {
        public ctrlTeacherClass1()
        {
            InitializeComponent();
        }
        public Roles classTeacherObj = new Roles();
        private void ctrlTeacherClass_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            lblTeacherName.Text = classTeacherObj.Name;
            GetTeacherClasses();
        }
        private void GetTeacherClasses()
        {
            ClassDAL Cdal = new ClassDAL();
            dgvClass.DataSource = Cdal.GetTeacherClasses(classTeacherObj.LoginId);
        }
        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClass.SelectedRows.Count > 0)
            {
                MessageBox.Show("Comming soon");
            }
        }
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            GetTeacherClasses();
        }
    }
}
