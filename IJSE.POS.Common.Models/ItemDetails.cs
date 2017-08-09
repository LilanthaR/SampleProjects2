using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IJSE.POS.Common.Models
{
    public class ItemDetail
    {
        public int ID { get; set; }
        public DateTime EffectiveDate { get; set; }
        public double UnitPrice { get; set; }
        public bool Active { get; set; }        

        public int ItemID { get; set; }
        public virtual Item Item { get; set; }
    }
}
