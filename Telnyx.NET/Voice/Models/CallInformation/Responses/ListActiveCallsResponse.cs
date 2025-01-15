using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallInformation.Responses
{
    /// <summary>
    /// Represents the response containing a list of active calls for a specific connection.
    /// Inherits from <see cref="TelnyxResponse{T}"/> with a list of <see cref="ListActiveCallsData"/>.
    /// </summary>
    public class ListActiveCallsResponse : TelnyxResponse<List<ListActiveCallsData>>
    {
    }

    /// <summary>
    /// Represents the data of a single active call, including key details like session ID, call control ID, and duration.
    /// </summary>
    public class ListActiveCallsData
    {
        /// <summary>
        /// Gets or sets the record type, which is always set to "call" for active call data.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = "call";

        /// <summary>
        /// Gets or sets the call session ID, which uniquely identifies the call session.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string CallSessionId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the call leg ID, which uniquely identifies a specific call leg within a session.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string CallLegId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the call control ID, which uniquely identifies the call control.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string CallControlId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the client state, representing the state of the client in relation to the active call.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string ClientState { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the call duration in seconds.
        /// </summary>
        [JsonPropertyName("call_duration")]
        public int CallDuration { get; set; }
    }

    /// <summary>
    /// Represents the cursors used for pagination in the active calls response.
    /// </summary>
    public class ActiveCallsMetaCursors
    {
        /// <summary>
        /// Gets or sets the cursor to retrieve the next page of results, if available.
        /// </summary>
        [JsonPropertyName("after")]
        public string? After { get; set; }

        /// <summary>
        /// Gets or sets the cursor to retrieve the previous page of results, if available.
        /// </summary>
        [JsonPropertyName("before")]
        public string? Before { get; set; }
    }

    /// <summary>
    /// Represents the metadata for active calls, including pagination information and total number of items.
    /// Inherits from <see cref="PaginationMeta"/>.
    /// </summary>
    public class ActiveCallsMeta : PaginationMeta
    {
        /// <summary>
        /// Gets or sets the pagination cursors for navigating between pages of active calls.
        /// </summary>
        [JsonPropertyName("cursors")]
        public ActiveCallsMetaCursors? Cursors { get; set; }

        /// <summary>
        /// Gets or sets the total number of items available for the active calls.
        /// </summary>
        [JsonPropertyName("total_items")]
        public int TotalItems { get; set; }

        /// <summary>
        /// Gets or sets the cursor for the next page of active calls, if available.
        /// </summary>
        [JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Gets or sets the cursor for the previous page of active calls, if available.
        /// </summary>
        [JsonPropertyName("previous")]
        public string? Previous { get; set; }
    }
}