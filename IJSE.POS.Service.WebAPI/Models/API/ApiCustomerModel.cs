using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IJSE.POS.Service.WebAPI.Models.API
{
    public class ApiCustomerModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public double Creditlimit { get; set; }
    }
}