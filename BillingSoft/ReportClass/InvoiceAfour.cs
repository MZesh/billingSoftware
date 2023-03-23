using BillingSoft.CreateBitmap;
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
    public partial class InvoiceAfour : Form
    {
        companyClass company = new companyClass();
        DeveloperClass developerClass = new DeveloperClass();
        AddWatermarkAndQRCode addWatermark = new AddWatermarkAndQRCode();
        PrintSetting setting = new PrintSetting();
        String loc = "";
        String check = "";
        public InvoiceAfour()
        {
            InitializeComponent();
        }

        private void InvoiceAfour_Load(object sender, EventArgs e)
        {
            getWaterMarkName();    
            String barCode = getBarCodePath() + ".jpg";
            this.reportViewerAfour.LocalReport.EnableExternalImages = true;
            ReportParameter companyName = new ReportParameter("companyName", setCompanyName());
            ReportParameter companyAddr = new ReportParameter("companyAddr", setCompanyAddress());
            ReportParameter companyph = new ReportParameter("companyContact", setCompanyPhone());
            ReportParameter checkString = new ReportParameter("checkString", check);
            ReportParameter checkLogoString = new ReportParameter("checkLogo", checkLogo());
            ReportParameter devName = new ReportParameter("developName", developerClass.GetDeveloperName());
            ReportParameter devPh = new ReportParameter("developPhone", developerClass.GetDeveloperContact());
            ReportParameter water = new ReportParameter("watermark", new Uri(loc).AbsoluteUri);
            ReportParameter bCode = new ReportParameter("barCode", new Uri(barCode).AbsoluteUri);
            ReportParameter companyimage = new ReportParameter("companyImage", new Uri(setLogo()).AbsoluteUri);
            this.reportViewerAfour.LocalReport.SetParameters(new ReportParameter[] { companyName, companyAddr, companyph, companyimage,water,bCode,checkString,checkLogoString,devName,devPh });
            this.reportViewerAfour.RefreshReport();
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
        public void getWaterMarkName()
        {
            String wmark = setting.getPrintingWatermark();
            if (wmark != String.Empty)
            {
                pictureBox1.Image = AddWatermarkAndQRCode.Convert_Text_to_Image(wmark, "Cambria", 20);
                String exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                String mainPath = System.IO.Path.GetDirectoryName(exePath);
                String imageUrl = mainPath + "\\logo\\" + wmark;
                pictureBox1.Image.Save(imageUrl + ".jpg");
                loc = imageUrl + ".jpg";
            }
            else
            {
                loc = System.Reflection.Assembly.GetExecutingAssembly().Location;
            }
            CreateQrCode();
        }
        //InvoiceNo
        // InvoiceDate
        private void CreateQrCode()
        {
            string code = setting.getPrintingQRCode();
            if (code.Equals("InvoiceNo"))
            {
                string brCode = setting.getInvoiceNo();
                addWatermark.CreateQRCode(brCode, "InvoiceNo");

            }
            else if (code.Equals("InvoiceDate"))
            {
                string brCode = DateTime.Now.ToShortDateString();
                addWatermark.CreateQRCode(brCode, "Date");
            }
            else
            {
                string brCode = "";
                // addWatermark.CreateQRCode(brCode,"");
            }
        }

        //get BarCode Path
        private string getBarCodePath()
        {
            string code = setting.getPrintingQRCode();
            string brCode = "";
            String exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            String mainPath = System.IO.Path.GetDirectoryName(exePath);
            if (code.Equals("InvoiceNo"))
            {
                brCode = mainPath + "\\logo\\InvoiceNo";
                check = "Yes";
            }
            else if (code.Equals("InvoiceDate"))
            {
                brCode = mainPath + "\\logo\\Date";
                check = "Yes";
            }
            else
            {
                brCode = exePath;
                check = "No";
            }

            return brCode;
        }
    }
}
