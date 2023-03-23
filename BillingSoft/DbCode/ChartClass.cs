using BillingSoft.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace BillingSoft.DbCode
{
    class ChartClass
    {
        DbConnection conn = new DbConnection();
        public void GetAllSelItProduct(Chart chart)
        {
            string query = "SELECT Distinct Price ,Date FROM History Group By Date Order By Id DESC  ";
            //  query += "ON customers.cid=pay.cid Order by customers.cid desc";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            //command.Parameters.Add("@ln", SqlDbType.VarChar).Value = invoice;
            conn.OpenConnection();
            SQLiteDataAdapter sdr = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            chart.DataSource = dt;

        }

        public DataTable GetAllSelItProductCount()
        {
            string query = "SELECT Distinct SUM(Price) as Sale ,Date FROM History Group By Date Order By Id DESC LIMIT 5  ";
            //  query += "ON customers.cid=pay.cid Order by customers.cid desc";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            //command.Parameters.Add("@ln", SqlDbType.VarChar).Value = invoice;
            conn.OpenConnection();
            SQLiteDataAdapter sdr = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);

            return dt;
        }
        public DataTable GetAllSelItProductCount(String date)
        {
            string query = "SELECT Distinct SUM(Price) as Sale FROM History WHERE Date!=@dt ";
            //  query += "ON customers.cid=pay.cid Order by customers.cid desc";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            command.Parameters.AddWithValue("@dt",date);
            conn.OpenConnection();
            SQLiteDataAdapter sdr = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);

            return dt;
        }
        //get Total Credit Price
        public String GetCreditPrice(String date)
        {
            string query = "SELECT  SUM(Price) as Sale FROM History WHERE Date!=@dt AND Payment='CREDIT' ";
            //  query += "ON customers.cid=pay.cid Order by customers.cid desc";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            command.Parameters.AddWithValue("@dt", date);
            conn.OpenConnection();
            int mySum = Convert.ToInt32(command.ExecuteScalar());
            conn.CloseConnection();
            return mySum.ToString();
        }

        //get Total Cash Price
        public String GetCashPrice(String date)
        {
            string query = "SELECT  SUM(Price) as Sale FROM History WHERE Date!=@dt AND Payment='CASH' ";
            //  query += "ON customers.cid=pay.cid Order by customers.cid desc";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            command.Parameters.AddWithValue("@dt", date);
            conn.OpenConnection();
            int mySum = Convert.ToInt32(command.ExecuteScalar());
            conn.CloseConnection();
            return mySum.ToString();
        }
        //get Total Price
        public String GetTotalPrice(String date)
        {
            string query = "SELECT  SUM(Price) as Sale FROM History WHERE Date!=@dt ";
            //  query += "ON customers.cid=pay.cid Order by customers.cid desc";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            command.Parameters.AddWithValue("@dt", date);
            conn.OpenConnection();
            int mySum = Convert.ToInt32(command.ExecuteScalar());
            conn.CloseConnection();
            return mySum.ToString();
        }
        //Update stock
        public bool addStockInfo(String open, String close, String date)
        {

            SQLiteCommand command = new SQLiteCommand();
            String insertQuery = "INSERT INTO Stock(Closing,Opening,Date) Values(@cl,@op,@dt) ";

            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@op", open);
            command.Parameters.AddWithValue("@dt", date);
            command.Parameters.AddWithValue("@cl", close); 
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
    }
}
