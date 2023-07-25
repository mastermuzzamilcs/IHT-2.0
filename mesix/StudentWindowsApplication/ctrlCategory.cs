using DAL;
using DataTransferObjects;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlCategory : UserControl
    {
        private static ctrlCategory _instance;
        public static ctrlCategory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrlCategory();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new ctrlCategory();
        }
        public ctrlCategory()
        {
            InitializeComponent();
            this._category = new Category();
            Controller = new CategoriesDAL();
        }
        public ctrlCategory(Category _c)
        {
            InitializeComponent();
            this._category = _c;
            Controller = new CategoriesDAL();
        }
        public CategoriesDAL Controller { get; set; }
        public Category _category { get; set; }
        private void ctrlCategory_Load(object sender, EventArgs e)
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
            dgvCategory.DataSource = Controller.GetCategories();
            if (dgvCategory.DataSource != null)
            {
                dgvCategory.Columns["CategoryID"].Visible = false;
                dgvCategory.Columns["IsDeleted"].Visible = false;
            }
        }
        private void RefreshFormControls()
        {
            dgvCategory.DataSource = null;

            txtCategoryName.Text = null;
            txtDesc.Text = null;

            this._category = new Category();
        }
        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get by ID and set _category and in UI
            if (dgvCategory.SelectedRows.Count > 0)
            {
                this._category = Controller.GetCategoryByID(Convert.ToInt32(dgvCategory.SelectedRows[0].Cells["CategoryID"].Value));
                txtCategoryName.Text = dgvCategory.SelectedRows[0].Cells["Name"].Value.ToString();
                txtDesc.Text = dgvCategory.SelectedRows[0].Cells["Description"].Value.ToString();
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
                if (this._category.CategoryID > 0)
                {
                    this._category.Name = txtCategoryName.Text;
                    this._category.Description = txtDesc.Text == null ? String.Empty : txtDesc.Text;
                    if (Controller.UpdateCategory(this._category))
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
                    if (Controller.InsertCategory(new Category()
                    {
                        Name = txtCategoryName.Text,
                        Description = txtDesc.Text == null ? String.Empty : txtDesc.Text,
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
            if (this._category.CategoryID > 0)
            {
                if (Controller.DeleteCategory(this._category.CategoryID))
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
            if (txtCategoryName.Text == null || txtCategoryName.Text == String.Empty)
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
