using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Voice.Models.ConferenceCommands.Responses
{
    /// <summary>
    /// Represents the response for creating a conference.
    /// It contains details about the conference such as its ID, name, and timestamps.
    /// </summary>
    public class CreateConferenceResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the type of record for the conference (e.g., permanent or temporary).
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier for the conference.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the conference.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the creation timestamp of the conference.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the expiration timestamp of the conference.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public string ExpiresAt { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the last updated timestamp of the conference (nullable).
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the region associated with the conference (nullable).
        /// </summary>
        [JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Gets or sets the status of the conference (nullable).
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the reason why the conference ended (nullable).
        /// </summary>
        [JsonPropertyName("end_reason")]
        public string? EndReason { get; set; }

        /// <summary>
        /// Gets or sets the information about who ended the conference.
        /// </summary>
        [JsonPropertyName("ended_by")]
        public EndedBy? EndedBy { get; set; }

        /// <summary>
        /// Gets or sets the connection ID associated with the conference (nullable).
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }
    }

    /// <summary>
    /// Represents the entity that ended the conference.
    /// Contains identifiers for both the call control and call session.
    /// </summary>
    public class EndedBy
    {
        /// <summary>
        /// Gets or sets the call control ID for the entity that ended the conference (nullable).
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string? CallControlId { get; set; }

        /// <summary>
        /// Gets or sets the call session ID for the entity that ended the conference (nullable).
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string? CallSessionId { get; set; }
    }
}