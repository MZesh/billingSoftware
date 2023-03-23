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
    public partial class ThemeTwo : Form
    {
        AuthClass auth = new AuthClass();
        public ThemeTwo()
        {
            InitializeComponent();
        }

        private void panelright_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForms(new ViewProducts());
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
            labeltitle.Text = frm.Text;
            frm.Show();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForms(new Setting());
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Backup().Show();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Restore().Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForms(new DailyExpense());
        }

        private void productSellingPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForms(new ProductSellingPanel());
        }

        private void sellingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForms(new SellHistory());
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForms(new AddProduct());
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForms(new IndexTwo());
        }

        private void ThemeTwo_Load(object sender, EventArgs e)
        {
            loadForms(new IndexTwo());
            labelrole.Text = Auth.userName;
            if (Auth.userName.Equals("Administrator"))
            {
                manageProductToolStripMenuItem.Enabled = true;
            }
            else
            {
                manageProductToolStripMenuItem.Enabled = false;
            }
        }

        private void Check_BAckup(object sender, FormClosingEventArgs e)
        {
            BackupPOPUp backupPOPUp = new BackupPOPUp();
            backupPOPUp.Show();
            
        }

      
        private void Closed(object sender, FormClosedEventArgs e)
        {
            if(auth.GetThemeName().Equals("ThemeTwo"))
            {
                Application.Exit();
            }
            else { }

        }
    }
}
