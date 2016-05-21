using System;
using System.Web;
using System.Web.Http;

namespace Blaze.Services.User.WebApi
{
    /// <summary>
    /// Web Application Class.
    /// </summary>
    public class Global : HttpApplication
    {
        /// <summary>
        /// Application Start.
        /// </summary>
        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Configure);
        }
    }
}