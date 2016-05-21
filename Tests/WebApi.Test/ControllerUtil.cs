using System.Net.Http;
using System.Web.Http;

namespace Blaze.Services.User.WebApi.Test
{
    public static class ControllerUtil
    {
        public static T SetupController<T>(ApiController controller) where T : ApiController
        {
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            return controller as T;
        }
    }
}
