using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Messaging.Models.Brands.Requests
{
    /// <summary>
    /// Represents the request payload for updating a brand.
    /// </summary>
    public class UpdateBrandRequest : ITelnyxRequest
    {
        /// <summary>
        /// The type of entity the brand represents.
        /// </summary>
        [JsonPropertyName("entityType")]
        public required EntityType EntityType { get; set; } = EntityType.Unknown;

        /// <summary>
        /// The display name of the brand.
        /// </summary>
        [JsonPropertyName("displayName")]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The company name associated with the brand.
        /// </summary>
        [JsonPropertyName("companyName")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// The first name of the primary contact for the brand.
        /// </summary>
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// The last name of the primary contact for the brand.
        /// </summary>
        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// The Employer Identification Number (EIN) of the brand.
        /// </summary>
        [JsonPropertyName("ein")]
        public string? EIN { get; set; }

        /// <summary>
        /// The phone number associated with the brand.
        /// </summary>
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// The street address of the brand.
        /// </summary>
        [JsonPropertyName("street")]
        public string? Street { get; set; }

        /// <summary>
        /// The city where the brand is located.
        /// </summary>
        [JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// The state or region where the brand is located.
        /// </summary>
        [JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// The postal code of the brand's location.
        /// </summary>
        [JsonPropertyName("postalCode")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// The country of the brand's location.
        /// </summary>
        [JsonPropertyName("country")]
        public required string Country { get; set; }

        /// <summary>
        /// The email address associated with the brand.
        /// </summary>
        [JsonPropertyName("email")]
        public required string Email { get; set; }

        /// <summary>
        /// The stock symbol of the company (if applicable).
        /// </summary>
        [JsonPropertyName("stockSymbol")]
        public string? StockSymbol { get; set; }

        /// <summary>
        /// The stock exchange where the company is listed (if applicable).
        /// </summary>
        [JsonPropertyName("stockExchange")]
        public StockExchange? StockExchange { get; set; }

        /// <summary>
        /// The IP address associated with the brand.
        /// </summary>
        [JsonPropertyName("ipAddress")]
        public string? IpAddress { get; set; }

        /// <summary>
        /// The website URL of the brand.
        /// </summary>
        [JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// The vertical or industry of the brand.
        /// </summary>
        [JsonPropertyName("vertical")]
        public required Vertical Vertical { get; set; }

        /// <summary>
        /// An alternative business identifier for the brand.
        /// </summary>
        [JsonPropertyName("altBusinessId")]
        public string? AltBusinessId { get; set; }

        /// <summary>
        /// The type of the alternative business identifier.
        /// </summary>
        [JsonPropertyName("altBusinessIdType")]
        public string? AltBusinessIdType { get; set; }

        /// <summary>
        /// Indicates if the brand is a reseller.
        /// </summary>
        [JsonPropertyName("isReseller")]
        public bool? IsReseller { get; set; }

        /// <summary>
        /// Gets or sets the identity status of the business entity.
        /// Example values could include "Active", "Inactive", or other status descriptions.
        /// </summary>
        [JsonPropertyName("identityStatus")]
        public string? IdentityStatus { get; set; }

        /// <summary>
        /// Gets or sets the email address of the business contact.
        /// This is typically used for administrative or notification purposes.
        /// </summary>
        [JsonPropertyName("businessContactEmail")]
        public string? BusinessContactEmail { get; set; }

        /// <summary>
        /// Gets or sets the primary webhook URL for receiving notifications or updates.
        /// This URL is expected to handle real-time data from external systems.
        /// </summary>
        [JsonPropertyName("webhookURL")]
        public string? WebhookURL { get; set; }

        /// <summary>
        /// Gets or sets the failover webhook URL.
        /// This URL serves as a backup in case the primary webhook URL is unavailable.
        /// </summary>
        [JsonPropertyName("webhookFailoverURL")]
        public string? WebhookFailoverURL { get; set; }
    }
}
