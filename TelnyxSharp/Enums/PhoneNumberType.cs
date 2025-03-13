using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    // <summary>
    /// Enum representing possible phone number types.
    /// </summary>
    [JsonConverter(typeof(Converters.PhoneNumberTypeConverter))]
    public enum PhoneNumberType
    {
        //NET9UNCOMMENT [JsonStringEnumMemberName("local")]
        Local,

        //NET9UNCOMMENT [JsonStringEnumMemberName("national")]
        National,

        //NET9UNCOMMENT [JsonStringEnumMemberName("toll_free")]
        TollFree,

        //NET9UNCOMMENT [JsonStringEnumMemberName("mobile")]
        Mobile,

        //NET9UNCOMMENT [JsonStringEnumMemberName("landline")]
        Landline,

        //NET9UNCOMMENT [JsonStringEnumMemberName("voip")]
        VoIP,

        //NET9UNCOMMENT [JsonStringEnumMemberName("shared_cost")]
        SharedCost
    }
}
