using DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlCurriculum : UserControl
    {
        public ctrlCurriculum()
        {
            InitializeComponent();
        }
        public int ID;
        private void btnView_Click(object sender, EventArgs e)
        {
            SubjectDAL sdal = new SubjectDAL();
            curriculum c = new curriculum();
            c.ClassId = Convert.ToInt32(cbxClassName.SelectedValue);
            c.SubjectId = Convert.ToInt32(cbxSubject.SelectedValue);
            c.SectionId = Convert.ToInt32(cbxSection.SelectedValue);

            dgvCurriculum.DataSource = sdal.GetCurriculum(c);
            this.dgvCurriculum.Columns["Id"].Visible = false;
        }

        public bool escapeSelectedIndexChangeEvent { get; set; }
        private void ViewCurriculum()
        {
            RefreshCurriculum();
            ClassDAL cdal = new ClassDAL();

            escapeSelectedIndexChangeEvent = true;
            cbxClassName.DataSource = cdal.GetClasses();
            cbxClassName.DisplayMember = "CName";
            cbxClassName.ValueMember = "ID";
            escapeSelectedIndexChangeEvent = false;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ViewCurriculum();
        }
        private void RefreshCurriculum()
        {
            cbxClassName.SelectedIndex = -1;
            cbxSubject.SelectedIndex = -1;
            cbxSection.SelectedIndex = -1;
            txtCurriculum.Clear();
            dgvCurriculum.DataSource = null;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (ID > 0)
                {
                    SubjectDAL sdal = new SubjectDAL();
                    sdal.DeleteCurriculum(ID);

                    ViewCurriculum();
                }
                else
                {
                    MessageBox.Show("please Select Atleast One Row", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvCurriculum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCurriculum.SelectedRows.Count > 0)
            {
                ID = Convert.ToInt32(dgvCurriculum.SelectedRows[0].Cells[0].Value);
                txtCurriculum.Text = dgvCurriculum.SelectedRows[0].Cells[1].Value.ToString();
            }
            else
                MessageBox.Show("Please Select Row");
        }



        private void ctrlCurriculum_Load(object sender, EventArgs e)
        {
            ViewCurriculum();
        }

        private void cbxClassName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!escapeSelectedIndexChangeEvent)
            {
                int classid = Convert.ToInt32(cbxClassName.SelectedValue);
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
                int classid = Convert.ToInt32(cbxClassName.SelectedValue);
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                this.ID = 0;
                curriculum c = new curriculum();
                c.ClassId = Convert.ToInt32(cbxClassName.SelectedValue);
                c.SubjectId = Convert.ToInt32(cbxSubject.SelectedValue);
                c.SectionId = Convert.ToInt32(cbxSection.SelectedValue);
                c.Curriculum = txtCurriculum.Text.ToString();
                SubjectDAL sdal = new SubjectDAL();
                sdal.SaveCurriculum(c);

                ViewCurriculum();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (ID > 0)
                {
                    curriculum c = new curriculum();
                    c.ClassId = Convert.ToInt32(cbxClassName.SelectedValue);
                    c.SubjectId = Convert.ToInt32(cbxSubject.SelectedValue);
                    c.SectionId = Convert.ToInt32(cbxSection.SelectedValue);
                    c.Curriculum = txtCurriculum.Text.ToString();

                    SubjectDAL sdal = new SubjectDAL();
                    sdal.UpdateCurriculum(c, ID);

                    ViewCurriculum();
                }
                else
                {
                    MessageBox.Show("please Select Atleast One Row", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool IsValid()
        {
            if (cbxClassName.SelectedIndex < 0 || cbxSubject.SelectedIndex < 0 || cbxSection.SelectedIndex < 0 || txtCurriculum.Text == null)
            {
                MessageBox.Show("Can't Accept Empty Fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
