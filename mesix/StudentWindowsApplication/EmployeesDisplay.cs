using DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class EmployeesDisplay : Form
    {
        public EmployeesDisplay()
        {
            InitializeComponent();
        }
        public int start = 1;
        public int end = 10;
        public int ID;
        private void EmployeesDisplay_Load(object sender, EventArgs e)
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

            dgvEmployee.DataSource = emp.GetEmployeesList();
            this.dgvEmployee.Columns["Id"].Visible = false;

            RefreshFormControls();
        }
        private void RefreshFormControls()
        {
            ID = 0;
            start = 1;
            end = 10;
            txtName.Clear();
            cbxFilter.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EmployeeClass emp = new EmployeeClass();
            string SearchName = txtName.Text;
            int FilterId = Convert.ToInt32(cbxFilter.SelectedValue);
            if (FilterId <= 0 && SearchName != string.Empty)
            {
                dgvEmployee.DataSource = emp.SearchEmployeeList(SearchName);
                this.dgvEmployee.Columns["Id"].Visible = false;
            }
            else
            {
                if ((SearchName == null || SearchName == string.Empty) && FilterId > 0)
                {
                    dgvEmployee.DataSource = emp.SearchEmployeeList(FilterId);
                    this.dgvEmployee.Columns["Id"].Visible = false;
                }
                else
                {
                    if (FilterId > 0 && (SearchName != null || SearchName != string.Empty))
                    {
                        dgvEmployee.DataSource = emp.SearchEmployeeList(SearchName, FilterId);
                        this.dgvEmployee.Columns["Id"].Visible = false;
                    }
                    else
                    {
                        dgvEmployee.DataSource = emp.GetEmployeesList();
                        this.dgvEmployee.Columns["Id"].Visible = false;
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetEmployeeRecords();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells[0].Value);
            if (ID > 0)
            {
                EmployeeForm EmpObj = new EmployeeForm();
                EmpObj.TopMost = false;
                EmpObj.ID = ID;
                EmpObj.Show();
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ID = 0;
            EmployeeForm EmpObj = new EmployeeForm();
            EmpObj.TopMost = false;
            EmpObj.ID = ID;
            EmpObj.Show();
        }
        //Implementation canceled
        private void lnkForward_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //incrementedvalue will be determined using start , end {lblstart,lblend}
            //if (incrementedvalue > 0)
            //{
            //    dgvEmployee.DataSource = MethodToGetRecord(incrementedvalue)
            //}
        }

        private void lnlBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //decrementedvalue will be determined using start , end {lblstart,lblend}
            //if (decrementedvalue > 0)
            //{
            //    dgvEmployee.DataSource = MethodToGetRecord(Decrementedvalue)
            //}
        }
    }
}
