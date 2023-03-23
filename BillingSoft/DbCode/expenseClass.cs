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
    class expenseClass
    {
        DbConnection conn = new DbConnection();
        public bool inserIntoExpenseCategory(String cat)
        {

            SQLiteCommand command = new SQLiteCommand();
            String insertQuery = "INSERT INTO ExpenseCategory(Category) Values(@cat)";

            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@cat", cat); 
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
        public void getExpenseCategory(ComboBox box)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT Category,Id FROM ExpenseCategory", conn.getConnection());
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            box.DisplayMember = "Category";
            box.ValueMember = "Id";
            box.DataSource = table;

        }
        public bool inserIntoExpense(String cat,String name,String price,String detail,String date)
        {

            SQLiteCommand command = new SQLiteCommand();
            String insertQuery = "INSERT INTO Expense(Category,Name,Price,Detail,Date) Values(@cat,@nm,@price,@detail,@date)";

            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@cat", cat);
            command.Parameters.AddWithValue("@nm", name);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@detail", detail);
            command.Parameters.AddWithValue("@date", date);
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
        public DataTable getAllExpense()
        {
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Expense ", conn.getConnection());
           // command.Parameters.AddWithValue("@slm", saleman);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        //Get All Expense Using Dates
        public DataTable getAllExpensebyDate(String from,String to)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Expense WHERE Date BETWEEN '"+from+"' AND '"+to+"' ", conn.getConnection());
           // command.Parameters.AddWithValue("@slm", from);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        //delete
        public bool deleteProduct(string id)
        {
            SQLiteCommand command = new SQLiteCommand();
            String deleteQuery = "DELETE FROM Expense WHERE Id = @id ";

            command.CommandText = deleteQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@id", id);
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
        public bool updateProduct(String name, String price,String id)
        {
            SQLiteCommand command = new SQLiteCommand();
            String updateQuery = "UPDATE Expense SET Name=@nm,Price=@price WHERE Id=@id";

            command.CommandText = updateQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@nm", name); 
            command.Parameters.AddWithValue("@id", id); 
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
