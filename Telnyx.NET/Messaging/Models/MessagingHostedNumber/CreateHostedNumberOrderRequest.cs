using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Messaging.Models.MessagingHostedNumber
{
    public class CreateHostedNumberOrderRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the phone numbers to be used for hosted messaging.
        /// </summary>
        /// <remarks>
        /// The phone numbers must be in E.164 format.
        /// </remarks>
        [JsonPropertyName("phone_numbers")]
        public List<string>? PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or sets the messaging profile ID to associate with the order.
        /// </summary>
        /// <remarks>
        /// This ID will automatically associate the numbers with the specified messaging profile once the order is complete.
        /// </remarks>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }
    }
}
