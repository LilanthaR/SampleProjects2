using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using System.Web.Http.Dispatcher;
using IJSE.POS.Service.WebAPI.DynamicCode;

namespace IJSE.POS.Service.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

          //  DynamicUtils.GenerateCode();

            // change the defult to our custome code
           // GlobalConfiguration.Configuration.Services.Replace(typeof(IAssembliesResolver), new DynamicCode.CustomAssemblyResolver());
        }
    }
}
