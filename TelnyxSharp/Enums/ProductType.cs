using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the different types of products available in the Telnyx system.
    /// </summary>
    [JsonConverter(typeof(Converters.ProductTypeConverter))]
    public enum ProductType
    {
       /// <summary>
        /// Represents the Call Control product type.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("call_control")]
        CallControl,

        /// <summary>
        /// Represents the Fax product type.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("fax")]
        Fax,

        /// <summary>
        /// Represents the Texml product type.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("texml")]
        Texml
    }
}
