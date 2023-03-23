using BillingSoft.DbCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.Products
{
    public partial class ViewProducts : Form
    {
        productClass pc = new productClass();
        long sp = 0;
        long pp = 0;
        long totalsp = 0;
        long totalpp = 0;
        long qt = 0;
        long sellprice = 0;
        public static string items = "";
        public static string code = "";
        public static string pprice = "";
        public static string sprice = "";
        public static string qty = "";
        public static string Id = "";
        public static string cat = "";
        public static string bnd = "";
        public ViewProducts()
        {
            InitializeComponent();
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.getAllProducts();
            //Add Button To Datagridview 
            RowColor();
            addDataGridViewColumn();
           
           
        }

        private void textBoxsearchbyname_TextChanged(object sender, EventArgs e)
        {
          //  String search = Regex.Replace(textBoxsearchbyname.Text, " ", "");
            DataTable dt = new DataTable();
            dt = pc.getAllProducts();
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("ItemName like '%{0}%'", textBoxsearchbyname.Text);
            dataGridView1.DataSource = DV;
        }

        private void CategorySearch(object sender, EventArgs e)
        {
            //String search = Regex.Replace(textBoxsearchbycategory.Text, " ", "");
            DataTable dt = new DataTable();
            dt = pc.getAllProducts();
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("ItemCategory like '%{0}%'", textBoxsearchbycategory.Text);
            dataGridView1.DataSource = DV;
        }

        private void SearchbyCode(object sender, EventArgs e)
        {
            String search = Regex.Replace(textBoxsearchbycode.Text, " ", "");
            DataTable dt = new DataTable();
            dt = pc.getAllProducts();
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("ItemCode like '%{0}%'", search);
            dataGridView1.DataSource = DV;
        }

        private void Check_Button_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Action"].Index && e.RowIndex >= 0)
            {


                Id = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                items = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                code = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                pprice = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                sprice = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                qty = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                cat = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                bnd = dataGridView1.CurrentRow.Cells[5].Value.ToString();
             
               new EditUpdate().ShowDialog();
                dataGridView1.DataSource = pc.getAllProducts();
                
            }
        }
        private void addDataGridViewColumn()
        {
            DataGridViewButtonColumn columnn = new DataGridViewButtonColumn();
            dataGridView1.Columns[8].Visible = false;
            columnn.DataPropertyName = "Action";
            columnn.Name = "Action";
            columnn.Text = "More Action";
            columnn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(columnn);
            //getting total
            int rows = dataGridView1.Rows.Count;
            labelitemcount.Text = rows.ToString();
            GetTotalAmount();
        }
        private void RowColor()
        { 
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                long remainQty = long.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                if (remainQty == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (remainQty >= 1 && remainQty < 5)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else if(remainQty >= 5)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
        private void GetTotalAmount()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sp = long.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                pp = long.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                qt = long.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                totalsp += qt * sp;
                totalpp += qt * pp;
                sellprice = qt * sp;
                dataGridView1.Rows[i].Cells[8].Value = sellprice.ToString();
            }
            labelpprice.Text = totalpp.ToString();
            labelsellprice.Text = totalsp.ToString();
            long diff = totalsp - totalpp;
            labeldiff.Text = diff.ToString();
        }

        private void Formatting_Cell_Values(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex==8 & e.Value!=null)
            {
                int value = Convert.ToInt32(e.Value);
                if (value >= 1 & value <= 5)
                    e.CellStyle.BackColor = Color.Yellow;
                else if (value == 0)
                    e.CellStyle.BackColor = Color.Red;
            }
        }
    }
}