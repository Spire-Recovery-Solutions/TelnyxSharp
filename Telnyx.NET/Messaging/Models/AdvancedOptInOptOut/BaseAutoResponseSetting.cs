using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Messaging.Models.AdvancedOptInOptOut
{
    /// <summary>
    /// Represents the base response for an auto-response setting, containing core properties.
    /// </summary>
    public class BaseAutoResponseSetting
    {
        /// <summary>
        /// The operation type for the auto-response setting, indicating the action.
        /// </summary>
        [JsonPropertyName("op")]
        public OperationType Op { get; set; } = OperationType.Unknown;

        /// <summary>
        /// A list of keywords that trigger the auto-response setting.
        /// </summary>
        [JsonPropertyName("keywords")]
        public List<string> Keywords { get; set; } = new();

        /// <summary>
        /// The response text that is sent when the auto-response setting is triggered.
        /// </summary>
        [JsonPropertyName("resp_text")]
        public string RespText { get; set; } = string.Empty;

        /// <summary>
        /// The country code associated with the auto-response setting.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; } = string.Empty;
    }
}