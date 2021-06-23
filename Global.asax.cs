 
using System;
 
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Web;
 
using System.Web.Optimization;
using System.Web.Routing;

namespace TestAzureAD
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
         }

        protected void Application_PostAuthenticateRequest(object sender, EventArgs e)
        {

        //    if (Request.IsAuthenticated)
        //    {

        //        ClaimsPrincipal principal = new ClaimsPrincipal(User.Identity);

        //        var identity = (ClaimsIdentity)principal.Identity;

        //        foreach (Claim claim in ClaimsPrincipal.Current.FindAll("groups"))
        //        {
        //            var groupStringValue = System.Configuration.ConfigurationManager.AppSettings[claim.Value];
        //            if (groupStringValue != null)
        //            {
        //                identity.AddClaim(new Claim(ClaimTypes.Role, groupStringValue));
        //            }
        //        }

        //        Thread.CurrentPrincipal = HttpContext.Current.User = principal;
        //    }

        }

    }
}