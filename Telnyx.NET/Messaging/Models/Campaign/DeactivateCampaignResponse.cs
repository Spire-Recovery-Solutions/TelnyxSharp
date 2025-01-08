using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.Campaign
{
    /// <summary>
    /// Represents the response for deactivating a campaign.
    /// </summary>
    public class DeactivateCampaignResponse : TelnyxResponse
    {
        /// <summary>
        /// The timestamp or duration associated with the response.
        /// </summary>
        [JsonPropertyName("time")]
        public int Time { get; set; }

        /// <summary>
        /// The type of record this response pertains to.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// A message providing additional context about the deactivation status.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// A list of detailed errors encountered during the process, if any.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }
}