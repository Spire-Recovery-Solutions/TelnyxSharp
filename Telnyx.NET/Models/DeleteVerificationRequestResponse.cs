using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class DeleteVerificationRequestResponse : ITelnyxResponse
    {
        /// <summary>
        /// Represents any errors encountered during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }
}
