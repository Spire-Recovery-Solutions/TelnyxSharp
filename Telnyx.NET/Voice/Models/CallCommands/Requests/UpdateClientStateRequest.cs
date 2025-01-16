using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to update the client state for a call.
    /// This class allows you to specify a new client state to be associated with the call.
    /// </summary>
    public class UpdateClientStateRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the new client state for the call.
        /// This property is required and is used to update the client state.
        /// </summary>
        [JsonPropertyName("client_state")]
        public required string ClientState { get; set; }
    }
}