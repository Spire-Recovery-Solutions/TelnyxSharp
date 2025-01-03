using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    public class DeleteVerificationRequestResponse : TelnyxResponse
    {
        /// <summary>
        /// Represents any errors encountered during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }
}
