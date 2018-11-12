using System.Web;
using System.Web.Mvc;

namespace INC.Web.MVC.Framework.Sample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
