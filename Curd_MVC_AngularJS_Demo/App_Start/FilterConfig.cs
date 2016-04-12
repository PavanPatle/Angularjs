using System.Web;
using System.Web.Mvc;

namespace Curd_MVC_AngularJS_Demo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
