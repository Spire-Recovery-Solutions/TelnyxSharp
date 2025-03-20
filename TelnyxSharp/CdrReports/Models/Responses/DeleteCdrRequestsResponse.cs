using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.CdrReports.Models.Responses
{
    /// <summary>
    /// Represents the response from a DELETE CDR Request operation.
    /// </summary>
    public class DeleteCdrRequestsResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether the deletion was successful.
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets a message regarding the deletion operation.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
