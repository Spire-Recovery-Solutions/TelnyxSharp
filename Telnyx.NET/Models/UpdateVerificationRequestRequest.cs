using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class UpdateVerificationRequestRequest : ITelnyxRequest
    {
        [JsonPropertyName("businessName")]
        public required string BusinessName { get; set; }

        [JsonPropertyName("corporateWebsite")]
        public required string CorporateWebsite { get; set; }

        [JsonPropertyName("businessAddr1")]
        public required string BusinessAddr1 { get; set; }

        [JsonPropertyName("businessAddr2")]
        public string BusinessAddr2 { get; set; } = string.Empty;

        [JsonPropertyName("businessCity")]
        public required string BusinessCity { get; set; }

        [JsonPropertyName("businessState")]
        public required string BusinessState { get; set; }

        [JsonPropertyName("businessZip")]
        public required string BusinessZip { get; set; }

        [JsonPropertyName("businessContactFirstName")]
        public required string BusinessContactFirstName { get; set; }

        [JsonPropertyName("businessContactLastName")]
        public required string BusinessContactLastName { get; set; }

        [JsonPropertyName("businessContactEmail")]
        public required string BusinessContactEmail { get; set; }

        [JsonPropertyName("businessContactPhone")]
        public required string BusinessContactPhone { get; set; }

        [JsonPropertyName("messageVolume")]
        public required string MessageVolume { get; set; }

        [JsonPropertyName("phoneNumbers")]
        public required List<PhoneNumber> PhoneNumbers { get; set; }

        [JsonPropertyName("useCase")]
        public required string UseCase { get; set; }

        [JsonPropertyName("useCaseSummary")]
        public required string UseCaseSummary { get; set; }

        [JsonPropertyName("productionMessageContent")]
        public required string ProductionMessageContent { get; set; }

        [JsonPropertyName("optInWorkflow")]
        public required string OptInWorkflow { get; set; }

        [JsonPropertyName("optInWorkflowImageURLs")]
        public required List<OptInWorkflowImage> OptInWorkflowImageURLs { get; set; }

        [JsonPropertyName("additionalInformation")]
        public required string AdditionalInformation { get; set; }

        [JsonPropertyName("isvReseller")]
        public required string IsvReseller { get; set; }

        [JsonPropertyName("webhookUrl")]
        public string WebhookUrl { get; set; } = string.Empty;

    }
}

