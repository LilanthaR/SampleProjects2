using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJSE.POS.Common.Models
{
    public class Invoice
    {
        public int ID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public double ItemTotal { get; set; }
        public double Discount { get; set; }
        public double Tax { get; set; }
        public double InvoiceTotal { get; set; }
        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<InvoiceDetail> InvocieDetail { get; set; }
    }
}
