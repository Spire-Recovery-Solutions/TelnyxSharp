using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the types of supporting documents that can be provided for port-out requests.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<SupportingDocumentType>))]
    public enum SupportingDocumentType
    {
        /// <summary>
        /// Letter of Authorization (LOA) document type, typically used to authorize the porting of a phone number.
        /// </summary>
        Loa,

        /// <summary>
        /// Invoice document type, typically used for verification or validation purposes during a port-out request.
        /// </summary>
        Invoice
    }
}