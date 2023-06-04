using DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlEmployee : UserControl
    {
        public ctrlEmployee()
        {
            InitializeComponent();
        }
        private static ctrlEmployee _instance;
        public static ctrlEmployee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrlEmployee();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new ctrlEmployee();
        }
        public int start = 1;
        public int end = 10;
        public int ID;
        public int PageNumber
        {
            get;
            set;
        } = 0;
        public int RecordsCount
        {
            get;
            set;
        } = 0;
        public int PageSize
        {
            get;
            set;
        } = 10;

        private void ctrlEmployee_Load(object sender, EventArgs e)
        {
            GetEmployeeRecords();
        }
        public void GetEmployeeRecords()
        {
            EmployeeClass emp = new EmployeeClass();
            List<EmpTag> Tags = emp.GetTags();

            cbxFilter.DataSource = Tags;
            cbxFilter.DisplayMember = "TagName";
            cbxFilter.ValueMember = "Id";

            RecordsCount = emp.GetEmployeeCount();
            dgvEmployee.DataSource = emp.GetEmployeesList(PageNumber, PageSize);
            if (dgvEmployee.DataSource != null)
            {
                this.dgvEmployee.Columns["Id"].Visible = false;
                this.dgvEmployee.Columns["FirstName"].HeaderText = "First Name";
                this.dgvEmployee.Columns["SecondName"].HeaderText = "Last Name";

            }
            txtPage.Text = (PageNumber + 1).ToString();
            btnPrev.Enabled = true;
            btnNext.Enabled = true;

            if (PageNumber <= 0)
            {
                btnPrev.Enabled = false;
            }
            if ((PageNumber * PageSize) + PageSize >= RecordsCount)
            {
                btnNext.Enabled = false;
            }

            RefreshFormControls();
        }
        private void RefreshFormControls()
        {
            ID = 0;
            start = 1;
            end = 10;
            txtName.Clear();
            txtName.Focus();
            cbxFilter.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EmployeeClass emp = new EmployeeClass();
            string SearchName = txtName.Text;
            int FilterId = Convert.ToInt32(cbxFilter.SelectedValue);
            dgvEmployee.DataSource = emp.SearchEmployeesList(SearchName, FilterId);

            //string SearchName = txtName.Text;
            //int FilterId = Convert.ToInt32(cbxFilter.SelectedValue);
            //if (FilterId <= 0 && SearchName != string.Empty)
            //{
            //    dgvEmployee.DataSource = emp.SearchEmployeeList(SearchName);
            //    this.dgvEmployee.Columns["Id"].Visible = false;
            //}
            //else
            //{
            //    if ((SearchName == null || SearchName == string.Empty) && FilterId > 0)
            //    {
            //        dgvEmployee.DataSource = emp.SearchEmployeeList(FilterId);
            //        this.dgvEmployee.Columns["Id"].Visible = false;
            //    }
            //    else
            //    {
            //        if (FilterId > 0 && (SearchName != null || SearchName != string.Empty))
            //        {
            //            dgvEmployee.DataSource = emp.SearchEmployeeList(SearchName, FilterId);
            //            this.dgvEmployee.Columns["Id"].Visible = false;
            //        }
            //        else
            //        {
            //            dgvEmployee.DataSource = emp.GetEmployeesList();
            //            this.dgvEmployee.Columns["Id"].Visible = false;
            //        }
            //    }
            //}
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetEmployeeRecords();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells[0].Value);
            if (ID > 0)
            {
                EmployeeForm EmpObj = new EmployeeForm(ID);
                EmpObj.CloseEmployeeFormEvent += new EventHandler(log_CloseEmployeeFormEvent);
                EmpObj.TopMost = false;
                EmpObj.Show();
            }
        }




        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ID = 0;
            EmployeeForm EmpObj = new EmployeeForm();
            EmpObj.CloseEmployeeFormEvent += new EventHandler(log_CloseEmployeeFormEvent);
            EmpObj.TopMost = false;
            EmpObj.ID = ID;
            EmpObj.Show();
        }

        private void log_CloseEmployeeFormEvent(object sender, EventArgs e)
        {
            GetEmployeeRecords();
        }

        private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPage_Leave(object sender, EventArgs e)
        {
            SetPage();
        }
        private void SetPage()
        {
            if (txtPage.Text != null && txtPage.Text != String.Empty)
            {
                if (Convert.ToInt32(txtPage.Text) > 0 && Convert.ToInt32(txtPage.Text) <= RecordsCount / PageSize)
                {
                    PageNumber = Convert.ToInt32(txtPage.Text) - 1;
                    GetEmployeeRecords();
                }
                else
                {
                    txtPage.Text = (PageNumber + 1).ToString();
                }
            }
            //if valid page then move to page else set pagenumber
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            PageNumber++;
            GetEmployeeRecords();
            //if (start >= 0 && end >= 10)
            //{
            //    start -= 10;
            //    end -= 10;
            //    //dgvStudents.DataSource = MethodToGetRecord(start, end);
            //    lblStartPage.Text = Convert.ToString(start);
            //    lblEndPage.Text = Convert.ToString(end);
            //}
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            PageNumber--;
            GetEmployeeRecords();
            //if (start >= 0 && end >= 10)
            //{
            //    start -= 10;
            //    end -= 10;
            //    //dgvStudents.DataSource = MethodToGetRecord(start, end);
            //    lblStartPage.Text = Convert.ToString(start);
            //    lblEndPage.Text = Convert.ToString(end);
            //}
        }
    }
}
