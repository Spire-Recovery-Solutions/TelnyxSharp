﻿using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberBlocksBackgroundJobs
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
        public string? Type { get; set; } = "delete_phone_number_block";

        /// <summary>
        /// Gets or sets the status of the phone number block job to filter by. 
        /// Uses the <see cref="JobStatusType"/> enumeration.
        /// </summary>
        public JobStatusType? Status { get; set; }

        /// <summary>
        /// Gets or sets the number of records to return per page. 
        /// Defaults to 20.
        /// </summary>
        public int? PageSize { get; set; } = 20;

        /// <summary>
        /// Gets or sets the field by which to sort the results. 
        /// Defaults to "created_at".
        /// </summary>
        public string? Sort { get; set; } = "created_at";
    }
}