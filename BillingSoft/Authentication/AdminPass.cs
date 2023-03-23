using BillingSoft.DbCode;
using BillingSoft.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.Authentication
{
    public partial class AdminPass : Form
    {
        AuthClass auth = new AuthClass();
        public AdminPass()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Auth().Show();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text.Equals(""))
           {
              MessageBox.Show("Error- Fill password field... ", "No Data entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           else
            {
                if (textBox1.Text.Equals(auth.GetAdministratorPass())) 
                {
                    if(Auth.formname.Equals("add"))
                    {
                        this.Hide();
                        new AddUser().Show();
                    }
                    else
                    {
                        this.Hide();
                        new UpdateCredentials().Show();
                    }
                }
                else
                {
                    labelwrong.Visible = true;
                }
            }
        }

        private void Unlock(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
           
        }
    }
}
