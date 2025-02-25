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
        sms,

        /// <summary>
        /// Multimedia Messaging Service (MMS) feature.
        /// </summary>
        mms,

        /// <summary>
        /// Voice call feature.
        /// </summary>
        voice,

        /// <summary>
        /// Fax communication feature.
        /// </summary>
        fax,

        /// <summary>
        /// Emergency services feature.
        /// </summary>
        emergency
    }
}