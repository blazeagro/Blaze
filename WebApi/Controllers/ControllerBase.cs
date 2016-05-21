using System.Web.Http;
using Common.Logging;

namespace Blaze.Services.User.WebApi.Controllers
{
    /// <summary>
    /// Base Controller for all Web APIs.
    /// </summary>
    public abstract class ControllerBase : ApiController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerBase" /> class.
        /// </summary>
        protected ControllerBase()
        {
            Log = LogManager.GetLogger(this.GetType());
        }

        /// <summary>
        /// The Log for this controller.
        /// </summary>
        protected ILog Log { get; private set; }
    }
}