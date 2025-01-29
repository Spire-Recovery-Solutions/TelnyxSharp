using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to edit an existing porting order with the option to modify 
    /// various aspects of the porting process such as the end user, documents, and settings.
    /// </summary>
    public class EditPortingOrderRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the miscellaneous settings related to the porting order.
        /// </summary>
        [JsonPropertyName("misc")]
        public PortingOrdersMisc? Misc { get; set; }

        /// <summary>
        /// Gets or sets the end user details for the porting order.
        /// </summary>
        [JsonPropertyName("end_user")]
        public PortingOrdersEndUser? EndUser { get; set; }

        /// <summary>
        /// Gets or sets the documents related to the porting order.
        /// </summary>
        [JsonPropertyName("documents")]
        public PortingOrdersDocuments? Documents { get; set; }

        /// <summary>
        /// Gets or sets the activation settings for the porting order.
        /// </summary>
        [JsonPropertyName("activation_settings")]
        public PortingOrdersActivationSettings? ActivationSettings { get; set; }

        /// <summary>
        /// Gets or sets the phone number configuration for the porting order.
        /// </summary>
        [JsonPropertyName("phone_number_configuration")]
        public PortingOrdersPhoneNumberConfiguration? PhoneNumberConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the requirement group ID for the porting order.
        /// </summary>
        [JsonPropertyName("requirement_group_id")]
        public string? RequirementGroupId { get; set; }

        /// <summary>
        /// Gets or sets the list of porting requirements associated with the porting order.
        /// </summary>
        [JsonPropertyName("requirements")]
        public List<PortingRequirement>? Requirements { get; set; }

        /// <summary>
        /// Gets or sets the user feedback for the porting order.
        /// </summary>
        [JsonPropertyName("user_feedback")]
        public PortingOrdersUserFeedback? UserFeedback { get; set; }

        /// <summary>
        /// Gets or sets the URL for webhook notifications related to the porting order.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Gets or sets a reference that can be used by the customer for tracking the porting order.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the messaging information related to the porting order.
        /// </summary>
        [JsonPropertyName("messaging")]
        public MessagingInfo? Messaging { get; set; }
    }
}