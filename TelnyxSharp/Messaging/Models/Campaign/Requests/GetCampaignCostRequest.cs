using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.Campaign.Requests
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
