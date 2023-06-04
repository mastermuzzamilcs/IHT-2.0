using DAL;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class StudentDisplay : Form
    {
        public StudentDisplay()
        {
            InitializeComponent();
        }
        public int ID;
        public int start = 1, end = 10;
        private void StudentDisplay_Load(object sender, EventArgs e)
        {
            GetStudentRecords();
        }
        //public bool escapeSelectedIndexChangeEvent { get; set; }
        public int PageNumber = 0;
        public int PageSize
        {
            get;
            set;
        } = 5;
        public void GetStudentRecords()
        {
            StudentDAL dal = new StudentDAL();

            dgvStudents.DataSource = dal.GetStudentList(PageNumber, PageSize);
            this.dgvStudents.Columns["ID"].Visible = false;

            ClassDAL cdal = new ClassDAL();
            cbxClass.DataSource = cdal.GetClasses();
            cbxClass.DisplayMember = "CName";
            cbxClass.ValueMember = "Id";

            lblStartPage.Text = Convert.ToString(start);
            lblEndPage.Text = Convert.ToString(end);

            RefreshFormControls();
        }
        private void RefreshFormControls()
        {
            ID = 0;
            txtName.Clear();
            cbxClass.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StudentDAL sdal = new StudentDAL();
            EmployeeClass emp = new EmployeeClass();
            string SearchName = txtName.Text;
            int FilterId = Convert.ToInt32(cbxClass.SelectedValue);
            if (FilterId <= 0 && SearchName != string.Empty)
            {
                dgvStudents.DataSource = sdal.SearchStudentList(SearchName);
                this.dgvStudents.Columns["ID"].Visible = false;
            }
            else
            {
                if ((SearchName == null || SearchName == string.Empty) && FilterId > 0)
                {
                    dgvStudents.DataSource = emp.SearchStudentList(FilterId);
                    this.dgvStudents.Columns["ID"].Visible = false;
                }
                else
                {
                    if (FilterId > 0 && (SearchName != null || SearchName != string.Empty))
                    {
                        dgvStudents.DataSource = emp.SearchStudentList(SearchName, FilterId);
                        this.dgvStudents.Columns["ID"].Visible = false;
                    }
                    else
                    {
                        dgvStudents.DataSource = emp.GetStudList();
                        this.dgvStudents.Columns["ID"].Visible = false;
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetStudentRecords();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells[0].Value);
            if (ID > 0)
            {
                Student_Adress Stu = new Student_Adress();
                Stu.TopMost = false;
                Stu.ID = ID;
                Stu.Show();
            }
        }

        private void lnlBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (start >= 0 && end >= 10)
            {
                start -= 10;
                end -= 10;
                //dgvStudents.DataSource = MethodToGetRecord(start, end);
                lblStartPage.Text = Convert.ToString(start);
                lblEndPage.Text = Convert.ToString(end);
            }
        }
        private void lnkForward_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            start += 10;
            end += 10;
            //dgvStudents.DataSource = MethodToGetRecord(start, end);
            lblStartPage.Text = Convert.ToString(start);
            lblEndPage.Text = Convert.ToString(end);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ID = 0;
            Student_Adress Stu = new Student_Adress();
            Stu.TopMost = false;
            Stu.ID = ID;
            Stu.Show();
        }
    }
}
