using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the Telnyx product a Terms of Service agreement applies to.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<TosProductType>))]
    public enum TosProductType
    {
        /// <summary>
        /// The Branded Calling product.
        /// </summary>
        [JsonStringEnumMemberName("branded_calling")]
        BrandedCalling,

        /// <summary>
        /// The Phone Number Reputation product.
        /// </summary>
        [JsonStringEnumMemberName("number_reputation")]
        NumberReputation
    }
}
