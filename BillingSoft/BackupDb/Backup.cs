using BillingSoft.DbCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.BackupDb
{
    public partial class Backup : Form
    {
        DbClass dbClass = new DbClass();
        public Backup()
        {
            InitializeComponent();
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            String loc = dbClass.getDbBackupLocation();
            textBoxloc.Text = loc;
        }

        private void BackupDb(object sender, EventArgs e)
        {

            try
            {
                if (textBoxloc.Text == string.Empty)
                {
                    MessageBox.Show("Error -- Enter Location ", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (var source = new SQLiteConnection("Data Source=dgbillingsoft.db; Version=3;"))
                    using (var destination = new SQLiteConnection("Data Source=" + textBoxloc.Text + "\\dgbillingsoft.db; Version=3;"))
                    {
                        source.Open();
                        destination.Open();
                        source.BackupDatabase(destination, "main", "main", -1, null, 0);
                    }

                    MessageBox.Show("Success -- BackUp Successfully Done ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
