using BillingSoft.Connection;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoft.DbCode
{
    class DeveloperClass
    {
        DbConnection conn = new DbConnection();
        //get developer name
        public string GetDeveloperName()
        {
            string dev = "";
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM developer", conn.getConnection());

            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    dev = reader["Name"].ToString();

                }
                /* else
                 {
                     MessageBox.Show("Error- No Data Found For Invoice " + invoice, "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
 */
            }
            return dev;
        }
        //get developer contact
        public string GetDeveloperContact()
        {
            string devcont = "";
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM developer", conn.getConnection());

            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    string cont1= reader["Contact"].ToString();
                    string cont2 = reader["Contact2"].ToString();
                    devcont = cont1 + "/" + cont2;
                }
               
            }
            return devcont;
        }
        //get developer email
        public string GetDeveloperEmail()
        {
            string devemail = "";
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM developer", conn.getConnection());

            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    devemail = reader["Email"].ToString();

                }
                /* else
                 {
                     MessageBox.Show("Error- No Data Found For Invoice " + invoice, "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
 */
            }
            return devemail;
        }
        //update developer credentials
        public bool updateDeveloper(String name, String cont1, String cont2,String email)
        {
            SQLiteCommand command = new SQLiteCommand();
            String editQuery = "UPDATE developer SET  Name=@nm, Contact=@cont1,Contact2=@cont2,Email=@email ";

            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@nm", name);
            command.Parameters.AddWithValue("@cont1", cont1);
            command.Parameters.AddWithValue("@cont2", cont2);
            command.Parameters.AddWithValue("@email", email);
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
