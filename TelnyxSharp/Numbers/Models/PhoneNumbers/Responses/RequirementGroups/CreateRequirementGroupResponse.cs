﻿using System.Net;
using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.RequirementGroups
{
    /// <summary>
    /// Represents the response for creating a requirement group.
    /// Inherits properties from <see cref="RequirementGroupData"/> and implements <see cref="ITelnyxResponse"/>.
    /// </summary>
    public class CreateRequirementGroupResponse : RequirementGroupData, ITelnyxResponse
    {
        /// <summary>
        /// Indicates whether the request was successful.
        /// This property is excluded from JSON serialization.
        /// </summary>
        [JsonIgnore]
        public bool IsSuccessful { get; set; }

        /// <summary>
        /// Gets or sets the HTTP status code of the response.
        /// This property is excluded from JSON serialization.
        /// </summary>
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the error message, if any, associated with the response.
        /// This property is excluded from JSON serialization.
        /// </summary>
        [JsonIgnore]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the array of errors, if any, returned by the API.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }

        /// <summary>
        /// Gets or sets pagination metadata associated with the response.
        /// </summary>
        [JsonPropertyName("meta")]
        public PaginationMeta? Meta { get; set; }
    }
}