using DAL;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class SalaryCnfgForm : Form
    {
        public SalaryCnfgForm()
        {
            InitializeComponent();
            this.ID = 0;
        }
        public EmployeeProp Emp;
        public int ID;
        public SalaryCnfgForm(EmployeeProp _e)
        {
            InitializeComponent();
            this.Emp = _e;
            this.ID = 0;
        }

        private void SalaryCnfgForm_Load(object sender, EventArgs e)
        {
            lblName.Text = this.Emp.FirstName + " " + this.Emp.LastName;
            //btnInsert.Text = "Submit";
            btnDelete.Visible = false;
            GetMandatoryData();
        }
        private void GetMandatoryData()
        {
            EmployeeClass emp = new EmployeeClass();
            dgvSalaryCnfg.DataSource = emp.GetSalaryCnfg(this.Emp.ID);
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                EmployeeClass emp = new EmployeeClass();
                SalaryCnfg item = new SalaryCnfg();
                item.EmployeeID = this.Emp.ID;
                item.Amount = Convert.ToDecimal(txtAmount.Text);
                emp.InsertSalaryCnfg(item);
                //Insert Salary CNFG
                RefreshFormControls();
            }
            else
            {
                //Shwo message
            }
        }
        private bool IsValid()
        {
            if (txtAmount.Text == null || txtAmount.Text == String.Empty)
            {
                MessageBox.Show("Salary Amount cant be empty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public event EventHandler changeParentTextWithCustomEvent;

        private void RefreshFormControls()
        {
            txtAmount.Text = null;
            txtAmount.Focus();
            this.ID = 0;
            GetMandatoryData();
        }

        private void dgvSalaryCnfg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.ID = Convert.ToInt32(dgvSalaryCnfg.SelectedRows[0].Cells["SalaryCnfgID"].Value);
            //txtAmount.Text = dgvSalaryCnfg.SelectedRows[0].Cells["Amount"].Value.ToString();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            //Implementation-Pending
        }
    }
}
