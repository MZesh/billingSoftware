using BillingSoft.DbCode;
using Microsoft.VisualBasic.Devices;
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
    public partial class About : Form
    {
        DeveloperClass developerClass = new DeveloperClass();
        public About()
        {
            InitializeComponent();
        }

        private string GetScreenResolution()
        {
            string resol = "";
            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            resol = screenWidth + " X " + screenHeight;

            return resol;
        }

        private void About_Load(object sender, EventArgs e)
        {
            labelresol.Text = GetScreenResolution();
            labelos.Text = new  ComputerInfo().OSFullName;
            labelmem.Text = new ComputerInfo().TotalPhysicalMemory.ToString();
            labelnetver.Text = Environment.Version.ToString();
            AddDeveloperDetails();
        }
        private void AddDeveloperDetails()
        {
            labelemail.Text = "Email: "+developerClass.GetDeveloperEmail();
            labelph.Text = "PH# " + developerClass.GetDeveloperContact();
        }

        private void Open_Form(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.U)
            {
                new UpdateDeveloper().ShowDialog();
            }
        }
    }
}
