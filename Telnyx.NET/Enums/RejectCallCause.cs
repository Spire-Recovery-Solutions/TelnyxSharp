using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enumeration of possible causes for call rejection.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RejectCallCause
    {
        /// <summary>
        /// Default unknown cause.
        /// </summary>
        [JsonPropertyName("UNKNOWN")]
        Unknown,

        /// <summary>
        /// Call was rejected.
        /// </summary>
        [JsonPropertyName("CALL_REJECTED")]
        CallRejected,

        /// <summary>
        /// User is busy.
        /// </summary>
        [JsonPropertyName("USER_BUSY")]
        UserBusy
    }
}
