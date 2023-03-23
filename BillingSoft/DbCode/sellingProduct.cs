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
    class sellingProduct
    {
        DbConnection conn = new DbConnection();
        public void getProductName(ComboBox box)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT Id,ItemName FROM Product", conn.getConnection());
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();
            // command.Parameters.AddWithValue("@sid", sid);
            adapter.SelectCommand = command;
            adapter.Fill(table); 
            box.DisplayMember = "ItemName";
            box.ValueMember = "Id";
            box.DataSource = table;

        }
        public void PopulateBoxes(String id,TextBox box1,TextBox box2,TextBox box3,Label label)
        {
            string query = "SELECT * FROM  Product where Id = @id";
            SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
            command.Parameters.AddWithValue("@id", id); 
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    box1.Text= reader["ItemCode"].ToString();
                    box2.Text = reader["ItemCategory"].ToString();
                    box3.Text = reader["SPrice"].ToString();
                    label.Text = reader["PPrice"].ToString();
                }


            }

        }

        //Deduct the quantity after sell
        public long GetQuantityProducts(string code, long remainQty)
        {
            long qty = 0;
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Product WHERE ItemCode=@code", conn.getConnection());
            command.Parameters.AddWithValue("@code", code);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    qty = long.Parse(reader["Quantity"].ToString());
                    remainQty = qty - remainQty;
                }


            }
            return remainQty;
        }
        //Checking Quantity Available
        public long AvailableQuantity(string id)
        {
            long availableQty = 0;
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Product WHERE Id=@id", conn.getConnection());
            command.Parameters.AddWithValue("@id", id);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    availableQty = long.Parse(reader["Quantity"].ToString());
                     
                }


            }
            return availableQty;
        }
        //Check qty using item code
        //Checking Quantity Available
        public long QuantityAvailable(string name)
        {
            long availableQty = 0;
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Product WHERE ItemName=@name", conn.getConnection());
            command.Parameters.AddWithValue("@name", name);
            conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    availableQty = long.Parse(reader["Quantity"].ToString());

                }


            }
            return availableQty;
        }
        //Search by Item Code
        private bool isItemCodeExistOrNot(String code)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT Count(*) FROM Product WHERE ItemCode=@code", conn.getConnection());


            command.Parameters.AddWithValue("@code", code);
            conn.OpenConnection();
            int exitst = Convert.ToInt32(command.ExecuteScalar());
            if (exitst > 0)
            {
                conn.CloseConnection();
               
                return true;
            }
            else
            {
                MessageBox.Show("Item Code Does Not Exists....", "Check Invoice", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }
        //If Item Code Exist Then Search
        public void SearchByItemCode(String code, ComboBox box1, TextBox box2, TextBox box3, Label label)
        {
            bool isCodeExist = isItemCodeExistOrNot(code);
            if (isCodeExist)
            {
                string query = "SELECT * FROM  Product where ItemCode = @icode";
                SQLiteCommand command = new SQLiteCommand(query, conn.getConnection());
                command.Parameters.AddWithValue("@icode", code);
                conn.OpenConnection();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {  
                        box2.Text = reader["ItemCategory"].ToString();
                        box3.Text = reader["SPrice"].ToString();
                        label.Text = reader["PPrice"].ToString();
                    }


                }
                getProductNamebyItemCode(box1,code);
            }
        }
        private void getProductNamebyItemCode(ComboBox box,String code)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT Id,ItemName FROM Product Where ItemCode=@code", conn.getConnection());
            command.Parameters.AddWithValue("@code", code);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();
            // command.Parameters.AddWithValue("@sid", sid);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            box.DisplayMember = "ItemName";
            box.ValueMember = "Id";
            box.DataSource = table;

        }
        //Get Invoice No
        public long getInvoiceNo()
        {
            long invoiceNo = 0; 
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Invoice", conn.getConnection());
             conn.OpenConnection();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    invoiceNo = long.Parse(reader["InvoiceNo"].ToString());

                }


            }
            return invoiceNo;

        }
        //Update Invoice No
        public void updateInvoiceNo(String invoice)
        { 
            SQLiteCommand command = new SQLiteCommand("UPDATE Invoice SET InvoiceNo=@invoice", conn.getConnection());
            command.Parameters.AddWithValue("@invoice",invoice);
            conn.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.CloseConnection(); 
            }
            else
            {
                conn.CloseConnection(); 
            }
        }
        //Insert into history
        public bool productHistory(String iname, String code, String cat, String pprice, String sprice, String qty, String cus, String cusno, String pay,String amountpay,String remain,String disc, String total,String invoice, String billgen,  String date)
        {

            SQLiteCommand command = new SQLiteCommand();
            String insertQuery = "INSERT INTO History (ItemName,ItemCode,Category,Purchase,Price,Quantity,Customer,Contact,Payment,AmountPaid,Remaining,Discount,Total,InvoiceNo,BillGen,Date)" +
                " Values(@nm, @code,@cat,@pprice,@sprice,@qt,@cus,@cno,@pay,@apay,@remain,@disc,@total,@inv,@bgen,@dt)";

            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@nm", iname);
            command.Parameters.AddWithValue("@code", code);
            command.Parameters.AddWithValue("@cat", cat);
            command.Parameters.AddWithValue("@pprice", pprice);
            command.Parameters.AddWithValue("@sprice", sprice);
            command.Parameters.AddWithValue("@qt", qty);
            command.Parameters.AddWithValue("@cus", cus);
            command.Parameters.AddWithValue("@cno", cusno);
            command.Parameters.AddWithValue("@pay", pay);
            command.Parameters.AddWithValue("@apay", amountpay);
            command.Parameters.AddWithValue("@remain", remain);
            command.Parameters.AddWithValue("@disc", disc);
            command.Parameters.AddWithValue("@total", total);
            command.Parameters.AddWithValue("@inv", invoice);
            command.Parameters.AddWithValue("@bgen", billgen);
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
        //Update Quantity
        public bool updateProductQuantity(String code,String qty)
        {
           // long quantity = GetQuantityProducts(code,long.Parse(qty));
            SQLiteCommand command = new SQLiteCommand("UPDATE Product SET Quantity=@qt WHERE ItemCode=@code", conn.getConnection());
            command.Parameters.AddWithValue("@code", code);
            command.Parameters.AddWithValue("@qt", qty);
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
        //Add Quantity
        public bool addProductQuantity(String name,String code, String qty)
        {
            // long quantity = GetQuantityProducts(code,long.Parse(qty));
            SQLiteCommand command = new SQLiteCommand("UPDATE Product SET Quantity=@qt WHERE ItemCode=@code AND ItemName=@nm", conn.getConnection());
            command.Parameters.AddWithValue("@code", code);
            command.Parameters.AddWithValue("@qt", qty);
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
        public bool updateBillStatus(String invoiceNo)
        {
            // long quantity = GetQuantityProducts(code,long.Parse(qty));
            SQLiteCommand command = new SQLiteCommand("UPDATE History SET BillGen='Yes' WHERE InvoiceNo=@inv", conn.getConnection());
            command.Parameters.AddWithValue("@inv", invoiceNo); 
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
        //Display All Selling History
        public DataTable getAllSellProduct()
        {
            SQLiteCommand command = new SQLiteCommand("SELECT ItemName as Item,ItemCode as Code,Category,Purchase,Price,Quantity as Qty,Customer,Contact,Payment as Type,Remaining as Remain,InvoiceNo,Date FROM History WHERE BillGen='Yes'  AND Payment='CASH' ", conn.getConnection());
            // command.Parameters.AddWithValue("@slm", saleman);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        //Display All selling Creditors
        public DataTable getAllSellCreditors(String date)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT ItemName as Item,ItemCode as Code,Category,Purchase,Price,Quantity as Qty,Customer,Contact,Payment as Type,Remaining as Remain,InvoiceNo,Total,Date FROM History WHERE Payment='CREDIT' AND Remaining > 0 AND Date=@dt", conn.getConnection());
            command.Parameters.AddWithValue("@dt", date);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        //Display All selling Creditors
        public DataTable getAllSellCreditors()
        {
            SQLiteCommand command = new SQLiteCommand("SELECT ItemName as Item,ItemCode as Code,Category,Purchase,Price,Quantity as Qty,Customer,Contact,Payment as Type,Remaining as Remain,InvoiceNo,Total,Date FROM History WHERE Payment='CREDIT' AND Remaining > 0", conn.getConnection());
           // command.Parameters.AddWithValue("@dt", date);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        //unprint invoices
        public DataTable getAllUnprintInvoices()
        {
            SQLiteCommand command = new SQLiteCommand("SELECT ItemName as Item,ItemCode as Code,Category,Purchase,Price,Quantity as Qty,Customer,Contact,Payment as Type,Remaining as Remain,InvoiceNo,Total,Date,AmountPaid,Discount FROM History WHERE BillGen='No' ", conn.getConnection());
            // command.Parameters.AddWithValue("@slm", saleman);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        //change print status
        public bool isPrint(String invoice)
        {
            SQLiteCommand command = new SQLiteCommand("UPDATE History SET BillGen='Yes' WHERE InvoiceNo=@invoice", conn.getConnection());
            command.Parameters.AddWithValue("@invoice", invoice);
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
        //Delete from History
        public bool deleteProduct(string inv,string item)
        {
            SQLiteCommand command = new SQLiteCommand();
            String deleteQuery = "DELETE FROM History WHERE InvoiceNo = @inv AND ItemName=@item ";

            command.CommandText = deleteQuery;
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@inv", inv);
            command.Parameters.AddWithValue("@item", item);
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
        //filter using date
        public DataTable FilterHistoryUsingDates(String dateTime, String dateTime1)
        {
            string query = "SELECT ItemName as Item,ItemCode as Code,Category,Purchase,Price,Quantity as Qty,Customer,Contact,Payment as Type,Remaining as Remain,InvoiceNo,Date FROM History WHERE BillGen='Yes'  AND Payment='CASH' AND Date BETWEEN '" + dateTime + "' AND '" + dateTime1 + "'";
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
