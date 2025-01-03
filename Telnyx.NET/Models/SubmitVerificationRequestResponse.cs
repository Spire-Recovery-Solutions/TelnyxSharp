using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response model for a submitted verification request.
    /// This class encapsulates the response data for a verification request submission.
    /// </summary>
    public class SubmitVerificationRequestResponse : BaseVerificationRequestResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier for the verification request.
        /// This ID is returned after submitting a verification request.
        /// </summary>
        [JsonPropertyName("verificationRequestId")]
        public string VerificationRequestId { get; set; } = string.Empty;
    }
}