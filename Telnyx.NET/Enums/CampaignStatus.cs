using System.Text.Json.Serialization;
using Telnyx.NET.Converters;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the different campaign statuses for Telnyx 10DLC campaigns.
    /// </summary>
    [JsonConverter(typeof(CampaignStatusConverter))]
    public enum CampaignStatus
    {
       /// <summary>
        /// The campaign is pending with TCR (The Campaign Registry).
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("TCR_PENDING")]
        TcrPending,

        /// <summary>
        /// The campaign has been suspended by TCR.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("TCR_SUSPENDED")]
        TcrSuspended,

        /// <summary>
        /// The campaign has expired in TCR.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("TCR_EXPIRED")]
        TcrExpired,

        /// <summary>
        /// The campaign has been accepted by TCR.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("TCR_ACCEPTED")]
        TcrAccepted,

        /// <summary>
        /// The campaign has failed in TCR.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("TCR_FAILED")]
        TcrFailed,

        /// <summary>
        /// The campaign has been accepted by Telnyx.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("TELNYX_ACCEPTED")]
        TelnyxAccepted,

        /// <summary>
        /// The campaign has failed in Telnyx.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("TELNYX_FAILED")]
        TelnyxFailed,

        /// <summary>
        /// The campaign is pending with the Mobile Network Operator (MNO).
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("MNO_PENDING")]
        MnoPending,

        /// <summary>
        /// The campaign has been accepted by the MNO.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("MNO_ACCEPTED")]
        MnoAccepted,

        /// <summary>
        /// The campaign has been rejected by the MNO.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("MNO_REJECTED")]
        MnoRejected,

        /// <summary>
        /// The campaign has been provisioned by the MNO.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("MNO_PROVISIONED")]
        MnoProvisioned,

        /// <summary>
        /// The campaign failed provisioning with the MNO.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("MNO_PROVISIONING_FAILED")]
        MnoProvisioningFailed
    }
}