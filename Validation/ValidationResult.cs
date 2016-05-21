using System;
using System.Collections.Generic;

namespace Blaze.Services.User.Validation
{
    /// <summary>
    /// Provides validation results.
    /// </summary>
    public class ValidationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult"/> class.
        /// </summary>
        public ValidationResult()
            : this(null, new List<ValidationMessage>())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult"/> class.
        /// </summary>
        /// <param name="index">Gets the index position of this result. This is only used on collections.</param>
        public ValidationResult(int? index)
            : this(index, new List<ValidationMessage>())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult"/> class.
        /// </summary>
        /// <param name="validationMessages">A list of <see cref="ValidationMessage"/>s.</param>
        public ValidationResult(List<ValidationMessage> validationMessages)
            : this(null, validationMessages)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult"/> class.
        /// </summary>
        /// <param name="index">Gets the index position of this result. This is only used on collections.</param>
        /// <param name="validationMessages">A list of <see cref="ValidationMessage"/>s.</param>
        public ValidationResult(int? index, List<ValidationMessage> validationMessages)
        {
            if (validationMessages == null)
            {
                throw new ArgumentNullException("validationMessages");
            }

            this.Index = index;
            this.Messages = validationMessages;
        }

        /// <summary>
        /// Gets the index position of this result. This is only used on collections.
        /// </summary>
        public int? Index { get; set; }

        /// <summary>
        /// Gets a list of validation messages.
        /// </summary>
        public List<ValidationMessage> Messages { get; private set; }
    }
}
