using System.Web.Http;

namespace Blaze.Services.User.WebApi.Controllers
{
    /// <summary>
    /// Echo controller.
    /// </summary>
    [AllowAnonymous]
    public class EchoController : ControllerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EchoController" /> class.
        /// </summary>
        public EchoController()
            : base()
        {
        }

        /// <summary>
        /// Echos the value provided.
        /// </summary>
        /// <param name="value">The value to echo.</param>
        /// <returns>The value provided.</returns>
        [Route(ApiRoute.Echo)]
        [HttpGet]
        public IHttpActionResult Get(string value)
        {
            return Ok(value);
        }
    }
}