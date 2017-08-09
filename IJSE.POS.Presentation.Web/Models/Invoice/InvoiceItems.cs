using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IJSE.POS.Presentation.Web.Models.Invoice
{
    public class InvoiceItems
    {
        public int ID { get; set; }

        [Display(Name = "Item Code")]
        public int ItemID { get; set; }

        [Display(Name = "Name")]
        public string ItemName { get; set; }

        [Display(Name = "Price")]
        public double ItemPrice { get; set; }

        [Display(Name = "QTY")]
        public int Quantity { get; set; }

        [Display(Name = "Sub Total")]
        public double SubTotal { get; set; }

    }
}