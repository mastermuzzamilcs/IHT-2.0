using DAL;
using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlStudentAttendanceReport : UserControl
    {
        public ctrlStudentAttendanceReport()
        {
            InitializeComponent();
        }
        public Roles attendanceStudentObj = new Roles();
        private void ctrlStudentAttendanceReport_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            GetAttendanceRecord();
        }
        private void GetAttendanceRecord()
        {
            SubjectDAL sdal = new SubjectDAL();
            List<Subject> Subjects = sdal.GetSubjectsByClassId(attendanceStudentObj.ClassId);
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
                dgvTest.DataSource = dgv.GetAttendanceBySubject(Subject, attendanceStudentObj.LoginId);
                this.dgvTest.Columns["ID"].Visible = false;
            }
            else
            {
                cbxSubject.DataSource = null;
            }
        }
    }
}
