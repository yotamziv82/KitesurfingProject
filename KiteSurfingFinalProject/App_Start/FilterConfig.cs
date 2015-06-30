using System.Web;
using System.Web.Mvc;

namespace KiteSurfingFinalProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // This definitions are for application level - לחסום את כל הפרוייקט
            //filters.Add(new System.Web.Mvc.AuthorizeAttribute());
            //filters.Add(new RequireHttpsAttribute());
        }
    }
}
