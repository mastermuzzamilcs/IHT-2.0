using DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlEmployeeAttendanceMark : UserControl
    {
        public ctrlEmployeeAttendanceMark()
        {
            InitializeComponent();
        }
        public int ID = 0;
        private void ctrlEmployeeAttendanceMark_Load(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EmployeeProp emp = new EmployeeProp();
            emp.Email = txtEmail.Text;
            EmployeeClass EmpObj = new EmployeeClass();
            emp = EmpObj.CheckLogin(emp);
            if (emp.ID > 0)
            {
                panel2.Show();
                ID = emp.ID;
                lblName.Text = emp.empName;
                lblEmail.Text = emp.Email;
                lblDept.Text = emp.Dept;
                lblEmpId.Text = Convert.ToString(emp.EmpId);
                lblTag.Text = emp.FirstName;
                lblDate.Text = Convert.ToString(DateTime.Now);
                lblStatus.Text = "Present";
                txtEmail.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Attendance at = new Attendance();
            at.date = Convert.ToDateTime(lblDate.Text);
            at.status = true;
            EmployeeClass EmpObj = new EmployeeClass();
            EmpObj.MarkAttendance(at, ID);
        }
        private void ResetFormControls()
        {
            panel2.Hide();
            dgvAttendanceSummary.Hide();
            lblName.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblDept.Text = string.Empty;
            lblEmpId.Text = string.Empty;
            lblTag.Text = string.Empty;
            lblDate.Text = string.Empty;
            lblStatus.Text = string.Empty;
            dgvAttendanceSummary.DataSource = null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            dgvAttendanceSummary.Show();
            DataTable dt = new DataTable();
            EmployeeClass emp = new EmployeeClass();
            dgvAttendanceSummary.DataSource = emp.GetEmployeeAttendanceSummary(ID);
        }
    }
}
