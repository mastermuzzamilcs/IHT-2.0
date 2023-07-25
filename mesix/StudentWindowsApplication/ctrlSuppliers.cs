using DAL;
using DataTransferObjects;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlSuppliers : UserControl
    {
        private static ctrlSuppliers _instance;
        public static ctrlSuppliers Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrlSuppliers();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new ctrlSuppliers();
        }
        public ctrlSuppliers()
        {
            InitializeComponent();
            this._supplier = new Supplier();
            Controller = new SuppliersDAL();
        }
        public ctrlSuppliers(Supplier _s)
        {
            InitializeComponent();
            this._supplier = _s;
            Controller = new SuppliersDAL();
        }
        public SuppliersDAL Controller { get; set; }
        public Supplier _supplier { get; set; }
        private void ctrlSupplier_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            btnUpdate.Enabled = false;
            btnView.Enabled = false;
            btnUpdate.Visible = false;
            btnView.Visible = false;

            RefreshFormControls();
            dgvSupplier.DataSource = Controller.GetSuppliers();
            if (dgvSupplier.DataSource != null)
            {
                dgvSupplier.Columns["SupplierID"].Visible = false;
                dgvSupplier.Columns["IsDeleted"].Visible = false;
            }
        }
        private void RefreshFormControls()
        {
            dgvSupplier.DataSource = null;

            txtSupplierName.Text = null;
            txtContactName.Text = null;
            txtPhone.Text = null;
            txtEmail.Text = null;
            txtAddress.Text = null;

            this._supplier = new Supplier();
        }
        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get by ID and set _category and in UI
            if (dgvSupplier.SelectedRows.Count > 0)
            {
                this._supplier = Controller.GetSupplierByID(Convert.ToInt32(dgvSupplier.SelectedRows[0].Cells["SupplierID"].Value));
                txtSupplierName.Text = dgvSupplier.SelectedRows[0].Cells["Name"].Value.ToString();
                txtContactName.Text = dgvSupplier.SelectedRows[0].Cells["ContactName"].Value.ToString();
                txtPhone.Text = dgvSupplier.SelectedRows[0].Cells["Phone"].Value.ToString();
                txtEmail.Text = dgvSupplier.SelectedRows[0].Cells["Email"].Value.ToString();
                txtAddress.Text = dgvSupplier.SelectedRows[0].Cells["Address"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (this._supplier.SupplierID > 0)
                {
                    this._supplier.Name = txtSupplierName.Text;
                    this._supplier.ContactName = txtContactName.Text == null ? String.Empty : txtContactName.Text;
                    this._supplier.Phone = txtPhone.Text == null ? String.Empty : txtPhone.Text;
                    this._supplier.Email = txtEmail.Text == null ? String.Empty : txtEmail.Text;
                    this._supplier.Address = txtAddress.Text == null ? String.Empty : txtAddress.Text;
                    if (Controller.UpdateSupplier(this._supplier))
                    {
                        MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("An Internal Error Occured... Please Try Again or Contact Service Administrator", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (Controller.InsertSupplier(new Supplier()
                    {
                        Name = txtSupplierName.Text,
                        ContactName = txtContactName.Text == null ? String.Empty : txtContactName.Text,
                        Phone = txtPhone.Text == null ? String.Empty : txtPhone.Text,
                        Email = txtEmail.Text == null ? String.Empty : txtEmail.Text,
                        Address = txtAddress.Text == null ? String.Empty : txtAddress.Text
                    }))
                    {
                        MessageBox.Show("Data Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("An Internal Error Occured... Please Try Again or Contact Service Administrator", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete _category
            if (this._supplier.SupplierID > 0)
            {
                if (Controller.DeleteSupplier(this._supplier.SupplierID))
                {
                    MessageBox.Show("Action Commited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An Internal Error Occured... Please Try Again or Contact Service Administrator", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private bool IsValid()
        {
            if (txtSupplierName.Text == null || txtSupplierName.Text == String.Empty)
            {
                MessageBox.Show("Name Can't be Empty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
