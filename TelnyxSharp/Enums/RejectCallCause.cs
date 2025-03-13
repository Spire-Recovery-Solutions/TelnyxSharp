using System.Text.Json.Serialization;
using TelnyxSharp.Converters;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enumeration of possible causes for call rejection.
    /// </summary>
    [JsonConverter(typeof(RejectCallCauseConverter))]
    public enum RejectCallCause
    {
        /// <summary>
        /// Default unknown cause.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("UNKNOWN")]
        Unknown,

        /// <summary>
        /// Call was rejected.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("CALL_REJECTED")]
        CallRejected,

        /// <summary>
        /// User is busy.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("USER_BUSY")]
        UserBusy
    }
}
