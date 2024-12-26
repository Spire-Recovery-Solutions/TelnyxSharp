using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class UpdateVerificationRequestResponse : BaseVerificationRequestResponse, ITelnyxResponse
    {
         /// <summary>
        /// Gets or sets the unique identifier for the verification request.
        /// This ID is returned after submitting a verification request.
        /// </summary>
        [JsonPropertyName("verificationRequestId")]
        public string VerificationRequestId { get; set; } = string.Empty;
    }
}
