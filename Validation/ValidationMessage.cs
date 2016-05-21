namespace Blaze.Services.User.Validation
{
    /// <summary>
    /// Represents validation messages.
    /// </summary>
    public class ValidationMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationMessage"/> class.
        /// </summary>
        public ValidationMessage()
            : this(null, null, null, ValidationMessageType.Error)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationMessage"/> class.
        /// </summary>
        /// <param name="message">The validation message.</param>
        public ValidationMessage(string message)
            : this(null, null, message, ValidationMessageType.Error)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationMessage"/> class.
        /// </summary>
        /// <param name="property">The name of the property.</param>
        /// <param name="message">The validation message.</param>
        public ValidationMessage(string property, string message)
            : this(property, null, message, ValidationMessageType.Error)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationMessage"/> class.
        /// </summary>
        /// <param name="property">The name of the property.</param>
        /// <param name="code">The validation code.</param>
        /// <param name="message">The validation message.</param>
        public ValidationMessage(string property, string code, string message)
            : this(property, code, message, ValidationMessageType.Error)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationMessage"/> class.
        /// </summary>
        /// <param name="property">The name of the property.</param>
        /// <param name="message">The validation message.</param>
        /// <param name="messageType">The message type.</param>
        public ValidationMessage(string property, string message, ValidationMessageType messageType)
            : this(property, null, message, messageType)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationMessage"/> class.
        /// </summary>
        /// <param name="property">The name of the property.</param>
        /// <param name="code">The validation code.</param>
        /// <param name="message">The validation message.</param>
        /// <param name="messageType">The message type.</param>
        public ValidationMessage(string property, string code, string message, ValidationMessageType messageType)
        {
            this.Property = property;
            this.Code = code;
            this.Message = message;
            this.MessageType = messageType;
        }

        /// <summary>
        /// Gets or sets the name of the property.
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// Gets or sets the validation code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the validation message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the message type.
        /// </summary>
        public ValidationMessageType MessageType { get; set; }

        /// <summary>
        /// Creates a textual representation of the validation error.
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0} for Property {1}; Code:{2}, Message:{3}", this.MessageType, this.Property, this.Code, this.Message);
        }
    }
}
