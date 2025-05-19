using System.Web.Mvc;

public class CustomAuthorizeAttribute : AuthorizeAttribute
{
    public override void OnAuthorization(AuthorizationContext filterContext)
    {
        var actionName = filterContext.ActionDescriptor.ActionName;
        var controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;

        if (controllerName == "Admin" && (actionName == "Login"))
        {
            return;
        }

        if (filterContext.HttpContext.Session["UserID"] == null)
        {
            filterContext.Result = new RedirectToRouteResult(
                new System.Web.Routing.RouteValueDictionary
                {
                    { "controller", "Admin" },
                    { "action", "Login" }
                });
        }
    }
}