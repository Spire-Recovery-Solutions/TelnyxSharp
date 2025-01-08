using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Messaging.Models.TollFreeVerificationOperations
{
    /// <summary>
    /// Request model for updating verification information related to a business.
    /// This model is used to submit the necessary details to update the verification process for a business.
    /// </summary>
    public class UpdateVerificationRequestRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the business name.
        /// </summary>
        [JsonPropertyName("businessName")]
        public required string BusinessName { get; set; }

        /// <summary>
        /// Gets or sets the corporate website URL of the business.
        /// </summary>
        [JsonPropertyName("corporateWebsite")]
        public required string CorporateWebsite { get; set; }

        /// <summary>
        /// Gets or sets the first line of the business address.
        /// </summary>
        [JsonPropertyName("businessAddr1")]
        public required string BusinessAddr1 { get; set; }

        /// <summary>
        /// Gets or sets the second line of the business address (optional).
        /// </summary>
        [JsonPropertyName("businessAddr2")]
        public string BusinessAddr2 { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the city where the business is located.
        /// </summary>
        [JsonPropertyName("businessCity")]
        public required string BusinessCity { get; set; }

        /// <summary>
        /// Gets or sets the state where the business is located.
        /// </summary>
        [JsonPropertyName("businessState")]
        public required string BusinessState { get; set; }

        /// <summary>
        /// Gets or sets the zip code of the business address.
        /// </summary>
        [JsonPropertyName("businessZip")]
        public required string BusinessZip { get; set; }

        /// <summary>
        /// Gets or sets the first name of the business contact.
        /// </summary>
        [JsonPropertyName("businessContactFirstName")]
        public required string BusinessContactFirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the business contact.
        /// </summary>
        [JsonPropertyName("businessContactLastName")]
        public required string BusinessContactLastName { get; set; }

        /// <summary>
        /// Gets or sets the email address of the business contact.
        /// </summary>
        [JsonPropertyName("businessContactEmail")]
        public required string BusinessContactEmail { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the business contact.
        /// </summary>
        [JsonPropertyName("businessContactPhone")]
        public required string BusinessContactPhone { get; set; }

        /// <summary>
        /// Gets or sets the estimated message volume the business expects to handle.
        /// </summary>
        [JsonPropertyName("messageVolume")]
        public required MessageVolume MessageVolume { get; set; }

        /// <summary>
        /// Gets or sets the list of phone numbers associated with the business.
        /// </summary>
        [JsonPropertyName("phoneNumbers")]
        public required List<PhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or sets the use case category for the business.
        /// </summary>
        [JsonPropertyName("useCase")]
        public required UseCaseCategories UseCase { get; set; }

        /// <summary>
        /// Gets or sets a detailed summary of the business's use case for verification.
        /// </summary>
        [JsonPropertyName("useCaseSummary")]
        public required string UseCaseSummary { get; set; }

        /// <summary>
        /// Gets or sets the content of the production messages that the business plans to send.
        /// </summary>
        [JsonPropertyName("productionMessageContent")]
        public required string ProductionMessageContent { get; set; }

        /// <summary>
        /// Gets or sets the opt-in workflow information for the business.
        /// </summary>
        [JsonPropertyName("optInWorkflow")]
        public required string OptInWorkflow { get; set; }

        /// <summary>
        /// Gets or sets a list of image URLs related to the opt-in workflow.
        /// </summary>
        [JsonPropertyName("optInWorkflowImageURLs")]
        public required List<OptInWorkflowImage> OptInWorkflowImageURLs { get; set; }

        /// <summary>
        /// Gets or sets any additional information that may be required for the verification request.
        /// </summary>
        [JsonPropertyName("additionalInformation")]
        public required string AdditionalInformation { get; set; }

        /// <summary>
        /// Gets or sets the ISV reseller information, if applicable.
        /// </summary>
        [JsonPropertyName("isvReseller")]
        public required string IsvReseller { get; set; }

        /// <summary>
        /// Gets or sets the webhook URL for receiving updates regarding the verification status.
        /// </summary>
        [JsonPropertyName("webhookUrl")]
        public string WebhookUrl { get; set; } = string.Empty;
    }
}