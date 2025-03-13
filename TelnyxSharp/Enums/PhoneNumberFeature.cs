using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the available features for a phone number.
    /// </summary>
    [JsonConverter(typeof(Converters.PhoneNumberFeatureConverter))]
    public enum PhoneNumberFeature
    {
        /// <summary>
        /// Short Message Service (SMS) support.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sms")]
        Sms,

        /// <summary>
        /// Multimedia Messaging Service (MMS) support.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("mms")]
        Mms,

        /// <summary>
        /// Voice calling support.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("voice")]
        Voice,

        /// <summary>
        /// Fax communication support.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("fax")]
        Fax,

        /// <summary>
        /// Emergency calling support.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("emergency")]
        Emergency,

        /// <summary>
        /// High-definition voice calling support.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("hd_voice")]
        HdVoice,

        /// <summary>
        /// International SMS messaging support.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("international_sms")]
        InternationalSms,

        /// <summary>
        /// Local calling support.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("local_calling")]
        LocalCalling
    }
}
