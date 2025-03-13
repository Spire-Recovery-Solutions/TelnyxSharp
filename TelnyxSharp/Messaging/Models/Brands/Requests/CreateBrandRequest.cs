using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Messaging.Models.Brands.Requests
{
    /// <summary>
    /// Represents the request payload for creating a brand in Telnyx API.
    /// </summary>
    public class CreateBrandRequest : ITelnyxRequest
    {
        /// <summary>
        /// Entity type behind the brand. This is the form of business establishment.
        /// Required: true.
        /// </summary>
        [JsonPropertyName("entityType")]
        public required EntityType EntityType { get; set; } = EntityType.Unknown;

        /// <summary>
        /// Display name, marketing name, or DBA name of the brand.
        /// Required: true.
        /// </summary>
        [JsonPropertyName("displayName")]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Legal company name. Required for Non-profit/private/public.
        /// </summary>
        [JsonPropertyName("companyName")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// First name of business contact.
        /// </summary>
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of business contact.
        /// </summary>
        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// Government-assigned corporate tax ID. Required for Non-profit.
        /// </summary>
        [JsonPropertyName("ein")]
        public string? Ein { get; set; }

        /// <summary>
        /// Valid phone number in E.164 international format.
        /// </summary>
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Street number and name.
        /// </summary>
        [JsonPropertyName("street")]
        public string? Street { get; set; }

        /// <summary>
        /// City name.
        /// </summary>
        [JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// State. Must be 2-letter code for United States.
        /// </summary>
        [JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// Postal codes. Use 5-digit ZIP code for United States.
        /// </summary>
        [JsonPropertyName("postalCode")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// ISO 2-character country code. Example: US - United States.
        /// Required: true.
        /// </summary>
        [JsonPropertyName("country")]
        public required string Country { get; set; }

        /// <summary>
        /// Valid email address of brand support contact.
        /// Required: true.
        /// </summary>
        [JsonPropertyName("email")]
        public required string Email { get; set; }

        /// <summary>
        /// Stock symbol. Required for public companies.
        /// </summary>
        [JsonPropertyName("stockSymbol")]
        public string? StockSymbol { get; set; }

        /// <summary>
        /// Stock exchange. Required for public companies.
        /// </summary>
        [JsonPropertyName("stockExchange")]
        public StockExchange? StockExchange { get; set; }

        /// <summary>
        /// IP address of the browser requesting to create brand identity.
        /// </summary>
        [JsonPropertyName("ipAddress")]
        public string? IpAddress { get; set; }

        /// <summary>
        /// Brand website URL.
        /// </summary>
        [JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// Vertical or industry segment of the brand or campaign.
        /// Required: true.
        /// </summary>
        [JsonPropertyName("vertical")]
        public required Vertical Vertical { get; set; }

        /// <summary>
        /// Indicates whether this brand is a reseller.
        /// Defaults to false.
        /// </summary>
        [JsonPropertyName("isReseller")]
        public bool IsReseller { get; set; } = false;

        /// <summary>
        /// Indicates whether this is a mock brand for testing purposes.
        /// Defaults to false.
        /// </summary>
        [JsonPropertyName("mock")]
        public bool Mock { get; set; } = false;

        /// <summary>
        /// Valid mobile phone number in E.164 international format.
        /// </summary>
        [JsonPropertyName("mobilePhone")]
        public string? MobilePhone { get; set; }

        /// <summary>
        /// Business contact email. Required for public companies.
        /// </summary>
        [JsonPropertyName("businessContactEmail")]
        public string? BusinessContactEmail { get; set; }

        /// <summary>
        /// Webhook URL for brand status updates.
        /// </summary>
        [JsonPropertyName("webhookURL")]
        public string? WebhookURL { get; set; }

        /// <summary>
        /// Failover webhook URL for brand status updates.
        /// </summary>
        [JsonPropertyName("webhookFailoverURL")]
        public string? WebhookFailoverURL { get; set; }
    }
}
