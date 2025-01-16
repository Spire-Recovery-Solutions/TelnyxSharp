using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Messaging.Models.NumberConfigurations.Requests
{
    public class UpdateNumbersMessagingBulkRequest : ITelnyxRequest
    {
        /// <summary>
        /// The unique identifier for the messaging profile to assign to the phone numbers.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public required string MessagingProfileId { get; set; }

        /// <summary>
        /// The list of phone numbers to update.
        /// </summary>
        [JsonPropertyName("numbers")]
        public required List<string> Numbers { get; set; }
    }
}
