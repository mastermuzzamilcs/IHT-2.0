using DAL;
using DataTransferObjects;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlStudentClass : UserControl
    {
        public ctrlStudentClass()
        {
            InitializeComponent();
        }
        public Roles classStudentObj = new Roles();
        public int ClassId;
        public int ID;
        private void ctrlStudentClass_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            GetStudentClasses();
        }
        public void GetStudentClasses()
        {
            HomeDAL hdal = new HomeDAL();
            dgvStudentClasses.DataSource = hdal.GetStClasses(classStudentObj.ClassId);
            this.dgvStudentClasses.Columns["Id"].Visible = false;
        }
        private void dgvStudentClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dgvStudentClasses.SelectedRows[0].Cells[0].Value);
            if (ID > 0)
            {
                MessageBox.Show("We are working at it. It will be Available Soon.", "Under Maintainance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetStudentClasses();
        }
    }
}
