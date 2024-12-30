using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageType
    {
        Unknown,

        [JsonPropertyName("long-code")]
        LongCode,

        [JsonPropertyName("toll-free")]
        TollFree,

        [JsonPropertyName("short-code")]
        ShortCode,

        [JsonPropertyName("longcode")]
        Longcode,

        [JsonPropertyName("tollfree")]
        Tollfree,

        [JsonPropertyName("shortcode")]
        Shortcode,

        [JsonPropertyName("SMS")]
        Sms,

        [JsonPropertyName("MMS")]
        Mms
    }
}
