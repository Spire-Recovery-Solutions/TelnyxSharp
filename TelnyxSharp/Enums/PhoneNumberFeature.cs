using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the available features for a phone number.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<PhoneNumberFeature>))]
    public enum PhoneNumberFeature
    {
        /// <summary>
        /// Short Message Service (SMS) support.
        /// </summary>
        [JsonStringEnumMemberName("sms")]
        Sms,

        /// <summary>
        /// Multimedia Messaging Service (MMS) support.
        /// </summary>
        [JsonStringEnumMemberName("mms")]
        Mms,

        /// <summary>
        /// Voice calling support.
        /// </summary>
        [JsonStringEnumMemberName("voice")]
        Voice,

        /// <summary>
        /// Fax communication support.
        /// </summary>
        [JsonStringEnumMemberName("fax")]
        Fax,

        /// <summary>
        /// Emergency calling support.
        /// </summary>
        [JsonStringEnumMemberName("emergency")]
        Emergency,

        /// <summary>
        /// High-definition voice calling support.
        /// </summary>
        [JsonStringEnumMemberName("hd_voice")]
        HdVoice,

        /// <summary>
        /// International SMS messaging support.
        /// </summary>
        [JsonStringEnumMemberName("international_sms")]
        InternationalSms,

        /// <summary>
        /// Local calling support.
        /// </summary>
        [JsonStringEnumMemberName("local_calling")]
        LocalCalling
    }
}
