using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Blaze.Services.User.WebApi.Results
{
    /// <summary>
    /// Represents an action result that returns a plain text <see cref="HttpStatusCode.InternalServerError"/> response.
    /// </summary>
    public class TextPlainErrorResult : IHttpActionResult
    {
        /// <summary>
        /// Gets or sets the <see cref="HttpRequestMessage"/>.
        /// </summary>
        public HttpRequestMessage Request { get; set; }

        /// <summary>
        /// Gets or sets the results content.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Creates an HttpResponseMessage asynchronously.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task that, when completed, contains the HttpResponseMessage.</returns>
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent(Content),
                RequestMessage = Request
            });
        }
    }
}