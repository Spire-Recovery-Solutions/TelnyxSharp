using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Messaging.Models.BulkPhoneNumberCampaign.Requests
{
    public class GetPhoneNumberStatusRequest : ITelnyxRequest
    {
        /// <summary>
        /// The number of records to return per page.
        /// </summary>
        public int? PageSize { get; set; }


    }
}
