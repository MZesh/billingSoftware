using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace BillingSoft.Connection
{
   public class DbConnection
    {
        string connectionString = "Data Source=dgbillingsoft.db;version=3";
        SQLiteConnection con;

        public SQLiteConnection getConnection()
        {
            con = new SQLiteConnection(connectionString);
            return con;
        }

        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
