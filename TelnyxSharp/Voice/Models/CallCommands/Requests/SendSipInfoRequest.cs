using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to send SIP (Session Initiation Protocol) information during a call.
    /// </summary>
    public class SendSipInfoRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the content type of the SIP information.
        /// This defines the type of content being sent, such as 'application/sdp'.
        /// </summary>
        [JsonPropertyName("content_type")]
        public required string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the body of the SIP information.
        /// This contains the actual content to be transmitted in the SIP message.
        /// </summary>
        [JsonPropertyName("body")]
        public required string Body { get; set; }

        /// <summary>
        /// Gets or sets the client state associated with the SIP info send request.
        /// This can be used to track the state of the request from the client's perspective.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the unique command ID for the SIP info send request.
        /// This ID can be used for tracking and managing multiple requests.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}