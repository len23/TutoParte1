using System.Web;
using System.Web.Mvc;

namespace SitioWebCompletoParte_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
