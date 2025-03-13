using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Voice.Models.CallControlApplications.Requests
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
        public int? PageSize { get; set; } = 20;

        /// <summary>
        /// Filters applications whose names contain the specified value.
        /// </summary>
        public string? ApplicationNameContains { get; set; }

        /// <summary>
        /// Filters applications by the specified outbound voice profile ID.
        /// </summary>
        public long? OutboundVoiceProfileId { get; set; }

        /// <summary>
        /// Specifies the sort order for the results.
        /// </summary>
        public SortVoice? Sort { get; set; }
    }
}