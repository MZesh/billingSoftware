using BillingSoft.DbCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.BusinessAnalysis
{
    public partial class Business : Form
    {
        BusinessClass business = new BusinessClass();
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        PrintDocument printDocument = new PrintDocument();
        public Business()
        {
            InitializeComponent();
        }

        private void Business_Load(object sender, EventArgs e)
        {
            dataGridViewsell.DataSource = business.GetAllSelItProduct();
            dataGridViewexpense.DataSource = business.GetAllExpenses();
            labelpprice.Text = GetPurchasePrice().ToString();
            labelsellprice.Text = GetSellPrice().ToString();
            labelExpenses.Text = GetExpensePrice().ToString();
            long pandsdiff = GetSellPrice()-GetPurchasePrice();
            labelprofitloss.Text = pandsdiff.ToString();
            long netprofit = pandsdiff - GetExpensePrice();
            labelnetProfit.Text = netprofit.ToString();
        }
        private long GetPurchasePrice()
        {
            long purchase = 0;
            try
            {
                for (int i = 0; i < dataGridViewsell.Rows.Count; i++)
                {
                    purchase += long.Parse(dataGridViewsell.Rows[i].Cells[2].Value.ToString());
                }
            }
            catch (Exception ex) {
               // MessageBox.Show("");
            }
           
            return purchase;
        }
        private long GetSellPrice()
        {
            long sell = 0;
            try {
                for (int i = 0; i < dataGridViewsell.Rows.Count; i++)
                {
                    sell += long.Parse(dataGridViewsell.Rows[i].Cells[3].Value.ToString());
                }
            } catch (Exception ex) { }
            
            return sell;
        }
        private long GetExpensePrice()
        {
            long expense = 0;
            try
            {
                for (int i = 0; i < dataGridViewexpense.Rows.Count; i++)
                {
                    expense += long.Parse(dataGridViewexpense.Rows[i].Cells[2].Value.ToString());
                }
            }
            catch (Exception ex)
            {

            }
               
            
         
            return expense;
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            dataGridViewsell.DataSource = business.GetAllSelItProduct(dateTimePickerfrm.Value.ToShortDateString(),dateTimePickerto.Value.ToShortDateString());
            dataGridViewexpense.DataSource = business.GetAllExpenses(dateTimePickerfrm.Value.ToShortDateString(),dateTimePickerto.Value.ToShortDateString());
            labelsellprice.Text = GetSellPrice().ToString();
            labelpprice.Text = GetPurchasePrice().ToString();
            labelExpenses.Text = GetExpensePrice().ToString();

            long pandsdiff = GetSellPrice() - GetPurchasePrice();
            labelprofitloss.Text = pandsdiff.ToString();
            long netprofit = pandsdiff - GetExpensePrice();
            labelnetProfit.Text = netprofit.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print(panel1);
        }
        private void Print(Panel panel)
        {
            PrinterSettings printerSettings = new PrinterSettings();
            panel1 = panel;
            getPrintArea(panel);
            printPreviewDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_Print);
            printPreviewDialog.ShowDialog();
            
            
        }
        public void printDocument_Print(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(bitmap, (pageArea.Width / 2) - (panel1.Width / 2), this.panel1.Location.Y);
        }
        Bitmap bitmap;
        public void getPrintArea(Panel pnl)
        {
            bitmap = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bitmap, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

    }
}
