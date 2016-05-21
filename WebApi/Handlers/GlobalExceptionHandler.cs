using System.Configuration;
using System.Web.Http.ExceptionHandling;
using Blaze.Services.User.WebApi.Results;

namespace Blaze.Services.User.WebApi.Handlers
{
    /// <summary>
    /// Global exception delegate handler.
    /// </summary>
    public class GlobalExceptionHandler : ExceptionHandler
    {
        public const string GlobalExceptionHandlerEnabledConfigKey = "GlobalExceptionHandlerEnabled";
        public const string DefaultMessage = "We apologize, but an unexpected exception has occurred. Please try your request again.";

        /// <summary>
        /// Handles the exception synchronously.
        /// </summary>
        /// <param name="context"></param>
        public override void Handle(ExceptionHandlerContext context)
        {
            context.Result = new TextPlainErrorResult
            {
                Request = context.ExceptionContext.Request,
                Content = DefaultMessage
            };
        }

        /// <summary>
        ///Determines whether the exception should be handled.
        /// </summary>
        /// <param name="context">The exception handler context.</param>
        /// <returns>true if the exception should be handled; otherwise false.</returns>
        public override bool ShouldHandle(ExceptionHandlerContext context)
        {
            bool shouldHandle;
            if (bool.TryParse(ConfigurationManager.AppSettings[GlobalExceptionHandlerEnabledConfigKey], out shouldHandle))
            {
                return shouldHandle;
            }

            return true;
        }
    }
}