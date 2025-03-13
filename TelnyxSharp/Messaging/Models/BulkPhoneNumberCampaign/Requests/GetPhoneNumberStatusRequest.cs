using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.BulkPhoneNumberCampaign.Requests
{
    public class GetPhoneNumberStatusRequest : ITelnyxRequest
    {
        /// <summary>
        /// The number of records to return per page.
        /// </summary>
        public int? PageSize { get; set; }


    }
}
