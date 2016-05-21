using System.Collections.Generic;
using System.Linq;
using Blaze.Services.User.Validation;
using Newtonsoft.Json;

namespace Blaze.Services.User.Business
{
    /// <summary>
    /// Represents an Api Response that provides a type safe implementation of the return value.
    /// </summary>
    /// <typeparam name="T">The type for the value to return.</typeparam>
    public class ApiResponse<T> : ApiResponse, IApiResponse<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse{T}"/> class.
        /// </summary>
        public ApiResponse()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse{T}"/> class.
        /// </summary>
        /// <param name="value">The type for the value to return.</param>
        [JsonConstructor]
        public ApiResponse(T value)
            : base()
        {
            this.Value = value;
        }

        /// <summary>
        /// The value to return.
        /// </summary>
        public virtual T Value { get; set; }
    }

    /// <summary>
    /// Represents an Api Response.
    /// </summary>
    public class ApiResponse : IApiResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse"/> class.
        /// </summary>
        public ApiResponse()
        {
            this.ValidationResults = new List<ValidationResult>();
        }

        /// <summary>
        /// Gets a list of validation results.
        /// </summary>
        public virtual List<ValidationResult> ValidationResults { get; private set; }

        /// <summary>
        /// Gets a value indicating if the result is valid. The result is considered valid if it does not
        /// contain any Validation Messages of type <see cref="ValidationMessageType.Error"/>.
        /// </summary>
        [JsonIgnore]
        public virtual bool IsValid
        {
            get
            {
                return !ContainsValidationMessageType(ValidationMessageType.Error);
            }
        }

        /// <summary>
        /// Gets a value indicating if the list of validation results contains any messages of the specified
        /// <see cref="ValidationMessageType"/>.
        /// </summary>
        /// <param name="validationMessageType">The <see cref="ValidationMessageType"/>.</param>
        /// <returns>true if the list of validation results contains any messages of the specified
        /// <see cref="ValidationMessageType"/>; otherwise false.</returns>
        public virtual bool ContainsValidationMessageType(ValidationMessageType validationMessageType)
        {
            return this.ValidationResults.Where(x => x.Messages.Any(y => y.MessageType == validationMessageType)).Any();
        }
    }
}
