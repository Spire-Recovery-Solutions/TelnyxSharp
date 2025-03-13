using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.NumberPortout.Requests
{
    /// <summary>
    /// Represents a request to create a comment for a port-out.
    /// This request includes the content of the comment to be added.
    /// </summary>
    public class CreatePortoutCommentRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the content of the comment to be added to the port-out.
        /// </summary>
        [JsonPropertyName("body")]
        public string? Body { get; set; }
    }
}