using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class FeeDAL : DBContext
    {
        SqlConnection con;

        public FeeDAL()
        {
            con = new SqlConnection(connectionstring);
        }
        public DataTable SearchStudentCnfg(string textToSearch)
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
        public List<FeesModel> FeeSummary(int studentId)
        {
            List<FeesModel> fees = new List<FeesModel>();
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_FEES_S2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@studentid", studentId);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    FeesModel item = new FeesModel();
                    item.FeeID = Convert.ToInt32(sdr["FeeID"]);
                    item.StudentID = Convert.ToInt32(sdr["StudentID"]);
                    item.isPaid = Convert.ToBoolean(sdr["IsPaid"]);
                    item.IssuedAmount = Convert.ToDecimal(sdr["IssuedFee"]);
                    item.PaidAmount = Convert.ToDecimal(sdr["Fee"]);
                    item.Balance = Convert.ToDecimal(sdr["Balance"]);
                    item.Month = Convert.ToInt32(sdr["MonthID"]);
                    item.MonthName = sdr["Month"].ToString();
                    item.Year = Convert.ToInt32(sdr["Year"]);
                    item.Day = Convert.ToInt32(sdr["Day"]);
                    item.SubmitDateTime = sdr["Date"].ToString();
                    item.SubmittedByUserID = Convert.ToInt32(sdr["UserID"]);
                    item.SubmittedBy = sdr["FirstName"].ToString();

                    fees.Add(item);
                }
                sdr.Close();
                //dt.Load(sdr);
                con.Close();
                return fees;
            }
            catch (Exception)
            {
                return new List<FeesModel>();
            }
        }
        public List<FeesPaidDetail> FeeInvoicePaidDetails(int InvcID, bool IsStudent)
        {
            List<FeesPaidDetail> fees = new List<FeesPaidDetail>();
            try
            {
                SqlCommand cmd;
                if (IsStudent)
                {
                    cmd = new SqlCommand("select rcbl_id,invc_id,Date as 'ReceiptDate', Amount as 'ReceiptAmount' from FeePaid where invc_id=@invc_id", con);
                }
                else
                {
                    cmd = new SqlCommand("select rcbl_id,invc_id,Date as 'ReceiptDate', Amount as 'ReceiptAmount' from SalaryPaid where invc_id=@invc_id", con);
                }
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@invc_id", InvcID);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    FeesPaidDetail item = new FeesPaidDetail();
                    item.RcblID = Convert.ToInt32(sdr["rcbl_id"]);
                    item.InvoiceID = Convert.ToInt32(sdr["invc_id"]);
                    item.PaidDate = Convert.ToDateTime(sdr["ReceiptDate"]);
                    item.PaidAmount = Convert.ToDecimal(sdr["ReceiptAmount"]);

                    fees.Add(item);
                }
                sdr.Close();
                //dt.Load(sdr);
                con.Close();
                return fees;
            }
            catch (Exception)
            {
                return new List<FeesPaidDetail>();
            }
        }
        public FeeDetailEntity GetFeeDetailEntity(int Mode, int InvcID = 0, int _studentID = 0)
        {
            FeeDetailEntity item = new FeeDetailEntity();

            try
            {
                SqlCommand cmd = new SqlCommand("SMS_FEE_CNFG_S3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@invoiceid", InvcID);
                cmd.Parameters.AddWithValue("@studentid", _studentID);
                cmd.Parameters.AddWithValue("@mode", Mode);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    item.Receivables = Convert.ToDecimal(sdr["Receivables"]);
                    item.Paid = Convert.ToDecimal(sdr["Paid"]);
                    item.Outstandings = Convert.ToDecimal(sdr["Outstandings"]);
                }
                sdr.Close();
                //dt.Load(sdr);
                con.Close();
                return item;
            }
            catch (Exception)
            {
                return new FeeDetailEntity();
            }
        }
        public List<FeesInvoiceDetail> FeeInvoiceDetails(int studentId)
        {
            List<FeesInvoiceDetail> fees = new List<FeesInvoiceDetail>();
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_FEE_INVC_S1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@studentid", studentId);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    FeesInvoiceDetail item = new FeesInvoiceDetail();
                    item.InvoiceID = Convert.ToInt32(sdr["invc_id"]);
                    item.StudentID = Convert.ToInt32(sdr["StudentID"]);
                    item.InvoiceDate = Convert.ToDateTime(sdr["InvcDate"]);
                    item.InvoiceAmount = Convert.ToDecimal(sdr["InvcAmount"]);
                    item.Comments = sdr["Comments"].ToString();
                    item.Status = Convert.ToBoolean(sdr["Status"]);

                    fees.Add(item);
                }
                sdr.Close();
                con.Close();
                return fees;
            }
            catch (Exception)
            {
                return new List<FeesInvoiceDetail>();
            }
        }
        public void InsertClassFeeCnfg(ClassFeeCnfg c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_CLASS_FEE_CNFG_I", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@feeamount", c.FeeAmount);
                cmd.Parameters.AddWithValue("@classid", c.ClassID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool InsertFeeCnfg(FeeCnfg c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_FEE_CNFG_I", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@amount", c.Amount);
                cmd.Parameters.AddWithValue("@studentid", c.StudentID);
                cmd.Parameters.AddWithValue("@status", c.Status);

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
        public void DeleteClassFeeCnfg(int classid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_CLASS_FEE_CNFG_D", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@classid", classid);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<ClassFeeCnfg> GetClassFeeCnfg()
        {
            List<ClassFeeCnfg> classFeeCnfg = new List<ClassFeeCnfg>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_CLASS_FEE_CNFG_S0";

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    ClassFeeCnfg item = new ClassFeeCnfg();
                    item.ClassFeeCnfgID = Convert.ToInt32(sdr["ClassFeeCnfgID"]);
                    item.ClassName = sdr["ClassName"].ToString();
                    item.FeeAmount = Convert.ToDecimal(sdr["Amount"]);

                    classFeeCnfg.Add(item);
                }
                sdr.Close();
                con.Close();

                return classFeeCnfg;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool GenerateInvoice(bool IsFee, FeesInvoiceDetail i = null, SalaryInvoiceDetail s = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_FEES_SLRY_INVC_GNTN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (IsFee)
                {

                    cmd.Parameters.AddWithValue("@studentid", i.StudentID);
                    cmd.Parameters.AddWithValue("@invcdate", i.InvoiceDate);
                    cmd.Parameters.AddWithValue("@invcamount", i.InvoiceAmount);
                    cmd.Parameters.AddWithValue("@comments", i.Comments);
                    cmd.Parameters.AddWithValue("@status", i.Status);
                    cmd.Parameters.AddWithValue("@isFee", IsFee);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@studentid", s.EmpID);
                    cmd.Parameters.AddWithValue("@invcdate", s.InvoiceDate);
                    cmd.Parameters.AddWithValue("@invcamount", s.InvoiceAmount);
                    cmd.Parameters.AddWithValue("@status", s.Status);
                    cmd.Parameters.AddWithValue("@isFee", IsFee);
                }

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
        public bool UpdateInvoice(bool IsFee, FeesInvoiceDetail i = null, SalaryInvoiceDetail s = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_FEES_SLRY_INVC_U", con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (IsFee)
                {
                    cmd.Parameters.AddWithValue("@invoiceid", i.InvoiceID);
                    cmd.Parameters.AddWithValue("@invcdate", i.InvoiceDate);
                    cmd.Parameters.AddWithValue("@invcamount", i.InvoiceAmount);
                    cmd.Parameters.AddWithValue("@comments", i.Comments);
                    cmd.Parameters.AddWithValue("@isFee", IsFee);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@invoiceid", s.InvoiceID);
                    cmd.Parameters.AddWithValue("@invcdate", s.InvoiceDate);
                    cmd.Parameters.AddWithValue("@invcamount", s.InvoiceAmount);
                    cmd.Parameters.AddWithValue("@comments", s.Comments);
                    cmd.Parameters.AddWithValue("@isFee", IsFee);
                }
                    
                
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
        public List<FeesInvoiceDetail> IsInvcExists(int sID, DateTime d)
        {
            List<FeesInvoiceDetail> feeInvoices = new List<FeesInvoiceDetail>();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_FEE_INVC_S2";
                command.Parameters.AddWithValue("@studentid", sID);
                command.Parameters.AddWithValue("@invcdte", d.Date);

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    FeesInvoiceDetail item = new FeesInvoiceDetail();
                    item.InvoiceID = Convert.ToInt32(sdr["invc_id"]);
                    item.StudentID = Convert.ToInt32(sdr["StudentID"]);
                    item.InvoiceDate = Convert.ToDateTime(sdr["Date"]);
                    item.InvoiceAmount = Convert.ToDecimal(sdr["Amount"]);
                    item.Status = Convert.ToBoolean(sdr["Status"]);
                    item.INSR_DTE = Convert.ToDateTime(sdr["INSR_DTE"]);

                    feeInvoices.Add(item);
                }
                sdr.Close();
                con.Close();

                return feeInvoices;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public FeesInvoiceDetail GetFeeInvoiceByInvoiceID(int InvoiceID)
        {
                    FeesInvoiceDetail item = new FeesInvoiceDetail();
            try
            {
                SqlCommand cmd = new SqlCommand("SMS_FEES_INVC_S1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@invoiceid", InvoiceID);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    item.InvoiceID = Convert.ToInt32(sdr["invc_id"]);
                    item.StudentID = Convert.ToInt32(sdr["StudentID"]);
                    item.InvoiceDate = Convert.ToDateTime(sdr["Date"]);
                    item.InvoiceAmount = Convert.ToDecimal(sdr["Amount"]);
                    item.Comments = sdr["Comments"].ToString();
                    item.Status = Convert.ToBoolean(sdr["Status"]);
                }
                sdr.Close();
                con.Close();
                return item;
            }
            catch (Exception)
            {
                return new FeesInvoiceDetail();
            }
        }
        public List<FeeCnfg> GetFeeCnfg(int sid)
        {
            List<FeeCnfg> feeCnfg = new List<FeeCnfg>();
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SMS_FEE_CNFG_S2";
                command.Parameters.AddWithValue("@studentid", sid);

                con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    FeeCnfg item = new FeeCnfg();
                    item.FeeCnfgID = Convert.ToInt32(sdr["FeeCnfgID"]);
                    item.StudentID = Convert.ToInt32(sdr["StudentID"]);
                    item.StudentName = sdr["FirstName"].ToString();
                    item.Amount = Convert.ToDecimal(sdr["Amount"]);
                    item.Status = Convert.ToBoolean(sdr["Status"]);

                    feeCnfg.Add(item);
                }
                sdr.Close();
                con.Close();

                return feeCnfg;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
