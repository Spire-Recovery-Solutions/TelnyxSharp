using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for retrieving a list of allowed FOC windows for a porting order.
    /// </summary>
    public class ListAllowedFocWindowsResponse : TelnyxResponse<List<FocWindow>>
    {
    }

    /// <summary>
    /// Represents a Firm Order Commitment (FOC) window.
    /// </summary>
    public class FocWindow
    {
        /// <summary>
        /// The start timestamp of the FOC window.
        /// </summary>
        [JsonPropertyName("started_at")]
        public DateTimeOffset? StartedAt { get; set; }

        /// <summary>
        /// The end timestamp of the FOC window.
        /// </summary>
        [JsonPropertyName("ended_at")]
        public DateTimeOffset? EndedAt { get; set; }

        /// <summary>
        /// The record type for this FOC window.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }
    }
}