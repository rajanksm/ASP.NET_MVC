using System.Web;
using System.Web.Mvc;

namespace MVC_ErrorHandling
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute
            {
                ExceptionType = typeof(System.Data.DataException),
                View = "Error"
            });
            filters.Add(new HandleErrorAttribute());
        }
    }
}
