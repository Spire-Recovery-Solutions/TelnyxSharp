using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    // <summary>
    /// Enum representing possible phone number types.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PhoneNumberType
    {
        [JsonStringEnumMemberName("local")]
        Local,

        [JsonStringEnumMemberName("national")]
        National,

        [JsonStringEnumMemberName("toll_free")]
        TollFree,

        [JsonStringEnumMemberName("mobile")]
        Mobile,

        [JsonStringEnumMemberName("landline")]
        Landline,

        [JsonStringEnumMemberName("voip")]
        VoIP,

        [JsonStringEnumMemberName("shared_cost")]
        SharedCost
    }
}
