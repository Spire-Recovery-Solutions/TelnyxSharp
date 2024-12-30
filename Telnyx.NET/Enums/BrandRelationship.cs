using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    public enum BrandRelationship
    {
        [JsonPropertyName("UNKNOWN")]
        Unknown,

        [JsonPropertyName("BASIC_ACCOUNT")]
        BasicAccount,

        [JsonPropertyName("SMALL_ACCOUNT")]
        SmallAccount,

        [JsonPropertyName("MEDIUM_ACCOUNT")]
        MediumAccount,

        [JsonPropertyName("LARGE_ACCOUNT")]
        LargeAccount,

        [JsonPropertyName("KEY_ACCOUNT")]
        KeyAccount
    }
}