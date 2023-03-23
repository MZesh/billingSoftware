using BillingSoft.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.DbCode
{
    class countClass
    {
        DbConnection conn = new DbConnection();
      
        public DataTable GetAllItProduct()
        {
            string query = "SELECT  ItemName,ItemCode FROM Product";
            //  query += "ON customers.cid=pay.cid Order by customers.cid desc";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            //command.Parameters.Add("@ln", SqlDbType.VarChar).Value = invoice;
            conn.OpenConnection();
            SQLiteDataAdapter sdr = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            return dt;

        }
        public DataTable GetAllSelltProduct(String date)
        {
            string query = "SELECT  ItemName,ItemCode,Price,Date FROM History WHERE Date=@dt";
            //  query += "ON customers.cid=pay.cid Order by customers.cid desc";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            command.Parameters.AddWithValue("@dt",date);
            conn.OpenConnection();
            SQLiteDataAdapter sdr = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            return dt;

        }
        public DataTable GetAllUnpaidInvoices()
        {
            string query = "SELECT  ItemName,ItemCode FROM History WHERE BillGen='No'";
            //  query += "ON customers.cid=pay.cid Order by customers.cid desc";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            //command.Parameters.Add("@ln", SqlDbType.VarChar).Value = invoice;
            conn.OpenConnection();
            SQLiteDataAdapter sdr = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            return dt;

        }
    }
}
