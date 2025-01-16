using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.Campaign.Responses
{
    /// <summary>
    /// Represents the response for qualifying a campaign based on its use case.
    /// This includes details about fees, sub-usecase constraints, and metadata.
    /// </summary>
    public class QualifyCampaignByUsecaseResponse : TelnyxResponse
    {
        /// <summary>
        /// The annual fee associated with the campaign's use case.
        /// </summary>
        [JsonPropertyName("annualFee")]
        public decimal AnnualFee { get; set; }

        /// <summary>
        /// The maximum number of sub-usecases allowed for the campaign.
        /// </summary>
        [JsonPropertyName("maxSubUsecases")]
        public int MaxSubUsecases { get; set; }

        /// <summary>
        /// The minimum number of sub-usecases required for the campaign.
        /// </summary>
        [JsonPropertyName("minSubUsecases")]
        public int MinSubUsecases { get; set; }

        /// <summary>
        /// Metadata specific to mobile network operators (MNO) related to the campaign.
        /// </summary>
        [JsonPropertyName("mnoMetadata")]
        public Dictionary<string, object>? MnoMetadata { get; set; }

        /// <summary>
        /// The monthly fee associated with the campaign's use case.
        /// </summary>
        [JsonPropertyName("monthlyFee")]
        public decimal MonthlyFee { get; set; }

        /// <summary>
        /// The quarterly fee associated with the campaign's use case.
        /// </summary>
        [JsonPropertyName("quarterlyFee")]
        public decimal QuarterlyFee { get; set; }

        /// <summary>
        /// The specific use case for which the campaign is being qualified.
        /// </summary>
        [JsonPropertyName("usecase")]
        public string Usecase { get; set; } = string.Empty;

        /// <summary>
        /// Represents any errors encountered during the qualification of the campaign.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }
}
