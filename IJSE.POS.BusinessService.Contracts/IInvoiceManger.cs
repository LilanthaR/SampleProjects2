using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IJSE.POS.Common.Models;

namespace IJSE.POS.BusinessService.Contracts
{
    public interface IInvoiceManger
    {

        bool RecoredInvoice(Invoice invoice);

    }
}
