using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to list verification codes for porting orders.
    /// This class allows filtering by phone number, verification status, and sorting options.
    /// </summary>
    public class ListVerificationCodesRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of verification codes to retrieve per page.
        /// This property is used for pagination. If not specified, the default behavior might be used by the API.
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets a specific phone number to filter verification codes for.
        /// If set, only verification codes for this particular phone number will be retrieved.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a list of phone numbers to filter verification codes for.
        /// This allows querying for verification codes for multiple phone numbers at once.
        /// </summary>
        public List<string>? PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the verification code has been verified.
        /// If set, it will filter the results to only include codes that match the verification status.
        /// </summary>
        public bool? Verified { get; set; }

        /// <summary>
        /// Gets or sets the sort order for the results.
        /// This property allows you to specify how the results should be sorted, such as by date or verification status.
        /// </summary>
        public RequirementSort? Sort { get; set; }
    }
}