using DAL;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class Sections : Form
    {
        public Sections()
        {
            InitializeComponent();
        }

        private void Sections_Load(object sender, EventArgs e)
        {
            GetcbxClasses();
        }

        public int ID;
        public bool escapeSelectedIndexChangeEvent { get; set; }
        private void GetcbxClasses()
        {
            ClassDAL cdal = new ClassDAL();
            escapeSelectedIndexChangeEvent = true;
            cbxClass.DataSource = cdal.GetClasses();
            cbxClass.DisplayMember = "CName";
            cbxClass.ValueMember = "Id";
            cbxClass.SelectedIndex = -1;
            escapeSelectedIndexChangeEvent = false;

            RefreshFormControls();
        }
        public int classid;
        private void cbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!escapeSelectedIndexChangeEvent)
            {
                classid = Convert.ToInt32(cbxClass.SelectedValue);
                ExamClass sDal = new ExamClass();
                dgvSections.DataSource = sDal.GetSections(classid);
                this.dgvSections.Columns["Id"].Visible = false;
            }
            else
            {
                dgvSections.DataSource = null;
            }
        }

        private void dgvSections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSections.SelectedRows.Count > 0)
            {
                ID = Convert.ToInt32(dgvSections.SelectedRows[0].Cells[0].Value);
                txtSection.Text = (string)dgvSections.SelectedRows[0].Cells[2].Value;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshFormControls();
        }

        private void RefreshFormControls()
        {
            dgvSections.DataSource = null;
            cbxClass.SelectedIndex = -1;
            txtSection.Text = null;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                this.ID = 0;
                SectionClass sec = new SectionClass();
                sec.classid = (int)cbxClass.SelectedValue;
                sec.SecName = txtSection.Text;

                ClassDAL cdal = new ClassDAL();
                cdal.InsertSection(sec);

                GetcbxClasses();
            }
        }
        private bool IsValid()
        {
            if (txtSection.Text == null || cbxClass.SelectedIndex == -1)
            {
                MessageBox.Show("Can't Accept Empty Fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (ID > 0)
                {
                    SectionClass sec = new SectionClass();
                    sec.classid = (int)cbxClass.SelectedValue;
                    sec.SecName = txtSection.Text;

                    ClassDAL cdal = new ClassDAL();
                    cdal.UpdateSection(sec, ID);

                    RefreshFormControls();
                }
                else
                {
                    MessageBox.Show("please Select Atleast One Row", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (ID > 0)
                {
                    ClassDAL cdal = new ClassDAL();
                    cdal.UpdateSection(ID);

                    GetcbxClasses();
                }
                else
                {
                    MessageBox.Show("please Select Atleast One Row", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
