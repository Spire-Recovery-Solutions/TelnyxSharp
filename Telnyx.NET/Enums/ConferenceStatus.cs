using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the possible statuses of a conference.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ConferenceStatus
    {
        /// <summary>
        /// The conference has been initialized but is not yet in progress.
        /// </summary>
        [JsonPropertyName("init")]
        Init,

        /// <summary>
        /// The conference is currently in progress.
        /// </summary>
        [JsonPropertyName("in_progress")]
        InProgress,

        /// <summary>
        /// The conference has been completed.
        /// </summary>
        [JsonPropertyName("completed")]
        Completed
    }
}