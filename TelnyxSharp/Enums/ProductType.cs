using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the different types of products available in the Telnyx system.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<ProductType>))]
    public enum ProductType
    {
        /// <summary>
        /// Represents the Call Control product type.
        /// </summary>
        [JsonStringEnumMemberName("call_control")]
        CallControl,

        /// <summary>
        /// Represents the Fax product type.
        /// </summary>
        [JsonStringEnumMemberName("fax")]
        Fax,

        /// <summary>
        /// Represents the Texml product type.
        /// </summary>
        [JsonStringEnumMemberName("texml")]
        Texml
    }
}
