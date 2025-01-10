using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for stopping SIP recording (SIPREC).
    /// </summary>
    public class SiprecStopResponse : TelnyxResponse<SiprecStopData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for stopping SIP recording (SIPREC).
    /// </summary>
    public class SiprecStopData
    {
        /// <summary>
        /// Gets or sets the result of the SIP recording stop operation.
        /// This field provides the status or result of stopping SIPREC.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}