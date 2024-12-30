using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BrandIdentityStatus
    {
        VERIFIED,
        UNVERIFIED,
        SELF_DECLARED,
        VETTED_VERIFIED
    }
}
