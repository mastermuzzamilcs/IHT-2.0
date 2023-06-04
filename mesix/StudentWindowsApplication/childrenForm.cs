using DAL;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class childrenForm : Form
    {
        public childrenForm()
        {
            InitializeComponent();
        }
        public int ParentId { get; set; }
        public int StudentId { get; set; }
        private void childrenForm_Load(object sender, EventArgs e)
        {
            ParentId = 1;
            GetChildren();

        }
        public void GetChildren()
        {
            EmployeeClass emp = new EmployeeClass();
            dgvChildren.DataSource = emp.GetChildrenFromParentId(ParentId);
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
