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

namespace BillingSoft.Help
{
    public partial class UpdateDeveloper : Form
    {
        DeveloperClass developerClass = new DeveloperClass();
        public UpdateDeveloper()
        {
            InitializeComponent();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            if (isEmpty(this))
            {
                MessageBox.Show("Please Fill All the field..", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isUpdate = developerClass.updateDeveloper(textBoxdname.Text,textBoxdcontact1.Text,textBoxdcontact2.Text,textBoxdemail.Text);
                if (isUpdate)
                {
                    MessageBox.Show("Successfully Updated...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Deletion Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private bool isEmpty(Form frm)
        {
            bool empty = false;
            foreach(Control c in frm.Controls)
            {
                if(c is TextBox)
                {
                    if(c.Text == "")
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
