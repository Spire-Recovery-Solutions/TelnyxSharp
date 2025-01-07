using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Models
{
    public class GetPhoneNumberStatusRequest : ITelnyxRequest
    {
        /// <summary>
        /// The number of records to return per page.
        /// </summary>
        [JsonPropertyName("recordsPerPage")]
        public int? PageSize  { get; set; }

        
    }
}
