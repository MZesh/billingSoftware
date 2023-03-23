using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoft.Reports
{
   public class InvoicePos
    {
        public string invoiceNo { get; set; }
        public string cusName { get; set; }
        public string Date { get; set; }
        public string paymentType { get; set; }
        public string itemname { get; set; }
        public string itemcode { get; set; }
        public string itemqty { get; set; }
        public string price { get; set; }
        public string totalprice { get; set; }
        public string gtotal { get; set; }
        public string remain { get; set; }
        public string amountpaid { get; set; }
        public string discount { get; set; }
        public Image watermark { get; set; }
        public Image qrcode { get; set; }
    }
}
