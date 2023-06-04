using DAL;
using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlTeacherTestNExam : UserControl
    {
        public ctrlTeacherTestNExam()
        {
            InitializeComponent();
        }
        public Roles testTeacherObj = new Roles();
        public int ID;
        public bool escapeSelectedIndexChangeEvent { get; set; }
        private void ctrlTeacherTestNExam_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
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

            lblTeacher.Text = testTeacherObj.Name;
        }
        private void ResetFormControls()
        {
            RefreshFormControls();
            cbxClass.SelectedIndex = -1;
            cbxSection.SelectedIndex = -1;
            cbxSubject.SelectedIndex = -1;

            dgvTest.DataSource = null;
        }

        private void View()
        {
            int Classid = (int)cbxClass.SelectedValue;
            int Subject = (int)cbxSubject.SelectedValue;
            int Section = (int)cbxSection.SelectedValue;
            ExamClass dgv = new ExamClass();
            dgvTest.DataSource = dgv.GetExams(Classid, Section, Subject, testTeacherObj.LoginId);
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
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
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
                ExamObj.TeacherId = testTeacherObj.LoginId;
                ExamObj.Description = txtDesc.Text;

                ExamClass nExam = new ExamClass();
                nExam.InsertExam(ExamObj);

                View();
                RefreshFormControls();
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
                    ExamObj.TeacherId = testTeacherObj.LoginId;
                    ExamObj.Description = txtDesc.Text;

                    ExamClass nExam = new ExamClass();
                    nExam.UpdateExam(ExamObj, ID);

                    View();
                    RefreshFormControls();
                }
                else
                {
                    MessageBox.Show("please Select Atleast One Row", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!escapeSelectedIndexChangeEvent)
            {
                int classid = Convert.ToInt32(cbxClass.SelectedValue);
                SubjectDAL sDal = new SubjectDAL();
                List<Subject> sbjct = sDal.GetSubjectsByClassId(classid);
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
            if (!escapeSelectedIndexChangeEvent)
            {
                int classid = Convert.ToInt32(cbxClass.SelectedValue);
                ExamClass sDal = new ExamClass();
                List<SectionClass> sections = sDal.GetSectionsByClassId(classid);
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
        }

        private void dgvTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTest.SelectedRows.Count > 0)
            {
                btnInsert.Enabled = false;
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
                txtTotalMarks.Text = Convert.ToString(tst.TotalMarks);
                txtPassingMarks.Text = Convert.ToString(tst.PassingMarks);
                txtDesc.Text = tst.Description;
            }
        }
    }
}
