using DAL;
using DataTransferObjects;
using System;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class ctrlProducts : UserControl
    {
        public ProductsManager Controller { get; set; }
        public Product product { get; set; }

        public int start = 1, end = 10;
        private static ctrlProducts _instance;
        public static ctrlProducts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrlProducts();
                return _instance;
            }
        }
        public void reset()
        {
            _instance = new ctrlProducts();
        }
        public ctrlProducts()
        {
            InitializeComponent();
            this.Controller = new ProductsManager();
            this.product = new Product();
        }
        public ctrlProducts(Product _p)
        {
            InitializeComponent();
            this.Controller = new ProductsManager();
            this.product = _p;
        }
        public int PageNumber
        {
            get;
            set;
        } = 0;
        public int RecordsCount
        {
            get;
            set;
        } = 0;
        public int PageSize
        {
            get;
            set;
        } = 10;

        public void LoadData()
        {
            StudentDAL dal = new StudentDAL();
            RecordsCount = Controller.GetProductsCount();
            dgvProducts.DataSource = Controller.GetProductsList(PageNumber, PageSize);
            if (dgvProducts.Rows != null && dgvProducts.Rows.Count > 0)
            {
                this.dgvProducts.Columns["ProductID"].Visible = false;
                this.dgvProducts.Columns["CategoryID"].Visible = false;
                this.dgvProducts.Columns["SupplierID"].Visible = false;
                this.dgvProducts.Columns["IsDeleted"].Visible = false;
            }

            cbxCategory.DataSource = Controller.GetAllCategories();
            cbxCategory.DisplayMember = "Name";
            cbxCategory.ValueMember = "CategoryID";

            cbxSupplier.DataSource = Controller.GetAllSuppliers();
            cbxSupplier.DisplayMember = "Name";
            cbxSupplier.ValueMember = "SupplierID";

            txtPage.Text = (PageNumber + 1).ToString();
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            if (PageNumber <= 0)
            {
                btnPrev.Enabled = false;
            }
            if ((PageNumber * PageSize) + PageSize >= RecordsCount)
            {
                btnNext.Enabled = false;
            }

            RefreshFormControls();
        }
        private void RefreshFormControls()
        {
            product = new Product();
            txtName.Clear();
            txtName.Focus();
            cbxCategory.SelectedIndex = -1;
            cbxSupplier.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = Controller.GetProductsListForSearch(txtName.Text,Convert.ToInt32(cbxCategory.SelectedValue), Convert.ToInt32(cbxSupplier.SelectedValue), PageNumber, PageSize);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.product = Controller.GetProductByProductID(Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value));
            if (this.product.ProductID > 0)
            {
                AddProductForm child = new AddProductForm(this.product);
                child.CloseProductFormEvent += log_CloseProductFormEvent;
                child.TopMost = false;
                child.Show();
            }
        }

        private void log_CloseProductFormEvent(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.product = new Product();
            AddProductForm child = new AddProductForm();
            child.CloseProductFormEvent+= log_CloseProductFormEvent;
            child.TopMost = false;
            child.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PageNumber++;
            LoadData();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            PageNumber--;
            LoadData();
        }

        private void SetPage()
        {
            if (txtPage.Text != null && txtPage.Text != String.Empty)
            {
                //if valid page then move to page else set pagenumber
                if (Convert.ToInt32(txtPage.Text) > 0 && Convert.ToInt32(txtPage.Text) <= RecordsCount / PageSize)
                {
                    PageNumber = Convert.ToInt32(txtPage.Text) - 1;
                    LoadData();
                }
                else
                {
                    txtPage.Text = (PageNumber + 1).ToString();
                }
            }
        }
        private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPage_Leave(object sender, EventArgs e)
        {
            SetPage();
        }

        private void ctrlProducts_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
