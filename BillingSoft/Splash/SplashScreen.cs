using BillingSoft.Authentication;
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

namespace BillingSoft.Splash
{
    public partial class SplashScreen : Form
    {
        DeveloperClass developerClass = new DeveloperClass();
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                new Auth().Show();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            AddDeveloperDetails();
        }

        private void AddDeveloperDetails()
        {
            labeldevelopname.Text = developerClass.GetDeveloperName();
            labelph.Text ="PH# "+ developerClass.GetDeveloperContact();
        }
    }
}
