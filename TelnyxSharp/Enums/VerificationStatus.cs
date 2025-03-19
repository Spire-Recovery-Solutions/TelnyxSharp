using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
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
        [JsonStringEnumMemberName("Verified")]
        Verified,

        /// <summary>
        /// The verification was rejected.
        /// </summary>
        [JsonStringEnumMemberName("Rejected")]
        Rejected,

        /// <summary>
        /// Verification is waiting for vendor action.
        /// </summary>
        [JsonStringEnumMemberName("Waiting For Vendor")]
        WaitingForVendor,

        /// <summary>
        /// Verification is waiting for customer action.
        /// </summary>
        [JsonStringEnumMemberName("Waiting For Customer")]
        WaitingForCustomer,

        /// <summary>
        /// The verification process is currently in progress.
        /// </summary>
        [JsonStringEnumMemberName("In Progress")]
        InProgress
    }
}