using BillingSoft.DbCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.BackupDb
{
    public partial class Restore : Form
    {
        DbClass dbClass = new DbClass();
        SQLiteConnection src = new SQLiteConnection("Data Source=dgbillingsoft.db;Version=3;");
        private static readonly string filePath = Environment.CurrentDirectory;
        public Restore()
        {
            InitializeComponent();
        }

        private void Restore_Load(object sender, EventArgs e)
        {
           
        }

        private void DbRestore(object sender, EventArgs e)
        {
            try
            {
                var srcfile = Path.Combine(filePath, "dgbillingsoft.db");
                File.Copy(textBoxloc.Text, srcfile, true);
                MessageBox.Show("Success - Restore Database Successfully ", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Sql Server Database Backup Files|*.db";
            dlg.Title = "Restore Database";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxloc.Text = dlg.FileName;
                //buttonrestore.Enabled = true;
            }
        }
    }
}
