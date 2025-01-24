using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents the types of supporting documents that can be provided for port-out requests.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SupportingDocumentType
    {
        /// <summary>
        /// Letter of Authorization (LOA) document type, typically used to authorize the porting of a phone number.
        /// </summary>
        [JsonPropertyName("loa")]
        LOA,

        /// <summary>
        /// Invoice document type, typically used for verification or validation purposes during a port-out request.
        /// </summary>
        [JsonPropertyName("invoice")]
        Invoice
    }
}