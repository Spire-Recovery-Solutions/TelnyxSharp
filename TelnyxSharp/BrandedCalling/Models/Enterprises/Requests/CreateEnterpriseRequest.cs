using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.BrandedCalling.Models.Enterprises.Requests
{
    /// <summary>
    /// Represents a request to create an enterprise (the legal entity that represents a business)
    /// in the Branded Calling API.
    /// </summary>
    public class CreateEnterpriseRequest : ITelnyxRequest
    {
        /// <summary>
        /// Legal name of the enterprise (3-64 characters). Required.
        /// </summary>
        [JsonPropertyName("legal_name")]
        public string? LegalName { get; set; }

        /// <summary>
        /// Organization category for vetting purposes: "commercial", "government", or "non_profit". Required.
        /// </summary>
        [JsonPropertyName("organization_type")]
        public string? OrganizationType { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code. Currently "US" and "CA" are supported. Required.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// "enterprise" for an organization registering its own DIRs; "bpo" for a Business Process
        /// Outsourcer placing calls on behalf of one or more enterprises. Defaults to "enterprise".
        /// </summary>
        [JsonPropertyName("role_type")]
        public string? RoleType { get; set; }

        /// <summary>
        /// Website of the enterprise. Required.
        /// </summary>
        [JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// US Federal Employer Identification Number ("NN-NNNNNNN") or Canadian equivalent. Required.
        /// </summary>
        [JsonPropertyName("fein")]
        public string? Fein { get; set; }

        /// <summary>
        /// Industry classification (e.g. "technology", "healthcare"). Required.
        /// </summary>
        [JsonPropertyName("industry")]
        public string? Industry { get; set; }

        /// <summary>
        /// Approximate headcount range (e.g. "1-10", "51-200", "10001+"). Required.
        /// </summary>
        [JsonPropertyName("number_of_employees")]
        public string? NumberOfEmployees { get; set; }

        /// <summary>
        /// Legal-entity form: "corporation", "llc", "partnership", "nonprofit", or "other". Required.
        /// </summary>
        [JsonPropertyName("organization_legal_type")]
        public string? OrganizationLegalType { get; set; }

        /// <summary>
        /// Trading name of the enterprise. Required.
        /// </summary>
        [JsonPropertyName("doing_business_as")]
        public string? DoingBusinessAs { get; set; }

        /// <summary>
        /// State/province/country of incorporation. Required.
        /// </summary>
        [JsonPropertyName("jurisdiction_of_incorporation")]
        public string? JurisdictionOfIncorporation { get; set; }

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
        /// Organization contact details. Required.
        /// </summary>
        [JsonPropertyName("organization_contact")]
        public OrganizationContact? OrganizationContact { get; set; }

        /// <summary>
        /// Billing contact details. Required.
        /// </summary>
        [JsonPropertyName("billing_contact")]
        public BillingContact? BillingContact { get; set; }

        /// <summary>
        /// Physical address of the organization. Required.
        /// </summary>
        [JsonPropertyName("organization_physical_address")]
        public PhysicalAddress? OrganizationPhysicalAddress { get; set; }

        /// <summary>
        /// Billing address of the organization. Required.
        /// </summary>
        [JsonPropertyName("billing_address")]
        public PhysicalAddress? BillingAddress { get; set; }
    }
}
