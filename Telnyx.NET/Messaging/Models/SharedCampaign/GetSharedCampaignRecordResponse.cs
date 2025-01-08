using System.Text.Json.Serialization;

namespace Telnyx.NET.Messaging.Models.SharedCampaign
{
    public class GetSharedCampaignRecordResponse : BaseSharedCampaigns
    {
        /// <summary>
        /// Represents any errors encountered during the retrieval of the auto-response setting.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }

    }
}
