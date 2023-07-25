using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CityDAL : DBContext
    {



        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A61AK54\NEWTEST;Initial Catalog=StudentDataBase;Integrated Security=True");


        public CityDAL()
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); // Add an Application Setting.
            //string connectionString=config.AppSettings.Settings["con"].Value;
            con = new SqlConnection(GetDBConnection());

        }
        public List<Cities> GetCities()
        {
            List<Cities> city = new List<Cities>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_GET_ALL_CITIES";

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    Cities item = new Cities();
                    item.Id = Convert.ToInt32(sdr["CityID"]);
                    item.CityName = sdr["CityName"].ToString();

                    city.Add(item);
                }
                sdr.Close();
                con.Close();

                return city;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public void AddCity(string city)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT into Cities VALUES(@city)", con);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void DeleteCity(int id)
        {

            SqlCommand cmd = new SqlCommand("Delete from Cities where CityID=@ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }


    }
}
