using System.Text.Json.Serialization;

namespace TelnyxSharp.Messaging.Models
{
    /// <summary>
    /// Represents details about a validation error that occurred during an API request.
    /// This model contains information about the location of the error, a message explaining the error, 
    /// and the type of error that occurred.
    /// </summary>
    public class ValidationErrorDetail
    {
        /// <summary>
        /// Gets or sets the location where the error occurred. 
        /// This can represent the specific field or section of the request that caused the error.
        /// </summary>
        [JsonPropertyName("loc")]
        public List<string> Location { get; set; } = new();

        /// <summary>
        /// Gets or sets the error message explaining what went wrong.
        /// This provides a description of the validation issue.
        /// </summary>
        [JsonPropertyName("msg")]
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of error that occurred. 
        /// This can provide a classification or category for the error.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
    }
}