using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IJSE.POS.Common.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public double Creditlimit { get; set; }

        // One customer has many Invoice
        public virtual ICollection<Invoice> Invoice { get; set; }

    }
}
