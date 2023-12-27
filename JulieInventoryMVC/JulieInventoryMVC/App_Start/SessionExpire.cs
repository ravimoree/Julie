using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace JulieInventoryMVC.App_Start
{
    [SessionExpire(false)]
    public class SessionExpire : ActionFilterAttribute
    {
        public bool _IsLogin;
        public SessionExpire(bool IsLogin = true)
        {
            _IsLogin = IsLogin;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (_IsLogin)
            {
                if (HttpContext.Current.Session["UserId"] == null)
                {
                    FormsAuthentication.SignOut();
                    filterContext.Result =
             new RedirectToRouteResult(new RouteValueDictionary
                    {
                  { "action", "Login" },
            { "controller", "Account" },
            { "returnUrl", filterContext.HttpContext.Request.RawUrl}
                 });
                }
                return;
            }
        }
    }
}