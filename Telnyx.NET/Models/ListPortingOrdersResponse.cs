
using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public partial class ListPortingOrdersResponse : TelnyxResponse
    {
        [JsonPropertyName("data")]
        public List<ListPortingOrdersDatum> Data { get; set; }

        [JsonPropertyName("meta")]
        public PaginationMeta Meta { get; set; }
    }

    public partial class ListPortingOrdersDatum
    {
        [JsonPropertyName("activation_settings")]
        public ListPortingOrdersActivationSettings ActivationSettings { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("documents")]
        public ListPortingOrdersDocuments Documents { get; set; }

        [JsonPropertyName("end_user")]
        public ListPortingOrdersEndUser EndUser { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("misc")]
        public ListPortingOrdersMisc Misc { get; set; }

        [JsonPropertyName("old_service_provider_ocn")]
        public string? OldServiceProviderOcn { get; set; }

        [JsonPropertyName("parent_support_key")]
        public string? ParentSupportKey { get; set; }

        [JsonPropertyName("phone_number_configuration")]
        public ListPortingOrdersPhoneNumberConfiguration PhoneNumberConfiguration { get; set; }

        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        [JsonPropertyName("phone_numbers")]
        public List<ListPortingOrdersPhoneNumber> PhoneNumbers { get; set; }

        [JsonPropertyName("porting_phone_numbers_count")]
        public long PortingPhoneNumbersCount { get; set; }

        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        [JsonPropertyName("requirements")]
        public List<string> Requirements { get; set; }

        [JsonPropertyName("requirements_met")]
        public bool? RequirementsMet { get; set; }

        [JsonPropertyName("status")]
        public ListPortingOrdersStatus Status { get; set; }

        [JsonPropertyName("support_key")]
        public string? SupportKey { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonPropertyName("user_feedback")]
        public ListPortingOrdersUserFeedback UserFeedback { get; set; }

        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }
    }

    public partial class ListPortingOrdersActivationSettings
    {
        [JsonPropertyName("activation_status")]
        public string? ActivationStatus { get; set; }

        [JsonPropertyName("activation_type")]
        public string? ActivationType { get; set; }

        [JsonPropertyName("fast_port_eligible")]
        public bool? FastPortEligible { get; set; }

        [JsonPropertyName("foc_datetime_actual")]
        public DateTimeOffset? FocDatetimeActual { get; set; }

        [JsonPropertyName("foc_datetime_requested")]
        public DateTimeOffset? FocDatetimeRequested { get; set; }
    }

    public partial class ListPortingOrdersDocuments
    {
        [JsonPropertyName("loa")]
        public string? Loa { get; set; }

        [JsonPropertyName("invoice")]
        public string? Invoice { get; set; }
    }

    public partial class ListPortingOrdersEndUser
    {
        [JsonPropertyName("admin")]
        public ListPortingOrdersAdmin Admin { get; set; }

        [JsonPropertyName("location")]
        public ListPortingOrdersLocation Location { get; set; }
    }

    public partial class ListPortingOrdersAdmin
    {
        [JsonPropertyName("account_number")]
        public string? AccountNumber { get; set; }

        [JsonPropertyName("auth_person_name")]
        public string? AuthPersonName { get; set; }

        [JsonPropertyName("billing_phone_number")]
        public string? BillingPhoneNumber { get; set; }

        [JsonPropertyName("business_identifier")]
        public string? BusinessIdentifier { get; set; }

        [JsonPropertyName("entity_name")]
        public string? EntityName { get; set; }

        [JsonPropertyName("pin_passcode")]
        public string? PinPasscode { get; set; }

        [JsonPropertyName("tax_identifier")]
        public string? TaxIdentifier { get; set; }
    }

    public partial class ListPortingOrdersLocation
    {
        [JsonPropertyName("administrative_area")]
        public string? AdministrativeArea { get; set; }

        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        [JsonPropertyName("extended_address")]
        public string? ExtendedAddress { get; set; }

        [JsonPropertyName("locality")]
        public string? Locality { get; set; }

        [JsonPropertyName("postal_code")]
        public string? PostalCode { get; set; }

        [JsonPropertyName("street_address")]
        public string? StreetAddress { get; set; }
    }

    public partial class ListPortingOrdersMisc
    {
        [JsonPropertyName("new_billing_phone_number")]
        public string? NewBillingPhoneNumber { get; set; }

        [JsonPropertyName("remaining_numbers_action")]
        public string? RemainingNumbersAction { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public partial class ListPortingOrdersPhoneNumberConfiguration
    {
        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        [JsonPropertyName("emergency_address_id")]
        public string? EmergencyAddressId { get; set; }

        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }
    }

    public partial class ListPortingOrdersPhoneNumber
    {
        [JsonPropertyName("activation_status")]
        public string? ActivationStatus { get; set; }

        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        [JsonPropertyName("portability_status")]
        public string? PortabilityStatus { get; set; }

        [JsonPropertyName("porting_order_id")]
        public string? PortingOrderId { get; set; }

        [JsonPropertyName("porting_order_status")]
        public string? PortingOrderStatus { get; set; }

        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        [JsonPropertyName("requirements_status")]
        public string? RequirementsStatus { get; set; }

        [JsonPropertyName("support_key")]
        public string? SupportKey { get; set; }
    }

    public partial class ListPortingOrdersStatus
    {
        [JsonPropertyName("details")]
        public List<ListPortingOrdersDetail> Details { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }

    public partial class ListPortingOrdersDetail
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }

    public partial class ListPortingOrdersUserFeedback
    {
        [JsonPropertyName("user_comment")]
        public string? UserComment { get; set; }

        [JsonPropertyName("user_rating")]
        public string? UserRating { get; set; }
    }
}
