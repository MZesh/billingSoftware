using BillingSoft.DbCode;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSoft.ReportClass
{
    public partial class CreditReport : Form
    {
        companyClass company = new companyClass();
        DeveloperClass developerClass = new DeveloperClass();
        public CreditReport()
        {
            InitializeComponent();
        }

        private void CreditReport_Load(object sender, EventArgs e)
        {
           
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            ReportParameter companyName = new ReportParameter("companyName", setCompanyName());
            ReportParameter companyAddr = new ReportParameter("companyAddr", setCompanyAddress());
            ReportParameter companyph = new ReportParameter("companyContact", setCompanyPhone());
            ReportParameter checklogostring = new ReportParameter("checkLogo", checkLogo());
            ReportParameter devName = new ReportParameter("developName", developerClass.GetDeveloperName());
            ReportParameter devPh = new ReportParameter("developPhone", developerClass.GetDeveloperContact());
            ReportParameter companyimage = new ReportParameter("companyImage", new Uri(setLogo()).AbsoluteUri);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { companyName, companyAddr, companyph, companyimage,checklogostring,devName,devPh });

            this.reportViewer1.RefreshReport();
        }
        public string checkLogo()
        {
            string logocheck = company.getCompanyImage();
            if (logocheck == String.Empty)
            {
                logocheck = "NoLogo";
            }
            else
            {
                logocheck = "LogoExists";
            }

            return logocheck;
        }
        public string setCompanyAddress()
        {
            String address = company.getCompanyAddress();
            if (address == String.Empty)
            {
                address = "Company Address Here";
            }
            return address;
        }
        public string setCompanyName()
        {
            String cName = company.getCompanyName();
            if (cName == String.Empty)
            {
                cName = "Company Name Here";
            }
            return cName;
        }
        public string setCompanyPhone()
        {
            String phone = company.getCompanyPhone();
            if (phone == String.Empty)
            {
                phone = "Company Phone No Here";
            }
            return phone;
        }
        public string setLogo()
        {
            String logo = company.getCompanyImage();
            String imageUrl = "";
            String strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            String strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            if (logo != string.Empty)
            {
                imageUrl = strWorkPath + "\\logo\\" + logo;
            }
            else
            {
                imageUrl = strWorkPath + "\\logo\\";
            }
            return imageUrl;
        }
    }
}
