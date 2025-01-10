using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for stopping a transcription operation.
    /// </summary>
    public class TranscriptionStopResponse : TelnyxResponse<TranscriptionStopData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for stopping a transcription operation.
    /// </summary>
    public class TranscriptionStopData
    {
        /// <summary>
        /// Gets or sets the result of the transcription stop operation.
        /// This field indicates the status or result of executing the stop transcription command.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}