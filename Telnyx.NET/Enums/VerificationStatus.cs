using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing various verification statuses.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum VerificationStatus
    {
        /// <summary>
        /// The verification status is unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// The verification has been successfully completed.
        /// </summary>
        [JsonPropertyName("Verified")]
        Verified,

        /// <summary>
        /// The verification was rejected.
        /// </summary>
        [JsonPropertyName("Rejected")]
        Rejected,

        /// <summary>
        /// Verification is waiting for vendor action.
        /// </summary>
        [JsonPropertyName("Waiting For Vendor")]
        WaitingForVendor,

        /// <summary>
        /// Verification is waiting for customer action.
        /// </summary>
        [JsonPropertyName("Waiting For Customer")]
        WaitingForCustomer,

        /// <summary>
        /// The verification process is currently in progress.
        /// </summary>
        [JsonPropertyName("In Progress")]
        InProgress
    }
}