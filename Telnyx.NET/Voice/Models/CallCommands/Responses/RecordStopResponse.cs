using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for a record stop operation.
    /// </summary>
    public class RecordStopResponse : TelnyxResponse<RecordStopData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for a record stop operation.
    /// </summary>
    public class RecordStopData
    {
        /// <summary>
        /// Gets or sets the result of the record stop operation.
        /// This field provides the status or result of the operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}