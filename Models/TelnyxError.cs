using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents an error returned by the Telnyx API.
    /// </summary>
    public class TelnyxError
    {
        /// <summary>
        /// The error code.
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }

        /// <summary>
        /// The title of the error.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Detailed description of the error.
        /// </summary>
        [JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional information about the source of the error.
        /// </summary>
        [JsonPropertyName("source")]
        public ErrorSource? Source { get; set; }

        /// <summary>
        /// Additional metadata about the error.
        /// </summary>
        [JsonPropertyName("meta")]
        public Dictionary<string, object>? Meta { get; set; }
    }

    /// <summary>
    /// Represents the source of an error in the Telnyx API response.
    /// </summary>
    public class ErrorSource
    {
        // Add properties as needed based on the actual error source structure
        // For example:
        [JsonPropertyName("pointer")]
        public string? Pointer { get; set; }

        /// <summary>
        /// Gets or sets the query parameter that caused the error.
        /// </summary>
        [JsonPropertyName("parameter")]
        public string Parameter { get; set; }
    }
}
