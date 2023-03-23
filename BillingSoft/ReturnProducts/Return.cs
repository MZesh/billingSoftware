using BillingSoft.DbCode;
using BillingSoft.SellForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.ReturnProducts
{
    public partial class Return : Form
    {
        sellingProduct selling = new sellingProduct();
        SellHistory history = new SellHistory();
        public Return()
        {
            InitializeComponent();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            if (isEmpty(this))
            {
                MessageBox.Show("Please Fill All the field..", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long availableQty = selling.QuantityAvailable(textBoxpname.Text);
                long returnQty = long.Parse(textBoxqty.Text);
                long updateQty = availableQty + returnQty;
                bool isAdd = selling.addProductQuantity(textBoxpname.Text,textBoxcode.Text,updateQty.ToString());
                if(isAdd)
                {
                    selling.deleteProduct(textBoxinv.Text,textBoxpname.Text);
                    MessageBox.Show("Product Return Successfully..", "Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Cannot return product..", "Return Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool isEmpty(Form frm)
        {
            bool empty = false;
            foreach(Control c in frm.Controls)
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
        private void ClearField()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
        private void Qty_Validate(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Price_Validate(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Return_Load(object sender, EventArgs e)
        {
            textBoxinv.Text = SellHistory.inv;
            textBoxpname.Text = SellHistory.item;
            textBoxcode.Text = SellHistory.code;
            textBoxqty.Text = SellHistory.qty;
            textBoxprc.Text = SellHistory.prce;
        }
    }
}
