using System.Text.Json.Serialization;
using Telnyx.NET.Enums;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response containing a list of brand records.
    /// </summary>
    public class ListBrandsResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the list of brand records.
        /// </summary>
        [JsonPropertyName("records")]
        public List<BrandRecord>? Records { get; set; }

        /// <summary>
        /// Gets or sets the current page number of the response.
        /// </summary>
        [JsonPropertyName("page")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the total number of records available.
        /// </summary>
        [JsonPropertyName("totalRecords")]
        public int TotalRecords { get; set; }

        /// <summary>
        /// Represents any errors encountered during the retrieval of the auto-response setting.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }

    /// <summary>
    /// Represents a single brand record in the list.
    /// </summary>
    public class BrandRecord
    {
        /// <summary>
        /// Gets or sets the unique identifier for the brand.
        /// </summary>
        [JsonPropertyName("brandId")]
        public string? BrandId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the TCR brand.
        /// </summary>
        [JsonPropertyName("tcrBrandId")]
        public string? TcrBrandId { get; set; }

        /// <summary>
        /// Gets or sets the type of entity for the brand (e.g., individual, company).
        /// </summary>
        [JsonPropertyName("entityType")]
        public EntityType? EntityType { get; set; }

        /// <summary>
        /// Gets or sets the identity status of the brand.
        /// </summary>
        [JsonPropertyName("identityStatus")]
        public string? IdentityStatus { get; set; }

        /// <summary>
        /// Gets or sets the company name associated with the brand.
        /// </summary>
        [JsonPropertyName("companyName")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the display name for the brand.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the email address associated with the brand.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the website URL for the brand.
        /// </summary>
        [JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// Gets or sets the list of failure reasons if applicable.
        /// </summary>
        [JsonPropertyName("failureReasons")]
        public List<string>? FailureReasons { get; set; }

        /// <summary>
        /// Gets or sets the current status of the brand.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the brand was created.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the brand was last updated.
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the count of assigned campaigns to the brand.
        /// </summary>
        [JsonPropertyName("assignedCampaingsCount")]
        public int AssignedCampaignsCount { get; set; }
    }
}