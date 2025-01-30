using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Messaging.Models.SharedCampaign.Requests
{
    public class GetPartnerCampaignsSharedByUserRequest : ITelnyxRequest
    {
        /// <summary>
        /// The number of records to return per page.
        /// </summary>
        public int? PageSize { get; set; }


    }
}
