using DAL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlSearchSalary : UserControl
    {
        public ctrlSearchSalary()
        {
            InitializeComponent();
        }
        private static ctrlSearchSalary _instance;
        public static ctrlSearchSalary Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrlSearchSalary();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new ctrlSearchSalary();
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            SearchEmployees();
        }
        private void SearchEmployees()
        {
            string searchTextValue = txtsearch.Text;
            EmployeeClass empClass = new EmployeeClass();

            dgvSearchedEmployees.DataSource = empClass.SearchEmployeesListForSalary(searchTextValue);
            HideAllColumns();
            if (this.dgvSearchedEmployees.DataSource != null)
            {
                try
                {
                    dgvSearchedEmployees.Columns["FirstName"].Visible = true;
                    dgvSearchedEmployees.Columns["LastName"].Visible = true;
                    dgvSearchedEmployees.Columns["Email"].Visible = true;
                    dgvSearchedEmployees.Columns["Phone"].Visible = true;
                    dgvSearchedEmployees.Columns["CNIC"].Visible = true;
                    dgvSearchedEmployees.Columns["Dept"].Visible = true;
                    dgvSearchedEmployees.Columns["EmpID"].Visible = true;
                    dgvSearchedEmployees.Columns["isActive"].Visible = true;

                    dgvSearchedEmployees.Columns["FirstName"].DisplayIndex = 0;
                    dgvSearchedEmployees.Columns["LastName"].DisplayIndex = 1;
                    dgvSearchedEmployees.Columns["Email"].DisplayIndex = 2;
                    dgvSearchedEmployees.Columns["Phone"].DisplayIndex = 3;
                    dgvSearchedEmployees.Columns["CNIC"].DisplayIndex = 4;
                    dgvSearchedEmployees.Columns["Dept"].DisplayIndex = 5;
                    dgvSearchedEmployees.Columns["EmpID"].DisplayIndex = 6;
                    dgvSearchedEmployees.Columns["isActive"].DisplayIndex = 7;

                    this.dgvSearchedEmployees.Columns["FirstName"].HeaderText = "First Name";
                    this.dgvSearchedEmployees.Columns["LastName"].HeaderText = "Last Name";
                    this.dgvSearchedEmployees.Columns["Email"].HeaderText = "Email";
                    this.dgvSearchedEmployees.Columns["Phone"].HeaderText = "Contact";
                    this.dgvSearchedEmployees.Columns["CNIC"].HeaderText = "CNIC";
                    this.dgvSearchedEmployees.Columns["Dept"].HeaderText = "Department";
                    this.dgvSearchedEmployees.Columns["EmpID"].HeaderText = "Employee ID";
                    this.dgvSearchedEmployees.Columns["isActive"].HeaderText = "Active";

                }
                catch (Exception)
                {
                }
            }
        }
        private void HideAllColumns()
        {
            for (int i = 0; i < dgvSearchedEmployees.Columns.Count; i++)
            {
                dgvSearchedEmployees.Columns[i].Visible = false;
            }
        }
        private void HideAllControls()
        {
            var controls = this.Controls.Cast<Control>();
            foreach (var ctrl in controls)
            {
                this.Controls.Remove(ctrl);
            }
        }
        private void ctrlSearchFee_Load(object sender, EventArgs e)
        {
            //this.ctrlFee1.Hide();
            //this.pnlSalary.Hide();
            //this.btnSalaryByClass.Hide();
            txtsearch.Focus();
        }

        private void btnCloseFeeForm_Click(object sender, EventArgs e)
        {
            //ctrlFee a = new ctrlFee();
            //a.RefreshFeeForm();
            //this.pnlSalary.Hide();
            //this.pnlSearch.Show();
        }

        //private void ctrlFee1_Load(object sender, EventArgs e)
        //{
        //}

        //private void btnFeeByClass_Click(object sender, EventArgs e)
        //{
        //    FeeByClass feeByClass = new FeeByClass();
        //    feeByClass.Show();
        //}

        //private void btnEditStudentFee_Click(object sender, EventArgs e)
        //{
        //    FeeByClass feeByClass = new FeeByClass();
        //    feeByClass.Show();
        //}

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.ctrlFee1.studentId = 0;
            //this.ctrlFee1.name = "";
            //this.ctrlFee1.RollNum = "";
            //this.ctrlFee1.ClassNum = "";
            //this.ctrlFee1.home = "";
            //this.ctrlFee1.city = "";

            //this.ctrlFee1.Hide();
            //this.pnlSalary.Hide();
            //this.pnlSearch.Show();
        }

        private void dgvSearchedEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearchedEmployees.SelectedRows.Count > 0)
            {
                //HideAllControls();
                try
                {
                    if (this.Controls.Contains(ctrlSalary.Instance))
                    {
                        ctrlSalary.Instance.reset();
                    }
                    this.Controls.Add(ctrlSalary.Instance);
                    //ctrlSettings.Instance.changeParentTextWithCustomEvent += new EventHandler(log_changeParentTextWithCustomEvent);
                    //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                    //ctrlSettings.Instance.loadData(this.SessionObject);
                    ctrlSalary.Instance.CloseSalaryCtrlEvent += new EventHandler(log_CloseSalaryCtrlEvent);
                    ctrlSalary.Instance.LoadSalaryData(Convert.ToInt32(dgvSearchedEmployees.SelectedRows[0].Cells["ID"].Value));
                    ctrlSalary.Instance.Dock = DockStyle.Fill;
                    this.pnlSearch.SendToBack();
                    ctrlSalary.Instance.BringToFront();
                    //}
                    //else
                    //{
                    //    ctrlSalary.Instance.BringToFront();
                    //}
                }
                catch (Exception)
                {
                }

                //this.ctrlFee1.studentId = Convert.ToInt32(dgvSearchedStudents.SelectedRows[0].Cells["stdID"].Value);
                //this.ctrlFee1.classid = Convert.ToInt32(dgvSearchedStudents.SelectedRows[0].Cells["ClassID"].Value);

                //this.ctrlFee1.name = dgvSearchedStudents.SelectedRows[0].Cells["Name"].Value.ToString();
                //this.ctrlFee1.RollNum = dgvSearchedStudents.SelectedRows[0].Cells["Roll"].Value.ToString();
                //this.ctrlFee1.ClassNum = dgvSearchedStudents.SelectedRows[0].Cells["ClassID"].Value.ToString();
                ////this.ctrlFee1.home = dgvSearchedStudents.SelectedRows[0].Cells["Dsc"].Value.ToString();
                ////this.ctrlFee1.city = dgvSearchedStudents.SelectedRows[0].Cells["City"].Value.ToString();
                //this.pnlSearch.Hide();
                //this.pnlFee.Show();                
                //pnlFee.Dock = DockStyle.Left;
                //this.ctrlFee1.LoadAllValues();
                //this.ctrlFee1.Show();
            }
        }

        private void log_CloseSalaryCtrlEvent(object sender, EventArgs e)
        {
            this.Controls.Remove(ctrlSalary.Instance);
        }
    }
}
