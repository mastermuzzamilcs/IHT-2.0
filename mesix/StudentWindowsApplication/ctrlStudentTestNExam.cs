using DAL;
using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlStudentTestNExam : UserControl
    {
        public ctrlStudentTestNExam()
        {
            InitializeComponent();
        }
        public Roles testStudentObj = new Roles();
        public int ID;
        private void ctrlStudentTestNExam_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            GetTestsRecord();
        }
        private void GetTestsRecord()
        {
            SubjectDAL sdal = new SubjectDAL();
            List<Subject> Subjects = sdal.GetSubjectsByClassId(testStudentObj.ClassId);
            escapeSelectedIndexChangeEvent = true;
            cbxSubject.DataSource = Subjects;
            cbxSubject.DisplayMember = "SName";
            cbxSubject.ValueMember = "Id";
            escapeSelectedIndexChangeEvent = false;
        }
        public bool escapeSelectedIndexChangeEvent { get; set; }
        private void cbxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!escapeSelectedIndexChangeEvent)
            {
                int Subject = (int)cbxSubject.SelectedValue;
                ExamClass dgv = new ExamClass();
                dgvTest.DataSource = dgv.GetExamsBySubject(Subject);
                this.dgvTest.Columns["ID"].Visible = false;
            }
            else
            {
                cbxSubject.DataSource = null;
            }
        }
        private void dgvTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTest.SelectedRows.Count > 0)
            {
                ID = Convert.ToInt32(dgvTest.SelectedRows[0].Cells[0].Value);
                //Upcoming .... Allow student to attempt and check report
                MessageBox.Show("We are working at it. It will be Available Soon.", "Under Maintainance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
