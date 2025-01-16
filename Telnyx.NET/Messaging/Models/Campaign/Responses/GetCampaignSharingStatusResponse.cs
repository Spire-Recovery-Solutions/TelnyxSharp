using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.Campaign.Responses
{
    /// <summary>
    /// Represents the response to a request for campaign sharing status, including details about sharing
    /// status both from and with the current user, and any validation errors encountered.
    /// </summary>
    public class GetCampaignSharingStatusResponse : TelnyxResponse
    {
        /// <summary>
        /// Details about the sharing status when shared by the current user.
        /// Nullable to accommodate scenarios where no sharing details are available.
        /// </summary>
        [JsonPropertyName("sharedByMe")]
        public SharingStatusDetail? SharedByMe { get; set; }

        /// <summary>
        /// Details about the sharing status when shared with the current user.
        /// Nullable to accommodate scenarios where no sharing details are available.
        /// </summary>
        [JsonPropertyName("sharedWithMe")]
        public SharingStatusDetail? SharedWithMe { get; set; }

        /// <summary>
        /// Represents any errors encountered during the retrieval of the sharing status details.
        /// Nullable to handle cases where there are no errors.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }

    /// <summary>
    /// Represents the details of a sharing status, including information on the downstream and upstream
    /// identifiers, sharing status, and relevant dates.
    /// </summary>
    public class SharingStatusDetail
    {
        /// <summary>
        /// The downstream CNP (Campaign Number Pool) ID.
        /// </summary>
        [JsonPropertyName("downstreamCnpId")]
        public string DownstreamCnpId { get; set; } = string.Empty;

        /// <summary>
        /// The date when the sharing occurred.
        /// </summary>
        [JsonPropertyName("sharedDate")]
        public string SharedDate { get; set; } = string.Empty;

        /// <summary>
        /// The current sharing status.
        /// </summary>
        [JsonPropertyName("sharingStatus")]
        public string SharingStatus { get; set; } = string.Empty;

        /// <summary>
        /// The date when the sharing status was last updated.
        /// </summary>
        [JsonPropertyName("statusDate")]
        public string StatusDate { get; set; } = string.Empty;

        /// <summary>
        /// The upstream CNP ID associated with the sharing status.
        /// </summary>
        [JsonPropertyName("upstreamCnpId")]
        public string UpstreamCnpId { get; set; } = string.Empty;
    }
}