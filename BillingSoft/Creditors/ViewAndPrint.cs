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
    public partial class ViewAndPrint : Form
    {
        ReportDataSource ds = new ReportDataSource();
        CreditorPayment creditorPayment = new CreditorPayment();
        public ViewAndPrint()
        {
            InitializeComponent();
        }

        private void ViewAndPrint_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1589, 754);
        }

        private void Search_By_Name(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                dataGridViewnew.DataSource = creditorPayment.GetAllCreditorReport(textBoxnewCreditor.Text);
                buttongen.Enabled = true;
            }

        }

        private void buttongen_Click(object sender, EventArgs e)
        {
            ReportGenerate();
        }
        //REport
        private void ReportGenerate()
        {
             
            List<InvoicePos> data = new List<InvoicePos>();
            data.Clear();
            foreach (DataGridViewRow row in dataGridViewnew.Rows)
            {
                InvoicePos invoiceBill = new InvoicePos
                {
                    Date = row.Cells[0].Value.ToString(),
                    cusName = row.Cells[1].Value.ToString(),
                    amountpaid = row.Cells[3].Value.ToString(),
                    remain = row.Cells[4].Value.ToString(),
                    totalprice = row.Cells[2].Value.ToString(),
                };
                data.Add(invoiceBill);
            }
            ds.Name = "DataSet1";
            ds.Value = data;
            
            CreditReport creditReport = new CreditReport();
            creditReport.reportViewer1.LocalReport.DataSources.Clear();
            creditReport.reportViewer1.LocalReport.DataSources.Add(ds);
            creditReport.reportViewer1.LocalReport.ReportEmbeddedResource = "BillingSoft.Reports.CreditorsReport.rdlc";
            creditReport.ShowDialog();
             
        }
    }
}
