using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.Requirements
{
    /// <summary>
    /// Represents the response returned when listing document requirements for phone numbers.
    /// Inherits from TelnyxResponse to encapsulate the document requirement data.
    /// </summary>
    public class ListRequirementResponse : TelnyxResponse<DocumentRequirement>
    {
    }

    /// <summary>
    /// Represents a document requirement for a phone number.
    /// Contains details about the country code, locality, phone number type, and associated requirement types.
    /// </summary>
    public class DocumentRequirement
    {
        /// <summary>
        /// Gets or sets the type of record for the document requirement.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the country code associated with the document requirement.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the locality associated with the document requirement.
        /// </summary>
        [JsonPropertyName("locality")]
        public string? Locality { get; set; }

        /// <summary>
        /// Gets or sets the type of phone number associated with the document requirement.
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the action that can be taken on the document requirement.
        /// </summary>
        [JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// Gets or sets the list of requirement types associated with the document requirement.
        /// </summary>
        [JsonPropertyName("requirements_types")]
        public List<RequirementType>? RequirementsTypes { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the document requirement.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp of the document requirement.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the update timestamp of the document requirement.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }
    }

    /// <summary>
    /// Represents the details of a requirement type associated with a document requirement.
    /// </summary>
    public class RequirementType
    {
        /// <summary>
        /// Gets or sets the list of acceptance criteria for the requirement type.
        /// </summary>
        [JsonPropertyName("acceptance_criteria")]
        public List<RequirementAcceptanceCriteria>? AcceptanceCriteria { get; set; }

        /// <summary>
        /// Gets or sets the description of the requirement type.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets an example of the requirement type.
        /// </summary>
        [JsonPropertyName("example")]
        public string? Example { get; set; }

        /// <summary>
        /// Gets or sets the type of the requirement.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the requirement type.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the record type of the requirement.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the requirement type.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp of the requirement type.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the update timestamp of the requirement type.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }
    }

    /// <summary>
    /// Represents the acceptance criteria for a requirement type.
    /// Specifies various constraints like time limit, length, and acceptable values.
    /// </summary>
    public class RequirementAcceptanceCriteria
    {
        /// <summary>
        /// Gets or sets the time limit associated with the acceptance criteria.
        /// </summary>
        [JsonPropertyName("time_limit")]
        public string? TimeLimit { get; set; }

        /// <summary>
        /// Gets or sets the locality limit associated with the acceptance criteria.
        /// </summary>
        [JsonPropertyName("locality_limit")]
        public string? LocalityLimit { get; set; }

        /// <summary>
        /// Gets or sets the acceptable values for the requirement.
        /// </summary>
        [JsonPropertyName("acceptable_values")]
        public List<string>? AcceptableValues { get; set; }

        /// <summary>
        /// Gets or sets the maximum length for the acceptance criteria.
        /// </summary>
        [JsonPropertyName("max_length")]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Gets or sets the minimum length for the acceptance criteria.
        /// </summary>
        [JsonPropertyName("min_length")]
        public int? MinLength { get; set; }

        /// <summary>
        /// Gets or sets the acceptable characters for the acceptance criteria.
        /// </summary>
        [JsonPropertyName("acceptable_characters")]
        public string? AcceptableCharacters { get; set; }
    }
}