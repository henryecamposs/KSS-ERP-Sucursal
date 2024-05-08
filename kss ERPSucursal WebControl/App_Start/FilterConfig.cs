using System.Web;
using System.Web.Mvc;

namespace kss_ERPSucursal_WebControl
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
