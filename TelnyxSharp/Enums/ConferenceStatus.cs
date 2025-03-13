using System.Text.Json.Serialization;
using TelnyxSharp.Converters;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the possible statuses of a conference.
    /// </summary>
    [JsonConverter(typeof(ConferenceStatusConverter))]
    public enum ConferenceStatus
    {
       /// <summary>
        /// The conference has been initialized but is not yet in progress.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("init")]
        Init,

        /// <summary>
        /// The conference is currently in progress.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("in_progress")]
        InProgress,

        /// <summary>
        /// The conference has been completed.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("completed")]
        Completed
    }
}