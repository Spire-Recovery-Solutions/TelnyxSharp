using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for starting a transcription operation.
    /// </summary>
    public class TranscriptionStartResponse : TelnyxResponse<TranscriptionStartData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for starting a transcription operation.
    /// </summary>
    public class TranscriptionStartData
    {
        /// <summary>
        /// Gets or sets the result of the transcription start operation.
        /// This field indicates the status or result of executing the start transcription command.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}