using DAL;
using DataTransferObjects;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class CollectFee : Form
    {
        //public CollectFee()
        //{
        //    InitializeComponent();
        //}
        bool isNewSubmit = true;
        bool IsStudent = false;
        FeeDetailEntity fDetailEntity;
        FeeCnfg feeCnfg;
        Student student;
        EmployeeProp employee;
        FeesModel feeDetail;
        int Invc_ID;
        //List<FeesModel> FeeList;
        //public CollectFee(int _sID,List<FeesModel> _feeDetail=null)
        public CollectFee(FeeDetailEntity _fDetail = null, Student _s = null, EmployeeProp _e = null, int _invcid = 0)
        {
            InitializeComponent();
            this.student = new Student();
            this.employee = new EmployeeProp();
            this.feeCnfg = new FeeCnfg();
            this.feeDetail = new FeesModel();
            if (_fDetail != null)
            {
                this.fDetailEntity = _fDetail;
            }
            if (_invcid > 0)
            {
                this.Invc_ID = _invcid;
            }
            else
            {

            }
            if (_s != null)
            {
                this.student = _s;
                this.IsStudent = true;
            }
            if (_e != null)
            {
                this.employee = _e;
                this.IsStudent = false;
            }
            btnDismiss.Visible = false;
            btnPrint.Visible = true;
        }
        public CollectFee(int _sID, int _rID, decimal _paidFee, decimal _balance, string _submitDateTime, string _submittedBy, decimal TotalPaid)
        {
            InitializeComponent();
            //this.studentId = _sID;
            this.ReceiptId = _rID;
            this.feeCnfg = new FeeCnfg();
            this.student = new Student();
            this.feeDetail = new FeesModel();
            this.isNewSubmit = true;
            this.feeDetail.PaidAmount = _paidFee;
            this.feeDetail.Balance = _balance;
            this.feeDetail.SubmitDateTime = _submitDateTime;
            this.feeDetail.SubmittedBy = _submittedBy;
            btnSubmitFee.Visible = false;
            dateTimePicker1.Enabled = false;
            txtPasword.Visible = false;
        }
        public int studentId { get; set; }
        public int ReceiptId { get; set; }
        public string name { get; set; }
        public string RollNum { get; set; }
        public string ClassNum { get; set; }
        public string home { get; set; }
        public string city { get; set; }
        public string feename { get; set; }
        public void LoadAllValues()
        {
            lblTotalFee.Text = "Total Amount";
            lblPaidFee.Text = "Paid Amount";
            if (IsStudent)
            {
                lblName.Text = this.student.Name;
                lblRollNumber.Text = this.student.Roll.ToString();
                lblClass.Text = this.student.Class;
                GetStudentFeeCnfg();
            }
            else
            {
                lblName.Text = this.employee.FirstName + " " + this.employee.LastName;
                lblRollNumber.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                lblClass.Visible = false;
            }
            SetStudentFeeCnfg();
            rbtnCash.Checked = true;
            rbtnBank.Visible = false;
            rbtnCash.Visible = false;
            lblBankReceipt.Visible = false;
            txtBankReceipt.Visible = false;
            this.CenterToScreen();
        }
        private void CollectFee_Load(object sender, EventArgs e)
        {
            RefreshFeeForm();
            LoadAllValues();
            this.BringToFront();
            this.CenterToScreen();
        }
        private void GetStudentFeeCnfg()
        {
            StudentDAL sd = new StudentDAL();
            this.feeCnfg = sd.GetStudentFeeCnfg(this.student.stdID);
            //this.student = sd.ViewStudentInfo(this.student.stdID);

        }
        private void SetStudentFeeCnfg()
        {
            txtFeeInfo.Text = this.fDetailEntity.Outstandings.ToString();
            if (isNewSubmit)
            {
                txtPaidFee.Text = "0";
            }
            SetAmounts();
            if (IsStudent)
            {
                lblRollNumber.Text = this.student.Roll.ToString();
                lblClass.Text = this.student.Class;
                lblName.Text = this.student.Name;

            }
            decimal TotalPaid = 0, outStand = 0, TotalFee = 0;

            //foreach(FeesModel feeDet in this.FeeList.Where(x=> x.Month== Convert.ToInt32(DateTime.Now.Month)).ToList<FeesModel>())
            //foreach(FeesModel feeDet in this.FeeList)
            //{
            //    TotalPaid += feeDet.PaidAmount;
            //}

            //this.feeDetail.OutstandingAmount;

            txtFeeInfo.Enabled = false;
            txtBalance.Enabled = false;
            if (!isNewSubmit)
            {
                txtPaidFee.Text = this.feeDetail.PaidAmount.ToString();
                txtBalance.Text = this.feeDetail.Balance.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(this.feeDetail.SubmitDateTime);
                txtLogIn.Text = this.feeDetail.SubmittedBy;
                txtLogIn.Enabled = false;
                txtPaidFee.Enabled = false;
            }
        }

        private void btnSubmitFee_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                FeesPaidDetail request = new FeesPaidDetail();
                StudentDAL sd = new StudentDAL();
                HomeDAL hdal = new HomeDAL();
                var res = hdal.ValidateLogin(txtLogIn.Text, txtPasword.Text);
                if (res.isAuthenticated)
                {
                    request.PaidAmount = Convert.ToDecimal(txtPaidFee.Text);
                    request.InvoiceID = this.Invc_ID;
                    request.PaidDate = dateTimePicker1.Value.Date;

                    if ((request.RcblID = sd.SubmitFees(request, IsStudent)) > 0)
                    {
                        if (IsStudent)
                        {
                            MessageBox.Show("Fee Submitted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invoice Payment Submitted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //print();
                        RefreshFeeForm();
                        LoadAllValues();
                    }
                }
                else
                    MessageBox.Show("UserId/Password are wrong.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool IsValid()
        {
            if (txtLogIn.Text == "" || txtLogIn.Text == null)
            {
                MessageBox.Show("Please provide UserName.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtPasword.Text == "" || txtPasword.Text == null)
            {
                MessageBox.Show("Please provide Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtPaidFee.Text == "" || txtPaidFee.Text == null || Convert.ToDecimal(txtPaidFee.Text) <= 0)
            {
                MessageBox.Show("Please provide Paid Amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (Convert.ToDecimal(txtPaidFee.Text) > Convert.ToDecimal(txtFeeInfo.Text))
            {
                MessageBox.Show("Paid Amount Can't be Greater Than Total Amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void rbtnCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCash.Checked)
                txtBankReceipt.Enabled = false;
            else if (rbtnBank.Checked)
                txtBankReceipt.Enabled = true;
        }
        public void RefreshFeeForm()
        {
            txtBankReceipt.Text = "";
            txtPaidFee.Text = "";
            txtLogIn.Clear();
            txtPasword.Clear();
            txtPaidFee.Focus();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            //Update Fees set status =0 where FeeID=this.ReceiptID
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //View a Telerik Report
            MessageBox.Show("Can't Continue with Currently Subscribed Package", "Unable to Access", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public event EventHandler CloseCtrlEvent;

        private void CollectFee_FormClosed(object sender, FormClosedEventArgs e)
        {
            //trigger close event
            if (CloseCtrlEvent != null)
            {
                CloseCtrlEvent(sender, new EventArgs());
            }
        }

        private void txtFeeInfo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPaidFee_TextChanged(object sender, EventArgs e)
        {
            SetAmounts();

        }
        private void SetAmounts()
        {
            decimal Total = 0, Paid = 0;
            if (txtFeeInfo.Text != null && txtFeeInfo.Text != String.Empty && txtFeeInfo.Text != "")
            {
                Total = Convert.ToDecimal(txtFeeInfo.Text);
            }
            if (txtPaidFee.Text != null && txtPaidFee.Text != String.Empty && txtPaidFee.Text != "")
            {
                Paid = Convert.ToDecimal(txtPaidFee.Text);
            }
            txtBalance.Text = (Total - Paid).ToString();
        }
    }
}
