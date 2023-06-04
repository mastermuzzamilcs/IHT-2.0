using DAL;
using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ExamReport : Form
    {
        public ExamReport()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A61AK54\NEWTEST;Initial Catalog=StudentDataBase;Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GetExamReportRecords()
        {
            ClassDAL cdal = new ClassDAL();
            List<SchoolClass> Classes = cdal.GetClasses();
            escapeSelectedIndexChangeEvent = true;
            cbxClass.DataSource = Classes;
            cbxClass.DisplayMember = "CName";
            cbxClass.ValueMember = "Id";
            escapeSelectedIndexChangeEvent = false; ;

            ClassDAL cdal1 = new ClassDAL();
            List<SectionClass> Sections = cdal.GetSections();
            escapeSelectedIndexChangeEvent = true;
            cbxSection.DataSource = Sections;
            cbxSection.DisplayMember = "SecName";
            cbxSection.ValueMember = "Id";
            escapeSelectedIndexChangeEvent = false;

            SubjectDAL sdal = new SubjectDAL();
            List<Subject> Subjects = sdal.GetSubject();
            escapeSelectedIndexChangeEvent = true;
            cbxSubject.DataSource = Subjects;
            cbxSubject.DisplayMember = "SName";
            cbxSubject.ValueMember = "Id";
            escapeSelectedIndexChangeEvent = false;

            ExamClass eclass = new ExamClass();
            List<Test> Tests = eclass.GetTests();
            escapeSelectedIndexChangeEvent = true;
            cbxTest.DataSource = Tests;
            cbxTest.DisplayMember = "TestName";
            cbxTest.ValueMember = "ID";
            escapeSelectedIndexChangeEvent = false;

            RefreshFormControls();
        }
        public void RefreshFormControls()
        {
            cbxClass.SelectedIndex = -1;
            cbxSection.SelectedIndex = -1;
            cbxSubject.SelectedIndex = -1;
            cbxTest.SelectedIndex = -1;
            lblTeacherName.Text = string.Empty;
            lblShowDate.Text = string.Empty;
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            ViewData();

        }

        private void ViewData()
        {
            int Class, Section, Subjct, Tst;
            Class = Convert.ToInt32(cbxClass.SelectedValue);
            Section = Convert.ToInt32(cbxSection.SelectedValue);
            Subjct = Convert.ToInt32(cbxSubject.SelectedValue);
            Tst = Convert.ToInt32(cbxTest.SelectedValue);

            ExamClass emp = new ExamClass();
            dgvExamReport.DataSource = emp.GetExamsReportList(Class, Section, Subjct, Tst);
            dgvExamReport.Columns["Id"].Visible = false;
            dgvExamReport.Columns[1].ReadOnly = true;
            dgvExamReport.Columns[2].ReadOnly = true;
            dgvExamReport.Columns[3].ReadOnly = true;
            dgvExamReport.Columns[4].ReadOnly = true;
            dgvExamReport.Columns[5].ReadOnly = true;
            dgvExamReport.Columns[6].ReadOnly = true;

        }

        public bool escapeSelectedIndexChangeEvent { get; set; }
        private void ExamReport_Load(object sender, EventArgs e)
        {
            GetExamReportRecords();
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
                    cbxSubject.SelectedIndex = -1;
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
                    cbxSection.SelectedIndex = -1;
                }
                else
                {
                    cbxSection.DataSource = null;
                }
            }
        }

        private void cbxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!escapeSelectedIndexChangeEvent)
            {
                int Subjectid = Convert.ToInt32(cbxSubject.SelectedValue);
                int Sectionid = Convert.ToInt32(cbxSection.SelectedValue);
                int classid = Convert.ToInt32(cbxClass.SelectedValue);
                ExamClass exm = new ExamClass();
                List<Test> tst = exm.GetTests(classid, Sectionid, Subjectid);
                if (tst.Count > 0)
                {
                    cbxTest.DataSource = tst;
                    cbxTest.DisplayMember = "TName";
                    cbxTest.ValueMember = "Id";
                    cbxTest.SelectedIndex = -1;
                }
                else
                {
                    cbxTest.DataSource = null;
                }
            }
        }

        private void dgvExamReport_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvExamReport.CurrentRow != null)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ExamEdit", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(dgvExamReport.CurrentRow.Cells[0].Value));
                cmd.Parameters.AddWithValue("@Obt", Convert.ToInt32(dgvExamReport.CurrentRow.Cells[7].Value));
                cmd.Parameters.AddWithValue("@Rem", Convert.ToString(dgvExamReport.CurrentRow.Cells[8].Value));
                cmd.ExecuteNonQuery();
                con.Close();
                ViewData();
            }

        }

        private void cbxTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!escapeSelectedIndexChangeEvent)
            {
                int test = Convert.ToInt32(cbxTest.SelectedValue);
                ExamClass exam = new ExamClass();
                TestDetails tst = new TestDetails();
                tst = exam.GetTestDetails(test);
                lblShowDate.Text = Convert.ToString(tst.Date);
                lblTeacherName.Text = tst.Teacher;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshFormControls();
        }
    }
}