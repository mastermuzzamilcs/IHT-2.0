using DAL;
using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlTeacherStudentAttendance : UserControl
    {
        public ctrlTeacherStudentAttendance()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A61AK54\NEWTEST;Initial Catalog=StudentDataBase;Integrated Security=True");
        public Roles stuAttendanceTeacherObj = new Roles();
        public bool escapeSelectedIndexChangeEvent { get; set; }
        public string dat;
        int Class, Section, Subjct;
        private void ctrlTeacherStudentAttendance_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            GetAttendanceData();
        }
        private void GetAttendanceData()
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

            lblTeacherName.Text = stuAttendanceTeacherObj.Name;
            lblDate.Text = DateTime.Today.ToString("dd/MM/yyyy");

            RefreshFormControls();
        }
        public void RefreshFormControls()
        {
            cbxClass.SelectedIndex = -1;
            cbxSection.SelectedIndex = -1;
            cbxSubject.SelectedIndex = -1;
            dgvAttendance.DataSource = null;
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshFormControls();
        }

        private void dgvAttendance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAttendance.CurrentRow != null)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spMarkStudentAttendance", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(dgvAttendance.CurrentRow.Cells[0].Value));
                if (Convert.ToString(dgvAttendance.CurrentRow.Cells[3].Value) == "Absent")
                {
                    cmd.Parameters.AddWithValue("@Status", "Present");
                }
                else if (Convert.ToString(dgvAttendance.CurrentRow.Cells[3].Value) == "Present")
                {
                    cmd.Parameters.AddWithValue("@Status", "Absent");
                }
                cmd.ExecuteNonQuery();
                con.Close();
                ViewData();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create();
        }
        private void Create()
        {
            Class = Convert.ToInt32(cbxClass.SelectedValue);
            Section = Convert.ToInt32(cbxSection.SelectedValue);
            Subjct = Convert.ToInt32(cbxSubject.SelectedValue);
            dat = lblDate.Text;
            ExamClass emp = new ExamClass();

            emp.CreateAttendanceList(Class, Section, Subjct, dat);
            ViewData();
        }
        private void ViewData()
        {
            ExamClass emp = new ExamClass();
            dgvAttendance.DataSource = emp.GetAttendanceList(Subjct, dat);
            dgvAttendance.Columns["SName"].ReadOnly = true;
            dgvAttendance.Columns["RollNo"].ReadOnly = true;
        }
    }
}
