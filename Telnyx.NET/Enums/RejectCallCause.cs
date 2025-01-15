using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enumeration of possible causes for call rejection.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<RejectCallCause>))]
    public enum RejectCallCause
    {
        UNKNOWN,
        CALL_REJECTED,
        USER_BUSY
    }
}
