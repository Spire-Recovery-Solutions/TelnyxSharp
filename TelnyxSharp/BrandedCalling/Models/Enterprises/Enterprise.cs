using System.Text.Json.Serialization;

namespace TelnyxSharp.BrandedCalling.Models.Enterprises
{
    /// <summary>
    /// Represents the public view of an enterprise (the legal entity that represents a business)
    /// in the Branded Calling API.
    /// </summary>
    public class Enterprise
    {
        /// <summary>
        /// Server-assigned unique identifier of the enterprise.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Legal name of the enterprise.
        /// </summary>
        [JsonPropertyName("legal_name")]
        public string? LegalName { get; set; }

        /// <summary>
        /// Organization category for vetting purposes (e.g. "commercial", "government", "non_profit").
        /// </summary>
        [JsonPropertyName("organization_type")]
        public string? OrganizationType { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code. Currently "US" and "CA" are supported.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// "enterprise" for an organization registering its own DIRs; "bpo" for a Business Process
        /// Outsourcer placing calls on behalf of one or more enterprises.
        /// </summary>
        [JsonPropertyName("role_type")]
        public string? RoleType { get; set; }

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
        /// Legal-entity form (e.g. "corporation", "llc", "partnership", "nonprofit", "other").
        /// </summary>
        [JsonPropertyName("organization_legal_type")]
        public string? OrganizationLegalType { get; set; }

        /// <summary>
        /// Trading name of the enterprise.
        /// </summary>
        [JsonPropertyName("doing_business_as")]
        public string? DoingBusinessAs { get; set; }

        /// <summary>
        /// State/province/country of incorporation.
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
        /// Optional D-U-N-S Number issued by Dun &amp; Bradstreet.
        /// </summary>
        [JsonPropertyName("dun_bradstreet_number")]
        public string? DunBradstreetNumber { get; set; }

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

        /// <summary>
        /// True once Branded Calling has been activated on this enterprise.
        /// </summary>
        [JsonPropertyName("branded_calling_enabled")]
        public bool? BrandedCallingEnabled { get; set; }

        /// <summary>
        /// True once Phone Number Reputation has been enabled on this enterprise.
        /// </summary>
        [JsonPropertyName("number_reputation_enabled")]
        public bool? NumberReputationEnabled { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the enterprise was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the enterprise was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }
    }

    /// <summary>
    /// Represents the organization contact for an enterprise registration.
    /// </summary>
    public class OrganizationContact
    {
        /// <summary>
        /// First name of the contact.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of the contact.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Email address of the contact.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Job title of the contact.
        /// </summary>
        [JsonPropertyName("job_title")]
        public string? JobTitle { get; set; }

        /// <summary>
        /// Phone number of the contact in E.164 format with leading "+".
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }
    }

    /// <summary>
    /// Represents the billing contact for an enterprise registration.
    /// </summary>
    public class BillingContact
    {
        /// <summary>
        /// First name of the contact.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of the contact.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Email address of the contact.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Phone number of the contact in E.164 format with leading "+".
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }
    }

    /// <summary>
    /// Represents a physical address used in an enterprise registration.
    /// </summary>
    public class PhysicalAddress
    {
        /// <summary>
        /// ISO 3166-1 alpha-2 country code (currently "US" or "CA").
        /// </summary>
        [JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// State or province code (e.g. "IL", "ON").
        /// </summary>
        [JsonPropertyName("administrative_area")]
        public string? AdministrativeArea { get; set; }

        /// <summary>
        /// City name.
        /// </summary>
        [JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        [JsonPropertyName("postal_code")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// Street address.
        /// </summary>
        [JsonPropertyName("street_address")]
        public string? StreetAddress { get; set; }

        /// <summary>
        /// Optional extended address (e.g. suite number).
        /// </summary>
        [JsonPropertyName("extended_address")]
        public string? ExtendedAddress { get; set; }
    }
}
