using BillingSoft.Authentication;
using BillingSoft.BackupDb;
using BillingSoft.Dashboard;
using BillingSoft.DbCode;
using BillingSoft.Expenses;
using BillingSoft.Help;
using BillingSoft.Products;
using BillingSoft.SellForms;
using BillingSoft.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.Themes
{
    public partial class ThemeThree : Form
    {
        AuthClass auth = new AuthClass();
        public ThemeThree()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForms(new SellHistory());
        }
        public void loadForms(object Form)
        {
            if (mainpanel.Controls.Count > 0)
                mainpanel.Controls.RemoveAt(0);

            Form frm = Form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(frm);
            this.mainpanel.Tag = frm;
         //   labeltitle.Text = frm.Text;
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadForms(new Index());
        }

        private void ThemeThree_Load(object sender, EventArgs e)
        {
            loadForms(new Index());
         //   string role= Auth.userName;
            if (Auth.userName.Equals("Administrator"))
            {
                buttonaddprod.Enabled = true;
                buttonViewProd.Enabled = true;
            }
            else
            {
                buttonaddprod.Enabled = false;
                buttonViewProd.Enabled = false;
            }
        }

        private void buttonaddprod_Click(object sender, EventArgs e)
        {
            loadForms(new AddProduct());
        }

        private void buttonViewProd_Click(object sender, EventArgs e)
        {
            loadForms(new ViewProducts());
        }

        private void buttonsellingpanel_Click(object sender, EventArgs e)
        {
            loadForms(new ProductSellingPanel());
        }

        private void buttonbackup_Click(object sender, EventArgs e)
        {
            new Backup().Show();
        }

        private void buttonrestore_Click(object sender, EventArgs e)
        {
            new Restore().Show();
        }

        private void buttonexpense_Click(object sender, EventArgs e)
        {
            loadForms(new DailyExpense());
        }

        private void buttonsetting_Click(object sender, EventArgs e)
        {
            loadForms(new Setting());
        }

        private void buttonhelp_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void Check(object sender, FormClosingEventArgs e)
        {
            BackupPOPUp backupPOPUp = new BackupPOPUp();
            backupPOPUp.Show();
        }

       

        private void Close(object sender, FormClosedEventArgs e)
        {
            if (auth.GetThemeName().Equals("ThemeThree"))
            {
                Application.Exit();
            }
            else
            {
                 
            }
        }
    }
}
