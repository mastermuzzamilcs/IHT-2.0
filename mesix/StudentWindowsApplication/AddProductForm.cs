using DAL;
using DataTransferObjects;
using DataTransferObjects.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StudentWindowsApplication
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            this.Controller = new ProductsManager();
            this._product = new Product();
            this.isNew = true;
        }
        public ProductsManager Controller { get; set; }
        public AddProductForm(Product _p = null)
        {
            InitializeComponent();
            this.Controller = new ProductsManager();
            if (_p != null && _p.ProductID > 0)
            {
                this._product = _p;
                this.isNew = false;
            }
            else
            {
                this._product = new Product();
                this.isNew = true;
            }
        }
        public int ID;
        public Product _product;
        public bool isNew { get; set; }
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            SetLayout();
            GetMandatoryData();
            LoadData();
        }
        private void SetLayout()
        {
            lblBarCode.Visible = false;
            txtBarCode.Visible = false;
            lblReorderLevel.Enabled = false;
            txtReorderLevel.Enabled = false;
            this.Text = "Add New Product";
        }

        public void GetMandatoryData()
        {
            cbxCategory.DataSource = Controller.GetAllCategories();
            cbxCategory.DisplayMember = "Name";
            cbxCategory.ValueMember = "CategoryID";


            cbxSupplier.DataSource = Controller.GetAllSuppliers();
            cbxSupplier.DisplayMember = "Name";
            cbxSupplier.ValueMember = "SupplierID";
        }
        private void LoadData()
        {
            btnDelete.Visible = false;
            btnRefresh.Visible = false;
            txtName.Focus();

            RefreshFormControls();
            if (this._product != null)
            {
                if (this._product.ProductID > 0)
                {
                    btnDelete.Visible = true;

                    txtName.Text = _product.Name;
                    txtCode.Text = _product.Code;
                    cbxCategory.SelectedValue = _product.CategoryID;
                    cbxSupplier.SelectedValue = _product.SupplierID;
                    txtQuantity.Text = _product.Quantity.ToString();
                    txtUnitPrice.Text = _product.UnitPrice.ToString();
                    txtBatchNumber.Text = _product.BatchNumber;
                    try
                    {
                        dtpEffectiveDate.Value = Convert.ToDateTime(_product.EffectiveDate);
                    }
                    catch (Exception)
                    {
                        dtpEffectiveDate.Value = DateTime.Now;
                    }
                    try
                    {
                        dtpExpiryDate.Value = Convert.ToDateTime(_product.ExpiryDate);
                    }
                    catch (Exception)
                    {
                        dtpExpiryDate.Value = DateTime.Now;
                    }
                    txtReorderLevel.Text = _product.ReorderLevel.ToString();
                    txtBarCode.Text = _product.Barcode;
                    txtDescription.Text = _product.Description;
                }
            }
            else
            {
                var savepos = tableLayoutPanel2.GetColumn(btnSave);
                var deletepos = tableLayoutPanel2.GetColumn(btnDelete);
                tableLayoutPanel2.SetColumn(btnDelete, savepos);
                tableLayoutPanel2.SetColumn(btnSave, deletepos);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) //Insert
        {
            if (isNew)
            {
                AddNewProduct();
            }
            else
            {
                UpdateProduct();
            }
        }
        public void UpdateProduct()
        {
            if (IsValid())
            {
                if (this._product != null)
                {
                    if (this._product.ProductID > 0)
                    {
                        this._product.Name = txtName.Text;
                        this._product.Code = txtCode.Text;
                        this._product.CategoryID = Convert.ToInt32(cbxCategory.SelectedValue);
                        this._product.SupplierID = Convert.ToInt32(cbxSupplier.SelectedValue);
                        this._product.Quantity = Convert.ToInt32(txtQuantity.Text);
                        this._product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                        this._product.BatchNumber = txtBatchNumber.Text;
                        this._product.EffectiveDate = dtpEffectiveDate.Value;
                        this._product.ExpiryDate = dtpExpiryDate.Value;
                        this._product.ReorderLevel = Convert.ToInt32(txtReorderLevel.Text);
                        this._product.Barcode = txtBarCode.Text;

                        if (Controller.UpdateProduct(_product))
                        {
                            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("An Internal Error Occured... Please Try Again or Try Contacting Service Administrator", "Internal Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("An Internal Error Occured. No Action Found", "No Action Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("An Internal Error Occured. No Action Found", "No Action Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void AddNewProduct()
        {
            if (IsValid())
            {
                this._product = new Product()
                {
                    Name = txtName.Text,
                    Code = txtCode.Text,
                    CategoryID = Convert.ToInt32(cbxCategory.SelectedValue),
                    SupplierID = Convert.ToInt32(cbxSupplier.SelectedValue),
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    BatchNumber = txtBatchNumber.Text,
                    EffectiveDate = dtpEffectiveDate.Value,
                    ExpiryDate = dtpExpiryDate.Value,
                    ReorderLevel = txtReorderLevel.Text==string.Empty? 0:Convert.ToInt32(txtReorderLevel.Text),
                    Barcode = txtBarCode.Text
                };

                if (Controller.AddProduct(_product))
                {
                    MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An Internal Error Occured... Please Try Again or Try Contacting Service Administrator", "Internal Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                RefreshFormControls();
            }
        }
        private bool IsValid()
        {
            bool isFormValid = true;
            List<string> ErrorMsgs = new List<string>();

            if (txtName.Text == string.Empty || txtName.Text == null)
            {
                ErrorMsgs.Add("Product Name cannot be Null or Empty");
                isFormValid = false;
            }
            if (cbxCategory.SelectedValue == null || Convert.ToInt32(cbxCategory.SelectedValue) <= 0)
            {
                ErrorMsgs.Add("Product Category cannot be Null or Empty");
                isFormValid = false;
            }
            if (cbxSupplier.SelectedValue == null || Convert.ToInt32(cbxSupplier.SelectedValue) <= 0)
            {
                ErrorMsgs.Add("Product Supplier cannot be Null or Empty");
                isFormValid = false;
            }
            if (txtQuantity.Text == null || txtQuantity.Text == string.Empty)
            {
                ErrorMsgs.Add("Product Quantity cannot be Empty");
                isFormValid = false;
            }
            if (txtUnitPrice.Text == null || txtUnitPrice.Text == string.Empty)
            {
                ErrorMsgs.Add("Unit Price cannot be Empty");
                isFormValid = false;
            }

            if (!isFormValid)
            {
                var message = string.Join(Environment.NewLine, ErrorMsgs);
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            RefreshFormControls();

        }
        private void RefreshFormControls()
        {
            btnSave.Enabled = true;
            txtName.Clear();
            txtCode.Clear();
            cbxCategory.SelectedIndex = -1;
            cbxSupplier.SelectedIndex = -1;
            txtQuantity.Clear();
            txtUnitPrice.Clear();
            txtBatchNumber.Clear();
            dtpEffectiveDate.Value = DateTime.Now;
            dtpExpiryDate.Value = DateTime.Now;
            txtReorderLevel.Clear();
            txtBarCode.Clear();
            txtDescription.Clear();

            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e) //Delete
        {
            if (this._product != null)
            {
                if (this._product.ProductID > 0)
                {
                    if (Controller.RemoveProduct(this._product))
                    {
                        MessageBox.Show("Action Commited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        RefreshFormControls();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("An Internal Error Occured... Please Try Again or Try Contacting Service Administrator", "Internal Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("please Select Atleast One Row", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SavePic()
        {
            //Student stu = new Student();
            //if (PicForUpdate != null)
            //{
            //    stu.Name = txtName.Text;
            //    stu.Roll = Convert.ToInt32(txtRollNo.Text);
            //    Image img = PicForUpdate.Image;
            //    stu.PictureName = stu.Name + "" + stu.Roll;// Asad14
            //    string path = ConfigurationManager.AppSettings["ImageRouteDir"];// +stu.PictureName;
            //    if (!Directory.Exists(path))
            //    {
            //        Directory.CreateDirectory(path);
            //    }
            //    path = ConfigurationManager.AppSettings["ImageRouteDir"] + stu.PictureName;

            //    if (File.Exists(path))
            //    {
            //        File.Delete(path);
            //    }
            //    if (img != null)
            //        img.Save(path + stu.PictureName);
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event EventHandler CloseProductFormEvent;

        private void AddProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CloseProductFormEvent != null)
            {
                CloseProductFormEvent(sender, new EventArgs());
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
            }
            else
            {
                if (!(e.KeyChar == '\b'))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtReorderLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
