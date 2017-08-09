using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Reflection;
using System.Web.Http.Dispatcher;

namespace IJSE.POS.Service.WebAPI.DynamicCode
{
    public class CustomAssemblyResolver :DefaultAssembliesResolver
    {

        public void AddAssembly(Assembly newAssembly)
        {
            ICollection<Assembly> baseAssemblies = base.GetAssemblies();
            List<Assembly> assemblies = new List<Assembly>(baseAssemblies);

            if (newAssembly != null)
            {
                assemblies.Add(newAssembly);
            }
        }

        public override ICollection<Assembly> GetAssemblies()
        {
            ICollection<Assembly> baseAssemblies = base.GetAssemblies();
            List<Assembly> assemblies = new List<Assembly>(baseAssemblies);            
           

            return assemblies;
        }
    }
}