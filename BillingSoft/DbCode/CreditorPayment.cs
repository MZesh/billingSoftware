using BillingSoft.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoft.DbCode
{
    class CreditorPayment
    {
        DbConnection conn = new DbConnection();
        public DataTable GetAllSelltProduct(String cus)
        {
            string query = "SELECT  Customer,Remaining,InvoiceNo,AmountPaid FROM History WHERE Customer=@cus Order by Id DESC LIMIT 1";
            //  query += "ON customers.cid=pay.cid Order by customers.cid desc";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            command.Parameters.AddWithValue("@cus",cus);
            conn.OpenConnection();
            SQLiteDataAdapter sdr = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            return dt;

        }
        public DataTable GetAllNewCreditor(String cus)
        {
            string query = "SELECT  Name,TotalAmount,PaidAmount AS LastPaidAmount,Remaining,Invoice as Contact FROM Credit  WHERE  Name=@cus Order By Id DESC LIMIT 1";
            //  query += "ON customers.cid=pay.cid Order by customers.cid desc";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            command.Parameters.AddWithValue("@cus", cus);
            conn.OpenConnection();
            SQLiteDataAdapter sdr = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            return dt;

        }
        public DataTable GetAllCreditorReport(String cus)
        {
            string query = "SELECT Date, Name,TotalAmount,PaidAmount,Remaining,Invoice as Contact FROM Credit  WHERE  Name=@cus ";
            //  query += "ON customers.cid=pay.cid Order by customers.cid desc";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            command.Parameters.AddWithValue("@cus", cus);
            conn.OpenConnection();
            SQLiteDataAdapter sdr = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            return dt;

        }
        //Insert Customer Payment
        public bool insertCreditorDetail(String name,String tAmount,String pAmount,String remain,String invoice,String date)
        {
            SQLiteCommand command = new SQLiteCommand();
            String insertQuery = "INSERT INTO Credit(Name,TotalAmount, PaidAmount,Remaining,Invoice,Date) Values( @nm,@ta,@pa,@rem,@inv,@dt)";

            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@ta", tAmount);
            command.Parameters.AddWithValue("@pa", pAmount);
            command.Parameters.AddWithValue("@nm", name);
            command.Parameters.AddWithValue("@rem", remain);
            command.Parameters.AddWithValue("@inv", invoice); 
            command.Parameters.AddWithValue("@dt", date);
            conn.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.CloseConnection();
                return true;
            }
            else
            {
                conn.CloseConnection();
                return false;
            }
        }
        //Edit Products
        public bool editCreditor(String name, String invoice,String remain,String pAmount)
        {

            SQLiteCommand command = new SQLiteCommand();
            String editQuery = "UPDATE History SET AmountPaid=@pam,Remaining=@rem WHERE Customer=@nm AND InvoiceNo=@inv ";

            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@inv", invoice);
            command.Parameters.AddWithValue("@nm", name);
            command.Parameters.AddWithValue("@rem", remain);
            command.Parameters.AddWithValue("@pam", pAmount);
            conn.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.CloseConnection();
                return true;
            }
            else
            {
                conn.CloseConnection();
                return false;
            }

        }
        //get remaining
        public string GetAllRemain(string cus)
        {
            string remain = "";
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM History WHERE Customer=@cus Order by Id DESC LIMIT 1", conn.getConnection());
            command.Parameters.AddWithValue("@cus", cus);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    remain = reader["Remaining"].ToString();

                }
                /* else
                 {
                     MessageBox.Show("Error- No Data Found For Invoice " + invoice, "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
 */
            }
            return remain;
        }
        //get remaining
        public string GetAllRemainCreditor(string cus)
        {
            string remain = "";
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Credit WHERE Name=@cus Order by Id DESC LIMIT 1", conn.getConnection());
            command.Parameters.AddWithValue("@cus", cus);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    remain = reader["Remaining"].ToString();

                }
                /* else
                 {
                     MessageBox.Show("Error- No Data Found For Invoice " + invoice, "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
 */
            }
            return remain;
        }
        //get history price total
        public long GetTotalPrice(string cus)
        {
            long price = 0;
            string query = "SELECT * FROM  History WHERE Customer=@cus";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());

            command.Parameters.AddWithValue("@cus", cus); 
            //command.Parameters.Add("@ln", SqlDbType.VarChar).Value = invoice;
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    price += long.Parse(reader["Price"].ToString());

                }


            }
            return price;
        }
    }
}
