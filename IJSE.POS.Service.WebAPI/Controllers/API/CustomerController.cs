using System;
using System.Collections.Generic;
//using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//using IJSE.POS.Service.WebAPI.Models.API;

namespace IJSE.POS.Service.WebAPI.Controllers.API
{
    public class CustomerController : ApiController
    {
        public bool AddCustomer(ApiCustomerModel newCustomer)
        {
            

            return true;
        }
        public ApiCustomerModel Get(int id)
        {
            ApiCustomerModel customer = new ApiCustomerModel { ID = 1,
                Name = "Abc", Address = "Colombo",
                Tel = "094", Creditlimit = 2000 } ;
              
            return customer;
        }

        public List<ApiCustomerModel> GetList()
        {
           List<ApiCustomerModel> customerList = new List<ApiCustomerModel>();

            ApiCustomerModel customer1 = new ApiCustomerModel
            {
                ID = 1,
                Name = "Abc",
                Address = "Colombo",
                Tel = "094",
                Creditlimit = 2000
            };

            ApiCustomerModel customer2 = new ApiCustomerModel
            {
                ID = 2,
                Name = "Bcd",
                Address = "Panadura",
                Tel = "094",
                Creditlimit = 2500
            };

            customerList.Add(customer1);
            customerList.Add(customer2);

            return customerList;
        }
    }

    public class ApiCustomerModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public double Creditlimit { get; set; }
    }
}
