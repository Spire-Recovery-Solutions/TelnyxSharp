
using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Response model for listing phone number porting orders, inheriting from TelnyxResponse
    /// </summary>
    public partial class ListPortingOrdersResponse : TelnyxResponse<List<ListPortingOrdersDatum>>
    {
    }

    /// <summary>
    /// Represents a single porting order entry with complete details including activation settings,
    /// customer information, documents, and status
    /// </summary>
    public partial class ListPortingOrdersDatum
    {
        /// <summary>
        /// Settings related to the activation of ported numbers, including timing and eligibility
        /// </summary>
        [JsonPropertyName("activation_settings")]
        public ListPortingOrdersActivationSettings ActivationSettings { get; set; }

        /// <summary>Timestamp when the porting order was created</summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>Customer's reference identifier for this order</summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>Optional description of the porting order</summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>Required documents for the porting process (LOA and invoice)</summary>
        [JsonPropertyName("documents")]
        public ListPortingOrdersDocuments Documents { get; set; }

        /// <summary>End user details including admin contact and location information</summary>
        [JsonPropertyName("end_user")]
        public ListPortingOrdersEndUser EndUser { get; set; }

        /// <summary>Unique identifier for the porting order</summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>Miscellaneous settings and configurations</summary>
        [JsonPropertyName("misc")]
        public ListPortingOrdersMisc Misc { get; set; }

        /// <summary>Operating Company Number of the current service provider</summary>
        [JsonPropertyName("old_service_provider_ocn")]
        public string? OldServiceProviderOcn { get; set; }

        /// <summary>Parent support key for grouped orders</summary>
        [JsonPropertyName("parent_support_key")]
        public string? ParentSupportKey { get; set; }

        /// <summary>Configuration settings for the ported phone numbers</summary>
        [JsonPropertyName("phone_number_configuration")]
        public ListPortingOrdersPhoneNumberConfiguration PhoneNumberConfiguration { get; set; }

        /// <summary>Type of phone number being ported (e.g., landline, mobile)</summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>List of phone numbers included in this porting order</summary>
        [JsonPropertyName("phone_numbers")]
        public List<ListPortingOrdersPhoneNumber> PhoneNumbers { get; set; }

        /// <summary>Total count of phone numbers being ported in this order</summary>
        [JsonPropertyName("porting_phone_numbers_count")]
        public long PortingPhoneNumbersCount { get; set; }

        /// <summary>Type of record in the system</summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>List of requirements that must be met for the porting order</summary>
        [JsonPropertyName("requirements")]
        public List<string> Requirements { get; set; }

        /// <summary>Indicates if all requirements have been satisfied</summary>
        [JsonPropertyName("requirements_met")]
        public bool? RequirementsMet { get; set; }

        /// <summary>Current status of the porting order including detailed information</summary>
        [JsonPropertyName("status")]
        public ListPortingOrdersStatus Status { get; set; }

        /// <summary>Unique support identifier for this order</summary>
        [JsonPropertyName("support_key")]
        public string? SupportKey { get; set; }

        /// <summary>Timestamp of the last update to the porting order</summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>Customer feedback about the porting process</summary>
        [JsonPropertyName("user_feedback")]
        public ListPortingOrdersUserFeedback UserFeedback { get; set; }

        /// <summary>Identifier of the user who created the porting order</summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>URL for receiving webhooks about order status changes</summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }
    }

    /// <summary>
    /// Settings controlling the activation process of ported numbers
    /// </summary>
    public partial class ListPortingOrdersActivationSettings
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
    public partial class ListPortingOrdersDocuments
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
    public partial class ListPortingOrdersEndUser
    {
        /// <summary>Administrative contact information</summary>
        [JsonPropertyName("admin")]
        public ListPortingOrdersAdmin Admin { get; set; }

        /// <summary>Physical location information</summary>
        [JsonPropertyName("location")]
        public ListPortingOrdersLocation Location { get; set; }
    }

    /// <summary>
    /// Administrative contact information for the end user
    /// </summary>
    public partial class ListPortingOrdersAdmin
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
    public partial class ListPortingOrdersLocation
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
    public partial class ListPortingOrdersMisc
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
    public partial class ListPortingOrdersPhoneNumberConfiguration
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
    public partial class ListPortingOrdersPhoneNumber
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
    public partial class ListPortingOrdersStatus
    {
        /// <summary>Detailed status information</summary>
        [JsonPropertyName("details")]
        public List<ListPortingOrdersDetail> Details { get; set; }

        /// <summary>Current status value</summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }

    /// <summary>
    /// Detailed status information
    /// </summary>
    public partial class ListPortingOrdersDetail
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
    public partial class ListPortingOrdersUserFeedback
    {
        /// <summary>User's comments about the porting process</summary>
        [JsonPropertyName("user_comment")]
        public string? UserComment { get; set; }

        /// <summary>User's rating of the porting process</summary>
        [JsonPropertyName("user_rating")]
        public string? UserRating { get; set; }
    }
}
