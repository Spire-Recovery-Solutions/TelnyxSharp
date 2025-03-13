using System.Text.Json.Serialization;
using TelnyxSharp.Enums;
using TelnyxSharp.Voice.Models.ConferenceCommands.Responses;

namespace TelnyxSharp.Voice.Models.ConferenceCommands
{
    /// <summary>
    /// Base class containing common conference data fields shared across multiple conference-related operations.
    /// </summary>
    public class BaseConferenceData
    {
        /// <summary>
        /// Specifies the type of the record; in this case, it's a "conference".
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = "conference";

        /// <summary>
        /// Unique identifier for the conference.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Name of the conference.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Timestamp indicating when the conference was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } = string.Empty;

        /// <summary>
        /// Timestamp indicating when the conference expires.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public string ExpiresAt { get; set; } = string.Empty;

        /// <summary>
        /// Timestamp indicating when the conference was last updated (if applicable).
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// The region where the conference is hosted.
        /// </summary>
        [JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// The current status of the conference.
        /// </summary>
        [JsonPropertyName("status")]
        public ConferenceStatus? Status { get; set; }

        /// <summary>
        /// Reason for the conference ending (if applicable).
        /// </summary>
        [JsonPropertyName("end_reason")]
        public string? EndReason { get; set; }

        /// <summary>
        /// Information about who ended the conference (if applicable).
        /// </summary>
        [JsonPropertyName("ended_by")]
        public EndedBy? EndedBy { get; set; }

        /// <summary>
        /// The connection ID associated with the conference.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }
    }
}