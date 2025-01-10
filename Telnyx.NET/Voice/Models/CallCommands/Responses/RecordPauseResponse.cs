using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for a record pause operation.
    /// </summary>
    public class RecordPauseResponse : TelnyxResponse<RecordPauseData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for a record pause operation.
    /// </summary>
    public class RecordPauseData
    {
        /// <summary>
        /// Gets or sets the result of the record pause operation.
        /// This field provides the status or result of the operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}