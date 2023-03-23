using BillingSoft.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace BillingSoft.DbCode
{
    class BusinessClass
    {
        DbConnection conn = new DbConnection();
        public DataTable GetAllSelItProduct()
        {
            string query = "SELECT  ItemName,ItemCode,Purchase,Price ,Date FROM History";
            //  query += "ON customers.cid=pay.cid Order by customers.cid desc";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            //command.Parameters.Add("@ln", SqlDbType.VarChar).Value = invoice;
            conn.OpenConnection();
            SQLiteDataAdapter sdr = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            return dt;

        }
        public DataTable GetAllExpenses()
        {
            string query = "SELECT  Category,Name,Price,Date FROM Expense";
            //  query += "ON customers.cid=pay.cid Order by customers.cid desc";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            //command.Parameters.Add("@ln", SqlDbType.VarChar).Value = invoice;
            conn.OpenConnection();
            SQLiteDataAdapter sdr = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            return dt;

        }

        public DataTable GetAllSelItProduct(String dateTime,String dateTime1)
        {
            string query = "SELECT  ItemName,ItemCode,Purchase,Price ,Date FROM History WHERE Date BETWEEN '"+dateTime+"' AND '"+dateTime1+"'";
            //  query += "ON customers.cid=pay.cid Order by customers.cid desc";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            //command.Parameters.Add("@ln", SqlDbType.VarChar).Value = invoice;
            conn.OpenConnection();
            SQLiteDataAdapter sdr = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            return dt;

        }
        public DataTable GetAllExpenses(String frm,String to)
        {
            string query = "SELECT  Category,Name,Price,Date FROM Expense WHERE Date BETWEEN '"+frm+"' AND '"+to+"'";
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
