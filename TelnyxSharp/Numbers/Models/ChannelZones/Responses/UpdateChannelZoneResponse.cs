using System.Net;
using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.ChannelZones.Responses
{
    public class UpdateChannelZoneResponse : ChannelZone , ITelnyxResponse
    {
        /// <summary>
        /// Indicates whether the operation was successful.
        /// This property is ignored during JSON serialization.
        /// </summary>
        [JsonIgnore]
        public bool IsSuccessful { get; set; }

        /// <summary>
        /// Contains the HTTP status code returned by the API.
        /// This property is ignored during JSON serialization.
        /// </summary>
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Holds any error message returned by the API, if applicable.
        /// This property is ignored during JSON serialization.
        /// </summary>
        [JsonIgnore]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// A list of errors related to the request, as returned by the Telnyx API.
        /// This property is serialized with the name "errors".
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }

        /// <summary>
        /// Contains metadata about the pagination of the response.
        /// This property is serialized with the name "meta".
        /// </summary>
        [JsonPropertyName("meta")]
        public PaginationMeta? Meta { get; set; }
    }
}
