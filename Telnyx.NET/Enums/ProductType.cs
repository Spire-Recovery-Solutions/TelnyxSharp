using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents the different types of products available in the Telnyx system.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ProductType
    {
        /// <summary>
        /// Represents the Call Control product type.
        /// </summary>
        [JsonPropertyName("call_control")]
        CallControl,

        /// <summary>
        /// Represents the Fax product type.
        /// </summary>
        [JsonPropertyName("fax")]
        Fax,

        /// <summary>
        /// Represents the Texml product type.
        /// </summary>
        [JsonPropertyName("texml")]
        Texml
    }
}
