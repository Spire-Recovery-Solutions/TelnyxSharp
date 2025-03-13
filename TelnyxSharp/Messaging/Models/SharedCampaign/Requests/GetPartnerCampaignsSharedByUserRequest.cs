using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.SharedCampaign.Requests
{
    public class GetPartnerCampaignsSharedByUserRequest : ITelnyxRequest
    {
        /// <summary>
        /// The number of records to return per page.
        /// </summary>
        public int? PageSize { get; set; }


    }
}
