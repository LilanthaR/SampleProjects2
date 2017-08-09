using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IJSE.POS.Common.Models;
using IJSE.POS.DataAccess.DAL.Contracts;
using IJSE.POS.BusinessService.Contracts;
using IJSE.POS.Common.Logs;

using Microsoft.Practices.Unity;

namespace IJSE.POS.BusinessService
{
    
    public class InvoiceManger : IInvoiceManger
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]    // Constructore  inject
        public InvoiceManger(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }


        [Dependency] //for setters
        public IRepository Repository
        {
            get { return _repository; }
            set { _repository = value; }
        }

        [Dependency] //for setters
        public ILogger Logger
        {
            get { return _log; }
            set { _log = value; }
        }


        [InjectionMethod] // for methodes
        public void SetRepository(IRepository repository)
        {
            _repository = repository;
        }

        public bool RecoredInvoice(Invoice invoice) //Add Invoice
        {
            _log.LogError("");

           return _repository.Create<Invoice>(invoice);

            //throw new NotImplementedException();
        }
    }
}
