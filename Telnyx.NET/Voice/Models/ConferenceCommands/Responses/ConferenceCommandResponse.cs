using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.ConferenceCommands.Responses
{
    /// <summary>
    /// Represents the response to a conference command request.
    /// This class wraps the result data of the conference command.
    /// </summary>
    public class ConferenceCommandResponse : TelnyxResponse<ConferenceCommandData>
    {
    }

    /// <summary>
    /// Contains the data for the response of a conference command.
    /// This class includes the result of the command.
    /// </summary>
    public class ConferenceCommandData
    {
        /// <summary>
        /// Gets or sets the result of the conference command.
        /// This field indicates whether the command was successful or failed.
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; } = string.Empty;
    }
}