using BillingSoft.DbCode;
using BillingSoft.Expenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.Products
{
    public partial class ActionPanel : Form
    {
        expenseClass expense = new expenseClass();
        public ActionPanel()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Action_Load(object sender, EventArgs e)
        {
            textBoxexpense.Text = DailyExpense.expenseName;
            textBoxprice.Text = DailyExpense.price;
            labelid.Text = DailyExpense.Id;
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            if (isEmpty(this))
            {
                MessageBox.Show("Please Fill All the field..", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isUpdate = expense.updateProduct(textBoxexpense.Text,textBoxprice.Text,labelid.Text);
                if (isUpdate)
                {
                    MessageBox.Show("Successfully Updated...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField(this);
                    labelid.Text = "";
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Updation Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isEmpty(this))
            {
                MessageBox.Show("Please Fill All the field..", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isDelete = expense.deleteProduct(labelid.Text);
                if (isDelete)
                {
                    MessageBox.Show("Successfully Deleted...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField(this);
                    labelid.Text = "";
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Deletion Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
        private bool isEmpty(Form form)
        {
            bool empty = false;
            foreach (Control c in form.Controls)
            {
                if (c is TextBox)
                {
                    empty = true;
                }
                else
                {
                    empty = false;
                }
            }
            return empty;
        }
        private void ClearField(Form form)
        {
            foreach (Control c in form.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

            }
        }

        private void Validate_price(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
