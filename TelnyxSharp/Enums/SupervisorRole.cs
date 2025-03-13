﻿using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
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
        //NET9UNCOMMENT [JsonStringEnumMemberName("barge")]
        Barge,

        /// <summary>
        /// The supervisor can listen to the call but cannot interact with the participants.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("monitor")]
        Monitor,

        /// <summary>
        /// The supervisor has no special role or permissions during the call.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("none")]
        None,

        /// <summary>
        /// The supervisor can listen to the call and whisper instructions to a participant without others hearing.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("whisper")]
        Whisper
    }
}