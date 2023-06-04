using DAL;
using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlFee : UserControl
    {
        public ctrlFee()
        {
            InitializeComponent();
            this.student = new Student();
            this.FeeList = new List<FeesModel>();
            this.FeeInvoiceDet = new List<FeesInvoiceDetail>();
            this.TotalFeeDetailEntity = new FeeDetailEntity();
            this.MonthlyFeeDetailEntity = new FeeDetailEntity();
        }
        private static ctrlFee _instance;
        public static ctrlFee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrlFee();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new ctrlFee();
        }
        public Student student;
        public List<FeesModel> FeeList;
        public List<FeesInvoiceDetail> FeeInvoiceDet;
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
        public void LoadFeeData(int _id)
        {
            btnCollectFee.Visible = false;
            this.student.stdID = _id;
            GetStudentInfo();
            GetFeeInfo();
            SetFormData();
            //btnClose.BringToFront();
        }
        private void GetStudentInfo()
        {
            StudentDAL sdal = new StudentDAL();
            this.student = sdal.ViewStudentInfo(this.student.stdID);
        }
        private void GetFeeInfo()
        {
            FeeDAL fdal = new FeeDAL();
            this.FeeInvoiceDet = (this.student.stdID > 0) ? fdal.FeeInvoiceDetails(this.student.stdID) : null;
            this.MonthlyFeeDetailEntity = fdal.GetFeeDetailEntity(2, 0, this.student.stdID);
            this.TotalFeeDetailEntity = fdal.GetFeeDetailEntity(3, 0, this.student.stdID);
        }
        private void SetFormData()
        {
            lblFeeName.Text = this.student.Name;
            dgvFeeSummary.DataSource = this.FeeInvoiceDet;
            if (dgvFeeSummary.DataSource != null)
            {
                try
                {
                    //dgvFeeSummary.Columns["FeeID"].Visible = false;
                    dgvFeeSummary.Columns["InvoiceID"].DisplayIndex = 0;
                    dgvFeeSummary.Columns["InvoiceDate"].DisplayIndex = 1;
                    dgvFeeSummary.Columns["INSR_DTE"].DisplayIndex = 2;
                    dgvFeeSummary.Columns["InvoiceAmount"].DisplayIndex = 3;
                    dgvFeeSummary.Columns["Status"].DisplayIndex = 4;
                    dgvFeeSummary.Columns["InvoiceAmount"].HeaderText = "Amount";
                    dgvFeeSummary.Columns["INSR_DTE"].HeaderText = "Insert Date";
                    dgvFeeSummary.Columns["InvoiceDate"].HeaderText = "Invoice Date";
                    dgvFeeSummary.Columns["StudentID"].Visible = false;

                }
                catch (Exception)
                {
                }
            }
            //lblset krwa monthly oustanding, paid receivables
            // total paid, receivables, oustanding
            lblTotalRecieveables.Text = this.TotalFeeDetailEntity.Receivables.ToString();
            lblTotalPaid.Text = this.TotalFeeDetailEntity.Paid.ToString();
            lblTotalOutstandings.Text = this.TotalFeeDetailEntity.Outstandings.ToString();
            lblMonthlyRecieveables.Text = this.MonthlyFeeDetailEntity.Receivables.ToString();
            lblMonthlyPaid.Text = this.MonthlyFeeDetailEntity.Paid.ToString();
            lblMonthlyOutstandings.Text = this.MonthlyFeeDetailEntity.Outstandings.ToString();
        }
        public void LoadAllValues()
        {
            FeeDAL fdal = new FeeDAL();
            //FeeList = (this.studentId > 0) ? fdal.FeeSummary(studentId) : null;
            //dgvFeeSummary.DataSource = FeeList;
            if (dgvFeeSummary.DataSource != null)
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

        private void ctrlFee_Load(object sender, EventArgs e)
        {
            //LoadAllValues();
        }

        public void RefreshFeeForm()
        {
            LoadFeeData(this.student.stdID);
        }
        private bool isFeeCnfgSet()
        {
            StudentDAL sdal = new StudentDAL();
            var res = sdal.GetStudentFeeCnfg(this.student.stdID);
            if (res == null || res.Status == false || res.FeeCnfgID < 1)
            {
                return false;
            }
            return true;
        }
        private void btnCollectFee_Click(object sender, EventArgs e)
        {
            if (!isFeeCnfgSet())
            {
                student.stdID = this.studentId;
                student.ClassId = this.classid;
                student.Roll = Convert.ToInt32(this.RollNum);
                student.Name = this.name;
                FeeByClass feeByClass = new FeeByClass(student, false);
                feeByClass.Show();
            }
            else
            {
                CollectFee frm = new CollectFee(null, this.student, null);
                frm.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshFeeForm();
        }

        private void dgvFeeSummary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(dgvFeeSummary.SelectedRows[0].Cells["InvoiceID"].Value) > 0)
            {
                try
                {
                    if (this.Controls.Contains(ctrlInvoicePaidDetails.Instance))
                    {
                        ctrlInvoicePaidDetails.Instance.reset();
                    }
                    this.Controls.Add(ctrlInvoicePaidDetails.Instance);
                    ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                    ctrlInvoicePaidDetails.Instance.LoadCtrlData(Convert.ToInt32(dgvFeeSummary.SelectedRows[0].Cells["InvoiceID"].Value), this.student, null, Convert.ToBoolean(dgvFeeSummary.SelectedRows[0].Cells["Status"].Value));
                    ctrlInvoicePaidDetails.Instance.Dock = DockStyle.Fill;
                    ctrlInvoicePaidDetails.Instance.BringToFront();
                    //}
                    //else
                    //{
                    //    ctrlInvoicePaidDetails.Instance.BringToFront();
                    //}
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

            CollectFee frm = new CollectFee(this.studentId, Convert.ToInt32(dgvFeeSummary.SelectedRows[0].Cells["FeeID"].Value),
                                Convert.ToDecimal(dgvFeeSummary.SelectedRows[0].Cells["PaidAmount"].Value), Convert.ToDecimal(dgvFeeSummary.SelectedRows[0].Cells["Balance"].Value)
                                , dgvFeeSummary.SelectedRows[0].Cells["SubmitDateTime"].Value.ToString(), dgvFeeSummary.SelectedRows[0].Cells["SubmittedBy"].Value.ToString()
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

        private void btnFeeCnfg_Click(object sender, EventArgs e)
        {
            //student.stdID = this.studentId;
            //student.ClassId = this.classid;
            //student.Roll = Convert.ToInt32(this.RollNum);
            //student.Name = this.name;
            FeeByClass feeByClass = new FeeByClass(this.student, false);
            feeByClass.Show();
        }
        public event EventHandler CloseFeeCtrlEvent;

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (CloseFeeCtrlEvent != null)
            {
                CloseFeeCtrlEvent(sender, new EventArgs());
            }
        }

        private void btnGntnInvc_Click(object sender, EventArgs e)
        {
            if (!isFeeCnfgSet())
            {
                student.stdID = this.student.stdID;
                student.ClassId = this.student.ClassId;
                student.Roll = Convert.ToInt32(this.student.Roll);
                student.Name = this.student.userObj.FirstName + " " + this.student.userObj.SecondName;
                FeeByClass feeByClass = new FeeByClass(student, false);
                feeByClass.Show();
            }
            else
            {
                GntnInvcForm gif = new GntnInvcForm(this.student);
                gif.CloseGntnInvcFormEvent += new EventHandler(log_CloseGntnInvcFormEvent);
                gif.Show();
            }
        }
        private void log_CloseGntnInvcFormEvent(object sender, EventArgs e)
        {
            RefreshFeeForm();
        }
    }
}

