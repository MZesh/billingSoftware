using BillingSoft.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace BillingSoft.DbCode
{
    class productClass
    {
        DbConnection conn = new DbConnection();

        public bool InsertProduct(String itemname, String itemcode, String cat, String brand, String purchase, String sell, String qty, String total, String dateTime)
        {
            Boolean isCheck = isItemExistsOrNot(itemname, itemcode);
            if (isCheck)
            {
                conn.OpenConnection();
                SQLiteCommand command = new SQLiteCommand();
                String insertQuery = "INSERT INTO Product(ItemName,ItemCode, ItemCategory,ItemBrand,PPrice,SPrice,Quantity,TotalPrice,Date)" +
                    " Values(@nm,@code,@cat,@bnd,@pp,@sp,@qt,@st,@dt)";

                command.CommandText = insertQuery;
                command.Connection = conn.getConnection();

                command.Parameters.AddWithValue("@cat", cat);
                command.Parameters.AddWithValue("@code", itemcode);
                command.Parameters.AddWithValue("@bnd", brand);
                command.Parameters.AddWithValue("@qt", qty);
                command.Parameters.AddWithValue("@nm", itemname);
                command.Parameters.AddWithValue("@pp", purchase);
                command.Parameters.AddWithValue("@sp", sell);
                command.Parameters.AddWithValue("@st", total);
                command.Parameters.AddWithValue("@dt", dateTime);
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
            else
            {
                return false;
            }
        }
        private bool isItemExistsOrNot(String itemname, String itemcode)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT Count(*) FROM Product WHERE ItemName=@nm AND ItemCode=@code", conn.getConnection());


            command.Parameters.AddWithValue("@nm", itemname);
            command.Parameters.AddWithValue("@code", itemcode);
            conn.OpenConnection();
            int exitst = Convert.ToInt32(command.ExecuteScalar());
            if (exitst > 0)
            {
                conn.CloseConnection();
                return false;
            }
            else
            {
                return true;
            }
        }
        //Get All Products
        public DataTable getAllProducts()
        {
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Product", conn.getConnection());
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        //Get All out of stock Products
        public DataTable getAllOutStockProducts()
        {
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Product WHERE Quantity <1", conn.getConnection());
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public bool updateProduct(String id,String itemname, String itemcode, String cat, String brand, String purchase, String sell, String qty)
        {
            SQLiteCommand command = new SQLiteCommand();
            String updateQuery = "UPDATE Product SET ItemName=@nm,ItemCode=@code,ItemCategory=@cat,ItemBrand=@bnd,PPrice=@pp,SPrice=@sp,Quantity=@qt WHERE Id=@id";

            command.CommandText = updateQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@cat", cat);
            command.Parameters.AddWithValue("@code", itemcode);
            command.Parameters.AddWithValue("@bnd", brand);
            command.Parameters.AddWithValue("@qt", qty);
            command.Parameters.AddWithValue("@nm", itemname);
            command.Parameters.AddWithValue("@pp", purchase);
            command.Parameters.AddWithValue("@sp", sell);
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
        public bool deleteProduct(string id)
        {
            SQLiteCommand command = new SQLiteCommand();
            String deleteQuery = "DELETE FROM Product WHERE Id = @id ";

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
        //insert product Category
        public bool InsertProdCategory(String cat,String brand)
        {
            SQLiteCommand command = new SQLiteCommand();
            String insertQuery = "INSERT INTO ProductCat(Category,Brand) Values(@cat,@bnd)";

            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@cat", cat); 
            command.Parameters.AddWithValue("@bnd", brand); 
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
        //GEt Product Category
        public void getProductCat(ComboBox box)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT Distinct Id,Category FROM ProductCat Group By Category", conn.getConnection());
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();
            // command.Parameters.AddWithValue("@sid", sid);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            box.DisplayMember = "Category";
            box.ValueMember = "Id";
            box.DataSource = table;

        }
        //Get Brand Name
        public void getProductBrand(ComboBox box,String cat)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT Distinct Id,Brand FROM ProductCat WHERE Category=@cat Group By Brand", conn.getConnection());
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();
             command.Parameters.AddWithValue("@cat", cat);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            box.DisplayMember = "Brand";
            box.ValueMember = "Id";
            box.DataSource = table;

        }
    }
}
