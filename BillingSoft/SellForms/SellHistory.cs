using BillingSoft.DbCode;
using BillingSoft.ReturnProducts;
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
    public partial class SellHistory : Form
    {
        sellingProduct selling = new sellingProduct();
        public static string inv = "";
        public static string item = "";
        public static string code = "";
        public static string qty = "";
        public static string prce = "";
        public SellHistory()
        {
            InitializeComponent();
        }
      
        public void SellHistory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = selling.getAllSellProduct();
            DataGridViewButtonColumn ret = new DataGridViewButtonColumn();
            ret.DataPropertyName = "Return";
            ret.Name = "Return";
            ret.Text = "Return";
            ret.UseColumnTextForButtonValue = true;
            ret.FlatStyle = FlatStyle.Flat;
            dataGridView1.Columns.Add(ret);
            TotalPrice();
        }
        private void TotalPrice()
        {
            long totalprice = 0;
            long remain = 0;
            long qty = 0;
            long totalSellPrice = 0;
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                qty = long.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                totalprice += long.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                remain += long.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString());
                totalSellPrice = totalprice * qty;
            }
            labelprice.Text = totalSellPrice.ToString();
            labelremaining.Text = remain.ToString();
        }

        private void Search_Using_Invoice_No(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = selling.getAllSellProduct();
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("InvoiceNo like '%{0}%'", textBoxsearchbyinv.Text);
            dataGridView1.DataSource = DV;
            TotalPrice();
        }

        private void search_using_customer_name(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = selling.getAllSellProduct();
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("Customer like '%{0}%'", textBoxsearchbycus.Text);
            dataGridView1.DataSource = DV;
            TotalPrice();
        }

        private void Return_Product(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Return"].Index && e.RowIndex >= 0)
            {
                inv = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                prce = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                item = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                code = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                qty = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                
                new Return().ShowDialog();
                dataGridView1.DataSource = selling.getAllSellProduct();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          dataGridView1.DataSource =  selling.FilterHistoryUsingDates(dateTimePickerfrm.Value.ToShortDateString(),dateTimePickerto.Value.ToShortDateString());   
        }
    }
}
