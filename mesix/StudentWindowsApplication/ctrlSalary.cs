using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlSalary : UserControl
    {
        private static ctrlSalary _instance;
        public static ctrlSalary Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrlSalary();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new ctrlSalary();
        }
        public ctrlSalary()
        {
            InitializeComponent();
            this.EmpObj = new EmployeeProp();
            this.FeeList = new List<FeesModel>();
            this.FeeInvoiceDet = new List<SalaryInvoiceDetail>();
            this.TotalFeeDetailEntity = new FeeDetailEntity();
            this.MonthlyFeeDetailEntity = new FeeDetailEntity();
        }
        public EmployeeProp EmpObj;
        public List<FeesModel> FeeList;
        public List<SalaryInvoiceDetail> FeeInvoiceDet;
        public FeeDetailEntity TotalFeeDetailEntity;
        public FeeDetailEntity MonthlyFeeDetailEntity;

        public int studentId { get; set; }
        public int classid { get; set; }
        public string name { get; set; }
        public string RollNum { get; set; }
        public string ClassNum { get; set; }
        public string home { get; set; }
        public string city { get; set; }
        public string feename { get; set; }
        public void LoadSalaryData(int _id)
        {
            btnCollectFee.Visible = false;
            this.EmpObj.ID = _id;
            GetEmployeeInfo();
            GetSalaryInfo();
            SetFormData();
            //btnClose.BringToFront();
        }
        private void GetEmployeeInfo()
        {
            EmployeeClass eClass = new EmployeeClass();
            this.EmpObj = eClass.GetEmployeeInfo(this.EmpObj.ID);
        }
        private void GetSalaryInfo()
        {
            EmployeeClass eClass = new EmployeeClass();
            this.FeeInvoiceDet = (this.EmpObj.ID > 0) ? eClass.SalaryInvoiceDetails(this.EmpObj.ID) : null;
            this.MonthlyFeeDetailEntity = eClass.GetSalaryDetailEntity(2, 0, this.EmpObj.ID);
            this.TotalFeeDetailEntity = eClass.GetSalaryDetailEntity(3, 0, this.EmpObj.ID);
        }
        private void SetFormData()
        {
            //Implement Now
            lblFeeName.Text = this.EmpObj.FirstName + " " + this.EmpObj.LastName;
            dgvSalarySummary.DataSource = this.FeeInvoiceDet;
            if (dgvSalarySummary.DataSource != null)
            {
                try
                {
                    this.dgvSalarySummary.Columns["EmpID"].Visible = false;
                    this.dgvSalarySummary.Columns["InvoiceDate"].HeaderText = "Invoice Date";
                    this.dgvSalarySummary.Columns["INSR_DTE"].HeaderText = "Insert Date";
                    this.dgvSalarySummary.Columns["InvoiceAmount"].HeaderText = "Amount";
                }
                catch (Exception)
                {
                }
                //dgvFeeSummary.Columns["FeeID"].Visible = false;
                //dgvFeeSummary.Columns["StudentID"].Visible = false;
                //dgvFeeSummary.Columns["Month"].Visible = false;
                //dgvFeeSummary.Columns["ReceiptNumber"].Visible = false;
                //dgvFeeSummary.Columns["SubmittedByUserID"].Visible = false;
                //dgvFeeSummary.Columns["OutstandingAmount"].Visible = false;
                //dgvFeeSummary.Columns["INSR_DTE"].Visible = false;
                //dgvFeeSummary.Columns["SubmitDateTime"].DisplayIndex = 0;
                //dgvFeeSummary.Columns["Day"].DisplayIndex = 1;
                //dgvFeeSummary.Columns["MonthName"].DisplayIndex = 2;
                //dgvFeeSummary.Columns["Year"].DisplayIndex = 3;
                //dgvFeeSummary.Columns["IssuedAmount"].DisplayIndex = 4;
                //dgvFeeSummary.Columns["PaidAmount"].DisplayIndex = 5;
                //dgvFeeSummary.Columns["Balance"].DisplayIndex = 6;
                //dgvFeeSummary.Columns["isPaid"].DisplayIndex = 7;
                //dgvFeeSummary.Columns["SubmittedBy"].DisplayIndex = 8;
                //dgvFeeSummary.Columns["SubmittedBy"].HeaderText = "Submitted By";
            }
            //lblset krwa monthly oustanding, paid receivables
            // total paid, receivables, oustanding
            lblTotalPayables.Text = this.TotalFeeDetailEntity.Receivables.ToString();
            lblTotalPaid.Text = this.TotalFeeDetailEntity.Paid.ToString();
            lblTotalOutstandings.Text = this.TotalFeeDetailEntity.Outstandings.ToString();
            lblMonthlyPayables.Text = this.MonthlyFeeDetailEntity.Receivables.ToString();
            lblMonthlyPaid.Text = this.MonthlyFeeDetailEntity.Paid.ToString();
            lblMonthlyOutstandings.Text = this.MonthlyFeeDetailEntity.Outstandings.ToString();
        }
        public void LoadAllValues()
        {
            lblFeeName.Text = name;
            FeeDAL fdal = new FeeDAL();
            EmployeeClass eClass = new EmployeeClass();
            //FeeList = (this.studentId > 0) ? fdal.FeeSummary(studentId) : null;
            //FeeInvoiceDet = (this.EmpObj.ID > 0) ? eClass.sala (this.EmpObj.ID) : null;
            this.MonthlyFeeDetailEntity = fdal.GetFeeDetailEntity(2, 0, this.studentId);
            this.TotalFeeDetailEntity = fdal.GetFeeDetailEntity(3, 0, this.studentId);
            //dgvFeeSummary.DataSource = FeeList;
            dgvSalarySummary.DataSource = FeeInvoiceDet;
            if (dgvSalarySummary.DataSource != null)
            {


                //dgvFeeSummary.Columns["FeeID"].Visible = false;
                //dgvFeeSummary.Columns["StudentID"].Visible = false;
                //dgvFeeSummary.Columns["Month"].Visible = false;
                //dgvFeeSummary.Columns["ReceiptNumber"].Visible = false;
                //dgvFeeSummary.Columns["SubmittedByUserID"].Visible = false;
                //dgvFeeSummary.Columns["OutstandingAmount"].Visible = false;
                //dgvFeeSummary.Columns["INSR_DTE"].Visible = false;
                //dgvFeeSummary.Columns["SubmitDateTime"].DisplayIndex = 0;
                //dgvFeeSummary.Columns["Day"].DisplayIndex = 1;
                //dgvFeeSummary.Columns["MonthName"].DisplayIndex = 2;
                //dgvFeeSummary.Columns["Year"].DisplayIndex = 3;
                //dgvFeeSummary.Columns["IssuedAmount"].DisplayIndex = 4;
                //dgvFeeSummary.Columns["PaidAmount"].DisplayIndex = 5;
                //dgvFeeSummary.Columns["Balance"].DisplayIndex = 6;
                //dgvFeeSummary.Columns["isPaid"].DisplayIndex = 7;
                //dgvFeeSummary.Columns["SubmittedBy"].DisplayIndex = 8;
                //dgvFeeSummary.Columns["SubmittedBy"].HeaderText = "Submitted By";

            }
        }
        private void LoadEmpData(int _id)
        {

        }
        private void ctrlSalary_Load(object sender, EventArgs e)
        {
            //LoadAllValues();
            //btnPaySalary.Enabled = false;
        }

        public void RefreshFeeForm()
        {
            //LoadAllValues();
            LoadSalaryData(this.EmpObj.ID);
        }
        private bool isSalaryCnfgSet()
        {
            EmployeeClass eClass = new EmployeeClass();
            var res = eClass.GetSalaryCnfg(this.EmpObj.ID).Where(x => x.Status == true).FirstOrDefault();
            if (res == null || res.Status == false || res.SalaryCnfgID < 1)
            {
                return false;
            }
            return true;
        }
        private void btnCollectFee_Click(object sender, EventArgs e)
        {
            //if (!isFeeCnfgSet())
            //{
            //    student.stdID = this.studentId;
            //    student.ClassId = this.classid;
            //    student.Roll = Convert.ToInt32(this.RollNum);
            //    student.Name = this.name;
            //    FeeByClass feeByClass = new FeeByClass(student, false);
            //    feeByClass.Show();
            //}
            //else
            //{
            //    CollectFee frm = new CollectFee(this.studentId);
            //    frm.Show();
            //}
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshFeeForm();
        }

        private void dgvSalarySummary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(dgvSalarySummary.SelectedRows[0].Cells["InvoiceID"].Value) > 0)
            {
                try
                {
                    if (this.Controls.Contains(ctrlInvoicePaidDetails.Instance))
                    {
                        ctrlInvoicePaidDetails.Instance.reset();
                    }
                        this.Controls.Add(ctrlInvoicePaidDetails.Instance);
                        ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                        ctrlInvoicePaidDetails.Instance.LoadCtrlData(Convert.ToInt32(dgvSalarySummary.SelectedRows[0].Cells["InvoiceID"].Value), null, this.EmpObj, Convert.ToBoolean(dgvSalarySummary.SelectedRows[0].Cells["Status"].Value));
                        ctrlInvoicePaidDetails.Instance.Dock = DockStyle.Fill;
                        ctrlInvoicePaidDetails.Instance.BringToFront();
                    //}
                    //else
                    //{
                    //    ctrlInvoicePaidDetails.Instance.BringToFront();
                    //}

                    //ShowReceiptControl for Specified invc

                    //decimal TotalPaid = 0;

                    //foreach (var feeDetail in FeeList)
                    //{
                    //    TotalPaid += feeDetail.PaidAmount;
                    //}

                    //CollectFee frm = new CollectFee(this.studentId, Convert.ToInt32(dgvFeeSummary.SelectedRows[0].Cells["FeeID"].Value),
                    //                    Convert.ToDecimal(dgvFeeSummary.SelectedRows[0].Cells["PaidAmount"].Value), Convert.ToDecimal(dgvFeeSummary.SelectedRows[0].Cells["Balance"].Value)
                    //                    , dgvFeeSummary.SelectedRows[0].Cells["SubmitDateTime"].Value.ToString(), dgvFeeSummary.SelectedRows[0].Cells["SubmittedBy"].Value.ToString()
                    //                    , TotalPaid);
                    //frm.Show();
                }
                catch (Exception)
                {
                }
            }
        }
        public void ReceiptDetails()
        {
            decimal TotalPaid = 0;

            foreach (var feeDetail in FeeList)
            {
                TotalPaid += feeDetail.PaidAmount;
            }

            CollectFee frm = new CollectFee(this.studentId, Convert.ToInt32(dgvSalarySummary.SelectedRows[0].Cells["FeeID"].Value),
                                Convert.ToDecimal(dgvSalarySummary.SelectedRows[0].Cells["PaidAmount"].Value), Convert.ToDecimal(dgvSalarySummary.SelectedRows[0].Cells["Balance"].Value)
                                , dgvSalarySummary.SelectedRows[0].Cells["SubmitDateTime"].Value.ToString(), dgvSalarySummary.SelectedRows[0].Cells["SubmittedBy"].Value.ToString()
                                , TotalPaid);
            frm.Show();
        }
        private void log_ShowInvoicePaidDetailsEvent(object sender, EventArgs e)
        {
            this.ReceiptDetails();
        }
        private void log_CloseCtrlEvent(object sender, EventArgs e)
        {
            this.Controls.Remove(ctrlInvoicePaidDetails.Instance);
            RefreshFeeForm();
        }

        private void btnSalaryCnfg_Click(object sender, EventArgs e)
        {
            SalaryCnfgForm scf = new SalaryCnfgForm(this.EmpObj);
            scf.Show();
        }
        private void btnGntnInvc_Click(object sender, EventArgs e)
        {
            if (isSalaryCnfgSet())
            {
                GntnInvcForm gif = new GntnInvcForm(null, this.EmpObj);
                gif.CloseGntnInvcFormEvent += new EventHandler(log_CloseGntnInvcFormEvent);
                gif.Show();

            }
            else
            {
                SalaryCnfgForm scf = new SalaryCnfgForm(this.EmpObj);
                scf.Show();
            }
        }
        private void log_CloseGntnInvcFormEvent(object sender, EventArgs e)
        {
            RefreshFeeForm();
        }
        public event EventHandler CloseSalaryCtrlEvent;
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (CloseSalaryCtrlEvent != null)
            {
                CloseSalaryCtrlEvent(sender, new EventArgs());
            }
        }

        private void btnCollectFee_Click_1(object sender, EventArgs e)
        {

        }
    }
}

