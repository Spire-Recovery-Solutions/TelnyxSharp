using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the possible statuses of a conference.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<ConferenceStatus>))]
    public enum ConferenceStatus
    {
        /// <summary>
        /// The conference has been initialized but is not yet in progress.
        /// </summary>
        [JsonStringEnumMemberName("init")]
        Init,

        /// <summary>
        /// The conference is currently in progress.
        /// </summary>
        [JsonStringEnumMemberName("in_progress")]
        InProgress,

        /// <summary>
        /// The conference has been completed.
        /// </summary>
        [JsonStringEnumMemberName("completed")]
        Completed
    }
}