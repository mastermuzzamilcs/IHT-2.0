using DAL;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ParentsStudentInfoForm : Form
    {
        public ParentsStudentInfoForm()
        {
            InitializeComponent();
        }
        public children ch;
        public int StdId = new int();
        public int SubjectID;
        private void ParentsStudentInfoForm_Load(object sender, EventArgs e)
        {
            GetChildrenInfo();
        }
        public void GetChildrenInfo()
        {
            EmployeeClass Eobj = new EmployeeClass();
            ch = Eobj.GetChildrenInfo(StdId);
            lblChildrenName.Text = ch.ChildName;
            lblClass.Text = ch.ClassName;
            lblSection.Text = ch.SectionName;
            lblTeacher.Text = ch.TeacherName;
            SubjectDAL sdal = new SubjectDAL();
            dgvSubjects.DataSource = sdal.GetSubject(StdId);
            this.dgvSubjects.Columns["Id"].Visible = false;
        }
        private void dgvSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSubjects.SelectedRows.Count > 0)
            {
                SubjectID = Convert.ToInt32(dgvSubjects.SelectedRows[0].Cells[0].Value);
                lblSubject.Text = dgvSubjects.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are working at it. It will be Available Soon.", "Under Maintainance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnExamReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are working at it. It will be Available Soon.", "Under Maintainance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetChildrenInfo();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
