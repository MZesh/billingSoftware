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
using static BillingSoft.Products.ViewProducts;

namespace BillingSoft.Products
{
    public partial class EditUpdate : Form
    {

        productClass pc = new productClass();
        public EditUpdate()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditUpdate_Load(object sender, EventArgs e)
        {
            textBoxcode.Text = ViewProducts.code;
            textBoxpname.Text = ViewProducts.items;
            textBoxpprice.Text = ViewProducts.pprice;
            textBoxsellprice.Text = ViewProducts.sprice;
            textBoxqty.Text = ViewProducts.qty;
            labelid.Text = ViewProducts.Id;
            textBoxcat.Text = ViewProducts.cat;
            textBoxbnd.Text = ViewProducts.bnd;
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            if (isEmpty(this))
            {
                MessageBox.Show("Please Fill All the field..", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isUpdate = pc.updateProduct(labelid.Text, textBoxpname.Text, textBoxcode.Text, textBoxcat.Text, textBoxbnd.Text, textBoxpprice.Text, textBoxsellprice.Text, textBoxqty.Text);
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
                bool isDelete = pc.deleteProduct(labelid.Text);
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
            foreach(Control c in form.Controls)
            {
                if(c is TextBox)
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

        private void Price_Purchase_Validate(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Sell_Price_Validate(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Qty_VAlidate(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
