using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Messaging.Models.Campaign
{
    public class GetCampaignCostRequest : ITelnyxRequest
    {
        /// <summary>
        /// The use case for the campaign. This is a required field.
        /// </summary>
        [JsonPropertyName("usecase")]
        public required string UseCase { get; set; }
    }
}
