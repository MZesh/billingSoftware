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
    public partial class UpdateCredentials : Form
    {
        AuthClass authClass = new AuthClass();
        public UpdateCredentials()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Auth().Show();
        }

        private void UpdateCredentials_Load(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (isEmpty(this))
            {
                MessageBox.Show("Error- Fill all the fields... ", "No Data entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(textBoxnewpass.Text.Equals(textBoxconfrmpass.Text))
                {
                    bool isUpdate = authClass.updateUser(textBoxnewUser.Text,textBoxnewpass.Text,comboBoxrole.Text);
                    if(isUpdate)
                    {
                        MessageBox.Show("Scuccessfully updated user... ", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        new Auth().Show();
                    }
                    else
                    {
                        MessageBox.Show("Cannot update information... ", "Error updation", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Match_Old_Pass(object sender, EventArgs e)
        {
            bool isOldPass = authClass.GetPass(textBoxpass.Text,textBoxuser.Text);
            if(!isOldPass)
            {
                MessageBox.Show("Error- Password is Incorrect... ", "No Data entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxpass.Text = "";
                textBoxpass.Focus();
            }

        }

        private void Get_Username(object sender, EventArgs e)
        {
            bool isOldUser = authClass.GetUser(textBoxuser.Text);
            if (!isOldUser)
            {
                MessageBox.Show("Error- UserName is Incorrect... ", "No Data entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxuser.Text = "";
                textBoxuser.Focus();
            }
        }
    }
}
