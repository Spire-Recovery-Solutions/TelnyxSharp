using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.BrandedCalling.Models.PhoneNumberBatches.Requests
{
    /// <summary>
    /// Represents a request for listing the phone-number batches of a Display Identity Record (DIR).
    /// </summary>
    public class ListDirPhoneNumberBatchesRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of items per page (default 50, maximum 250).
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets a filter restricting results to batches whose aggregate status equals this value.
        /// </summary>
        public DirPhoneNumberStatus? Status { get; set; }
    }
}
