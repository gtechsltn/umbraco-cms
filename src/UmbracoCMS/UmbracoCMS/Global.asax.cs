using System;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;

namespace UmbracoCMS
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_Error()
        {
            Exception exception = Server.GetLastError();
            Server.ClearError();

            Debug.WriteLine(exception);

            Response.Redirect("/Home/Error");
        }
    }
}