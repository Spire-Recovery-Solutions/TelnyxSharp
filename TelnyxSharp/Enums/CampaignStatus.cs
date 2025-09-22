using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the different campaign statuses for Telnyx 10DLC campaigns.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<CampaignStatus>))]
    public enum CampaignStatus
    {
        /// <summary>
        /// The campaign is pending with TCR (The Campaign Registry).
        /// </summary>
        [JsonStringEnumMemberName("TCR_PENDING")]
        TcrPending,

        /// <summary>
        /// The campaign has been suspended by TCR.
        /// </summary>
        [JsonStringEnumMemberName("TCR_SUSPENDED")]
        TcrSuspended,

        /// <summary>
        /// The campaign has expired in TCR.
        /// </summary>
        [JsonStringEnumMemberName("TCR_EXPIRED")]
        TcrExpired,

        /// <summary>
        /// The campaign has been accepted by TCR.
        /// </summary>
        [JsonStringEnumMemberName("TCR_ACCEPTED")]
        TcrAccepted,

        /// <summary>
        /// The campaign has failed in TCR.
        /// </summary>
        [JsonStringEnumMemberName("TCR_FAILED")]
        TcrFailed,

        /// <summary>
        /// The campaign has been accepted by Telnyx.
        /// </summary>
        [JsonStringEnumMemberName("TELNYX_ACCEPTED")]
        TelnyxAccepted,

        /// <summary>
        /// The campaign has failed in Telnyx.
        /// </summary>
        [JsonStringEnumMemberName("TELNYX_FAILED")]
        TelnyxFailed,

        /// <summary>
        /// The campaign is pending with the Mobile Network Operator (MNO).
        /// </summary>
        [JsonStringEnumMemberName("MNO_PENDING")]
        MnoPending,

        /// <summary>
        /// The campaign has been accepted by the MNO.
        /// </summary>
        [JsonStringEnumMemberName("MNO_ACCEPTED")]
        MnoAccepted,

        /// <summary>
        /// The campaign has been rejected by the MNO.
        /// </summary>
        [JsonStringEnumMemberName("MNO_REJECTED")]
        MnoRejected,

        /// <summary>
        /// The campaign has been provisioned by the MNO.
        /// </summary>
        [JsonStringEnumMemberName("MNO_PROVISIONED")]
        MnoProvisioned,

        /// <summary>
        /// The campaign failed provisioning with the MNO.
        /// </summary>
        [JsonStringEnumMemberName("MNO_PROVISIONING_FAILED")]
        MnoProvisioningFailed
    }
}