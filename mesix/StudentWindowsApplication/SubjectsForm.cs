using DAL;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class SubjectsForm : Form
    {
        public SubjectsForm()
        {
            InitializeComponent();
        }

        private void SubjectsForm_Load(object sender, EventArgs e)
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
                StudentDAL sDal = new StudentDAL();
                dgvSubject.DataSource = sDal.GetSubjects(classid);
                this.dgvSubject.Columns["Id"].Visible = false;
            }
            else
            {
                dgvSubject.DataSource = null;
            }
        }

        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSubject.SelectedRows.Count > 0)
            {
                ID = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells[0].Value);
                txtSubject.Text = (string)dgvSubject.SelectedRows[0].Cells[2].Value;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshFormControls();
        }

        private void RefreshFormControls()
        {
            dgvSubject.DataSource = null;
            cbxClass.SelectedIndex = -1;
            txtSubject.Text = null;
        }

        private bool IsValid()
        {
            if (txtSubject.Text == null || cbxClass.SelectedIndex == -1)
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
                    Subject s = new Subject();
                    s.Id = (int)cbxClass.SelectedValue;
                    s.SName = txtSubject.Text;

                    ClassDAL cdal = new ClassDAL();
                    cdal.UpdateSubject(s, ID);

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
                    cdal.UpdateSubject(ID);

                    GetcbxClasses();
                }
                else
                {
                    MessageBox.Show("please Select Atleast One Row", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if (IsValid())
            {
                this.ID = 0;
                Subject s = new Subject();
                s.Id = (int)cbxClass.SelectedValue;
                s.SName = txtSubject.Text;

                ClassDAL cdal = new ClassDAL();
                cdal.InsertSubject(s);

                GetcbxClasses();
            }
        }
    }
}
