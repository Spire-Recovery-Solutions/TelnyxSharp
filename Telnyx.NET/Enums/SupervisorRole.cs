using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the possible supervisor roles in a conference call.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SupervisorRole
    {
        /// <summary>
        /// The supervisor can join the call and interact with the participants (e.g., interrupt the conversation).
        /// </summary>
        [JsonPropertyName("barge")]
        Barge,

        /// <summary>
        /// The supervisor can listen to the call but cannot interact with the participants.
        /// </summary>
        [JsonPropertyName("monitor")]
        Monitor,

        /// <summary>
        /// The supervisor has no special role or permissions during the call.
        /// </summary>
        [JsonPropertyName("none")]
        None,

        /// <summary>
        /// The supervisor can listen to the call and whisper instructions to a participant without others hearing.
        /// </summary>
        [JsonPropertyName("whisper")]
        Whisper
    }
}