using BillingSoft.DbCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.Products
{
    public partial class OutOfStock : Form
    {
        productClass pc = new productClass();
        public OutOfStock()
        {
            InitializeComponent();
        }

        private void OutOfStock_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.getAllOutStockProducts();
        }
    }
}
