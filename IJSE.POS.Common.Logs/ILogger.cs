using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJSE.POS.Common.Logs
{
    public interface ILogger
    {
        bool LogError(string err);
    }
}
