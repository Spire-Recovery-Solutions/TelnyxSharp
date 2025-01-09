using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Messaging.Models.TollFreeVerificationOperations.Requests
{
    /// <summary>
    /// Represents the request model for submitting a verification request.
    /// </summary>
    public class SubmitVerificationRequestRequest : ITelnyxRequest
    {
        /// <summary>
        /// The name of the business requesting verification.
        /// </summary>
        [JsonPropertyName("businessName")]
        public required string BusinessName { get; set; }

        /// <summary>
        /// The corporate website of the business.
        /// </summary>
        [JsonPropertyName("corporateWebsite")]
        public required string CorporateWebsite { get; set; }

        /// <summary>
        /// The primary address line of the business.
        /// </summary>
        [JsonPropertyName("businessAddr1")]
        public required string BusinessAddr1 { get; set; }

        /// <summary>
        /// The secondary address line of the business (if applicable).
        /// </summary>
        [JsonPropertyName("businessAddr2")]
        public string BusinessAddr2 { get; set; } = string.Empty;

        /// <summary>
        /// The city where the business is located.
        /// </summary>
        [JsonPropertyName("businessCity")]
        public required string BusinessCity { get; set; }

        /// <summary>
        /// The state or province where the business is located.
        /// </summary>
        [JsonPropertyName("businessState")]
        public required string BusinessState { get; set; }

        /// <summary>
        /// The ZIP or postal code of the business address.
        /// </summary>
        [JsonPropertyName("businessZip")]
        public required string BusinessZip { get; set; }

        /// <summary>
        /// The first name of the business contact person.
        /// </summary>
        [JsonPropertyName("businessContactFirstName")]
        public required string BusinessContactFirstName { get; set; }

        /// <summary>
        /// The last name of the business contact person.
        /// </summary>
        [JsonPropertyName("businessContactLastName")]
        public required string BusinessContactLastName { get; set; }

        /// <summary>
        /// The email address of the business contact person.
        /// </summary>
        [JsonPropertyName("businessContactEmail")]
        public required string BusinessContactEmail { get; set; }

        /// <summary>
        /// The phone number of the business contact person.
        /// </summary>
        [JsonPropertyName("businessContactPhone")]
        public required string BusinessContactPhone { get; set; }

        /// <summary>
        /// The estimated message volume for the business.
        /// </summary>
        [JsonPropertyName("messageVolume")]
        public required string MessageVolume { get; set; }

        /// <summary>
        /// A list of phone numbers associated with the business.
        /// </summary>
        [JsonPropertyName("phoneNumbers")]
        public required List<PhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// The primary use case for messaging by the business.
        /// </summary>
        [JsonPropertyName("useCase")]
        public required string UseCase { get; set; }

        /// <summary>
        /// A summary of the use case for messaging.
        /// </summary>
        [JsonPropertyName("useCaseSummary")]
        public required string UseCaseSummary { get; set; }

        /// <summary>
        /// Example content of production messages.
        /// </summary>
        [JsonPropertyName("productionMessageContent")]
        public required string ProductionMessageContent { get; set; }

        /// <summary>
        /// Details of the opt-in workflow for customers.
        /// </summary>
        [JsonPropertyName("optInWorkflow")]
        public required string OptInWorkflow { get; set; }

        /// <summary>
        /// URLs of images illustrating the opt-in workflow.
        /// </summary>
        [JsonPropertyName("optInWorkflowImageURLs")]
        public required List<OptInWorkflowImage> OptInWorkflowImageUrls { get; set; }

        /// <summary>
        /// Any additional information provided by the business.
        /// </summary>
        [JsonPropertyName("additionalInformation")]
        public required string AdditionalInformation { get; set; }

        /// <summary>
        /// Specifies if the business is an ISV reseller.
        /// </summary>
        [JsonPropertyName("isvReseller")]
        public required string IsvReseller { get; set; }

        /// <summary>
        /// The webhook URL for receiving updates about the verification request.
        /// </summary>
        [JsonPropertyName("webhookUrl")]
        public string WebhookUrl { get; set; } = string.Empty;
    }
}