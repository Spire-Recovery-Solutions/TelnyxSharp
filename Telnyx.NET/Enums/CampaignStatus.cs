using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CampaignStatus
    {
        [JsonPropertyName("TCR_PENDING")]
        TcrPending,

        [JsonPropertyName("TCR_SUSPENDED")]
        TcrSuspended,

        [JsonPropertyName("TCR_EXPIRED")]
        TcrExpired,

        [JsonPropertyName("TCR_ACCEPTED")]
        TcrAccepted,

        [JsonPropertyName("TCR_FAILED")]
        TcrFailed,

        [JsonPropertyName("TELNYX_ACCEPTED")]
        TelnyxAccepted,

        [JsonPropertyName("TELNYX_FAILED")]
        TelnyxFailed,

        [JsonPropertyName("MNO_PENDING")]
        MnoPending,

        [JsonPropertyName("MNO_ACCEPTED")]
        MnoAccepted,

        [JsonPropertyName("MNO_REJECTED")]
        MnoRejected,

        [JsonPropertyName("MNO_PROVISIONED")]
        MnoProvisioned,

        [JsonPropertyName("MNO_PROVISIONING_FAILED")]
        MnoProvisioningFailed
    }
}