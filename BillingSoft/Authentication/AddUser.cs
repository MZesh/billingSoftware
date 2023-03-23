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

namespace BillingSoft.Authentication
{
    public partial class AddUser : Form
    {
        AuthClass authClass = new AuthClass();
        public AddUser()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Auth().Show();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (isEmpty(this))
            {
                MessageBox.Show("Error- Fill all the fields... ", "No Data entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(textBoxpass.Text.Equals(textBoxconfrmpass.Text))
                {
                    bool isInsert = authClass.isAddNewUser(textBoxuser.Text, textBoxpass.Text, comboBoxrole.Text, DateTime.Now.ToShortDateString());
                    if(isInsert)
                    {
                        MessageBox.Show("Scuccessfully added new user... ", "Added User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        new Auth().Show();
                    }
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password didnt match... ", "No match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private bool isEmpty(Form form)
        {
            bool empty = false;
            foreach (Control c in form.Controls)
            {
                if (c is TextBox || c is ComboBox)
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
    }
}
