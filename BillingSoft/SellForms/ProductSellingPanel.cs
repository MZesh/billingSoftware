using BillingSoft.CreateBitmap;
using BillingSoft.DbCode;
using BillingSoft.ReportClass;
using BillingSoft.Reports;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.SellForms
{
    public partial class ProductSellingPanel : Form
    {
        ReportDataSource ds = new ReportDataSource();
        DataTable table = new DataTable();
        sellingProduct sp = new sellingProduct();
        PrintSetting printSetting = new PrintSetting(); 
        long oldInvoice = 0;
        public ProductSellingPanel()
        {
            InitializeComponent();
        }

        private void Validate(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void priceValidation(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void QtyValidation(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void contactvalidation(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void FillTheBoxes(object sender, EventArgs e)
        {
            String id = comboBoxitemname.SelectedValue.ToString();
            sp.PopulateBoxes(id,textBoxItemCode,textBoxitemcat,textBoxitemprice,labelpprice);
        }

        private void ProductSellingPanel_Load(object sender, EventArgs e)
        {
           AddColumnToGridView();
            //sp.getProductName(comboBoxitemname);
            // comboBoxitemname.Items.Insert(0, "--Select--");
           
        }
        //add column t0 GridView
        private void AddColumnToGridView()
        {
            table.Columns.Add("Item Name");
            table.Columns.Add("Item Code");
            table.Columns.Add("Item Category");
            table.Columns.Add("Purchase Price");
            table.Columns.Add("Price");
            table.Columns.Add("Quantity");
            table.Columns.Add("Customer Name");
            table.Columns.Add("Customer Contact");
            table.Columns.Add("Total Price"); 
            table.Columns.Add("Remove"); 
            dataGridView1.DataSource = table;
            dataGridView1.Columns[3].Visible = false;
            
            
           
        }

        private void AddItemToTable(object sender, EventArgs e)
        {
            
            if (isEmpty())
            {
                MessageBox.Show("Items Properties i.e(Name, Code,Price,Quantity) are required...", "Fill Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long qty = long.Parse(textBoxitemqty.Text);
                long price = long.Parse(textBoxitemprice.Text);
                long total = qty * price;
                long checkqty = sp.AvailableQuantity(comboBoxitemname.SelectedValue.ToString());
               
                if (qty > checkqty)
                {
                    MessageBox.Show("Quantity for sell is greater than Quantity in Stock...", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    table.Rows.Add(comboBoxitemname.Text, textBoxItemCode.Text, textBoxitemcat.Text, labelpprice.Text, textBoxitemprice.Text, textBoxitemqty.Text, textBoxcusname.Text, textBoxcusno.Text, total.ToString(),"Remove");
                    dataGridView1.Columns["Remove"].DefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.Columns["Remove"].DefaultCellStyle.BackColor = Color.OrangeRed;
                    buttoncnfirmsell.Enabled = true;
                    calculateItemPaidPrice();
                }
            }
           
           
        }

        private void calculateItemPaidPrice()
        {
            long totalPrice = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                 totalPrice += long.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
            }
            labeltotal.Text = totalPrice.ToString();
            labelgTotal.Text = totalPrice.ToString();
        }

        private void Check_DiscountPrice(object sender, EventArgs e)
        {
            if(textBoxdiscount.Text != "")
            {
                long discountPrice = long.Parse(textBoxdiscount.Text);
                long totalPrice = long.Parse(labelgTotal.Text);
                long priceAfterDisc = 0;
                if(discountPrice > totalPrice)
                {
                    MessageBox.Show("Discount Price Cannot greater than total price...","Discount Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    priceAfterDisc = totalPrice - discountPrice;
                    labelgTotal.Text = priceAfterDisc.ToString();
                }

            }
             
        }

        private void PaidMethod(object sender, EventArgs e)
        {
            if (comboBoxcredit.Text.Equals("CREDIT"))
            {
                labelremain.Text = labelgTotal.Text;
                textBoxpaidAmount.Text = "0";
            }
            else if(comboBoxcredit.Text.Equals("CASH"))
            {
                textBoxpaidAmount.Text = labelgTotal.Text;
                labelremain.Text = "0";
            }
        }

        private void Amount_Paid(object sender, EventArgs e)
        {
            if (textBoxpaidAmount.Text.Equals(""))
            {
                textBoxpaidAmount.Text = "0";
                labelremain.Text = "0";
            }else if (textBoxpaidAmount.Text.Equals("0")) 
            {
                labelremain.Text = "0";
            }
            else
            {
                long totalPrice = long.Parse(labelgTotal.Text);
                long paidAmount = long.Parse(textBoxpaidAmount.Text);
                long remain = totalPrice - paidAmount;
                labelremain.Text = remain.ToString();

            }
        }

        private void Searchby_ItemCode(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
               sp.SearchByItemCode(textBoxItemCode.Text,comboBoxitemname,textBoxitemcat,textBoxitemprice,labelpprice);
                 
            }
        }

        private void ChangeValue(object sender, EventArgs e)
        {
            textBoxpaidAmount.Text = labelgTotal.Text;
        }
        private bool isEmpty()
        {
            if(comboBoxitemname.Text.Equals("") || textBoxItemCode.Text.Equals("") || textBoxitemprice.Text.Equals("") || textBoxitemqty.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Fill_the_Value(object sender, EventArgs e)
        {
            sp.getProductName(comboBoxitemname);
        }

        //insert into history,credit,generate invoice etc
        private bool isInsertIntoProductHistory()
        {
            bool isInsert = false;
            long invoiceNo = sp.getInvoiceNo();
            for (int i=0; i < dataGridView1.Rows.Count;i++)
            {
                long qty = long.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                long remainQty = sp.GetQuantityProducts(dataGridView1.Rows[i].Cells[1].Value.ToString(), qty);
                isInsert = sp.productHistory(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString(), dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[i].Cells[5].Value.ToString(), dataGridView1.Rows[i].Cells[6].Value.ToString(), dataGridView1.Rows[i].Cells[7].Value.ToString(),comboBoxcredit.Text,textBoxpaidAmount.Text,labelremain.Text,textBoxdiscount.Text,dataGridView1.Rows[i].Cells[8].Value.ToString(),invoiceNo.ToString(),"No",DateTime.Now.ToShortDateString());
                if (isInsert)
                {
                    sp.updateProductQuantity(dataGridView1.Rows[i].Cells[1].Value.ToString(), remainQty.ToString());
                }
                 
            }
            oldInvoice = invoiceNo;
            invoiceNo += 1;
            sp.updateInvoiceNo(invoiceNo.ToString());
            return isInsert;
               
        }

        private void SellProduct(object sender, EventArgs e)
        {
          
            DialogResult dr = MessageBox.Show("Are you sure to sell Items?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                isInsertIntoProductHistory();
              
                DialogResult genbill = MessageBox.Show("Do You Want to Generate The Invoice Receipt?", "Confirmation", MessageBoxButtons.YesNo);
                if (genbill == DialogResult.Yes)
                {
                    ReportGenerate();
                    sp.updateBillStatus(oldInvoice.ToString());
                }
                else { }

                  
            table.Clear();
            dataGridView1.Refresh();
            ClearItems(groupBox2);
            ClearItems(groupBox3);
            ClearField();
                textBoxitemqty.Text = "1";   
              
            }
                
        }
        private void ClearItems(GroupBox box)
        {
            foreach(Control c in box.Controls)
            {
                if(c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }
            }
        }
        private void ClearField()
        {
            foreach (Control c in panel2.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }
            }
            labeltotal.Text = "0";
            labelremain.Text = "0";
            labelgTotal.Text = "0";
            comboBoxcredit.Text = "CASH";
        }
        //REport
        private void ReportGenerate()
        {
            String size = printSetting.getPrintingSizes();
          
            List<InvoicePos> data = new List<InvoicePos>();
            data.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                InvoicePos invoiceBill = new InvoicePos
                {
                    Date = DateTime.Now.ToShortDateString(),
                    invoiceNo = sp.getInvoiceNo().ToString(),
                    cusName = row.Cells[6].Value.ToString(),
                    paymentType = comboBoxcredit.Text,
                    remain = labelremain.Text,
                    amountpaid = textBoxpaidAmount.Text,
                    gtotal = labelgTotal.Text,
                    price = row.Cells[4].Value.ToString(),
                    itemqty = row.Cells[5].Value.ToString(),
                    totalprice = row.Cells[8].Value.ToString(),
                    discount = textBoxdiscount.Text,
                    itemname = row.Cells[0].Value.ToString(),
                    itemcode = row.Cells[1].Value.ToString(),
                    
                };
                data.Add(invoiceBill);
            }
                ds.Name = "DataSet1";
                ds.Value = data;
                if (size.Equals("POS (80mm x 80 mm)"))
                {
                    InvoicePOS invoicepos = new InvoicePOS();
                    invoicepos.reportViewer1.LocalReport.DataSources.Clear();
                    invoicepos.reportViewer1.LocalReport.DataSources.Add(ds);
                    invoicepos.reportViewer1.LocalReport.ReportEmbeddedResource = "BillingSoft.Reports.invoicePOS.rdlc";
                    invoicepos.ShowDialog();
                } else if (size.Equals("A4 (210 x 297 mm)")) 
                {
                    InvoiceAfour invoiceAfour = new InvoiceAfour();
                    invoiceAfour.reportViewerAfour.LocalReport.DataSources.Clear();
                    invoiceAfour.reportViewerAfour.LocalReport.DataSources.Add(ds);
                    invoiceAfour.reportViewerAfour.LocalReport.ReportEmbeddedResource = "BillingSoft.Reports.invoiceAfour.rdlc";
                    invoiceAfour.ShowDialog();
                }

           
        }

        

        private void Action(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Remove"].Index && e.RowIndex >= 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to Remove items ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                { 
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    calculateItemPaidPrice();
                }
              
            }
        }

        
    }
}
