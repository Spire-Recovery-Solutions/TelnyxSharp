using System.Text.Json.Serialization;
using Telnyx.NET.Models;
using System.Collections.Generic;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.RegulatoryRequirements
{
    /// <summary>
    /// Represents the response containing a list of regulatory requirements for a phone number.
    /// Inherits from <see cref="TelnyxResponse{T}"/> where T is a list of <see cref="RegulatoryRequirement"/>.
    /// </summary>
    public class GetRegulatoryRequirementsResponse : TelnyxResponse<List<RegulatoryRequirement>>
    {
    }

    /// <summary>
    /// Represents a regulatory requirement for a phone number, including the country, phone number type, action, and details.
    /// </summary>
    public class RegulatoryRequirement
    {
        /// <summary>
        /// Gets or sets the country code for the regulatory requirement.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the phone number type (e.g., local, toll-free, mobile).
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the action (e.g., ordering, porting) associated with the regulatory requirement.
        /// </summary>
        [JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// Gets or sets the list of regulatory requirement details.
        /// </summary>
        [JsonPropertyName("regulatory_requirements")]
        public List<RequirementDetail>? RegulatoryRequirementDetails { get; set; }
    }

    /// <summary>
    /// Represents the details of a regulatory requirement, including description, example, and acceptance criteria.
    /// </summary>
    public class RequirementDetail
    {
        /// <summary>
        /// Gets or sets the description of the regulatory requirement.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the unique ID of the regulatory requirement.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets an example value for the regulatory requirement.
        /// </summary>
        [JsonPropertyName("example")]
        public string? Example { get; set; }

        /// <summary>
        /// Gets or sets the name of the regulatory requirement.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the field type associated with the regulatory requirement (e.g., text, number).
        /// </summary>
        [JsonPropertyName("field_type")]
        public string? FieldType { get; set; }

        /// <summary>
        /// Gets or sets the acceptance criteria for the regulatory requirement.
        /// </summary>
        [JsonPropertyName("acceptance_criteria")]
        public AcceptanceCriteria? AcceptanceCriteria { get; set; }

        /// <summary>
        /// Gets or sets the record type associated with the regulatory requirement (e.g., individual, business).
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }
    }

    /// <summary>
    /// Represents the acceptance criteria for a regulatory requirement, including constraints like locality, time, and character restrictions.
    /// </summary>
    public class AcceptanceCriteria
    {
        /// <summary>
        /// Gets or sets the locality limit for the regulatory requirement (e.g., geographic restrictions).
        /// </summary>
        [JsonPropertyName("locality_limit")]
        public string? LocalityLimit { get; set; }

        /// <summary>
        /// Gets or sets the time limit for the regulatory requirement (e.g., duration of validity).
        /// </summary>
        [JsonPropertyName("time_limit")]
        public string? TimeLimit { get; set; }

        /// <summary>
        /// Gets or sets the regular expression for validating the regulatory requirement.
        /// </summary>
        [JsonPropertyName("regex")]
        public string? Regex { get; set; }

        /// <summary>
        /// Gets or sets whether the regulatory requirement is case-sensitive.
        /// </summary>
        [JsonPropertyName("case_sensitive")]
        public string? CaseSensitive { get; set; }

        /// <summary>
        /// Gets or sets the list of acceptable characters for the regulatory requirement.
        /// </summary>
        [JsonPropertyName("acceptable_characters")]
        public string? AcceptableCharacters { get; set; }

        /// <summary>
        /// Gets or sets the list of acceptable values for the regulatory requirement.
        /// </summary>
        [JsonPropertyName("acceptable_values")]
        public List<string>? AcceptableValues { get; set; }

        /// <summary>
        /// Gets or sets the maximum length of the value for the regulatory requirement.
        /// </summary>
        [JsonPropertyName("max_length")]
        public string? MaxLength { get; set; }

        /// <summary>
        /// Gets or sets the minimum length of the value for the regulatory requirement.
        /// </summary>
        [JsonPropertyName("min_length")]
        public string? MinLength { get; set; }
    }
}