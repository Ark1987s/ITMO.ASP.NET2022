using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Lab07
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            Application["Visitors"] = 0;
            // Код, выполняемый при запуске приложения
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        void Session_Start(object sender, EventArgs e)
        {
            // Код, выполняемый при запуске нового сеанса
            // Increment Visitors counter
            Application["Visitors"] = long.Parse(Application["Visitors"].ToString()) + 1;
            }
        }
}