using DAL;
using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class GntnInvcForm : Form
    {
        public Student s;
        public bool IsStudent = false;
        public EmployeeProp e;
        public FeeCnfg fc;
        public SalaryCnfg sc;
        public FeesInvoiceDetail fid;
        public FeesInvoiceDetail TempFID;
        public SalaryInvoiceDetail sid;
        public SalaryInvoiceDetail TempSID;
        public int InvoiceID;
        public GntnInvcForm(Student _s = null, EmployeeProp _e = null)
        {
            InitializeComponent();
            if (_s != null)
            {
                this.s = _s;
                this.IsStudent = true;
            }
            if (_e != null)
            {
                this.e = _e;
                this.IsStudent = false;
            }

            this.fc = new FeeCnfg();
            this.sc = new SalaryCnfg();
            this.fid = new FeesInvoiceDetail();
            this.sid = new SalaryInvoiceDetail();
        }
        public GntnInvcForm(int invoiceID, Student _s = null, EmployeeProp _e = null)
        {
            InitializeComponent();
            if (_s != null)
            {
                this.s = _s;
                this.IsStudent = true;
            }
            if (_e != null)
            {
                this.e = _e;
                this.IsStudent = false;
            }

            this.fc = new FeeCnfg();
            this.sc = new SalaryCnfg();
            this.fid = new FeesInvoiceDetail();
            this.sid = new SalaryInvoiceDetail();
            InvoiceID = invoiceID;
        }
        private void GntnInvcForm_Load(object sender, EventArgs e)
        {
            GetFormData();
            SetFormData();
            this.CenterToScreen();
        }
        public void SetFormData()
        {
            if (IsStudent)
            {
                txtStudentName.Text = this.s.userObj.FirstName + " " + this.s.userObj.SecondName;
                txtStudentName.ReadOnly = true;
                txtRoll.Text = this.s.Roll.ToString();
                txtRoll.ReadOnly = true;
                if (InvoiceID > 0)
                {
                    if (this.s != null)
                    {
                        txtAmount.Text = this.TempFID.InvoiceAmount.ToString();
                        dtpInvcDate.Value = this.TempFID.InvoiceDate;
                    }
                    if (this.e != null)
                    {
                        txtAmount.Text = this.TempSID.InvoiceAmount.ToString();
                        dtpInvcDate.Value = this.TempSID.InvoiceDate;
                    }
                }
                else
                {
                    txtAmount.Text = this.fc.Amount.ToString();
                    dtpInvcDate.Value = DateTime.Now;
                }
            }
            else
            {
                lblName.Text = "Name";
                txtStudentName.Text = this.e.FirstName + " " + this.e.LastName;
                txtStudentName.ReadOnly = true;

                //Hides rollnumber and update layout - Start
                txtRoll.Visible = false;
                lblRoll.Visible = false;

                var row = tableLayoutPanel2.GetRow(txtRoll);
                tableLayoutPanel2.RowStyles[row].SizeType = SizeType.Percent;
                tableLayoutPanel2.RowStyles[row].Height = 0;

                //update the layout immediately.
                tableLayoutPanel1.PerformLayout();
                //End

                if (InvoiceID > 0)
                {
                    if (this.e != null)
                    {
                        txtAmount.Text = this.TempSID.InvoiceAmount.ToString();
                        dtpInvcDate.Value = this.TempSID.InvoiceDate;
                    }
                }
                else
                {
                    txtAmount.Text = this.sc.Amount.ToString();
                    dtpInvcDate.Value = DateTime.Now;
                }
            }
        }
        public void GetFormData()
        {
            if (IsStudent)
            {
                FeeDAL fdal = new FeeDAL();
                //agr invoiceid hy to invoice ki details fc me set krwa do
                if (InvoiceID > 0)
                {
                    this.TempFID = fdal.GetFeeInvoiceByInvoiceID(this.InvoiceID);
                }
                else
                {
                    this.fc = fdal.GetFeeCnfg(this.s.stdID).Where(x => x.Status == true).FirstOrDefault();
                    if (this.fc == null)
                    {
                        this.fc = new FeeCnfg();
                    }
                }
            }
            else
            {
                EmployeeClass emp = new EmployeeClass();

                if (InvoiceID > 0)
                {
                    this.TempSID = emp.GetInvoiceByID(this.InvoiceID);
                }
                else
                {
                    this.sc = emp.GetSalaryCnfg(this.e.ID).Where(x => x.Status == true).FirstOrDefault();
                    if (this.sc == null)
                    {
                        this.sc = new SalaryCnfg();
                    }
                }
            }
        }
        public void RefreshFormControls()
        {
            GetFormData();
            SetFormData();
            txtStudentName.Focus();
        }

        private void btnGntnInvc_Click(object sender, EventArgs e)
        {
            FeeDAL fdal = new FeeDAL();
            EmployeeClass empClass = new EmployeeClass();
            if (IsStudent)
            {
                List<FeesInvoiceDetail> res = new List<FeesInvoiceDetail>();
                if (!(InvoiceID > 0))
                {
                    res = fdal.IsInvcExists(this.s.stdID, dtpInvcDate.Value);
                }
                if (res.Count <= 0)
                {
                    fid.StudentID = this.s.stdID;
                    fid.InvoiceAmount = Convert.ToDecimal(txtAmount.Text);
                    fid.InvoiceDate = dtpInvcDate.Value;
                    fid.Status = false;
                    fid.Comments = txtComments.Text;
                    if (InvoiceID > 0)
                    {
                        fid.InvoiceID = InvoiceID;
                        if (fdal.UpdateInvoice(IsStudent, fid, null))
                        {
                            MessageBox.Show("Invoice Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshFormControls();
                        }
                        else
                        {
                            MessageBox.Show("An unhandled error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                        if (fdal.GenerateInvoice(IsStudent, fid, null))
                        {
                            MessageBox.Show("Invoice Generated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshFormControls();
                        }
                        else
                        {
                            MessageBox.Show("An unhandled error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invoice Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                List<SalaryInvoiceDetail> res = new List<SalaryInvoiceDetail>();
                if (!(InvoiceID > 0))
                {
                    res = empClass.IsSlryInvcExists(this.e.ID, dtpInvcDate.Value);
                }
                if (res.Count <= 0)
                {
                    sid.EmpID = this.e.ID;
                    sid.InvoiceAmount = Convert.ToDecimal(txtAmount.Text);
                    sid.InvoiceDate = dtpInvcDate.Value;
                    sid.Status = false;
                    sid.Comments = txtComments.Text;
                    if (InvoiceID > 0)
                    {
                        sid.InvoiceID = InvoiceID;
                        if (fdal.UpdateInvoice(IsStudent, null, sid))
                        {
                            MessageBox.Show("Invoice Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshFormControls();
                        }
                        else
                        {
                            MessageBox.Show("An unhandled error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                        if (fdal.GenerateInvoice(IsStudent, null, sid))
                        {
                            MessageBox.Show("Invoice Generated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshFormControls();
                        }
                        else
                        {
                            MessageBox.Show("An unhandled error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invoice Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public event EventHandler CloseGntnInvcFormEvent;

        private void GntnInvcForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CloseGntnInvcFormEvent != null)
            {
                CloseGntnInvcFormEvent(sender, new EventArgs());
            }
        }
    }
}
