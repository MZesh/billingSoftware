using BillingSoft.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BillingSoft.DbCode
{
    class companyClass
    {
        DbConnection conn = new DbConnection();

        public String getCompanyName()
        {
            String company = "";
            SQLiteCommand command = new SQLiteCommand("SELECT Name FROM Company ", conn.getConnection());
            //command.Parameters.AddWithValue("@ln", invoice);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                   company=reader["Name"].ToString();
                     
                }
            }
            return company;
        }
        public String getCompanyAddress()
        {
            String company = "";
            SQLiteCommand command = new SQLiteCommand("SELECT Address FROM Company ", conn.getConnection());
            //command.Parameters.AddWithValue("@ln", invoice);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    company = reader["Address"].ToString();

                }
            }
            return company;
        }
        public String getCompanyPhone()
        {
            String company = "";
            SQLiteCommand command = new SQLiteCommand("SELECT Phone FROM Company ", conn.getConnection());
            //command.Parameters.AddWithValue("@ln", invoice);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    company = reader["Phone"].ToString();

                }
            }
            return company;
        }
        public String getCompanyImage()
        {
            String company = "";
            SQLiteCommand command = new SQLiteCommand("SELECT LogoName FROM Company ", conn.getConnection());
            //command.Parameters.AddWithValue("@ln", invoice);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    company = reader["LogoName"].ToString();

                }
            }
            return company;
        }
        public String getStatus()
        {
            String company = "";
            SQLiteCommand command = new SQLiteCommand("SELECT Enabled FROM Company ", conn.getConnection());
            //command.Parameters.AddWithValue("@ln", invoice);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    company = reader["Enabled"].ToString();

                }
            }
            return company;
        }
         public bool insertCompanyDetail(String name, String add, String phone, String ntn, String zip , String logoname,String Enable)
        {
            
                SQLiteCommand command = new SQLiteCommand();
                String insertQuery = "INSERT INTO Company(Name,Address, Phone,NTN,ZipCode,LogoName,Enabled)" +
                " Values( @nm,@add,@ph,@ntn,@zip,@logo,@enb)";

                command.CommandText = insertQuery;
                command.Connection = conn.getConnection();

                command.Parameters.AddWithValue("@add", add);
                command.Parameters.AddWithValue("@ph", phone);
                command.Parameters.AddWithValue("@nm", name);
                command.Parameters.AddWithValue("@ntn", ntn);
                command.Parameters.AddWithValue("@zip", zip);
                command.Parameters.AddWithValue("@logo", logoname); 
                command.Parameters.AddWithValue("@enb", Enable); 
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
        public void fillTheFields(TextBox box1, TextBox box2, TextBox box3,TextBox box4,TextBox box5, Label label)
        {
            
                string query = "SELECT * FROM  Company";
                SQLiteCommand command = new SQLiteCommand(query, conn.getConnection()); 
                conn.OpenConnection();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        box1.Text = reader["Name"].ToString();
                        box2.Text = reader["Address"].ToString();
                        box3.Text = reader["Phone"].ToString();
                        box4.Text = reader["NTN"].ToString();
                        box5.Text = reader["ZipCode"].ToString();
                        label.Text = reader["LogoName"].ToString();
                    }
                     
            }
        }
    }
}
