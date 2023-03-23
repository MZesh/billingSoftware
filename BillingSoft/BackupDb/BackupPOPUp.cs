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
    public partial class BackupPOPUp : Form
    {
        DbClass dbClass = new DbClass();
        public BackupPOPUp()
        {
            InitializeComponent();
        }

        private void BackupPOPUp_Load(object sender, EventArgs e)
        {
            timer_autoBackup.Start();
            StartBackup();
        }
        public void StartBackup()
        {
           
            String loc = dbClass.getDbBackupLocation();
            DbBackup(loc);
           
        }
        private void DbBackup(string loc)
        {
            try
            {
                if (loc == string.Empty)
                {
                    this.Close();
                }
                else
                {
                    using (var source = new SQLiteConnection("Data Source=dgbillingsoft.db; Version=3;"))
                    using (var destination = new SQLiteConnection("Data Source=" + loc + "\\dgbillingsoft.db; Version=3;"))
                    {
                        source.Open();
                        destination.Open();
                        source.BackupDatabase(destination, "main", "main", -1, null, 0);
                    }

                   // MessageBox.Show("Success -- BackUp Successfully Done ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer_autoBackup_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(50);
          //  StartBackup();
            if (progressBar1.Value == 100)
            {
                //StartBackup();
                timer_autoBackup.Stop();
                this.Close();
            }
        }
    }
}
