using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from Telnyx API for brand-related details.
    /// This class maps to the JSON structure returned by the API and contains
    /// information such as brand identifiers, contact information, and status.
    /// </summary>
    public class BaseBrandResponse : TelnyxResponse
    {
        /// <summary>
        /// The type of entity the brand represents.
        /// </summary>
        [JsonPropertyName("entityType")]
        public EntityType EntityType { get; set; } = EntityType.Unknown;

        /// <summary>
        /// The CSP (Communication Service Provider) ID associated with the brand.
        /// </summary>
        [JsonPropertyName("cspId")]
        public string? CspId { get; set; }

        /// <summary>
        /// The unique identifier for the brand.
        /// </summary>
        [JsonPropertyName("brandId")]
        public string? BrandId { get; set; }

        /// <summary>
        /// The TCR (The Campaign Registry) brand ID.
        /// </summary>
        [JsonPropertyName("tcrBrandId")]
        public string? TcrBrandId { get; set; }

        /// <summary>
        /// The display name of the brand.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; } = string.Empty;

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
        public string Country { get; set; } = string.Empty;

        /// <summary>
        /// The email address associated with the brand.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

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
        /// The relationship of the brand to the associated entity.
        /// </summary>
        [JsonPropertyName("brandRelationship")]
        public BrandRelationship BrandRelationShip { get; set; } = BrandRelationship.Unknown;

        /// <summary>
        /// The vertical or industry of the brand.
        /// </summary>
        [JsonPropertyName("vertical")]
        public Vertical Vertical { get; set; } = Vertical.Unknown;

        /// <summary>
        /// An alternative business identifier for the brand.
        /// </summary>
        [JsonPropertyName("altBusinessId")]
        public string? AltBusinessId { get; set; }

        /// <summary>
        /// The type of the alternative business identifier.
        /// </summary>
        [JsonPropertyName("altBusinessIdType")]
        public AltBusinessIdType? AltBusinessIdType { get; set; }

        /// <summary>
        /// A universal EIN (if applicable).
        /// </summary>
        [JsonPropertyName("universalEin")]
        public string? UniversalEin { get; set; }

        /// <summary>
        /// A reference ID associated with the brand.
        /// </summary>
        [JsonPropertyName("referenceId")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// The identity verification status of the brand.
        /// </summary>
        [JsonPropertyName("identityStatus")]
        public BrandIdentityStatus? IdentityStatus { get; set; }

        /// <summary>
        /// Optional additional attributes for the brand.
        /// </summary>
        [JsonPropertyName("optionalAttributes")]
        public OptionalAttributes? OptionalAttributes { get; set; }

        /// <summary>
        /// Indicates if the brand is a mock entry.
        /// </summary>
        [JsonPropertyName("mock")]
        public bool? Mock { get; set; }

        /// <summary>
        /// The mobile phone number associated with the brand.
        /// </summary>
        [JsonPropertyName("mobilePhone")]
        public string? MobilePhone { get; set; }

        /// <summary>
        /// Indicates if the brand is a reseller.
        /// </summary>
        [JsonPropertyName("isReseller")]
        public bool? IsReseller { get; set; }

        /// <summary>
        /// The URL for webhook callbacks.
        /// </summary>
        [JsonPropertyName("webhookURL")]
        public string? WebhookURL { get; set; }

        /// <summary>
        /// The bussiness email.
        /// </summary>
        [JsonPropertyName("businessContactEmail")]
        public string? BusinessContactEmail { get; set; }

        /// <summary>
        /// The failover URL for webhook callbacks.
        /// </summary>
        [JsonPropertyName("webhookFailoverURL")]
        public string? WebhookFailoverURL { get; set; }

        /// <summary>
        /// The creation timestamp of the brand.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// The last updated timestamp of the brand.
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// The current status of the brand.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// A list of reasons for failure, if applicable.
        /// </summary>
        [JsonPropertyName("failureReasons")]
        public List<string>? FailureReasons { get; set; }
    }

    public class OptionalAttributes
    {
        /// <summary>
        /// The tax exempt status of the brand.
        /// </summary>
        [JsonPropertyName("taxExemptStatus")]
        public string? TaxExemptStatus { get; set; }
    }
}