using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for a send SIP info operation.
    /// </summary>
    public class SendSipInfoResponse : TelnyxResponse<SendSipInfoData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for a send SIP info operation.
    /// </summary>
    public class SendSipInfoData
    {
        /// <summary>
        /// Gets or sets the result of the send SIP info operation.
        /// This field provides the status or result of the operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}