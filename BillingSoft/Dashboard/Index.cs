using BillingSoft.Authentication;
using BillingSoft.BusinessAnalysis;
using BillingSoft.Creditors;
using BillingSoft.DailyReport;
using BillingSoft.DbCode;
using BillingSoft.Invoices;
using BillingSoft.Products;
using BillingSoft.SellForms;
using BillingSoft.Stock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BillingSoft.Dashboard
{
    public partial class Index : Form
    {
        countClass count = new countClass();
        ChartClass chartClass = new ChartClass();
        productClass pc = new productClass();
        public Index()
        {
            InitializeComponent();
        }
        private void Index_Load(object sender, EventArgs e)
        {
            //count.TotalProduct(labeltotalproduct);
            dataGridViewoutofstock.DataSource = pc.getAllOutStockProducts();
            dataGridViewtotalProduct.DataSource = count.GetAllItProduct();
            dataGridViewtotalsell.DataSource = count.GetAllSelltProduct(DateTime.Now.ToShortDateString());
            dataGridViewunprint.DataSource = count.GetAllUnpaidInvoices();
            int counts = dataGridViewtotalProduct.Rows.Count;
            int sellcount = dataGridViewtotalsell.Rows.Count;
            int unprint = dataGridViewunprint.Rows.Count;
            labeltotalproduct.Text = counts.ToString();
            labeltotalsellitems.Text = sellcount.ToString();
            labeltotalinvoices.Text = unprint.ToString();
            FillChart();

            if(Auth.userName.Equals("Administrator"))
            {
                panel8.Enabled = true;
                panel2.Enabled = true;
            }
            else
            {
                panel8.Enabled = false;
                panel2.Enabled = false;
            }
            ShowLabel();
        }
        private void ShowLabel()
        {
            if(dataGridViewoutofstock.Rows.Count >0)
            {
                paneloutofstock.Visible = true;
                timer_blink.Start();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit();
            credit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DailyCredit().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UnprintInvoice().Show();
        }

        private void buttonhelp_Click(object sender, EventArgs e)
        {
            new DailySellReport().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Business().Show();
        }

        private void makePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PaymentCreditors().Show();
        }

        private void addNewCreditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewCreditor().Show();
        }

        private void creditorReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewAndPrint().Show();
        }
        private void FillChart()
        {
            //chartClass.GetAllSelItProduct(chart1);
            chart1.DataSource = chartClass.GetAllSelItProductCount(); 
            chart1.Series["Sales"].XValueMember = "Date";
            chart1.Series["Sales"].XValueType = ChartValueType.Date;
            chart1.Series["Sales"].YValueMembers = "Sale";
            chart1.Series["Sales"].IsValueShownAsLabel = true;
            chart1.Series["Sales"].YValueType = ChartValueType.Int32;
            chart1.Titles.Add("Sales");
            long totalprod = long.Parse(labeltotalproduct.Text);
            if(totalprod>0)
            {
                chart2.Visible = true;
            }
            else
            {
                chart2.Visible = false;
            }
            //Chart 2 
            chart2.Series["TotalProduct"].Points.AddXY("Total Product", labeltotalproduct.Text);
            
            chart2.Series["DailySell"].Points.AddXY("Daily Sells", labeltotalsellitems.Text);
         //   chart1.Series["DailySell"].IsValueShownAsLabel = true;
            chart2.Series["UnprintInvoices"].Points.AddXY("Unprint Invoices", labeltotalinvoices.Text);
           // chart1.Series["UnprintInvoices"].IsValueShownAsLabel = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Parent.Parent.Name);
            HideForm(this);
            new Auth().Show();
        }

        private void HideForm(Form frm)
        {
            frm.Parent.Parent.Hide();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelfill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new OutOfStock().Show();
        }

        private void timer_blink_Tick(object sender, EventArgs e)
        {
            if(paneloutofstock.Visible == true)
            {
                paneloutofstock.Visible = false;
                
            }else if(paneloutofstock.Visible == false)
            {
                paneloutofstock.Visible = true;
                
            }
        }

        private void Stop_Blinking(object sender, EventArgs e)
        {
            timer_blink.Stop();
        }

        private void Start_Blink(object sender, EventArgs e)
        {
            timer_blink.Start();
        }
    }
}
