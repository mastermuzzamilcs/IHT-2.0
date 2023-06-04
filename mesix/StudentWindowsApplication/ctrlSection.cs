using DAL;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlSection : UserControl
    {
        public ctrlSection()
        {
            InitializeComponent();
        }
        private static ctrlSection _instance;
        public static ctrlSection Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrlSection();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new ctrlSection();
        }
        public int ID;
        public bool escapeSelectedIndexChangeEvent { get; set; }
        public int classid;
        private void ctrlSection_Load(object sender, EventArgs e)
        {
            GetcbxClasses();
            //btnRefresh.Visible = false;
            btnUpdate.Visible = false;
            //btnInsert.Text = "Save";
            cbxClass.Focus();
        }
        public void LoadData()
        {
            GetcbxClasses();
        }
        private void GetcbxClasses()
        {
            ClassDAL cdal = new ClassDAL();
            escapeSelectedIndexChangeEvent = true;
            cbxClass.DataSource = cdal.GetClasses();
            cbxClass.DisplayMember = "CName";
            cbxClass.ValueMember = "Id";
            cbxClass.SelectedIndex = -1;
            escapeSelectedIndexChangeEvent = false;
        }
        private void RefreshFormControls()
        {
            GetSections(Convert.ToInt32(cbxClass.SelectedValue));
            cbxClass.SelectedIndex = -1;
            txtSection.Text = null;
            this.ID = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshFormControls();
        }

        private void btnInsert_Click(object sender, EventArgs e)
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

                    this.ID = 0;
                    SectionClass sec = new SectionClass();
                    sec.classid = (int)cbxClass.SelectedValue;
                    sec.SecName = txtSection.Text;

                    ClassDAL cdal = new ClassDAL();
                    cdal.InsertSection(sec);

                    RefreshFormControls();
                }
            }
        }
        private bool IsValid()
        {
            if (txtSection.Text == null || txtSection.Text == String.Empty || cbxClass.SelectedIndex == -1 || Convert.ToInt32(cbxClass.SelectedValue) < 1)
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
            //if (IsValid())
            //{
            //    if (ID > 0)
            //    {
            //        SectionClass sec = new SectionClass();
            //        sec.classid = (int)cbxClass.SelectedValue;
            //        sec.SecName = txtSection.Text;

            //        ClassDAL cdal = new ClassDAL();
            //        cdal.UpdateSection(sec, ID);

            //        RefreshFormControls();
            //    }
            //    else
            //    {
            //        MessageBox.Show("please Select Atleast One Row", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
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
                    RefreshFormControls();
                }
                else
                {
                    MessageBox.Show("please Select Atleast One Row", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void GetSections(int _id)
        {
            ExamClass sDal = new ExamClass();
            dgvSections.DataSource = sDal.GetSectionsByClassId(_id);
            if (dgvSections.DataSource != null)
            {
                this.dgvSections.Columns["Id"].Visible = false;
            this.dgvSections.Columns["classid"].Visible = false;
            this.dgvSections.Columns["SecName"].HeaderText = "Section Name";

            }
        }
        private void cbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!escapeSelectedIndexChangeEvent)
            {
                classid = Convert.ToInt32(cbxClass.SelectedValue);
                GetSections(classid);
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
                ID = Convert.ToInt32(dgvSections.SelectedRows[0].Cells["Id"].Value);
                txtSection.Text = (string)dgvSections.SelectedRows[0].Cells["SecName"].Value;
                cbxClass.SelectedValue = Convert.ToInt32(dgvSections.SelectedRows[0].Cells["classid"].Value);
            }
        }
    }
}
