using BillingSoft.DbCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.Creditors
{
    public partial class NewCreditor : Form
    {
        CreditorPayment creditorPayment = new CreditorPayment();
        public NewCreditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool empty = isEmpty(groupBox3);
            if(empty)
            {
                MessageBox.Show("Fill The form...", "Fill Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isInsert = creditorPayment.insertCreditorDetail(textBoxcrdnm.Text,textBoxamount.Text,textBoxpaidAmount.Text,textBoxremaining.Text,textBoxinvoice.Text,DateTime.Now.ToShortDateString());
                if(isInsert)
                {
                    MessageBox.Show("Payment Done Successfull...", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields(groupBox3);
                }
                else
                {
                    MessageBox.Show("Error Occur in Insertion...", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearFields(GroupBox box)
        {
            foreach (Control c in box.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
        private bool isEmpty(GroupBox box)
        {
            bool empty = false;
            foreach(Control c in box.Controls)
            {
                if(c is TextBox)
                {
                    if(c.Text.Equals(""))
                    {
                        empty = true;
                    }
                    else
                    {
                        empty = false;
                    }
                }
            }
            return empty;
        }

        private void Validate_Amount(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Validate_PaidAmount(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Validate_contact(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Check_remain(object sender, EventArgs e)
        {
            long paidAmount = long.Parse(textBoxpaidAmount.Text);
            long totalAmount = long.Parse(textBoxamount.Text);
            if (paidAmount > totalAmount)
            {
                MessageBox.Show("Paid Amount Cannot Greater Than Total Amount...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long remain = totalAmount - paidAmount;
                textBoxremaining.Text = remain.ToString();
            }

        }
    }
}
