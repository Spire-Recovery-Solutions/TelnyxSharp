using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for a send DTMF (Dual-tone multi-frequency) operation.
    /// </summary>
    public class SendDtmfResponse : TelnyxResponse<SendDtmfData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for a send DTMF operation.
    /// </summary>
    public class SendDtmfData
    {
        /// <summary>
        /// Gets or sets the result of the send DTMF operation.
        /// This field provides the status or result of the operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}