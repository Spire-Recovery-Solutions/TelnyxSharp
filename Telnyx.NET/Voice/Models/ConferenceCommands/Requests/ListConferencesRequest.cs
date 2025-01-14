using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for listing conferences.
    /// This model allows filtering the conferences by name and status, 
    /// and it supports pagination to manage the number of conferences returned.
    /// </summary>
    public class ListConferencesRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the name filter for the conferences.
        /// If provided, only conferences with names that match this filter will be returned.
        /// </summary>
        [JsonPropertyName("filter[name]")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the status filter for the conferences.
        /// If provided, only conferences with the specified status will be returned.
        /// The status can be one of the values from the <see cref="ConferenceStatus"/> enum.
        /// </summary>
        [JsonPropertyName("filter[status]")]
        public ConferenceStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets the number of conferences to be returned per page.
        /// The default page size is 20.
        /// </summary>
        [JsonPropertyName("page[size]")]
        public int? PageSize { get; set; } = 20;
    }
}