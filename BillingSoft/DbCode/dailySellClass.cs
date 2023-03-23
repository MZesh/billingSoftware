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
    class dailySellClass
    {
        DbConnection conn = new DbConnection();
        public DataTable getDailyReport(String date)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT ItemName as Item,ItemCode as Code,Category,Purchase,Price,Quantity as Qty,Customer,Contact,Payment as Type,Remaining as Remain,InvoiceNo,Total,Date FROM History WHERE Date=@dt", conn.getConnection());

            command.Parameters.AddWithValue("@dt", date);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
}
