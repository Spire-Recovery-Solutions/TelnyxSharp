using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for starting SIP recording (SIPREC).
    /// </summary>
    public class SiprecStartResponse : TelnyxResponse<SiprecStartData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for starting SIP recording (SIPREC).
    /// </summary>
    public class SiprecStartData
    {
        /// <summary>
        /// Gets or sets the result of the SIP recording start operation.
        /// This field provides the status or result of starting SIPREC.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}