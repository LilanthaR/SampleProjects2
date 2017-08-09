using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Reflection;


namespace IJSE.POS.Service.WebAPI.DynamicCode
{
    public static class DynamicUtils
    {
       public static CustomAssemblyResolver AssemblyResolver = new CustomAssemblyResolver();

        public static void GenerateCode ()
        {
            DynamicCodeGen gen = new DynamicCodeGen("DynamicWebApiController");
            Assembly newAssembly = gen.CreateDll();
            
            AssemblyResolver.AddAssembly(newAssembly);

        }

    }
}