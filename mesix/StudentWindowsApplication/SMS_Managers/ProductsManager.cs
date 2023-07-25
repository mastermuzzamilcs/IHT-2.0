using DAL;
using DataTransferObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentWindowsApplication
{
    public class ProductsManager
    {
        public ProductsDAL productsDAL { get; set; }
        public CategoriesDAL categoriesDAL { get; set; }
        public SuppliersDAL suppliersDAL { get; set; }
        
        public ProductsManager()
        {
            productsDAL = new ProductsDAL();
            categoriesDAL = new CategoriesDAL();
            suppliersDAL = new SuppliersDAL();
        }
        public int GetProductsCount()
        {
            return productsDAL.GetProductsCount();
        }
        public List<Product> GetProductsList(int pageNumber = 0, int Pagesize = 10)
        {
            return productsDAL.GetProductsList(pageNumber, Pagesize);
        }
        public List<Product> GetProductsListForSearch(string name = "", int categoryid = 0, int supplierid = 0, int pageNumber = 0, int Pagesize = 10)
        {
            return productsDAL.GetProductsListForSearch(name,categoryid,supplierid,pageNumber, Pagesize);
        }
        public List<Category> GetAllCategories()
        {
            return categoriesDAL.GetCategories();
        }
        public List<Supplier> GetAllSuppliers()
        {
            return suppliersDAL.GetSuppliers();
        }
        public Product GetProductByProductID(int productid)
        {
            return productsDAL.GetProductByID(productid);
        }
        public bool AddProduct(Product _p)
        {
            return productsDAL.InsertProduct(_p);
        }
        public bool UpdateProduct(Product _p)
        {
            return productsDAL.UpdateProduct(_p);
        }
        public bool RemoveProduct(Product _p)
        {
            return productsDAL.DeleteProduct(_p.ProductID);
        }
    }
}
