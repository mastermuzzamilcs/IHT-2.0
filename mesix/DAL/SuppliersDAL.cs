using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SuppliersDAL : DBContext
    {
        SqlConnection con;

        public SuppliersDAL()
        {
            con = new SqlConnection(GetDBConnection());
        }
        public List<Supplier> GetSuppliers()
        {
            List<Supplier> Suppliers = new List<Supplier>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_SPLR_S0";

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    Supplier item = new Supplier();
                    item.SupplierID = Convert.ToInt32(sdr["SupplierID"]);
                    item.Name = Convert.ToString(sdr["Name"]);
                    item.ContactName = Convert.ToString(sdr["ContactName"]);
                    item.Phone = Convert.ToString(sdr["Phone"]);
                    item.Email = Convert.ToString(sdr["Email"]);
                    item.Address = Convert.ToString(sdr["Address"]);

                    Suppliers.Add(item);
                }
                sdr.Close();
                con.Close();

                return Suppliers;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public Supplier GetSupplierByID(int SupplierID)
        {
            Supplier item = new Supplier();

            try
            {
                SqlCommand cmd = new SqlCommand("SMS_SPLR_S1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@supplierid", SupplierID);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    item.SupplierID = Convert.ToInt32(sdr["SupplierID"]);
                    item.Name = Convert.ToString(sdr["Name"]);
                    item.ContactName = Convert.ToString(sdr["ContactName"]);
                    item.Phone = Convert.ToString(sdr["Phone"]);
                    item.Email = Convert.ToString(sdr["Email"]);
                    item.Address = Convert.ToString(sdr["Address"]);
                }
                sdr.Close();
                con.Close();
                return item;
            }
            catch (Exception)
            {
                return new Supplier();
            }
        }

        public bool InsertSupplier(Supplier item)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_SPLR_I", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@contactname", item.ContactName);
                cmd.Parameters.AddWithValue("@phone", item.Phone);
                cmd.Parameters.AddWithValue("@email", item.Email);
                cmd.Parameters.AddWithValue("@address", item.Address);

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
        public bool DeleteSupplier(int supplierid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_SPLR_D", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@supplierid", supplierid);

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

        public bool UpdateSupplier(Supplier item)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_SPLR_U", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@contactname", item.ContactName);
                cmd.Parameters.AddWithValue("@phone", item.Phone);
                cmd.Parameters.AddWithValue("@email", item.Email);
                cmd.Parameters.AddWithValue("@address", item.Address);
                cmd.Parameters.AddWithValue("@supplierid", item.SupplierID);

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

    public class Supplier
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string IsDeleted { get; set; }
    }

}
