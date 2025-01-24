using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.NumberPortout.Requests
{
    /// <summary>
    /// Represents a request to update the status of a port-out operation.
    /// This request allows you to provide a reason for changing the status of the port-out.
    /// </summary>
    public class UpdatePortoutStatusRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the reason for updating the port-out status.
        /// This is an optional field that provides context for the status change.
        /// </summary>
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
    }
}