using System.Text.Json.Serialization;
using TelnyxSharp.Enums;
using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.TollFreeVerificationOperations
{
    /// <summary>
    /// Represents the base response model for a verification request.
    /// This class contains common information related to the verification request and can be extended by other response models.
    /// </summary>
    public class BaseVerificationRequestResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the name of the business associated with the verification request.
        /// </summary>
        [JsonPropertyName("businessName")]
        public string BusinessName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the corporate website of the business.
        /// </summary>
        [JsonPropertyName("corporateWebsite")]
        public string CorporateWebsite { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the first line of the business address.
        /// </summary>
        [JsonPropertyName("businessAddr1")]
        public string BusinessAddr1 { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the second line of the business address (optional).
        /// </summary>
        [JsonPropertyName("businessAddr2")]
        public string? BusinessAddr2 { get; set; }

        /// <summary>
        /// Gets or sets the city of the business address.
        /// </summary>
        [JsonPropertyName("businessCity")]
        public string BusinessCity { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the state of the business address.
        /// </summary>
        [JsonPropertyName("businessState")]
        public string BusinessState { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the zip code of the business address.
        /// </summary>
        [JsonPropertyName("businessZip")]
        public string BusinessZip { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the first name of the business contact.
        /// </summary>
        [JsonPropertyName("businessContactFirstName")]
        public string BusinessContactFirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the last name of the business contact.
        /// </summary>
        [JsonPropertyName("businessContactLastName")]
        public string BusinessContactLastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the email address of the business contact.
        /// </summary>
        [JsonPropertyName("businessContactEmail")]
        public string BusinessContactEmail { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the phone number of the business contact.
        /// </summary>
        [JsonPropertyName("businessContactPhone")]
        public string BusinessContactPhone { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the message volume associated with the verification request.
        /// </summary>
        [JsonPropertyName("messageVolume")]
        public MessageVolume MessageVolume { get; set; } = MessageVolume.Unknown;

        /// <summary>
        /// Gets or sets the list of phone numbers included in the verification request.
        /// </summary>
        [JsonPropertyName("phoneNumbers")]
        public List<PhoneNumber> PhoneNumbers { get; set; } = new();

        /// <summary>
        /// Gets or sets the use case associated with the verification request.
        /// </summary>
        [JsonPropertyName("useCase")]
        public UseCaseCategories UseCase { get; set; } = UseCaseCategories.Unknown;

        /// <summary>
        /// Gets or sets a summary of the use case for the verification request.
        /// </summary>
        [JsonPropertyName("useCaseSummary")]
        public string UseCaseSummary { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the content of the production message associated with the verification request.
        /// </summary>
        [JsonPropertyName("productionMessageContent")]
        public string ProductionMessageContent { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the opt-in workflow associated with the verification request.
        /// </summary>
        [JsonPropertyName("optInWorkflow")]
        public string OptInWorkflow { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of opt-in workflow image URLs associated with the verification request.
        /// </summary>
        [JsonPropertyName("optInWorkflowImageURLs")]
        public List<OptInWorkflowImage> OptInWorkflowImageURLs { get; set; } = new();

        /// <summary>
        /// Gets or sets any additional information related to the verification request.
        /// </summary>
        [JsonPropertyName("additionalInformation")]
        public string AdditionalInformation { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the ISV reseller information associated with the verification request.
        /// </summary>
        [JsonPropertyName("isvReseller")]
        public string IsvReseller { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL for the webhook where the verification request results will be sent.
        /// </summary>
        [JsonPropertyName("webhookUrl")]
        public string WebhookUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier for the verification request.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the verification status of the request.
        /// </summary>
        [JsonPropertyName("verificationStatus")]
        public VerificationStatus VerificationStatus { get; set; } = VerificationStatus.Unknown;

        /// <summary>
        /// Gets or sets the reason for the verification status, if applicable.
        /// </summary>
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Gets or sets the creation date and time of the verification request.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last update date and time of the verification request.
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Represents any errors encountered during the retrieval of the auto-response setting.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents a phone number included in a verification request.
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Gets or sets the phone number value.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumberValue { get; set; } = string.Empty;
    }

    /// <summary>
    /// Represents an opt-in workflow image associated with a verification request.
    /// </summary>
    public class OptInWorkflowImage
    {
        /// <summary>
        /// Gets or sets the URL of the opt-in workflow image.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
    }
}