using BillingSoft.DbCode;
using BillingSoft.Reports;
using BillingSoft.Themes;
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
    public partial class Auth : Form
    {
        AuthClass authClass = new AuthClass();
        public static string formname = "";
        public static string userName = "";
        public Auth()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labeladdnew_Click(object sender, EventArgs e)
        {
            formname = "add";
            this.Hide();
            //  new AddUser().Show();
            new AdminPass().Show();
        }

        private void labelupdate_Click(object sender, EventArgs e)
        {
            formname = "update";
            this.Hide();
            new AdminPass().Show();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (isEmpty(this))
            {
                MessageBox.Show("Error- Fill all the fields... " , "No Data entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isLogin = authClass.Login(textBoxuser.Text,textBoxpass.Text,comboBoxrole.Text);
                if(isLogin)
                {
                    userName = comboBoxrole.Text;
                    this.Hide();
                    OpenForm(authClass.GetThemeName());
                }
                else
                {
                    MessageBox.Show("Error- Failed to login... ", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
         private bool isEmpty(Form form)
        {
            bool empty = false;
            foreach(Control c in form.Controls)
            {
                if(c is TextBox)
                {
                    if (c.Text.Equals(""))
                    {
                        empty = true;
                    }
                    else
                    {
                        empty = false;
                    }
                }
            }
            return empty;
        }

        private void Login_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonlogin.PerformClick();
            }
        }
        private void OpenForm(string name)
        { 
            switch (name)
            {
                case "Home":
                    new Home().Show();
                    break;
                case "ThemeTwo":
                    new ThemeTwo().Show();
                    break;
                case "ThemeThree":
                    new ThemeThree().Show();
                    break;
            } 
         
        }
    }
}
