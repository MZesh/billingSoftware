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

namespace BillingSoft.Creditors
{
    public partial class DailyCredit : Form
    {
        sellingProduct selling = new sellingProduct();
        ReportDataSource ds = new ReportDataSource();
        public DailyCredit()
        {
            InitializeComponent();
        }

        private void DailyCredit_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = selling.getAllSellCreditors(DateTime.Now.ToShortDateString());
            TotalPrice();
            EnableDisableButton();
        }
        private void EnableDisableButton()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }
        private void TotalPrice()
        {
            long totalprice = 0;
            long remain = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                totalprice += long.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                remain += long.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
            }
            labelprice.Text = totalprice.ToString();
             
        }

        private void Search_Using_Invoice(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = selling.getAllSellCreditors(DateTime.Now.ToShortDateString());
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("InvoiceNo like '%{0}%'", textBoxsearchbyinv.Text);
            dataGridView1.DataSource = DV;
            TotalPrice();
        }

        private void Search_using_Customer(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = selling.getAllSellCreditors(DateTime.Now.ToShortDateString());
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("Customer like '%{0}%'", textBoxsearchbycus.Text);
            dataGridView1.DataSource = DV;
            TotalPrice();
        }
        private long TotalAmount()
        {
            long total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += long.Parse(dataGridView1.Rows[i].Cells[11].Value.ToString());
            }
            return total;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ReportGenerate();
        }
        private void ReportGenerate()
        {

            List<InvoicePos> data = new List<InvoicePos>();
            data.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                InvoicePos invoiceBill = new InvoicePos
                {
                    Date = row.Cells[12].Value.ToString(),
                    itemname = row.Cells[0].Value.ToString(),
                    itemcode = row.Cells[1].Value.ToString(),
                    cusName = row.Cells[6].Value.ToString(),
                    itemqty = row.Cells[5].Value.ToString(),
                    price = row.Cells[4].Value.ToString(),
                    remain = row.Cells[9].Value.ToString(),
                    invoiceNo = row.Cells[10].Value.ToString(),
                    totalprice = TotalAmount().ToString(),
                    discount = "Daily Creditor report",
                };
                data.Add(invoiceBill);
            }
            ds.Name = "DataSet1";
            ds.Value = data;
            InvoiceCredit invoice = new InvoiceCredit();
            invoice.reportViewer1.LocalReport.DataSources.Clear();
            invoice.reportViewer1.LocalReport.DataSources.Add(ds);
            invoice.reportViewer1.LocalReport.ReportEmbeddedResource = "BillingSoft.Reports.creditReport.rdlc";
            invoice.ShowDialog();
        }
    }
}
