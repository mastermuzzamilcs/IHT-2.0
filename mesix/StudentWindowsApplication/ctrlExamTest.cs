using DAL;
using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlExamTest : UserControl
    {
        public ctrlExamTest()
        {
            InitializeComponent();
        }
        private static ctrlExamTest _instance;
        public static ctrlExamTest Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrlExamTest();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new ctrlExamTest();
        }
        public int ID = 0;
        public bool escapeSelectedIndexChangeEvent { get; set; }
        private void ExamTest_Load(object sender, EventArgs e)
        {
            GetTestsRecord();
            ResetFormControls();
        }
        public void LoadData()
        {
            GetTestsRecord();
            ResetFormControls();
        }
        private void GetTestsRecord()
        {
            ClassDAL cdal = new ClassDAL();
            List<SchoolClass> Classes = cdal.GetClasses();
            escapeSelectedIndexChangeEvent = true;
            cbxClass.DataSource = Classes;
            cbxClass.DisplayMember = "CName";
            cbxClass.ValueMember = "Id";
            escapeSelectedIndexChangeEvent = false;

            SubjectDAL sdal = new SubjectDAL();
            List<Subject> Subjects = sdal.GetSubject();
            escapeSelectedIndexChangeEvent = true;
            cbxSubject.DataSource = Subjects;
            cbxSubject.DisplayMember = "SName";
            cbxSubject.ValueMember = "Id";
            escapeSelectedIndexChangeEvent = false;

            ClassDAL cdal1 = new ClassDAL();
            List<SectionClass> Sections = cdal.GetSections();
            escapeSelectedIndexChangeEvent = true;
            cbxSection.DataSource = Sections;
            cbxSection.DisplayMember = "SecName";
            cbxSection.ValueMember = "Id";
            escapeSelectedIndexChangeEvent = false;

            EmployeeClass Teacher = new EmployeeClass();
            List<EmployeeProp> Teachers = Teacher.GetTeachers();
            //cbxTeacher.DataSource = Teachers;
            //cbxTeacher.DisplayMember = "EmpName";
            //cbxTeacher.ValueMember = "ID";
        }
        private void ResetFormControls()
        {
            RefreshFormControls();
            cbxClass.SelectedIndex = -1;
            cbxSection.SelectedIndex = -1;
            cbxSubject.SelectedIndex = -1;
            cbxClass.Focus();

            dgvTest.DataSource = null;
        }

        private void View()
        {
            int Classid = (int)cbxClass.SelectedValue;
            int Subject = (int)cbxSubject.SelectedValue;
            int Section = (int)cbxSection.SelectedValue;
            ExamClass dgv = new ExamClass();
            dgvTest.DataSource = dgv.GetExams(Classid, Section, Subject);
            this.dgvTest.Columns["ID"].Visible = false;
        }
        private void RefreshFormControls()
        {
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            ID = 0;
            txtTestName.Clear();
            dtpTest.Value = DateTime.Today.Add(dtpTest.Value.TimeOfDay);
            txtTotalMarks.Clear();
            txtPassingMarks.Clear();
            txtDesc.Clear();
            //cbxTeacher.SelectedIndex = -1;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (ID > 0)
                {
                    Test ExamObj = new Test();

                    ExamObj.TName = txtTestName.Text;
                    ExamObj.date = Convert.ToDateTime(dtpTest.Text);
                    ExamObj.TotalMarks = Convert.ToInt32(txtTotalMarks.Text);
                    ExamObj.PassingMarks = Convert.ToInt32(txtPassingMarks.Text);
                    ExamObj.Class = Convert.ToInt32(cbxClass.SelectedValue);
                    ExamObj.Section = Convert.ToInt32(cbxSection.SelectedValue);
                    ExamObj.Subject = Convert.ToInt32(cbxSubject.SelectedValue);
                    //ExamObj.TeacherId = Convert.ToInt32(cbxTeacher.SelectedValue);
                    ExamObj.Description = txtDesc.Text;

                    ExamClass nExam = new ExamClass();
                    nExam.UpdateExam(ExamObj, ID);

                    View();
                    RefreshFormControls();
                }
                else
                {
                    this.ID = 0;
                    Test ExamObj = new Test();
                    ExamObj.TName = txtTestName.Text;
                    ExamObj.date = Convert.ToDateTime(dtpTest.Text);
                    ExamObj.TotalMarks = Convert.ToInt32(txtTotalMarks.Text);
                    ExamObj.PassingMarks = Convert.ToInt32(txtPassingMarks.Text);
                    ExamObj.Class = Convert.ToInt32(cbxClass.SelectedValue);
                    ExamObj.Section = Convert.ToInt32(cbxSection.SelectedValue);
                    ExamObj.Subject = Convert.ToInt32(cbxSubject.SelectedValue);
                    //ExamObj.TeacherId = Convert.ToInt32(cbxTeacher.SelectedValue);
                    ExamObj.Description = txtDesc.Text;

                    ExamClass nExam = new ExamClass();
                    nExam.InsertExam(ExamObj);

                    View();
                    RefreshFormControls();
                }
            }
        }
        private bool IsValid()
        {
            if (txtTestName.Text == null || txtTotalMarks.Text == null || txtPassingMarks.Text == null || cbxClass.SelectedIndex == -1 || cbxSection.SelectedIndex == -1 || cbxSubject.SelectedIndex == -1)
            {
                MessageBox.Show("Can't Accept Empty Fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool CheckIsEmpty()
        {
            if (cbxClass.SelectedIndex == -1 || cbxSection.SelectedIndex == -1 || cbxSubject.SelectedIndex == -1)
            {
                MessageBox.Show("Can't Accept Empty Fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (CheckIsEmpty())
            {
                View();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                ExamClass DelExam = new ExamClass();
                DelExam.DeleteExam(ID);
                View();
                RefreshFormControls();

            }
            else
            {
                MessageBox.Show("Please Select Atleast One Row", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshFormControls();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTest.SelectedRows.Count > 0)
            {
                try
                {
                    if (this.Controls.Contains(CtrlEditTest.Instance))
                    {
                        this.Controls.Remove(CtrlEditTest.Instance);
                        CtrlEditTest.Instance.reset();
                    }
                    this.Controls.Add(CtrlEditTest.Instance);
                    //ctrlSettings.Instance.changeParentTextWithCustomEvent += new EventHandler(log_changeParentTextWithCustomEvent);
                    //ctrlInvoicePaidDetails.Instance.CloseCtrlEvent += new EventHandler(log_CloseCtrlEvent);
                    //ctrlSettings.Instance.loadData(this.SessionObject);
                    CtrlEditTest.Instance.CloseEditTestCtrlEvent += new EventHandler(log_CloseEditTestCtrlEvent);
                    CtrlEditTest.Instance.LoadData(Convert.ToInt32(dgvTest.SelectedRows[0].Cells["ID"].Value));
                    CtrlEditTest.Instance.Dock = DockStyle.Fill;
                    CtrlEditTest.Instance.BringToFront();
                    this.panel1.Hide();
                    //this.dgvTest.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("An Unhandled Exception Occured", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CloseEditTestCtrl();
                }
            }
        }
        private void CloseEditTestCtrl()
        {
            this.Controls.Remove(CtrlEditTest.Instance);
            this.panel1.Show();
            //this.dgvTest.Show();
            RefreshFormControls();
        }
        private void log_CloseEditTestCtrlEvent(object sender, EventArgs e)
        {
            CloseEditTestCtrl();
        }

        private void GetSubjectsList(int _id)
        {
            SubjectDAL sDal = new SubjectDAL();
            List<Subject> sbjct = sDal.GetSubjectsByClassId(_id);
            if (sbjct.Count > 0)
            {
                cbxSubject.DataSource = sbjct;
                cbxSubject.DisplayMember = "SName";
                cbxSubject.ValueMember = "ID";
            }
            else
            {
                cbxSubject.DataSource = null;
            }
        }
        private void GetSectionsList(int _id)
        {
            ExamClass sDal = new ExamClass();
            List<SectionClass> sections = sDal.GetSectionsByClassId(_id);
            if (sections.Count > 0)
            {
                cbxSection.DataSource = sections;
                cbxSection.DisplayMember = "SecName";
                cbxSection.ValueMember = "Id";
            }
            else
            {
                cbxSection.DataSource = null;
            }
        }
        private void cbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!escapeSelectedIndexChangeEvent)
            {
                int classid = Convert.ToInt32(cbxClass.SelectedValue);
                GetSubjectsList(classid);
            }
            if (!escapeSelectedIndexChangeEvent)
            {
                int classid = Convert.ToInt32(cbxClass.SelectedValue);
                GetSectionsList(classid);
            }
        }

        private void dgvTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTest.SelectedRows.Count > 0)
            {
                btnUpdate.Enabled = true;
                ID = Convert.ToInt32(dgvTest.SelectedRows[0].Cells[0].Value);
                ExamClass exam = new ExamClass();
                Test tst = new Test();
                tst = exam.ViewExamDetail(ID);
                dtpTest.Value = tst.date;
                txtTestName.Text = tst.TName;
                cbxClass.SelectedValue = tst.Class;
                cbxSubject.SelectedValue = tst.Subject;
                cbxSection.SelectedValue = tst.Section;
                //cbxTeacher.SelectedValue = tst.TeacherId;
                txtTotalMarks.Text = Convert.ToString(tst.TotalMarks);
                txtPassingMarks.Text = Convert.ToString(tst.PassingMarks);
                txtDesc.Text = tst.Description;
            }
        }
    }
}