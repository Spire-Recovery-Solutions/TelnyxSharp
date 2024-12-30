using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CampaignStatus
    {
        TCR_PENDING,
        TCR_SUSPENDED,
        TCR_EXPIRED,
        TCR_ACCEPTED,
        TCR_FAILED,
        TELNYX_ACCEPTED,
        TELNYX_FAILED,
        MNO_PENDING,
        MNO_ACCEPTED,
        MNO_REJECTED,
        MNO_PROVISIONED,
        MNO_PROVISIONING_FAILED
    }
}
