using System.Net;
using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.RequirementGroups
{
    /// <summary>
    /// Represents the response for listing requirement groups.
    /// Inherits from <see cref="List{RequirementGroupData}"/> to provide a collection of requirement group data and implements <see cref="ITelnyxResponse"/>.
    /// </summary>
    public class ListRequirementGroupsResponse : List<RequirementGroupData>, ITelnyxResponse
    {
        /// <summary>
        /// Indicates whether the request to list requirement groups was successful.
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

    /// <summary>
    /// Represents the data for a single requirement group.
    /// </summary>
    public class RequirementGroupData
    {
        /// <summary>
        /// Gets or sets the unique identifier of the requirement group.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the country code associated with the requirement group.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the type of phone number associated with the requirement group.
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the status of the requirement group.
        /// </summary>
        [JsonPropertyName("status")]
        public RequirementStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets the action associated with the requirement group.
        /// </summary>
        [JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// Gets or sets the customer reference for the requirement group.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the requirement group was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the requirement group was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the type of record associated with the requirement group.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the list of regulatory requirements for the requirement group.
        /// </summary>
        [JsonPropertyName("regulatory_requirements")]
        public List<RegulatoryRequirementDetail>? RegulatoryRequirements { get; set; }
    }

    /// <summary>
    /// Represents detailed information about a regulatory requirement.
    /// </summary>
    public class RegulatoryRequirementDetail
    {
        /// <summary>
        /// Gets or sets the unique identifier of the regulatory requirement.
        /// </summary>
        [JsonPropertyName("requirement_id")]
        public string? RequirementId { get; set; }

        /// <summary>
        /// Gets or sets the value for the regulatory requirement field.
        /// </summary>
        [JsonPropertyName("field_value")]
        public string? FieldValue { get; set; }

        /// <summary>
        /// Gets or sets the type of field for the regulatory requirement.
        /// </summary>
        [JsonPropertyName("field_type")]
        public string? FieldType { get; set; }

        /// <summary>
        /// Gets or sets the status of the regulatory requirement.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the expiration date and time for the regulatory requirement.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the regulatory requirement was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the regulatory requirement was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}