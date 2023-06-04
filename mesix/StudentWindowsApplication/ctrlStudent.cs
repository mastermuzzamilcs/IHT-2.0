using DAL;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlStudent : UserControl
    {

        public int ID;
        public int start = 1, end = 10;
        private static ctrlStudent _instance;
        public static ctrlStudent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrlStudent();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new ctrlStudent();
        }
        public ctrlStudent()
        {
            InitializeComponent();
        }
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

        public void GetStudentRecords()
        {
            StudentDAL dal = new StudentDAL();
            RecordsCount = dal.GetStudentCount();
            dgvStudents.DataSource = dal.GetStudentList(PageNumber, PageSize);
            if (dgvStudents.Rows != null && dgvStudents.Rows.Count > 0)
            {
                this.dgvStudents.Columns["StudentID"].Visible = false;
                //this.dgvStudents.Columns["Name"].Width=
            }

            ClassDAL cdal = new ClassDAL();
            cbxClass.DataSource = cdal.GetClasses();
            cbxClass.DisplayMember = "CName";
            cbxClass.ValueMember = "Id";

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
            txtName.Clear();
            txtName.Focus();
            cbxClass.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StudentDAL sdal = new StudentDAL();
            //EmployeeClass emp = new EmployeeClass();
            string SearchName = txtName.Text;
            int FilterId = Convert.ToInt32(cbxClass.SelectedValue);
            dgvStudents.DataSource = sdal.SearchStudentList(SearchName, FilterId);
            btnNext.Enabled = false;

            //if (FilterId <= 0 && SearchName != string.Empty)
            //{
            //    dgvStudents.DataSource = sdal.SearchStudentList(SearchName);
            //    this.dgvStudents.Columns["StudentID"].Visible = false;
            //}
            //else
            //{
            //    if ((SearchName == null || SearchName == string.Empty) && FilterId > 0)
            //    {
            //        dgvStudents.DataSource = emp.SearchStudentList(FilterId);
            //        this.dgvStudents.Columns["ID"].Visible = false;
            //    }
            //    else
            //    {
            //        if (FilterId > 0 && (SearchName != null || SearchName != string.Empty))
            //        {
            //            dgvStudents.DataSource = emp.SearchStudentList(SearchName, FilterId);
            //            this.dgvStudents.Columns["StudentID"].Visible = false;
            //        }
            //        else
            //        {
            //            dgvStudents.DataSource = sdal.GetStudentList();
            //            this.dgvStudents.Columns["StudentID"].Visible = false;
            //        }
            //    }
            //}
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
                Student_Adress Stu = new Student_Adress(ID);
                Stu.CloseStudentFormEvent += log_CloseStudentFormEvent;
                Stu.TopMost = false;
                Stu.Show();
            }
        }

        private void log_CloseStudentFormEvent(object sender, EventArgs e)
        {
            GetStudentRecords();
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageNumber--;
            GetStudentRecords();
            //if (start >= 0 && end >= 10)
            //{
            //    start -= 10;
            //    end -= 10;
            //    //dgvStudents.DataSource = MethodToGetRecord(start, end);
            //    lblStartPage.Text = Convert.ToString(start);
            //    lblEndPage.Text = Convert.ToString(end);
            //}
        }

        private void lblForward_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageNumber++;
            GetStudentRecords();
            //if (start >= 0 && end >= 10)
            //{
            //    start -= 10;
            //    end -= 10;
            //    //dgvStudents.DataSource = MethodToGetRecord(start, end);
            //    lblStartPage.Text = Convert.ToString(start);
            //    lblEndPage.Text = Convert.ToString(end);
            //}
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ID = 0;
            Student_Adress Stu = new Student_Adress();
            Stu.CloseStudentFormEvent += log_CloseStudentFormEvent;
            Stu.TopMost = false;
            Stu.ID = ID;
            Stu.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PageNumber++;
            GetStudentRecords();
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
            GetStudentRecords();
            //if (start >= 0 && end >= 10)
            //{
            //    start -= 10;
            //    end -= 10;
            //    //dgvStudents.DataSource = MethodToGetRecord(start, end);
            //    lblStartPage.Text = Convert.ToString(start);
            //    lblEndPage.Text = Convert.ToString(end);
            //}
        }

        private void txtPage_TextChanged(object sender, EventArgs e)
        {
            //restrict numeric letters only
            //if valid page then move to page else set pagenumber
        }
        private void SetPage()
        {
            if (txtPage.Text != null && txtPage.Text != String.Empty)
            {
                if (Convert.ToInt32(txtPage.Text) > 0 && Convert.ToInt32(txtPage.Text) <= RecordsCount / PageSize)
                {
                    PageNumber = Convert.ToInt32(txtPage.Text) - 1;
                    GetStudentRecords();
                }
                else
                {
                    txtPage.Text = (PageNumber + 1).ToString();
                }
            }
            //if valid page then move to page else set pagenumber
        }
        private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                //if (!(e.KeyChar == (char)(Keys.Back)))
                //{
                //    SetPage();
                //}
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtPage_Leave(object sender, EventArgs e)
        {
            SetPage();
        }

        private void ctrlStudent_Load(object sender, EventArgs e)
        {
            GetStudentRecords();
        }
    }
}
