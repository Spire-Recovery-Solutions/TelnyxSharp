using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for a SIP REFER operation.
    /// </summary>
    public class SipReferResponse : TelnyxResponse<SipReferData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for a SIP REFER operation.
    /// </summary>
    public class SipReferData
    {
        /// <summary>
        /// Gets or sets the result of the SIP REFER operation.
        /// This field indicates the status or result of executing the SIP REFER command.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}