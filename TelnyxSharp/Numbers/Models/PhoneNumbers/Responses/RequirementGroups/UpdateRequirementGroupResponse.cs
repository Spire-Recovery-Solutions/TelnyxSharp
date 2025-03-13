using System.Net;
using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.RequirementGroups
{
    /// <summary>
    /// Represents the response for updating a requirement group.
    /// It contains information about the success of the update, the status code, error messages, and additional metadata.
    /// </summary>
    public class UpdateRequirementGroupResponse : RequirementGroupData, ITelnyxResponse
    {
        /// <summary>
        /// Indicates whether the update operation was successful.
        /// This property is ignored during JSON serialization.
        /// </summary>
        [JsonIgnore]
        public bool IsSuccessful { get; set; }

        /// <summary>
        /// Contains the HTTP status code returned by the Telnyx API.
        /// This property is ignored during JSON serialization.
        /// </summary>
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Holds any error message returned by the API if the update operation failed.
        /// This property is ignored during JSON serialization.
        /// </summary>
        [JsonIgnore]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// A list of errors returned by the Telnyx API.
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