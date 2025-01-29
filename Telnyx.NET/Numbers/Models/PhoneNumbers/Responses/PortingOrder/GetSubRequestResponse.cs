using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response when retrieving a sub-request.
    /// Inherits from TelnyxResponse and includes SubRequestData.
    /// </summary>
    public class GetSubRequestResponse : TelnyxResponse<SubRequestData>
    {
    }

    /// <summary>
    /// Represents the data for a sub-request in the Telnyx porting process.
    /// </summary>
    public class SubRequestData
    {
        /// <summary>
        /// The ID of the sub-request.
        /// </summary>
        [JsonPropertyName("sub_request_id")]
        public string? SubRequestId { get; set; }

        /// <summary>
        /// The ID of the associated port request.
        /// </summary>
        [JsonPropertyName("port_request_id")]
        public string? PortRequestId { get; set; }
    }
}