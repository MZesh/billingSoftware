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

namespace BillingSoft.Creditors
{
    public partial class PaymentCreditors : Form
    {
        CreditorPayment creditorPayment = new CreditorPayment();
        long paidAmound = 0;
        public PaymentCreditors()
        {
            InitializeComponent();
        }

        

        private void PaymentCreditors_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1589, 754);
        }

        private void Getting_Creditor_Information(object sender, DataGridViewCellEventArgs e)
        {
          if(e.RowIndex != -1)
            {
                textBoxcrdnm.Text = dataGridViewCreditors.CurrentRow.Cells[0].Value.ToString();
                textBoxamount.Text = labeltotalamount.Text;
                textBoxremaining.Text = dataGridViewCreditors.CurrentRow.Cells[1].Value.ToString();
                labelremain.Text = dataGridViewCreditors.CurrentRow.Cells[1].Value.ToString();
                textBoxinvoice.Text = dataGridViewCreditors.CurrentRow.Cells[2].Value.ToString();
                button1.Enabled = true;
            }
        }

        private void Validate(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure To Make Payment Against Customer "+textBoxcrdnm.Text+" ?" , "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                bool isInsert = creditorPayment.insertCreditorDetail(textBoxcrdnm.Text,textBoxamount.Text,textBoxpaidAmount.Text,textBoxremaining.Text,textBoxinvoice.Text,DateTime.Now.ToShortDateString());
                if(isInsert)
                {
                    long amount = long.Parse(textBoxpaidAmount.Text);
                    long updateAmount = paidAmound + amount;
                    creditorPayment.editCreditor(textBoxcrdnm.Text,textBoxinvoice.Text,textBoxremaining.Text,updateAmount.ToString());
                    MessageBox.Show("Payment Done Successfull...", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields(groupBox3);
                    Int32 selectedRowCount = dataGridViewCreditors.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        dataGridViewCreditors.Rows.RemoveAt(dataGridViewCreditors.SelectedRows[0].Index);

                    }
                    labeltotalamount.Text = "0";
                    textBoxsearchcreditorname.Text = "";
                }
                else
                {
                    MessageBox.Show("Something Went Wrong...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearFields(GroupBox box)
        {
            foreach(Control c in box.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }

        }

        private void AmountPaid(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                long paidAmount = long.Parse(textBoxpaidAmount.Text);
                long totalAmount = long.Parse(labelremain.Text);

                if(paidAmount > totalAmount)
                {
                    MessageBox.Show("Paid Amount Cannot Greater Than Total Amount...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    long remain = totalAmount - paidAmount;
                    textBoxremaining.Text = remain.ToString();
                }
               

            }
        }

        private void Search_New_Creditor(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string remain = creditorPayment.GetAllRemainCreditor(textBoxnewCreditor.Text);
                if(remain.Equals("0"))
                {
                    MessageBox.Show("This Customer Already Paid the Credit.The remaining credit is " + remain, "Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridViewnew.DataSource = creditorPayment.GetAllNewCreditor(textBoxnewCreditor.Text);
                    if (dataGridViewnew.Rows.Count > 0)
                    {
                        long total = 0;
                        for (int i = 0; i < dataGridViewnew.Rows.Count; i++)
                        {
                            total += long.Parse(dataGridViewnew.Rows[i].Cells[1].Value.ToString());
                            paidAmound = long.Parse(dataGridViewnew.Rows[i].Cells[2].Value.ToString());
                        }
                        labelnewTotal.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Record Found by This Name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
        }

        private void Search_Credit_Old(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string remain = creditorPayment.GetAllRemain(textBoxsearchcreditorname.Text);
                long price = creditorPayment.GetTotalPrice(textBoxsearchcreditorname.Text);
                
                if(remain.Equals("0"))
                {
                    MessageBox.Show("This Customer Already Paid the Credit.The remaining credit is "+remain, "Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridViewCreditors.DataSource = creditorPayment.GetAllSelltProduct(textBoxsearchcreditorname.Text);
                   // dataGridViewCreditors.Columns.Add("Total Price", price.ToString());
                    
                    if (dataGridViewCreditors.Rows.Count > 0)
                    {
                        long total = 0;
                        for (int i = 0; i < dataGridViewCreditors.Rows.Count; i++)
                        {
                           // total += long.Parse(dataGridViewCreditors.Rows[i].Cells[6].Value.ToString());
                            //paidAmound = long.Parse(dataGridViewCreditors.Rows[i].Cells[5].Value.ToString());
                        }
                        labeltotalamount.Text = price.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Record Found by This Name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
        }

        private void Old_Credit_Edit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                textBoxnewcrdnm.Text = dataGridViewnew.CurrentRow.Cells[0].Value.ToString();
                textBoxnewamount.Text = dataGridViewnew.CurrentRow.Cells[1].Value.ToString();
                textBoxnewremain.Text = dataGridViewnew.CurrentRow.Cells[3].Value.ToString();
                textBoxnewinvoice.Text = dataGridViewnew.CurrentRow.Cells[4].Value.ToString();
                labelnewRemain.Text = textBoxnewremain.Text;
                button2.Enabled = true;
            }
        }

        private void New_Validation(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void New_Creditor_Payment(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                long paidAmount = long.Parse(textBoxnewpaid.Text);
                long totalAmount = long.Parse(labelnewRemain.Text);

                if (paidAmount > totalAmount)
                {
                    MessageBox.Show("Paid Amount Cannot Greater Than Total Amount...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    long remain = totalAmount - paidAmount;
                    textBoxnewremain.Text = remain.ToString();
                }


            }
        }

        private void Add_New_Pay_Creditor(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure To Make Payment Against Customer " + textBoxnewcrdnm.Text + " ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                long amount = long.Parse(textBoxnewamount.Text);
                long amountPaid = long.Parse(textBoxnewpaid.Text);
                long updateAmount = amountPaid + amount;
                long remain = long.Parse(textBoxnewremain.Text);
                bool isInsert = creditorPayment.insertCreditorDetail(textBoxnewcrdnm.Text,textBoxnewamount.Text,textBoxnewpaid.Text,remain.ToString(),textBoxnewinvoice.Text,DateTime.Now.ToShortDateString());
                if (isInsert)
                {
                   
                    MessageBox.Show("Payment Done Successfull...", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields(groupBox5);
                    Int32 selectedRowCount = dataGridViewnew.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        dataGridViewnew.Rows.RemoveAt(dataGridViewnew.SelectedRows[0].Index);

                    }
                    labelnewTotal.Text = "0";
                    textBoxnewCreditor.Text = "";
                }
                else
                {
                    MessageBox.Show("Something Went Wrong...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Change_Amount(object sender, EventArgs e)
        {
            if(textBoxpaidAmount.Text == string.Empty)
            {
                labelmsg.Visible = false;
            }
            else
            {
                labelmsg.Visible = true;
            }
        }

        private void Change(object sender, EventArgs e)
        {
            if (textBoxnewpaid.Text == string.Empty)
            {
                labelnewmsg.Visible = false;
            }
            else
            {
                labelnewmsg.Visible = true;
            }
        }
    }
}
