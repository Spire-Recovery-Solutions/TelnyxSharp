using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.BrandedCalling.Models.PhoneNumbers.Requests
{
    /// <summary>
    /// Represents a request for listing the phone numbers attached to a Display Identity Record (DIR).
    /// </summary>
    public class ListDirPhoneNumbersRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of items per page (default 50, maximum 250).
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets a filter on phone-number status.
        /// </summary>
        public DirPhoneNumberStatus? Status { get; set; }
    }
}
