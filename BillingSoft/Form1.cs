using BillingSoft.Products;
using BillingSoft.Settings;
using BillingSoft.SellForms;
using BillingSoft.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillingSoft.Expenses;
using BillingSoft.BackupDb;
using BillingSoft.DbCode;
using BillingSoft.Authentication;
using System.Threading;
using BillingSoft.Help;

namespace BillingSoft
{
    public partial class Home : Form
    {
        bool sliderExpend = true;
        bool prodCollapse = true;
        bool sellCollapse = true;
        bool databaseMenuCollapse = true;
        bool logcoll = true;
        AuthClass auth = new AuthClass();
        public Home()
        {
            InitializeComponent();
        }

        private void timer_slideMenu_Tick(object sender, EventArgs e)
        {
            if (sliderExpend)
            {
                flowLayoutmenupanel.Width -= 10;
                if (flowLayoutmenupanel.Width == flowLayoutmenupanel.MinimumSize.Width)
                {
                    pictureBoxExpend.Visible = true;
                    pictureBoxclose.Visible = false;
                    sliderExpend = false;
                    timer_slideMenu.Stop();
                }
            }
            else
            {
                flowLayoutmenupanel.Width += 10;
                if (flowLayoutmenupanel.Width == flowLayoutmenupanel.MaximumSize.Width)
                {
                    pictureBoxExpend.Visible = false;
                    pictureBoxclose.Visible = true;
                    sliderExpend = true;
                    timer_slideMenu.Stop();
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer_slideMenu.Start();
        }



        private void timer_prod_Tick(object sender, EventArgs e)
        {
            if (prodCollapse)
            {
                panelprodbtn.Height += 10;

                if (panelprodbtn.Height == panelprodbtn.MaximumSize.Height)
                {
                    prodCollapse = false;
                    timer_prod.Stop();
                }
            }
            else
            {
                panelprodbtn.Height -= 10;

                if (panelprodbtn.Height == panelprodbtn.MinimumSize.Height)
                {
                    prodCollapse = true;
                    timer_prod.Stop();
                }
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            timer_prod.Start();

        }


        private void timerdatabase_Tick(object sender, EventArgs e)
        {
            if (databaseMenuCollapse)
            {
                paneldatabase.Height += 10;

                if (paneldatabase.Height == paneldatabase.MaximumSize.Height)
                {
                    databaseMenuCollapse = false;
                    timerdatabase.Stop();
                }
            }
            else
            {
                paneldatabase.Height -= 10;

                if (paneldatabase.Height == paneldatabase.MinimumSize.Height)
                {
                    databaseMenuCollapse = true;
                    timerdatabase.Stop();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerdatabase.Start();
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

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            loadForms(new AddProduct());
        }

        private void buttonViewProduct_Click(object sender, EventArgs e)
        {
            loadForms(new ViewProducts());
        }

        private void buttonsetting_Click(object sender, EventArgs e)
        {
            loadForms(new Setting());
        }

        private void timerselling_Tick(object sender, EventArgs e)
        {
            if (sellCollapse)
            {
                panelselling.Height += 10;

                if (panelselling.Height == panelselling.MaximumSize.Height)
                {
                    sellCollapse = false;
                    timerselling.Stop();
                }
            }
            else
            {
                panelselling.Height -= 10;

                if (panelselling.Height == panelselling.MinimumSize.Height)
                {
                    sellCollapse = true;
                    timerselling.Stop();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timerselling.Start();
        }

        private void selling_panel(object sender, EventArgs e)
        {
            loadForms(new ProductSellingPanel());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForms(new DailyExpense());
        }

        private void Home_Load(object sender, EventArgs e)
        {
            loadForms(new Index());
            labelad.Text ="Welcome "+ Auth.userName;
            if(Auth.userName.Equals("Administrator"))
            {
                panelprodbtn.Enabled = true;
            }
            else
            {
                panelprodbtn.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadForms(new Index());
        }

        private void open_Selling_History(object sender, EventArgs e)
        {
            loadForms(new SellHistory());
        }

        private void backupDb(object sender, EventArgs e)
        {
            new Backup().Show();
        }

        private void restoreDb(object sender, EventArgs e)
        {
            new Restore().Show();
        }

        private void CheckClosing(object sender, FormClosingEventArgs e)
        {
            BackupPOPUp backupPOPUp = new BackupPOPUp();
            backupPOPUp.Show();
           
           // backupPOPUp.StartBackup();
           //Application.Exit();
        }

        private void pictureBoxExpend_Click(object sender, EventArgs e)
        {
            timer_slideMenu.Start();
        }

        private void buttonhelp_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
 

        private void Home_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            if(auth.GetThemeName().Equals("Home"))
            {
                Application.Exit();
            }
            else { }
        }
    }
}
