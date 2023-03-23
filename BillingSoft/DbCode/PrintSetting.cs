using BillingSoft.Connection;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.DbCode
{
    class PrintSetting
    {
        DbConnection conn = new DbConnection();
        public void getPrintingTemplateSizes(ComboBox box1,TextBox box2,ComboBox box3)
        {
             
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM PrintingSetting ", conn.getConnection());
            //command.Parameters.AddWithValue("@ln", invoice);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    box1.Text = reader["Template"].ToString();
                    box2.Text = reader["Watermark"].ToString();
                    box3.Text = reader["QR"].ToString();

                }
            }
            
        }

        public String getPrintingSizes()
        {
            String sizes = "";
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM PrintingSetting ", conn.getConnection());
            //command.Parameters.AddWithValue("@ln", invoice);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    sizes = reader["Template"].ToString();

                }
            }
            return sizes;

        }

        public bool updatePrintSetting(String temp, String waterm, String qr, String preview)
        {

            SQLiteCommand command = new SQLiteCommand();
            String insertQuery = "Update PrintingSetting SET Template=@temp,Watermark=@wtr,QR=@qr,Preview=@prv";

            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@temp", temp);
            command.Parameters.AddWithValue("@wtr", waterm);
            command.Parameters.AddWithValue("@qr", qr);
            command.Parameters.AddWithValue("@prv", preview);
            
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
        public bool updateBackupLocSetting(String loc1, String loc2)
        {

            SQLiteCommand command = new SQLiteCommand();
            String insertQuery = "Update Backup SET Loc1=@loc1,Loc2=@loc2";

            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@loc1", loc1);
            command.Parameters.AddWithValue("@loc2", loc2); 

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
        public void getLocations(TextBox box1, TextBox box2)
        {

            SQLiteCommand command = new SQLiteCommand("SELECT Loc1,Loc2 FROM Backup", conn.getConnection());
            //command.Parameters.AddWithValue("@ln", invoice);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    box1.Text = reader["Loc1"].ToString();
                    box2.Text = reader["Loc2"].ToString();
                }
            }
        }
        public String getPrintingWatermark()
        {
            String watermark = "";
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM PrintingSetting ", conn.getConnection());
            //command.Parameters.AddWithValue("@ln", invoice);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    watermark = reader["Watermark"].ToString();

                }
            }
            return watermark;

        }
        public String getPrintingQRCode()
        {
            String qr = "";
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM PrintingSetting ", conn.getConnection());
            //command.Parameters.AddWithValue("@ln", invoice);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    qr = reader["QR"].ToString();

                }
            }
            return qr;

        }
        public string getInvoiceNo()
        {
            string invoiceNo = "";
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Invoice", conn.getConnection());
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    invoiceNo = reader["InvoiceNo"].ToString();

                }


            }
            return invoiceNo;

        }

    }
}
