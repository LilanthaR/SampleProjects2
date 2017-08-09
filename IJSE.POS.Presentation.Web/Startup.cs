using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IJSE.POS.Presentation.Web.Startup))]
namespace IJSE.POS.Presentation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
