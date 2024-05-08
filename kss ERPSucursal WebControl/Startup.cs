using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kss_ERPSucursal_WebControl.Startup))]
namespace kss_ERPSucursal_WebControl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
