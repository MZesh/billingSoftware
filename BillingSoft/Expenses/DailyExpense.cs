using BillingSoft.DbCode;
using BillingSoft.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.Expenses
{
    public partial class DailyExpense : Form
    {
        expenseClass expense = new expenseClass();
        public static string expenseName = "";
        public static string price = "";
        public static string Id = "";
        public DailyExpense()
        {
            InitializeComponent();
        }
        private void DailyExpense_Load(object sender, EventArgs e)
        {
            expense.getExpenseCategory(comboBoxcategory);
          
            dataGridViewExpenseview.DataSource = expense.getAllExpense();
            getTotalPrice();
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.DataPropertyName = "Action";
            column.Name = "Action";
            column.UseColumnTextForButtonValue = true;
            column.Text = "More Action";
            dataGridViewExpenseview.Columns.Add(column);
        }
        private void Add_Expense_Category(object sender, EventArgs e)
        {
            if (textBoxExpenseCat.Text.Equals(""))
            {
                MessageBox.Show("Fill The Expense Category...","Empty Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                bool isInsert = expense.inserIntoExpenseCategory(textBoxExpenseCat.Text);
                if (isInsert)
                {
                    expense.getExpenseCategory(comboBoxcategory);
                    textBoxExpenseCat.Text = "";
                }
                else
                {
                    MessageBox.Show("Cannot Insert Expense Category...", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Add_Daily_Expenses(object sender, EventArgs e)
        {
            bool empty = isEmpty(groupBox2);
            if (empty)
            {
                MessageBox.Show("Fill The Expense Category...", "Empty Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isInsert = expense.inserIntoExpense(comboBoxcategory.Text,textBoxname.Text,textBoxprice.Text,richTextBoxdetail.Text,DateTime.Now.ToShortDateString());
                if (isInsert)
                {
                    MessageBox.Show("Expense Inserted Successfully...", "Insertion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewExpenseview.DataSource = expense.getAllExpense();
                    ClearItems(groupBox2);
                    getTotalPrice();
                }
                else
                {
                    MessageBox.Show("Cannot Insert Expense ...", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool isEmpty(GroupBox box)
        {
            bool empty = false;
            foreach (Control c in box.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text.Equals(""))
                    {
                       empty=true;
                    }
                    else
                    {
                        empty = false;
                    }
                }
            }
            return empty;
        }
        private void ClearItems(GroupBox box)
        {
            foreach (Control c in box.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }
            }
        }

        private void textBoxprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void getTotalPrice()
        {
            long totalprice = 0;
            try
            {
                for (int i = 0; i < dataGridViewExpenseview.Rows.Count; i++)
                {
                    totalprice += long.Parse(dataGridViewExpenseview.Rows[i].Cells[3].Value.ToString());
                }
            }
            catch(Exception ex) { }
         
            labeltotalexp.Text = totalprice.ToString();
        }

        private void Search_Expense(object sender, EventArgs e)
        {
           // String search = Regex.Replace(textBoxsearchbyname.Text, " ", "");
            DataTable dt = new DataTable();
            dt = expense.getAllExpense();
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("Name like '%{0}%'", textBoxsearchbyname.Text);
            dataGridViewExpenseview.DataSource = DV;
            getTotalPrice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewExpenseview.DataSource = expense.getAllExpensebyDate(dateTimePickerfrom.Value.ToShortDateString(),dateTimePickerTo.Value.ToShortDateString());
        }

        private void Take_Action(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewExpenseview.Columns["Action"].Index && e.RowIndex >= 0)
            {
                Id = dataGridViewExpenseview.CurrentRow.Cells[1].Value.ToString();
                expenseName = dataGridViewExpenseview.CurrentRow.Cells[2].Value.ToString();
                price = dataGridViewExpenseview.CurrentRow.Cells[4].Value.ToString();
                new ActionPanel().ShowDialog();
                dataGridViewExpenseview.DataSource = expense.getAllExpense();
            }
        }
    }
}
