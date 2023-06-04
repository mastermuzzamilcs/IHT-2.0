using DAL;
using DataTransferObjects;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlParentsChildren : UserControl
    {
        public ctrlParentsChildren()
        {
            InitializeComponent();
        }
        public Roles childrenParentObj = new Roles();
        public int StudentId { get; set; }
        private void ctrlParentsChildren_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            GetChildren();
        }
        public void GetChildren()
        {
            EmployeeClass emp = new EmployeeClass();
            dgvChildren.DataSource = emp.GetChildrenFromParentId(childrenParentObj.LoginId);
            this.dgvChildren.Columns["Id"].Visible = false;
        }
        private void dgvChildren_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentId = Convert.ToInt32(dgvChildren.SelectedRows[0].Cells[0].Value);
            if (StudentId > 0)
            {
                ParentsStudentInfoForm child = new ParentsStudentInfoForm();
                child.TopMost = false;
                child.StdId = StudentId;
                child.Show();
            }
        }
    }
}
