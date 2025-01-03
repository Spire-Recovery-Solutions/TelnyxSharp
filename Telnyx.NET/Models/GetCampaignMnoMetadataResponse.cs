using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response containing metadata for a campaign's Mobile Network Operator (MNO).
    /// </summary>
    public class GetCampaignMnoMetadataResponse : TelnyxResponse
    {
        /// <summary>
        /// Metadata details associated with the specified MNO ID.
        /// </summary>
        [JsonPropertyName("10999")]
        public MnoMetadataDetail? Metadata { get; set; }

        /// <summary>
        /// List of errors, if any occurred during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents detailed metadata for a Mobile Network Operator (MNO) related to a campaign.
    /// </summary>
    public class MnoMetadataDetail
    {
        /// <summary>
        /// Indicates whether the MNO qualifies for the campaign.
        /// </summary>
        [JsonPropertyName("qualify")]
        public bool Qualify { get; set; }

        /// <summary>
        /// The name or identifier of the MNO.
        /// </summary>
        [JsonPropertyName("mno")]
        public string Mno { get; set; } = string.Empty;

        /// <summary>
        /// Indicates whether embedded links are prohibited by the MNO.
        /// </summary>
        [JsonPropertyName("noEmbeddedLink")]
        public bool NoEmbeddedLink { get; set; }

        /// <summary>
        /// Indicates whether the MNO requires subscriber help information.
        /// </summary>
        [JsonPropertyName("reqSubscriberHelp")]
        public bool ReqSubscriberHelp { get; set; }

        /// <summary>
        /// Indicates whether the MNO requires subscriber opt-out information.
        /// </summary>
        [JsonPropertyName("reqSubscriberOptout")]
        public bool ReqSubscriberOptout { get; set; }

        /// <summary>
        /// Indicates whether the campaign requires MNO review before approval.
        /// </summary>
        [JsonPropertyName("mnoReview")]
        public bool MnoReview { get; set; }

        /// <summary>
        /// Indicates whether embedded phone numbers are prohibited by the MNO.
        /// </summary>
        [JsonPropertyName("noEmbeddedPhone")]
        public bool NoEmbeddedPhone { get; set; }

        /// <summary>
        /// Indicates whether the MNO provides support for the campaign.
        /// </summary>
        [JsonPropertyName("mnoSupport")]
        public bool MnoSupport { get; set; }

        /// <summary>
        /// Indicates whether the MNO requires subscriber opt-in information.
        /// </summary>
        [JsonPropertyName("reqSubscriberOptin")]
        public bool ReqSubscriberOptin { get; set; }

        /// <summary>
        /// The minimum number of message samples required by the MNO.
        /// </summary>
        [JsonPropertyName("minMsgSamples")]
        public int MinMsgSamples { get; set; }
    }
}