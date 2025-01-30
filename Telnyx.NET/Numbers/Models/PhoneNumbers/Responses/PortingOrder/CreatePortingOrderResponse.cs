using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response returned when a porting order is created.
    /// Inherits from TelnyxResponse and contains a list of PortingOrder objects.
    /// </summary>
    public class CreatePortingOrderResponse : TelnyxResponse<List<PortingOrder>>
    {
    }

    /// <summary>
    /// Represents a porting order with various properties that describe its status,
    /// associated customer references, phone numbers, documents, and other details.
    /// </summary>
    public class PortingOrder
    {
        /// <summary>
        /// The unique identifier for the porting order.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The customer reference associated with the porting order.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// The timestamp when the porting order was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the porting order was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// The current status of the porting order.
        /// </summary>
        [JsonPropertyName("status")]
        public PortingOrdersStatus? Status { get; set; }

        /// <summary>
        /// A unique key for support related to the porting order.
        /// </summary>
        [JsonPropertyName("support_key")]
        public string? SupportKey { get; set; }

        /// <summary>
        /// A key for the parent support ticket, if applicable.
        /// </summary>
        [JsonPropertyName("parent_support_key")]
        public string? ParentSupportKey { get; set; }

        /// <summary>
        /// The count of porting phone numbers associated with the order.
        /// </summary>
        [JsonPropertyName("porting_phone_numbers_count")]
        public int? PortingPhoneNumbersCount { get; set; }

        /// <summary>
        /// The OCN (Operating Company Number) of the old service provider.
        /// </summary>
        [JsonPropertyName("old_service_provider_ocn")]
        public string? OldServiceProviderOcn { get; set; }

        /// <summary>
        /// Additional documents related to the porting order.
        /// </summary>
        [JsonPropertyName("documents")]
        public PortingOrdersDocuments? Documents { get; set; }

        /// <summary>
        /// Miscellaneous data related to the porting order.
        /// </summary>
        [JsonPropertyName("misc")]
        public PortingOrdersMisc? Misc { get; set; }

        /// <summary>
        /// The end user information for the porting order.
        /// </summary>
        [JsonPropertyName("end_user")]
        public PortingOrdersEndUser? EndUser { get; set; }

        /// <summary>
        /// The activation settings for the porting order.
        /// </summary>
        [JsonPropertyName("activation_settings")]
        public PortingOrdersActivationSettings? ActivationSettings { get; set; }

        /// <summary>
        /// The phone number configuration for the porting order.
        /// </summary>
        [JsonPropertyName("phone_number_configuration")]
        public PortingOrdersPhoneNumberConfiguration? PhoneNumberConfiguration { get; set; }

        /// <summary>
        /// The type of phone number being ported.
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// A description for the porting order.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether all requirements for the porting order have been met.
        /// </summary>
        [JsonPropertyName("requirements_met")]
        public bool? RequirementsMet { get; set; }

        /// <summary>
        /// User feedback related to the porting order.
        /// </summary>
        [JsonPropertyName("user_feedback")]
        public PortingOrdersUserFeedback? UserFeedback { get; set; }

        /// <summary>
        /// A list of requirements for the porting order.
        /// </summary>
        [JsonPropertyName("requirements")]
        public List<PortingRequirement>? Requirements { get; set; }

        /// <summary>
        /// A list of phone numbers being ported in the order.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<PortingOrdersPhoneNumber>? PhoneNumbers { get; set; }

        /// <summary>
        /// The user ID associated with the porting order.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// A webhook URL that can be used for receiving notifications related to the porting order.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// The record type associated with the porting order (e.g., comment, log).
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Messaging-related information for the porting order.
        /// </summary>
        [JsonPropertyName("messaging")]
        public MessagingInfo? Messaging { get; set; }
    }

    /// <summary>
    /// Represents the requirements for the porting order, including the field type and value.
    /// </summary>
    public class PortingRequirement
    {
        [JsonPropertyName("field_type")]
        public string? FieldType { get; set; }

        [JsonPropertyName("field_value")]
        public string? FieldValue { get; set; }

        [JsonPropertyName("requirement_type_id")]
        public string? RequirementTypeId { get; set; }

        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }
    }

    /// <summary>
    /// Represents messaging capabilities and settings for the porting order.
    /// </summary>
    public class MessagingInfo
    {
        [JsonPropertyName("messaging_capable")]
        public bool? MessagingCapable { get; set; }

        [JsonPropertyName("enable_messaging")]
        public bool? EnableMessaging { get; set; }

        [JsonPropertyName("messaging_port_status")]
        public string? MessagingPortStatus { get; set; } = string.Empty;

        [JsonPropertyName("messaging_port_completed")]
        public bool? MessagingPortCompleted { get; set; }
    }
}