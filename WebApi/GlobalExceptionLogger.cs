using System.Web.Http.ExceptionHandling;
using Common.Logging;

namespace Blaze.Services.User.WebApi
{
    /// <summary>
    /// Represents an unhandled exception logger.
    /// </summary>
    public class GlobalExceptionLogger : ExceptionLogger
    {
        /// <summary>
        /// Logs the exception synchronously.
        /// </summary>
        /// <param name="context">The exception logger context.</param>
        public override void Log(ExceptionLoggerContext context)
        {
            var controllerContext = context.ExceptionContext.ControllerContext;
            var actionContext = context.ExceptionContext.ActionContext;

            var message = string.Format("A fatal error occurred while invoking the {0} Controller and {1} Action. {2}",
                controllerContext?.ControllerDescriptor != null ? controllerContext.ControllerDescriptor.ControllerName : "Unknown",
                actionContext?.ActionDescriptor != null ? actionContext.ActionDescriptor.ActionName : "Unknown",
                context.ExceptionContext.Exception.ToString());

            LogManager.GetLogger(this.GetType()).Fatal(message);
        }

        /// <summary>
        /// Determines whether the exception should be logged.
        /// </summary>
        /// <param name="context">The exception logger context.</param>
        /// <returns>true if the exception should be logged; otherwise false.</returns>
        public override bool ShouldLog(ExceptionLoggerContext context)
        {
            return base.ShouldLog(context);
        }
    }
}