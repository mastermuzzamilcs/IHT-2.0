using DAL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlSearchFee : UserControl
    {
        public ctrlSearchFee()
        {
            InitializeComponent();
        }
        private static ctrlSearchFee _instance;
        public static ctrlSearchFee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrlSearchFee();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new ctrlSearchFee();
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            SearchStudents();
        }
        private void SearchStudents()
        {
            string searchTextValue = txtsearch.Text;
            StudentDAL sDal = new StudentDAL();
            dgvSearchedStudents.DataSource = sDal.SearchStudentList(searchTextValue);
            HideAllColumns();
            dgvSearchedStudents.Columns["Name"].Visible = true;
            dgvSearchedStudents.Columns["Name"].DisplayIndex = 0;
            dgvSearchedStudents.Columns["Name"].HeaderText = "Student Name";
            dgvSearchedStudents.Columns["FatherName"].Visible = true;
            dgvSearchedStudents.Columns["FatherName"].DisplayIndex = 1;
            dgvSearchedStudents.Columns["FatherName"].HeaderText = "Father Name";
            dgvSearchedStudents.Columns["Roll"].Visible = true;
            dgvSearchedStudents.Columns["Roll"].DisplayIndex = 2;
            dgvSearchedStudents.Columns["Roll"].HeaderText = "Roll No.";
            dgvSearchedStudents.Columns["Class"].Visible = true;
            dgvSearchedStudents.Columns["Class"].DisplayIndex = 3;
            dgvSearchedStudents.Columns["Class"].HeaderText = "Class";
            dgvSearchedStudents.Columns["Section"].Visible = true;
            dgvSearchedStudents.Columns["Section"].DisplayIndex = 4;
            dgvSearchedStudents.Columns["Section"].HeaderText = "Section";
            dgvSearchedStudents.Columns["Contact1"].Visible = true;
            dgvSearchedStudents.Columns["Contact1"].DisplayIndex = 5;
            dgvSearchedStudents.Columns["Contact1"].HeaderText = "Contact";
        }
        private void HideAllColumns()
        {
            for (int i = 0; i < dgvSearchedStudents.Columns.Count; i++)
            {
                dgvSearchedStudents.Columns[i].Visible = false;
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
        private void dgvSearchedStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearchedStudents.SelectedRows.Count > 0)
            {
                //HideAllControls();
                try
                {
                    if (this.Controls.Contains(ctrlFee.Instance))
                    {
                        ctrlFee.Instance.reset();
                    }
                        this.Controls.Add(ctrlFee.Instance);
                        //ctrlSettings.Instance.changeParentTextWithCustomEvent += new EventHandler(log_changeParentTextWithCustomEvent);
                        //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                        //ctrlSettings.Instance.loadData(this.SessionObject);
                        ctrlFee.Instance.CloseFeeCtrlEvent += new EventHandler(log_CloseFeeCtrlEvent);
                        ctrlFee.Instance.LoadFeeData(Convert.ToInt32(dgvSearchedStudents.SelectedRows[0].Cells["stdID"].Value));
                        ctrlFee.Instance.Dock = DockStyle.Fill;
                        this.pnlSearch.SendToBack();
                        ctrlFee.Instance.BringToFront();
                    //}
                    //else
                    //{
                    //    ctrlFee.Instance.BringToFront();
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

        private void ctrlSearchFee_Load(object sender, EventArgs e)
        {
            //this.ctrlFee1.Hide();
            //this.pnlFee.Hide();
            //this.btnFeeByClass.Hide();
            txtsearch.Focus();
        }

        private void btnCloseFeeForm_Click(object sender, EventArgs e)
        {
            //ctrlFee a = new ctrlFee();
            //a.RefreshFeeForm();
            //this.pnlFee.Hide();
            //this.pnlSearch.Show();
        }

        private void ctrlFee1_Load(object sender, EventArgs e)
        {
        }

        private void btnFeeByClass_Click(object sender, EventArgs e)
        {
            //FeeByClass feeByClass = new FeeByClass();
            //feeByClass.Show();
        }

        private void btnEditStudentFee_Click(object sender, EventArgs e)
        {
            //FeeByClass feeByClass = new FeeByClass();
            //feeByClass.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.ctrlFee1.studentId = 0;
            //this.ctrlFee1.name = "";
            //this.ctrlFee1.RollNum = "";
            //this.ctrlFee1.ClassNum = "";
            //this.ctrlFee1.home = "";
            //this.ctrlFee1.city = "";

            //this.ctrlFee1.Hide();
            //this.pnlFee.Hide();
            //this.pnlSearch.Show();
        }
        private void log_CloseFeeCtrlEvent(object sender, EventArgs e)
        {
            //this.Controls.Contains(ctrlFee.Instance);
            this.Controls.Remove(ctrlFee.Instance);
            pnlSearch.BringToFront();
            //Refresh();
        }
    }
}
