using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    // <summary>
    /// Enum representing possible phone number types.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PhoneNumberType
    {
        [JsonPropertyName("local")]
        Local,

        [JsonPropertyName("toll_free")]
        TollFree,

        [JsonPropertyName("mobile")]
        Mobile,

        [JsonPropertyName("voip")]
        VoIP
    }
}
