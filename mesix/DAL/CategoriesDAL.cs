using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CategoriesDAL : DBContext
    {
        SqlConnection con;

        public CategoriesDAL()
        {
            con = new SqlConnection(GetDBConnection());
        }
        public List<Category> GetCategories()
        {
            List<Category> Categories = new List<Category>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_CTGY_S0";

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    Category item = new Category();
                    item.CategoryID = Convert.ToInt32(sdr["CategoryID"]);
                    item.Name = Convert.ToString(sdr["Name"]);
                    item.Description = Convert.ToString(sdr["Description"]);
                    item.IsDeleted = Convert.ToBoolean(sdr["IsDeleted"]);

                    Categories.Add(item);
                }
                sdr.Close();
                con.Close();

                return Categories;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public Category GetCategoryByID(int CategoryID)
        {
            Category item = new Category();

            try
            {
                SqlCommand cmd = new SqlCommand("SMS_CTGY_S1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@categoryid", CategoryID);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    item.CategoryID = Convert.ToInt32(sdr["CategoryID"]);
                    item.Name = Convert.ToString(sdr["Name"]);
                    item.Description = Convert.ToString(sdr["Description"]);
                    item.IsDeleted = Convert.ToBoolean(sdr["IsDeleted"]);
                }
                sdr.Close();
                con.Close();
                return item;
            }
            catch (Exception)
            {
                return new Category();
            }
        }
        
        public bool InsertCategory(Category item)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_CTGY_I", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@description", item.Description);

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
        public bool DeleteCategory(int CategoryId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_CTGY_D", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@categoryid", CategoryId);

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
        
        public bool UpdateCategory(Category item)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_CTGY_U", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@description", item.Description);
                cmd.Parameters.AddWithValue("@categoryid", item.CategoryID);

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
                return false;
            }
        }
    }
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }
    }


}
