using DAL;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class SubjectsCTRL : UserControl
    {
        public SubjectsCTRL()
        {
            InitializeComponent();
        }
        private static SubjectsCTRL _instance;
        public static SubjectsCTRL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SubjectsCTRL();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new SubjectsCTRL();
        }
        public void LoadData()
        {
            GetcbxClasses();
        }
        private void SubjectsCTRL_Load(object sender, EventArgs e)
        {
            GetcbxClasses();
            btnUpdate.Visible = false;
            //btnRefresh.Visible = false;
            //btnInsert.Text = "Save";
            cbxClass.Focus();
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
        }
        public int classid;
        private void cbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!escapeSelectedIndexChangeEvent)
            {
                classid = Convert.ToInt32(cbxClass.SelectedValue);
                GetSubjects(classid);
            }
            else
            {
                dgvSubject.DataSource = null;
            }
        }
        private void GetSubjects(int _id)
        {
            StudentDAL sDal = new StudentDAL();
            dgvSubject.DataSource = sDal.GetSubjects(_id);
            if(dgvSubject.DataSource != null)
            {
            this.dgvSubject.Columns["Id"].Visible = false;
            this.dgvSubject.Columns["ClassID"].Visible = false;
            this.dgvSubject.Columns["SName"].HeaderText = "Subject Name";

            }
        }
        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSubject.SelectedRows.Count > 0)
            {
                ID = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells[0].Value);
                txtSubject.Text = (string)dgvSubject.SelectedRows[0].Cells[2].Value;
                cbxClass.SelectedValue = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells["classid"].Value);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshFormControls();
        }
        private void RefreshFormControls()
        {
            GetSubjects(Convert.ToInt32(cbxClass.SelectedValue));
            cbxClass.SelectedIndex = -1;
            txtSubject.Text = null;
            this.ID = 0;
            //dgvSubject.DataSource = null;
            //cbxClass.SelectedIndex = -1;
            //txtSubject.Text = null;
        }

        private bool IsValid()
        {
            if (txtSubject.Text == null || txtSubject.Text == String.Empty || cbxClass.SelectedIndex == -1 || Convert.ToInt32(cbxClass.SelectedValue) < 1)
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
            //        Subject s = new Subject();
            //        s.Id = (int)cbxClass.SelectedValue;
            //        s.SName = txtSubject.Text;

            //        ClassDAL cdal = new ClassDAL();
            //        cdal.UpdateSubject(s, ID);

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
                    this.ID = 0;
                    Subject s = new Subject();
                    s.Id = (int)cbxClass.SelectedValue;
                    s.SName = txtSubject.Text;

                    ClassDAL cdal = new ClassDAL();
                    cdal.InsertSubject(s);

                    RefreshFormControls();

                }
            }
        }
    }
}
