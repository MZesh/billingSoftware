using BillingSoft.Connection;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoft.DbCode
{
    class DbClass
    {
        DbConnection conn = new DbConnection();
        //Getting the backup location from Db
        public String getDbBackupLocation()
        {
            String loc = "";
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Backup   ", conn.getConnection());

            ///   command.Parameters.AddWithValue("@ln", inv);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {


                    loc = reader["Loc1"].ToString();

                }
            }
            return loc;
        }
    }
}
