using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Voice.Models.CallControlApplications.Requests
{
    /// <summary>
    /// Represents the request model for listing call control applications with filtering and sorting options.
    /// </summary>
    public class ListCallControlApplicationsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Specifies the number of items per page for pagination.
        /// Default is 20.
        /// </summary>
        [JsonPropertyName("page[size]")]
        public int? PageSize { get; set; } = 20;

        /// <summary>
        /// Filters applications whose names contain the specified value.
        /// </summary>
        [JsonPropertyName("filter[application_name][contains]")]
        public string? ApplicationNameContains { get; set; }

        /// <summary>
        /// Filters applications by the specified outbound voice profile ID.
        /// </summary>
        [JsonPropertyName("filter[outbound.outbound_voice_profile_id]")]
        public long? OutboundVoiceProfileId { get; set; }

        /// <summary>
        /// Specifies the sort order for the results.
        /// </summary>
        [JsonPropertyName("sort")]
        public Sort? Sort { get; set; }
    }
}