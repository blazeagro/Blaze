using System.Collections.Generic;
using Blaze.Services.User.Validation;

namespace Blaze.Services.User.Business
{
    /// <summary>
    /// Interface for the Api Response that provides a type safe implementation of the return value.
    /// </summary>
    /// <typeparam name="T">The type for the value to return.</typeparam>
    public interface IApiResponse<T> : IApiResponse
    {
        /// <summary>
        /// The value to return.
        /// </summary>
        T Value { get; }
    }

    /// <summary>
    /// Interface for the Api Response.
    /// </summary>
    public interface IApiResponse
    {
        /// <summary>
        /// Gets a list of validation results.
        /// </summary>
        List<ValidationResult> ValidationResults { get; }

        /// <summary>
        /// Gets a value indicating if the response is valid.
        /// </summary>
        bool IsValid { get; }

        /// <summary>
        /// Gets a value indicating if the list of validation results contains any messages of the specified
        /// <see cref="ValidationMessageType"/>.
        /// </summary>
        /// <param name="validationMessageType">The <see cref="ValidationMessageType"/>.</param>
        /// <returns>true if the list of validation results contains any messages of the specified
        /// <see cref="ValidationMessageType"/>; otherwise false.</returns>
        bool ContainsValidationMessageType(ValidationMessageType validationMessageType);
    }
}
