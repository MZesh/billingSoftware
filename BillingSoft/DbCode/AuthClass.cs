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
    class AuthClass
    {
        DbConnection conn = new DbConnection();

        public bool Login(string user, string pass,string role)
        {
            DataTable table = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            SQLiteCommand command = new SQLiteCommand();

            String loginQuery = "SELECT * FROM Auth WHERE Username=@usn AND Password=@psd AND Role=@role";

            command.CommandText = loginQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@usn", user);
            command.Parameters.AddWithValue("@psd", pass);
            command.Parameters.AddWithValue("@role", role);


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetUserRole(string user,string pass)
        {
            string role = "";
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Auth  WHERE Username=@usn AND Password=@psd", conn.getConnection());
            command.Parameters.AddWithValue("@usn", user);
            command.Parameters.AddWithValue("@psd", pass);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    role = reader["Role"].ToString();

                }
                /* else
                 {
                     MessageBox.Show("Error- No Data Found For Invoice " + invoice, "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
 */
            }
            return role;
        }
        public string GetAdministratorPass()
        {
            string pass = "";
            SQLiteCommand command = new SQLiteCommand("SELECT Password FROM Auth  WHERE Role='Administrator'", conn.getConnection());
           // command.Parameters.AddWithValue("@usn", user);
           // command.Parameters.AddWithValue("@psd", pass);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    pass = reader["Password"].ToString();

                }
                /* else
                 {
                     MessageBox.Show("Error- No Data Found For Invoice " + invoice, "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
 */
            }
            return pass;
        }
        //add new users
        public bool isAddNewUser(string user,string pass,string role,string date)
        {
            SQLiteCommand command = new SQLiteCommand();
            String insertQuery = "INSERT INTO Auth(Username,Password,Role,Date) Values( @user,@pas,@role,@dt)";

            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pas", pass);
            command.Parameters.AddWithValue("@role", role); 
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
        public bool updateUser(String user, String pass, String role)
        {
            SQLiteCommand command = new SQLiteCommand();
            String editQuery = "UPDATE Auth SET  Username=@user, Password=@pass,Role=@role  WHERE Username = @user ";

            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);
            command.Parameters.AddWithValue("@role", role); 
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
        //getting password
        public bool GetPass(string pass,string user)
        {
            DataTable table = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            SQLiteCommand command = new SQLiteCommand();

            String loginQuery = "SELECT * FROM Auth WHERE Username=@user AND Password=@psd ";

            command.CommandText = loginQuery;
            command.Connection = conn.getConnection();
             
            command.Parameters.AddWithValue("@psd", pass); 
            command.Parameters.AddWithValue("@user", user); 


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //getting user
        public bool GetUser(string user)
        {
            DataTable table = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            SQLiteCommand command = new SQLiteCommand();

            String loginQuery = "SELECT * FROM Auth WHERE Username=@user ";

            command.CommandText = loginQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@user", user);


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //get theme name
        public string GetThemeName()
        {
            string theme = "";
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Theme", conn.getConnection());
             
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    theme = reader["Name"].ToString();

                }
                /* else
                 {
                     MessageBox.Show("Error- No Data Found For Invoice " + invoice, "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
 */
            }
            return theme;
        }
        //update theme name
        public bool updatetheme(String name)
        {
            SQLiteCommand command = new SQLiteCommand();
            String editQuery = "UPDATE Theme SET  Name=@nm ";

            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@nm", name);
            
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
