using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProductsDAL : DBContext
    {
        SqlConnection con;

        public ProductsDAL()
        {
            con = new SqlConnection(GetDBConnection());
        }
        public DataTable SearchProduct(string textToSearch)
        {
            SqlCommand cmd;
            int checkIfInterger;

            if (int.TryParse(textToSearch, out checkIfInterger))
            {
                cmd = new SqlCommand("SELECT StudentID, Fname AS Name,RollNo,c.ClassName,ad.Dsc, null as 'CityName' FROM Student AS st Inner join Class AS c on st.ClassID = c.ClassID left join Address ad on ad.AddressID = st.AddressID WHERE  RollNo = @text", con);
                //--inner join Cities as CT On st.ci = CT.CityID
            }
            else
            {
                cmd = new SqlCommand("SELECT StudentID,Fname AS Name,RollNo,c.ClassName,ad.Dsc,null as 'CityName' FROM Student AS st Inner join Class AS c on st.ClassID = c.ClassID left join Address ad on ad.AddressID = st.AddressID WHERE Fname LIKE '%' + @text + '%'", con);
                //--inner join Cities as CT On st.City = CT.CityID
            }
            DataTable dt = new DataTable();
            con.Open();
            cmd.Parameters.AddWithValue("@text", textToSearch);
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_PDCT_S0";

                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductID = Convert.ToInt32(reader["ProductID"]);
                    product.Name = Convert.ToString(reader["ProductName"]);
                    product.Code = Convert.ToString(reader["Code"]);
                    product.Description = Convert.ToString(reader["Description"]);
                    product.Quantity = Convert.ToInt32(reader["Quantity"]);
                    product.UnitPrice = Convert.ToDecimal(reader["UnitPrice"]);
                    product.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                    product.SupplierID = Convert.ToInt32(reader["SupplierID"]);
                    product.IsDeleted = Convert.ToBoolean(reader["IsDeleted"]);
                    product.ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]);
                    product.EffectiveDate = Convert.ToDateTime(reader["EffectiveDate"]);
                    product.ExpiryDate = reader["ExpiryDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ExpiryDate"]);
                    product.BatchNumber = Convert.ToString(reader["BatchNumber"]);
                    product.Barcode = Convert.ToString(reader["Barcode"]);
                    product.Barcode = Convert.ToString(reader["CreatedAt"]);
                    product.Barcode = Convert.ToString(reader["UpdatedAt"]);

                    products.Add(product);
                }
                reader.Close();
                con.Close();

                return products;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public Product GetProductByID(int ProductID)
        {
            Product product = new Product();

            try
            {
                SqlCommand cmd = new SqlCommand("SMS_PDCT_S1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@productid", ProductID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    product.ProductID = Convert.ToInt32(reader["ProductID"]);
                    product.Name = Convert.ToString(reader["ProductName"]);
                    product.Code = Convert.ToString(reader["Code"]);
                    product.Description = Convert.ToString(reader["Description"]);
                    product.Quantity = Convert.ToInt32(reader["Quantity"]);
                    product.UnitPrice = Convert.ToDecimal(reader["UnitPrice"]);
                    product.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                    product.SupplierID = Convert.ToInt32(reader["SupplierID"]);
                    product.IsDeleted = Convert.ToBoolean(reader["IsDeleted"]);
                    product.ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]);
                    product.EffectiveDate = Convert.ToDateTime(reader["EffectiveDate"]);
                    product.ExpiryDate = reader["ExpiryDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ExpiryDate"]);
                    product.BatchNumber = Convert.ToString(reader["BatchNumber"]);
                    product.Barcode = Convert.ToString(reader["Barcode"]);
                    product.Barcode = Convert.ToString(reader["CreatedAt"]);
                    product.Barcode = Convert.ToString(reader["UpdatedAt"]);
                }
                reader.Close();
                con.Close();
                return product;
            }
            catch (Exception)
            {
                return new Product();
            }
        }

        public bool InsertProduct(Product product)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_PDCT_I", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@productname", product.Name);
                cmd.Parameters.AddWithValue("@code", product.Code);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@quantity", product.Quantity);
                cmd.Parameters.AddWithValue("@unitprice", product.UnitPrice);
                cmd.Parameters.AddWithValue("@categoryid", product.CategoryID);
                cmd.Parameters.AddWithValue("@supplierid", product.SupplierID);
                cmd.Parameters.AddWithValue("@reorderlevel", product.ReorderLevel);
                cmd.Parameters.AddWithValue("@effectivedate", product.EffectiveDate);
                cmd.Parameters.AddWithValue("@expirydate", product.ExpiryDate);
                cmd.Parameters.AddWithValue("@batchnumber", product.BatchNumber);
                cmd.Parameters.AddWithValue("@barcode", product.Barcode);

                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    return true;
                }
                con.Close();
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool DeleteProduct(int productid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_PDCT_D", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@productid", productid);

                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    return true;
                }
                con.Close();
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                SqlCommand command = new SqlCommand("SMS_PDCT_U", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@productname", product.Name);
                command.Parameters.AddWithValue("@code", product.Code);
                command.Parameters.AddWithValue("@desc", product.Description);
                command.Parameters.AddWithValue("@quantity", product.Quantity);
                command.Parameters.AddWithValue("@unitprice", product.UnitPrice);
                command.Parameters.AddWithValue("@categoryid", product.CategoryID);
                command.Parameters.AddWithValue("@supplierid", product.SupplierID);
                command.Parameters.AddWithValue("@reorderlevel", product.ReorderLevel);
                command.Parameters.AddWithValue("@effectivedate", product.EffectiveDate);
                command.Parameters.AddWithValue("@expirydate", product.ExpiryDate);
                command.Parameters.AddWithValue("@batchnumber", product.BatchNumber);
                command.Parameters.AddWithValue("@barcode", product.Barcode);
                command.Parameters.AddWithValue("@productid", product.ProductID);

                con.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    return true;
                }
                con.Close();
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Helper
        #region Helper

        public int GetProductsCount()
        {
            try
            {
                con.Open();
                int count = 0;

                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_PDCT_COUNT";

                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    count = Convert.ToInt32(sdr["Products"]);
                }

                con.Close();
                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public List<Product> GetProductsList(int pageNumber = 0, int Pagesize = 10)
        {
            CategoriesDAL categoryHelper = new CategoriesDAL();
            SuppliersDAL suppliersHelper = new SuppliersDAL();
            List<Product> products = new List<Product>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_PDCT_S2";
                command.Parameters.AddWithValue("@pagenum", pageNumber);
                command.Parameters.AddWithValue("@pagesize", Pagesize);

                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductID = Convert.ToInt32(reader["ProductID"]);
                    product.Name = Convert.ToString(reader["ProductName"]);
                    product.Code = Convert.ToString(reader["Code"]);
                    product.Description = Convert.ToString(reader["Description"]);
                    product.Quantity = Convert.ToInt32(reader["Quantity"]);
                    product.UnitPrice = Convert.ToDecimal(reader["UnitPrice"]);
                    product.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                    product.SupplierID = Convert.ToInt32(reader["SupplierID"]);
                    product.IsDeleted = Convert.ToBoolean(reader["IsDeleted"]);
                    product.ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]);
                    product.EffectiveDate = Convert.ToDateTime(reader["EffectiveDate"]);
                    product.ExpiryDate = reader["ExpiryDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ExpiryDate"]);
                    product.BatchNumber = Convert.ToString(reader["BatchNumber"]);
                    product.Barcode = Convert.ToString(reader["Barcode"]);
                    product.Barcode = Convert.ToString(reader["CreatedAt"]);
                    product.Barcode = Convert.ToString(reader["UpdatedAt"]);
                    if (product.CategoryID > 0)
                    {
                        product.category = categoryHelper.GetCategoryByID(product.CategoryID);
                    }
                    else
                    {
                        product.category = null;
                    }
                    if (product.CategoryID > 0)
                    {
                        product.supplier = suppliersHelper.GetSupplierByID(product.SupplierID);
                    }
                    else
                    {
                        product.supplier = null;
                    }

                    products.Add(product);
                }
                reader.Close();
                con.Close();

                return products;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Product> GetProductsListForSearch(string name = "", int categoryid = 0, int supplierid = 0, int pageNumber = 0, int Pagesize = 10)
        {
            CategoriesDAL categoryHelper = new CategoriesDAL();
            SuppliersDAL suppliersHelper = new SuppliersDAL();
            List<Product> products = new List<Product>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_PDCT_S3";

                command.Parameters.AddWithValue("@pagenum", pageNumber);
                command.Parameters.AddWithValue("@pagesize", Pagesize);
                if (name != null && name != string.Empty)
                {
                    command.Parameters.AddWithValue("@name", name);
                }
                if (categoryid > 0)
                {
                    command.Parameters.AddWithValue("@categoryid", categoryid);
                }
                if (supplierid > 0)
                {
                    command.Parameters.AddWithValue("@supplierid", supplierid);
                }

                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductID = Convert.ToInt32(reader["ProductID"]);
                    product.Name = Convert.ToString(reader["ProductName"]);
                    product.Code = Convert.ToString(reader["Code"]);
                    product.Description = Convert.ToString(reader["Description"]);
                    product.Quantity = Convert.ToInt32(reader["Quantity"]);
                    product.UnitPrice = Convert.ToDecimal(reader["UnitPrice"]);
                    product.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                    product.SupplierID = Convert.ToInt32(reader["SupplierID"]);
                    product.IsDeleted = Convert.ToBoolean(reader["IsDeleted"]);
                    product.ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]);
                    product.EffectiveDate = Convert.ToDateTime(reader["EffectiveDate"]);
                    product.ExpiryDate = reader["ExpiryDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ExpiryDate"]);
                    product.BatchNumber = Convert.ToString(reader["BatchNumber"]);
                    product.Barcode = Convert.ToString(reader["Barcode"]);
                    product.Barcode = Convert.ToString(reader["CreatedAt"]);
                    product.Barcode = Convert.ToString(reader["UpdatedAt"]);
                    if (product.CategoryID > 0)
                    {
                        product.category = categoryHelper.GetCategoryByID(product.CategoryID);
                    }
                    else
                    {
                        product.category = null;
                    }
                    if (product.CategoryID > 0)
                    {
                        product.supplier = suppliersHelper.GetSupplierByID(product.SupplierID);
                    }
                    else
                    {
                        product.supplier = null;
                    }

                    products.Add(product);
                }
                reader.Close();
                con.Close();

                return products;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        #endregion
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public Category category { get; set; }
        public int SupplierID { get; set; }
        public Supplier supplier { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int ReorderLevel { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string BatchNumber { get; set; }
        public string Barcode { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class StockIn
    {
        public int StockInID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime StockInDate { get; set; }
        public string Remarks { get; set; }
    }
    public class StockOut
    {
        public int StockOutID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime StockOutDate { get; set; }
        public string Remarks { get; set; }
    }
}
