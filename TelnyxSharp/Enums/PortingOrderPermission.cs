using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Specifies the permissions available for a porting order token.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PortingOrderPermission
    {
        /// <summary>
        /// Permission to read porting order documents.
        /// </summary>
        [JsonStringEnumMemberName("porting_order.document.read")]
        DocumentRead,

        /// <summary>
        /// Permission to update porting order documents.
        /// </summary>
        [JsonStringEnumMemberName("porting_order.document.update")]
        DocumentUpdate
    }
}