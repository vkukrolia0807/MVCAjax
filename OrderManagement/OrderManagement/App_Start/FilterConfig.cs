using System.Web;
using System.Web.Mvc;

namespace OrderManagement
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
    public class LoginFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if(HttpContext.Current.Session["id"]==null)
            {
                filterContext.Result = new RedirectResult("/Login/Login");
            }
        }
    }
}
