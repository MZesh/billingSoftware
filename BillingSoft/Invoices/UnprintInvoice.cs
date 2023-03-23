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

namespace BillingSoft.Invoices
{
    public partial class UnprintInvoice : Form
    {
        sellingProduct selling = new sellingProduct();
        PrintSetting printSetting = new PrintSetting();
        ReportDataSource ds = new ReportDataSource();
        public UnprintInvoice()
        {
            InitializeComponent();
        }

        private void UnprintInvoice_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = selling.getAllUnprintInvoices();
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            GTotal();
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
        private void Search_Using_invoice(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = selling.getAllUnprintInvoices();
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("InvoiceNo like '%{0}%'", textBoxsearchbyinv.Text);
            dataGridView1.DataSource = DV;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            GTotal();
        }

        private void Search_using_cus(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = selling.getAllUnprintInvoices();
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("Customer like '%{0}%'", textBoxsearchbycus.Text);
            dataGridView1.DataSource = DV;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            GTotal();
        }
        private void GTotal()
        {
            long gtotal = 0;
            for(int i =0;i<dataGridView1.Rows.Count;i++)
            {
                gtotal += long.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }
            labeltotal.Text = gtotal.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                 selling.isPrint(row.Cells[10].Value.ToString()); 
            } 
            ReportGenerate();
            dataGridView1.DataSource = selling.getAllUnprintInvoices();
        }
        private void ReportGenerate()
        {
            String size = printSetting.getPrintingSizes();
            List<InvoicePos> data = new List<InvoicePos>();
            data.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                InvoicePos invoiceBill = new InvoicePos
                {
                    Date = row.Cells[12].Value.ToString(),
                    invoiceNo = row.Cells[10].Value.ToString(),
                    cusName = row.Cells[6].Value.ToString(),
                    paymentType = row.Cells[8].Value.ToString(),
                    remain = row.Cells[9].Value.ToString(),
                   amountpaid = row.Cells[13].Value.ToString(),
                    gtotal = labeltotal.Text,
                    price = row.Cells[4].Value.ToString(),
                    itemqty = row.Cells[5].Value.ToString(),
                    totalprice = row.Cells[11].Value.ToString(),
                     discount = row.Cells[14].Value.ToString(),
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
            }
            else if (size.Equals("A4 (210 x 297 mm)"))
            {
                InvoiceAfour invoiceAfour = new InvoiceAfour();
                invoiceAfour.reportViewerAfour.LocalReport.DataSources.Clear();
                invoiceAfour.reportViewerAfour.LocalReport.DataSources.Add(ds);
                invoiceAfour.reportViewerAfour.LocalReport.ReportEmbeddedResource = "BillingSoft.Reports.invoiceAfour.rdlc";
                invoiceAfour.ShowDialog();
            }


        }
    }
}
