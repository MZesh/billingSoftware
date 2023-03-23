using BillingSoft.DbCode;
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

namespace BillingSoft.Products
{
    public partial class AddProduct : Form
    {
        productClass pc = new productClass();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void purchasePriceValidation(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SellPriceValidation(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void qtyValidation(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            bool isEmpty = checkEmpty();
            if (isEmpty)
            {
                MessageBox.Show("Please Fill All the field...", "Required",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int qty = Int32.Parse(textBoxqty.Text);
                int sprice = Int32.Parse(textBoxsellprice.Text);
                int pprice = Int32.Parse(textBoxpprice.Text);
                int total = qty * sprice;

                bool isInsert = pc.InsertProduct(textBoxpname.Text, textBoxcode.Text, comboBoxpcat.Text, comboBoxbrandname.Text, textBoxpprice.Text, textBoxsellprice.Text, textBoxqty.Text, total.ToString(), DateTime.Now.ToShortDateString());
                if (isInsert)
                {
                    MessageBox.Show("Successfully Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField();
                    labelid.Text = "";
                }
                else
                {
                    MessageBox.Show(" Insertion Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        bool checkEmpty()
        {
            if (textBoxpname.Text.Trim().Equals("") || textBoxcode.Text.Equals("") || textBoxpprice.Text.Equals("") || textBoxsellprice.Text.Equals("")|| textBoxqty.Text.Equals("")|| comboBoxbrandname.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ClearField()
        {
            foreach (Control c in panelbox.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }
            }
            labelid.Text = "";
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            bool isEmpty = checkEmpty();
            if (isEmpty)
            {
                MessageBox.Show("Please Fill All the field..", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isUpdate = pc.updateProduct(labelid.Text, textBoxpname.Text, textBoxcode.Text, comboBoxpcat.Text, comboBoxbrandname.Text, textBoxpprice.Text, textBoxsellprice.Text, textBoxqty.Text);
                if (isUpdate)
                {
                    MessageBox.Show("Successfully Updated...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField();
                    labelid.Text = "";
                }
                else
                {
                    MessageBox.Show(" Updation Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // dataGridViewproducts.DataSource = pc.getAllProducts();
            pc.getProductCat(comboBoxpcat);
            pc.getProductBrand(comboBoxbrandname,comboBoxpcat.Text);
        }

        private void SearchItemByName(object sender, EventArgs e)
        {
           // String search = Regex.Replace(textBoxsearchname.Text, " ", "");
            DataTable dt = new DataTable();
            dt = pc.getAllProducts();
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("ItemName like '%{0}%'", textBoxsearchname.Text);
            dataGridViewproducts.DataSource = DV;
            dataGridViewproducts.Columns[8].Visible = false;
        }

        private void Edit_Data(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                labelid.Text = dataGridViewproducts.CurrentRow.Cells[0].Value.ToString();
                textBoxpname.Text = dataGridViewproducts.CurrentRow.Cells[1].Value.ToString();
                textBoxcode.Text = dataGridViewproducts.CurrentRow.Cells[2].Value.ToString();
                comboBoxpcat.Text = dataGridViewproducts.CurrentRow.Cells[3].Value.ToString();
                comboBoxbrandname.Text = dataGridViewproducts.CurrentRow.Cells[4].Value.ToString();
                textBoxpprice.Text = dataGridViewproducts.CurrentRow.Cells[5].Value.ToString();
                textBoxsellprice.Text = dataGridViewproducts.CurrentRow.Cells[6].Value.ToString();
                textBoxqty.Text = dataGridViewproducts.CurrentRow.Cells[7].Value.ToString();
            }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isEmpty = checkEmpty();
            if (isEmpty)
            {
                MessageBox.Show("Please Fill All the field..", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isUpdate = pc.deleteProduct(labelid.Text);
                DialogResult dr = MessageBox.Show("Are you sure to Delete the Product?", "Confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (isUpdate)
                    {
                        MessageBox.Show("Deleted Updated...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearField();
                    }
                    else
                    {
                        MessageBox.Show(" Deletion Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               

            }
        }

        private void buttonaddcat_Click(object sender, EventArgs e)
        {
            if(textBoxitemcat.Text.Equals("") || textBoxitembrandname.Text.Equals(""))
            {
                MessageBox.Show("Please Fill All the field..", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isInsertCat = pc.InsertProdCategory(textBoxitemcat.Text,textBoxitembrandname.Text);
                if(isInsertCat)
                {
                    MessageBox.Show("Successfully Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxitemcat.Text = "";
                    textBoxitembrandname.Text = "";
                    pc.getProductCat(comboBoxpcat);
                }
                else
                {
                    MessageBox.Show(" Insertion Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Change_Brand(object sender, EventArgs e)
        {
            pc.getProductBrand(comboBoxbrandname, comboBoxpcat.Text);
        }
    }
}
