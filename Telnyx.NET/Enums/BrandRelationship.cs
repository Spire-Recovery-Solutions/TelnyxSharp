using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BrandRelationship
    {
        Unknown,
        BASIC_ACCOUNT,
        SMALL_ACCOUNT,
        MEDIUM_ACCOUNT,
        LARGE_ACCOUNT,
        KEY_ACCOUNT
    }
}
