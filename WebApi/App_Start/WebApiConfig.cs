using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using Blaze.Services.User.WebApi.Handlers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Blaze.Services.User.WebApi
{
    /// <summary>
    /// WebApi configuration.
    /// </summary>
    public class WebApiConfig
    {
        /// <summary>
        /// Configure the WebApi settings.
        /// </summary>
        /// <param name="config"></param>
        public static void Configure(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApiRoute",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler());
            config.Services.Add(typeof(IExceptionLogger), new GlobalExceptionLogger());

            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            config.Formatters.JsonFormatter.SerializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            config.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new StringEnumConverter()); //Serialize enums to strings instead of numeric values.
        }
    }
}