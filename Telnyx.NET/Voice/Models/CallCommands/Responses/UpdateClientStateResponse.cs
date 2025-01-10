using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for updating the client state.
    /// </summary>
    public class UpdateClientStateResponse : TelnyxResponse<UpdateClientStateData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response after updating the client state.
    /// </summary>
    public class UpdateClientStateData
    {
        /// <summary>
        /// Gets or sets the result of the client state update operation.
        /// This field indicates the status or result of the update client state operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}