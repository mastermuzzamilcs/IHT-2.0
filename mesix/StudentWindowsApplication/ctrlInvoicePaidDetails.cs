using DAL;
using DataTransferObjects;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlInvoicePaidDetails : UserControl
    {
        public Student student;
        public EmployeeProp employee;
        public FeeDetailEntity feeDetailEntity;
        private static ctrlInvoicePaidDetails _instance;
        public static ctrlInvoicePaidDetails Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrlInvoicePaidDetails();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new ctrlInvoicePaidDetails();
        }
        public ctrlInvoicePaidDetails(int _InvcID)
        {
            InitializeComponent();
            this.InvcID = _InvcID;
            this.student = new Student();
        }
        public ctrlInvoicePaidDetails()
        {
            InitializeComponent();
            this.student = new Student();
            this.employee = new EmployeeProp();
            this.feeDetailEntity = new FeeDetailEntity();
        }
        public int InvcID;
        private void ctrlInvoicePaidDetails_Load(object sender, EventArgs e)
        {
            if (ShowInvoicePaidDetailsEvent != null)
            {
                ShowInvoicePaidDetailsEvent(sender, new EventArgs());
            }
        }
        public event EventHandler ShowInvoicePaidDetailsEvent;
        public event EventHandler CloseCtrlEvent;

        private void dgvInvoicePaidDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int StudentID, ClassID, RollNo;
        string StudentName;
        bool IsInvcPaid;
        bool IsStudent = false;
        public void LoadCtrlData(int _InvcID, Student _s = null, EmployeeProp _e = null, bool _IsInvcPaid = false)
        {
            if (_s != null)
            {
                this.student = _s;
                IsStudent = true;
            }
            if (_e != null)
            {
                this.employee = _e;
                IsStudent = false;
            }
            this.InvcID = _InvcID;
            this.IsInvcPaid = _IsInvcPaid;

            LoadFormData();
            SetFormData();
        }
        private void SetFormData()
        {
            lblTotalRecieveables.Text = this.feeDetailEntity.Receivables.ToString();
            lblTotalPaid.Text = this.feeDetailEntity.Paid.ToString();
            lblTotalOutstandings.Text = this.feeDetailEntity.Outstandings.ToString();
            this.BringToFront();
        }
        private void LoadFormData()
        {
            FeeDAL fdal = new FeeDAL();
            EmployeeClass eClass = new EmployeeClass();
            this.dgvFeeSummary.DataSource = fdal.FeeInvoicePaidDetails(this.InvcID, IsStudent);
            if (this.dgvFeeSummary.DataSource != null)
            {
                try
                {
                this.dgvFeeSummary.Columns["RcblID"].Visible = false;
                this.dgvFeeSummary.Columns["InvoiceID"].HeaderText = "Invoice ID";
                this.dgvFeeSummary.Columns["PaidDate"].HeaderText = "Payment Date";
                this.dgvFeeSummary.Columns["PaidAmount"].HeaderText = "Amount";

                }
                catch (Exception)
                {
                }
            }
            if (IsStudent)
            {
                this.feeDetailEntity = fdal.GetFeeDetailEntity(1, this.InvcID, 0);
            }
            else
            {
                this.feeDetailEntity = eClass.GetSalaryDetailEntity(1, this.InvcID, 0);
                lblHeadingTotalRecieveables.Text = "Total Payables";
            }
            this.IsInvcPaid = this.feeDetailEntity.Outstandings > 0 ? false : true;
            this.btnCollectFee.Visible = !IsInvcPaid;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (CloseCtrlEvent != null)
            {
                CloseCtrlEvent(sender, new EventArgs());
            }
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
        private bool isSalaryCnfgSet()
        {
            EmployeeClass eClass = new EmployeeClass();
            var res = eClass.GetSalaryCnfg(this.employee.ID).Where(x => x.Status == true).FirstOrDefault();
            if (res == null || res.Status == false || res.SalaryCnfgID < 1)
            {
                return false;
            }
            return true;
        }

        private void smsButtons1_Click(object sender, EventArgs e)
        {
            if (IsStudent)
            {
                GntnInvcForm gif = new GntnInvcForm(this.InvcID,this.student);
                gif.CloseGntnInvcFormEvent += new EventHandler(log_CloseGntnInvcFormEvent);
                gif.Show();
            }
            else
            {
                GntnInvcForm gif = new GntnInvcForm(this.InvcID, null, this.employee);
                gif.CloseGntnInvcFormEvent += new EventHandler(log_CloseGntnInvcFormEvent);
                gif.Show();
            }
        }

        private void btnCollectFee_Click(object sender, EventArgs e)
        {
            if (IsStudent)
            {
                if (!isFeeCnfgSet())
                {
                    MessageBox.Show("Stop", "Please Configure Fee First", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    CollectFee frm = new CollectFee(this.feeDetailEntity, this.student, null, this.InvcID);
                    frm.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                    frm.Show();
                }
            }
            else
            {
                if (!isSalaryCnfgSet())
                {
                    MessageBox.Show("Stop", "Please Configure Fee First", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    CollectFee frm = new CollectFee(this.feeDetailEntity, null, this.employee, this.InvcID);
                    frm.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                    frm.Show();
                }
            }
        }
        private void log_CloseCtrlEvent(object sender, EventArgs e)
        {
            this.LoadFormData();
            this.SetFormData();
            
        }
        private void log_CloseGntnInvcFormEvent(object sender, EventArgs e)
        {
            this.LoadFormData();
            this.SetFormData();
        }
    }
}
