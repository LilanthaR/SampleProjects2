using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJSE.POS.Common.Models
{
    public class InvoiceDetail
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public double ItemDiscount { get; set; }
        public double ItemTotal { get; set; }

        public int ItemDetailID { get; set; }
        public int InvoiceID { get; set; }

        public virtual ItemDetail ItemDetail { get; set; }
        public virtual Invoice Invoice { get; set; }

    }
}
