using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.BrandedCalling.Models.Enterprises.Requests
{
    /// <summary>
    /// Represents a request to update an enterprise in the Branded Calling API.
    /// All fields are optional; only the ones supplied are updated.
    /// </summary>
    public class UpdateEnterpriseRequest : ITelnyxRequest
    {
        /// <summary>
        /// Legal name of the enterprise (3-64 characters).
        /// </summary>
        [JsonPropertyName("legal_name")]
        public string? LegalName { get; set; }

        /// <summary>
        /// Website of the enterprise.
        /// </summary>
        [JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// US Federal Employer Identification Number ("NN-NNNNNNN") or Canadian equivalent.
        /// </summary>
        [JsonPropertyName("fein")]
        public string? Fein { get; set; }

        /// <summary>
        /// Industry classification (e.g. "technology", "healthcare").
        /// </summary>
        [JsonPropertyName("industry")]
        public string? Industry { get; set; }

        /// <summary>
        /// Approximate headcount range (e.g. "51-200").
        /// </summary>
        [JsonPropertyName("number_of_employees")]
        public string? NumberOfEmployees { get; set; }

        /// <summary>
        /// Legal-entity form (e.g. "corporation", "llc").
        /// </summary>
        [JsonPropertyName("organization_legal_type")]
        public string? OrganizationLegalType { get; set; }

        /// <summary>
        /// Trading name of the enterprise.
        /// </summary>
        [JsonPropertyName("doing_business_as")]
        public string? DoingBusinessAs { get; set; }

        /// <summary>
        /// Optional free-form string the caller can attach for their own bookkeeping.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Optional SIC code for the primary line of business.
        /// </summary>
        [JsonPropertyName("primary_business_domain_sic_code")]
        public string? PrimaryBusinessDomainSicCode { get; set; }

        /// <summary>
        /// Optional corporate-registration / company-number identifier.
        /// </summary>
        [JsonPropertyName("corporate_registration_number")]
        public string? CorporateRegistrationNumber { get; set; }

        /// <summary>
        /// Optional professional-license number for regulated industries.
        /// </summary>
        [JsonPropertyName("professional_license_number")]
        public string? ProfessionalLicenseNumber { get; set; }

        /// <summary>
        /// Optional D-U-N-S Number.
        /// </summary>
        [JsonPropertyName("dun_bradstreet_number")]
        public string? DunBradstreetNumber { get; set; }

        /// <summary>
        /// Updated state/province/country of incorporation.
        /// </summary>
        [JsonPropertyName("jurisdiction_of_incorporation")]
        public string? JurisdictionOfIncorporation { get; set; }

        /// <summary>
        /// Organization contact details.
        /// </summary>
        [JsonPropertyName("organization_contact")]
        public OrganizationContact? OrganizationContact { get; set; }

        /// <summary>
        /// Billing contact details.
        /// </summary>
        [JsonPropertyName("billing_contact")]
        public BillingContact? BillingContact { get; set; }

        /// <summary>
        /// Physical address of the organization.
        /// </summary>
        [JsonPropertyName("organization_physical_address")]
        public PhysicalAddress? OrganizationPhysicalAddress { get; set; }

        /// <summary>
        /// Billing address of the organization.
        /// </summary>
        [JsonPropertyName("billing_address")]
        public PhysicalAddress? BillingAddress { get; set; }
    }
}
