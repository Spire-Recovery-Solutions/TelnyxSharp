using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response containing a list of LOA (Letter of Authorization) configurations.
    /// </summary>
    public class ListLoaConfigurationsResponse : TelnyxResponse<List<LoaConfiguration>>
    {
    }

    /// <summary>
    /// Represents the details of an individual LOA (Letter of Authorization) configuration.
    /// </summary>
    public class LoaConfiguration
    {
        /// <summary>
        /// Gets or sets the unique identifier of the LOA configuration.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the company name associated with the LOA configuration.
        /// </summary>
        [JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the organization ID associated with the LOA configuration.
        /// </summary>
        [JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the name of the LOA configuration.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the logo information associated with the LOA configuration.
        /// </summary>
        [JsonPropertyName("logo")]
        public LogoInfo? Logo { get; set; }

        /// <summary>
        /// Gets or sets the address associated with the LOA configuration.
        /// </summary>
        [JsonPropertyName("address")]
        public Address? Address { get; set; }

        /// <summary>
        /// Gets or sets the contact information associated with the LOA configuration.
        /// </summary>
        [JsonPropertyName("contact")]
        public Contact? Contact { get; set; }

        /// <summary>
        /// Gets or sets the record type associated with the LOA configuration.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the LOA configuration was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the LOA configuration was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }

    /// <summary>
    /// Represents the logo information for an LOA configuration.
    /// </summary>
    public class LogoInfo
    {
        /// <summary>
        /// Gets or sets the document ID associated with the logo.
        /// </summary>
        [JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// Gets or sets the content type of the logo (default is image/png).
        /// </summary>
        [JsonPropertyName("content_type")]
        public string? ContentType { get; set; } = "image/png";
    }

    /// <summary>
    /// Represents the address information associated with an LOA configuration.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the street address for the LOA.
        /// </summary>
        [JsonPropertyName("street_address")]
        public string? StreetAddress { get; set; }

        /// <summary>
        /// Gets or sets the extended address (e.g., suite or apartment number).
        /// </summary>
        [JsonPropertyName("extended_address")]
        public string? ExtendedAddress { get; set; }

        /// <summary>
        /// Gets or sets the city for the LOA address.
        /// </summary>
        [JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// Gets or sets the state for the LOA address.
        /// </summary>
        [JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// Gets or sets the zip code for the LOA address.
        /// </summary>
        [JsonPropertyName("zip_code")]
        public string? ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the country code for the LOA address.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }
    }

    /// <summary>
    /// Represents the contact information associated with an LOA configuration.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Gets or sets the email address for the LOA contact.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the phone number for the LOA contact.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }
    }
}