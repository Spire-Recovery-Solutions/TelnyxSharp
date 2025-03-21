﻿using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Messaging.Models.Campaign.Requests
{
    /// <summary>
    /// Represents the request model for listing campaigns associated with a specific brand.
    /// </summary>
    public class ListCampaignsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier of the brand for which campaigns are being listed.
        /// </summary>
        public required string BrandId { get; set; }

        /// <summary>
        /// Gets or sets the page number for paginated results. Defaults to 1.
        /// </summary>
        [JsonPropertyName("page")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// Gets or sets the number of records per page in the paginated results. Defaults to 10.
        /// </summary>
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// Gets or sets the sorting criteria for the campaign results.
        /// Defaults to descending order of creation date ("-createdAt").
        /// </summary>
        public Sort? Sort { get; set; } = TelnyxSharp.Enums.Sort.CreatedAtDesc;
    }
}