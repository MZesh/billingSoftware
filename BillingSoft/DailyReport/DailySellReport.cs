using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using BillingSoft.DbCode;
using BillingSoft.ReportClass;
using BillingSoft.Reports;
using Microsoft.Reporting.WinForms;

namespace BillingSoft.DailyReport
{
    public partial class DailySellReport : Form
    {
        dailySellClass dailySell = new dailySellClass();
        ReportDataSource ds = new ReportDataSource();
        public DailySellReport()
        {
            InitializeComponent();
        }

        private void DailySellReport_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dailySell.getDailyReport(DateTime.Now.ToShortDateString());
            getTotal();
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
        private void getTotal()
        {
            long totalprice = 0;
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                totalprice += long.Parse(dataGridView1.Rows[i].Cells[11].Value.ToString());
            }
            labeltotal.Text = totalprice.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportGenerate();
        }
        //REport
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
                    totalprice = labeltotal.Text,
                    discount = "DailySell Report",
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
