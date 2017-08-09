using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJSE.POS.Common.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        // One Item has many itemPrice ( ItemDetails )
        public virtual ICollection<ItemDetail> ItemDetails { get; set; }
    }
}
