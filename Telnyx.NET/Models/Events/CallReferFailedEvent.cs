using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event triggered when a call refer operation fails.
    /// This event provides details about the failure, such as the related call information
    /// and the SIP response indicating the cause of the failure.
    /// </summary>
    public class CallReferFailedEvent : BaseEvent
    {
        /// <summary>
        /// Contains detailed information about the call refer failure event.
        /// </summary>
        [JsonPropertyName("payload")]
        public CallReferFailedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a call refer failure event.
    /// </summary>
    public class CallReferFailedPayload
    {
        /// <summary>
        /// Gets or sets the unique identifier for call control actions.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string Call_control_id { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the specific leg of the call.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string Call_leg_id { get; set; }

        /// <summary>
        /// Gets or sets the unique session identifier for the call.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string Call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the connection associated with the call.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string Connection_id { get; set; }

        /// <summary>
        /// Gets or sets the custom client state for the call, if provided.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string Client_state { get; set; }

        /// <summary>
        /// Gets or sets the number or address of the call's originator.
        /// </summary>
        [JsonPropertyName("from")]
        public string From { get; set; }

        /// <summary>
        /// Gets or sets the SIP notify response code indicating the reason for the failure.
        /// </summary>
        [JsonPropertyName("sip_notify_response")]
        public int Sip_notify_response { get; set; }

        /// <summary>
        /// Gets or sets the number or address of the call's recipient.
        /// </summary>
        [JsonPropertyName("to")]
        public string To { get; set; }
    }
}