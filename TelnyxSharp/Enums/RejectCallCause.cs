using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
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
        [JsonStringEnumMemberName("UNKNOWN")]
        Unknown,

        /// <summary>
        /// Call was rejected.
        /// </summary>
        [JsonStringEnumMemberName("CALL_REJECTED")]
        CallRejected,

        /// <summary>
        /// User is busy.
        /// </summary>
        [JsonStringEnumMemberName("USER_BUSY")]
        UserBusy
    }
}
