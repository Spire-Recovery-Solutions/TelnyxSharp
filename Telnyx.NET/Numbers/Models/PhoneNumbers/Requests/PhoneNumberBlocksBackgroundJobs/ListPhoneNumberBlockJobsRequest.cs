using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberBlocksBackgroundJobs
{
    /// <summary>
    /// Represents a request to retrieve a list of phone number block jobs with optional filtering and pagination.
    /// </summary>
    public class ListPhoneNumberBlockJobsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the type of phone number block job to filter by. 
        /// Defaults to "delete_phone_number_block".
        /// </summary>
        [JsonPropertyName("filter[type]")]
        public string? Type { get; set; } = "delete_phone_number_block";

        /// <summary>
        /// Gets or sets the status of the phone number block job to filter by. 
        /// Uses the <see cref="JobStatusType"/> enumeration.
        /// </summary>
        [JsonPropertyName("filter[status]")]
        public JobStatusType? Status { get; set; }

        /// <summary>
        /// Gets or sets the number of records to return per page. 
        /// Defaults to 20.
        /// </summary>
        [JsonPropertyName("page[size]")]
        public int? PageSize { get; set; } = 20;

        /// <summary>
        /// Gets or sets the field by which to sort the results. 
        /// Defaults to "created_at".
        /// </summary>
        [JsonPropertyName("sort")]
        public string? Sort { get; set; } = "created_at";
    }
}