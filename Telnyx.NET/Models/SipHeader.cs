using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents a SIP (Session Initiation Protocol) header used in call control operations.
    /// SIP headers provide essential information for managing SIP sessions and signaling.
    /// </summary>
    public class SipHeader
    {
        /// <summary>
        /// The name of the SIP header. This field specifies the type of header, 
        /// such as "To", "From", "Call-ID", etc.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The value associated with the SIP header. This field contains the data 
        /// that corresponds to the specified header name.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}