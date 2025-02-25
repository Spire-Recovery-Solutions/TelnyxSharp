using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents the different types of features available for a phone number.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FeatureType
    {
        /// <summary>
        /// Short Message Service (SMS) feature.
        /// </summary>
        Sms,

        /// <summary>
        /// Multimedia Messaging Service (MMS) feature.
        /// </summary>
        Mms,

        /// <summary>
        /// Voice call feature.
        /// </summary>
        Voice,

        /// <summary>
        /// Fax communication feature.
        /// </summary>
        Fax,

        /// <summary>
        /// Emergency services feature.
        /// </summary>
        Emergency
    }
}