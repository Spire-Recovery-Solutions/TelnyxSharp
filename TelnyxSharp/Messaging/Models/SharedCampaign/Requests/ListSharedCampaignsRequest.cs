using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Messaging.Models.SharedCampaign.Requests
{
    public class ListSharedCampaignsRequest : ITelnyxRequest
    {
        /// <summary>
        /// The number of records to return per page.
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets the sorting order for the results. Defaults to sorting by created date in descending order.
        /// </summary>
        public Sort Sort { get; set; } = Sort.CreatedAtDesc;
    }
}
