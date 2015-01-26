using System.Web;
using System.Web.Mvc;

namespace MVC_Practic_Rizor
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}