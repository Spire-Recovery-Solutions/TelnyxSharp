using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.SharedCampaign.Responses
{
    public class GetSharingStatusResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the ID of the downstream campaign number provider.
        /// </summary>
        [JsonPropertyName("downstreamCnpId")]
        public string? DownstreamCnpId { get; set; }

        /// <summary>
        /// Gets or sets the date when the sharing occurred.
        /// </summary>
        [JsonPropertyName("sharedDate")]
        public string? SharedDate { get; set; }

        /// <summary>
        /// Gets or sets the current status of the sharing process.
        /// </summary>
        [JsonPropertyName("sharingStatus")]
        public string? SharingStatus { get; set; }

        /// <summary>
        /// Gets or sets the date when the sharing status was last updated.
        /// </summary>
        [JsonPropertyName("statusDate")]
        public string? StatusDate { get; set; }

        /// <summary>
        /// Gets or sets the ID of the upstream campaign number provider.
        /// </summary>
        [JsonPropertyName("upstreamCnpId")]
        public string? UpstreamCnpId { get; set; }

        /// <summary>
        /// Represents any validation errors encountered during the sharing status retrieval.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }
}
