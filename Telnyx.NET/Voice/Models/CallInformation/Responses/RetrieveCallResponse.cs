using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallInformation.Responses
{
    /// <summary>
    /// Represents the response to a call information retrieval request.
    /// Inherits from <see cref="TelnyxResponse{T}"/> with the data type being <see cref="RetrieveCallData"/>.
    /// </summary>
    public class RetrieveCallResponse : TelnyxResponse<RetrieveCallData>
    {
    }

    /// <summary>
    /// Contains detailed information about a specific call.
    /// This data is returned when retrieving call information by its control ID.
    /// </summary>
    public class RetrieveCallData
    {
        /// <summary>
        /// Gets or sets the record type. This will always be "call" for call-related records.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = "call";

        /// <summary>
        /// Gets or sets the unique identifier for the call session.
        /// This ID groups together related call legs.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string CallSessionId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier for the specific call leg.
        /// This represents a single instance or segment of a call.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string CallLegId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier for the call control.
        /// This is the identifier used to track the call's life cycle within the Telnyx system.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string CallControlId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether the call is still alive.
        /// True if the call is ongoing, false if the call has ended.
        /// </summary>
        [JsonPropertyName("is_alive")]
        public bool IsAlive { get; set; }

        /// <summary>
        /// Gets or sets the client state for the call, which is a custom field that may be used to track the state within the client's system.
        /// This can be null if no client state is set.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the duration of the call in seconds.
        /// This will be null if the call duration is not available.
        /// </summary>
        [JsonPropertyName("call_duration")]
        public int? CallDuration { get; set; }
    }
}