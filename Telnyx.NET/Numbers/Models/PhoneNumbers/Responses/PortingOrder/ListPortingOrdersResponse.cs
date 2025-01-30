
using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Response model for listing phone number porting orders, inheriting from TelnyxResponse
    /// </summary>
    public partial class ListPortingOrdersResponse : TelnyxResponse<List<PortingOrder>>
    {
    }

    /// <summary>
    /// Settings controlling the activation process of ported numbers
    /// </summary>
    public partial class PortingOrdersActivationSettings
    {
        /// <summary>Current status of the activation process</summary>
        [JsonPropertyName("activation_status")]
        public string? ActivationStatus { get; set; }

        /// <summary>Type of activation process being used</summary>
        [JsonPropertyName("activation_type")]
        public string? ActivationType { get; set; }

        /// <summary>Indicates if the order is eligible for expedited porting</summary>
        [JsonPropertyName("fast_port_eligible")]
        public bool? FastPortEligible { get; set; }

        /// <summary>Actual Firm Order Commitment (FOC) date and time</summary>
        [JsonPropertyName("foc_datetime_actual")]
        public DateTimeOffset? FocDatetimeActual { get; set; }

        /// <summary>Requested Firm Order Commitment (FOC) date and time</summary>
        [JsonPropertyName("foc_datetime_requested")]
        public DateTimeOffset? FocDatetimeRequested { get; set; }
    }

    /// <summary>
    /// Required documents for the porting process
    /// </summary>
    public partial class PortingOrdersDocuments
    {
        /// <summary>Letter of Authorization document URL or identifier</summary>
        [JsonPropertyName("loa")]
        public string? Loa { get; set; }

        /// <summary>Invoice document URL or identifier</summary>
        [JsonPropertyName("invoice")]
        public string? Invoice { get; set; }
    }

    /// <summary>
    /// End user information including administrative contact and location
    /// </summary>
    public partial class PortingOrdersEndUser
    {
        /// <summary>Administrative contact information</summary>
        [JsonPropertyName("admin")]
        public PortingOrdersAdmin? Admin { get; set; }

        /// <summary>Physical location information</summary>
        [JsonPropertyName("location")]
        public PortingOrdersLocation? Location { get; set; }
    }

    /// <summary>
    /// Administrative contact information for the end user
    /// </summary>
    public partial class PortingOrdersAdmin
    {
        /// <summary>Account number with current service provider</summary>
        [JsonPropertyName("account_number")]
        public string? AccountNumber { get; set; }

        /// <summary>Name of authorized person for the port request</summary>
        [JsonPropertyName("auth_person_name")]
        public string? AuthPersonName { get; set; }

        /// <summary>Billing phone number on the account</summary>
        [JsonPropertyName("billing_phone_number")]
        public string? BillingPhoneNumber { get; set; }

        /// <summary>Business identifier (if applicable)</summary>
        [JsonPropertyName("business_identifier")]
        public string? BusinessIdentifier { get; set; }

        /// <summary>Legal entity name</summary>
        [JsonPropertyName("entity_name")]
        public string? EntityName { get; set; }

        /// <summary>PIN or passcode for account verification</summary>
        [JsonPropertyName("pin_passcode")]
        public string? PinPasscode { get; set; }

        /// <summary>Tax identifier (e.g., EIN, SSN)</summary>
        [JsonPropertyName("tax_identifier")]
        public string? TaxIdentifier { get; set; }
    }

    /// <summary>
    /// Physical location information for the end user
    /// </summary>
    public partial class PortingOrdersLocation
    {
        /// <summary>State/Province</summary>
        [JsonPropertyName("administrative_area")]
        public string? AdministrativeArea { get; set; }

        /// <summary>Two-letter country code</summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>Additional address information (apt, suite, etc.)</summary>
        [JsonPropertyName("extended_address")]
        public string? ExtendedAddress { get; set; }

        /// <summary>City</summary>
        [JsonPropertyName("locality")]
        public string? Locality { get; set; }

        /// <summary>ZIP/Postal code</summary>
        [JsonPropertyName("postal_code")]
        public string? PostalCode { get; set; }

        /// <summary>Street address</summary>
        [JsonPropertyName("street_address")]
        public string? StreetAddress { get; set; }
    }

    /// <summary>
    /// Miscellaneous porting order settings
    /// </summary>
    public partial class PortingOrdersMisc
    {
        /// <summary>New billing phone number after port</summary>
        [JsonPropertyName("new_billing_phone_number")]
        public string? NewBillingPhoneNumber { get; set; }

        /// <summary>Action for remaining numbers on the account</summary>
        [JsonPropertyName("remaining_numbers_action")]
        public string? RemainingNumbersAction { get; set; }

        /// <summary>Type of miscellaneous configuration</summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    /// <summary>
    /// Configuration settings for ported phone numbers
    /// </summary>
    public partial class PortingOrdersPhoneNumberConfiguration
    {
        /// <summary>Connection identifier for routing</summary>
        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        /// <summary>Emergency service address identifier</summary>
        [JsonPropertyName("emergency_address_id")]
        public string? EmergencyAddressId { get; set; }

        /// <summary>Messaging profile identifier</summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>Custom tags for the phone numbers</summary>
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }
    }

    /// <summary>
    /// Individual phone number information in a porting order
    /// </summary>
    public partial class PortingOrdersPhoneNumber
    {
        /// <summary>Current activation status</summary>
        [JsonPropertyName("activation_status")]
        public string? ActivationStatus { get; set; }

        /// <summary>The phone number being ported</summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>Type of phone number (e.g., landline, mobile)</summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>Current portability status</summary>
        [JsonPropertyName("portability_status")]
        public string? PortabilityStatus { get; set; }

        /// <summary>Associated porting order identifier</summary>
        [JsonPropertyName("porting_order_id")]
        public string? PortingOrderId { get; set; }

        /// <summary>Current status of the porting order</summary>
        [JsonPropertyName("porting_order_status")]
        public string? PortingOrderStatus { get; set; }

        /// <summary>Type of record</summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>Status of porting requirements</summary>
        [JsonPropertyName("requirements_status")]
        public string? RequirementsStatus { get; set; }

        /// <summary>Support identifier</summary>
        [JsonPropertyName("support_key")]
        public string? SupportKey { get; set; }
    }

    /// <summary>
    /// Status information for the porting order
    /// </summary>
    public partial class PortingOrdersStatus
    {
        /// <summary>Detailed status information</summary>
        [JsonPropertyName("details")]
        public List<PortingOrdersDetail>? Details { get; set; }

        /// <summary>Current status value</summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }

    /// <summary>
    /// Detailed status information
    /// </summary>
    public partial class PortingOrdersDetail
    {
        /// <summary>Status code</summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>Human-readable description of the status</summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }

    /// <summary>
    /// User feedback about the porting process
    /// </summary>
    public partial class PortingOrdersUserFeedback
    {
        /// <summary>User's comments about the porting process</summary>
        [JsonPropertyName("user_comment")]
        public string? UserComment { get; set; }

        /// <summary>User's rating of the porting process</summary>
        [JsonPropertyName("user_rating")]
        public string? UserRating { get; set; }
    }
}
