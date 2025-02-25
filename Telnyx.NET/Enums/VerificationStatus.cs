using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
   /// <summary>
    /// Enum representing various verification statuses.
    /// </summary>
    [JsonConverter(typeof(Converters.VerificationStatusConverter))]
    public enum VerificationStatus
    {
        /// <summary>
        /// The verification status is unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// The verification has been successfully completed.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Verified")]
        Verified,

        /// <summary>
        /// The verification was rejected.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Rejected")]
        Rejected,

        /// <summary>
        /// Verification is waiting for vendor action.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Waiting For Vendor")]
        WaitingForVendor,

        /// <summary>
        /// Verification is waiting for customer action.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Waiting For Customer")]
        WaitingForCustomer,

        /// <summary>
        /// The verification process is currently in progress.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("In Progress")]
        InProgress
    }
}