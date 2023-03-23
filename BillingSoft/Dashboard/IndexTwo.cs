using BillingSoft.Authentication;
using BillingSoft.BusinessAnalysis;
using BillingSoft.Creditors;
using BillingSoft.DailyReport;
using BillingSoft.DbCode;
using BillingSoft.Invoices;
using BillingSoft.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BillingSoft.Dashboard
{
    public partial class IndexTwo : Form
    {
        countClass count = new countClass();
        productClass pc = new productClass();
        ChartClass chartClass = new ChartClass();
        public IndexTwo()
        {
            InitializeComponent();
        }
        private void IndexTwo_Load(object sender, EventArgs e)
        {
            dataGridViewoutofstock.DataSource = pc.getAllOutStockProducts();
            FillChart();
            ShowLabel();
        }
        private void ShowLabel()
        {
            if (dataGridViewoutofstock.Rows.Count > 0)
            {
                paneloutofstock.Visible = true;
                timer_blink.Start();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            new DailySellReport().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new UnprintInvoice().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new DailyCredit().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Business().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit();
            credit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideForm(this);
            new Auth().Show();
        }

        private void HideForm(Form frm)
        {
            frm.Parent.Parent.Hide();
        }

        private void creditorReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewCreditorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void makePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void makePaymentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new PaymentCreditors().Show();
        }

        private void addNewCreditorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new NewCreditor().Show();
        }

        private void creditorReportToolStripMenuItem_Click_1(object sender, EventArgs e)
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
           // long totalprod = long.Parse(labeltotalproduct.Text);
            
        }

        private void timer_blink_Tick(object sender, EventArgs e)
        {
            if (paneloutofstock.Visible == true)
            {
                paneloutofstock.Visible = false;

            }
            else if (paneloutofstock.Visible == false)
            {
                paneloutofstock.Visible = true;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new OutOfStock().Show();
        }

        private void Stop_Blink(object sender, EventArgs e)
        {
            timer_blink.Stop();
        }

        private void Start_Blink(object sender, EventArgs e)
        {
            timer_blink.Start();
        }
    }
}
