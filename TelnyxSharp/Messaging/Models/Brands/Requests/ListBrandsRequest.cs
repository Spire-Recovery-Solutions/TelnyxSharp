﻿using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Messaging.Models.Brands.Requests
{
    /// <summary>
    /// Represents a request to list brands from the Telnyx API.
    /// This model allows pagination, filtering by various fields (such as display name, entity type, state, etc.),
    /// and sorting the results based on a specified field.
    /// </summary>
    public class ListBrandsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the page number for pagination. Defaults to 1.
        /// </summary>
        [JsonPropertyName("page")]
        public int PageNumber { get; set; } = 1;
        /// <summary>
        /// Gets or sets the number of records per page for pagination. Defaults to 10.
        /// </summary>
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// Gets or sets the sorting order for the results. Defaults to sorting by created date in descending order.
        /// </summary>
        public Sort Sort { get; set; } = Sort.CreatedAtDesc;

        /// <summary>
        /// Gets or sets the display name of the brand to filter by. Defaults to an empty string, meaning no filtering by display name.
        /// </summary>
        public string DisplayName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the entity type to filter by. Defaults to an empty string, meaning no filtering by entity type.
        /// </summary>
        public EntityType EntityType { get; set; } = EntityType.Unknown;

        /// <summary>
        /// Gets or sets the state to filter by. Defaults to an empty string, meaning no filtering by state.
        /// </summary>
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the country to filter by. Defaults to an empty string, meaning no filtering by country.
        /// </summary>
        public string Country { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the brand ID to filter by. Defaults to an empty string, meaning no filtering by brand ID.
        /// </summary>
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the TCR brand ID to filter by. Defaults to an empty string, meaning no filtering by TCR brand ID.
        /// </summary>
        public string TcrBrandId { get; set; } = string.Empty;
    }
}