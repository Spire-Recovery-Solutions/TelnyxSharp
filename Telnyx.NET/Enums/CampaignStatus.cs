using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the different campaign statuses for Telnyx 10DLC campaigns.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CampaignStatus
    {
        /// <summary>
        /// The campaign is pending with TCR (The Campaign Registry).
        /// </summary>
        [JsonPropertyName("TCR_PENDING")]
        TcrPending,

        /// <summary>
        /// The campaign has been suspended by TCR.
        /// </summary>
        [JsonPropertyName("TCR_SUSPENDED")]
        TcrSuspended,

        /// <summary>
        /// The campaign has expired in TCR.
        /// </summary>
        [JsonPropertyName("TCR_EXPIRED")]
        TcrExpired,

        /// <summary>
        /// The campaign has been accepted by TCR.
        /// </summary>
        [JsonPropertyName("TCR_ACCEPTED")]
        TcrAccepted,

        /// <summary>
        /// The campaign has failed in TCR.
        /// </summary>
        [JsonPropertyName("TCR_FAILED")]
        TcrFailed,

        /// <summary>
        /// The campaign has been accepted by Telnyx.
        /// </summary>
        [JsonPropertyName("TELNYX_ACCEPTED")]
        TelnyxAccepted,

        /// <summary>
        /// The campaign has failed in Telnyx.
        /// </summary>
        [JsonPropertyName("TELNYX_FAILED")]
        TelnyxFailed,

        /// <summary>
        /// The campaign is pending with the Mobile Network Operator (MNO).
        /// </summary>
        [JsonPropertyName("MNO_PENDING")]
        MnoPending,

        /// <summary>
        /// The campaign has been accepted by the MNO.
        /// </summary>
        [JsonPropertyName("MNO_ACCEPTED")]
        MnoAccepted,

        /// <summary>
        /// The campaign has been rejected by the MNO.
        /// </summary>
        [JsonPropertyName("MNO_REJECTED")]
        MnoRejected,

        /// <summary>
        /// The campaign has been provisioned by the MNO.
        /// </summary>
        [JsonPropertyName("MNO_PROVISIONED")]
        MnoProvisioned,

        /// <summary>
        /// The campaign failed provisioning with the MNO.
        /// </summary>
        [JsonPropertyName("MNO_PROVISIONING_FAILED")]
        MnoProvisioningFailed
    }
}