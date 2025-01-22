using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberConfigurations
{
    /// <summary>
    /// Represents a request to list phone numbers with voice settings using specific filters and pagination options.
    /// </summary>
    public class ListNumbersWithVoiceSettingsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of records to retrieve per page.
        /// </summary>
        /// <remarks>
        /// Default value is 20. Use this to control the pagination size.
        /// </remarks>
        [JsonPropertyName("page[size]")]
        public int? PageSize { get; set; } = 20;

        /// <summary>
        /// Gets or sets the phone number filter.
        /// </summary>
        /// <remarks>
        /// Use this to filter results by a specific phone number.
        /// </remarks>
        [JsonPropertyName("filter[phone_number]")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a substring to filter connection names that contain this value.
        /// </summary>
        /// <remarks>
        /// Useful for partial matches in connection names.
        /// </remarks>
        [JsonPropertyName("filter[connection_name][contains]")]
        public string? ConnectionNameContains { get; set; }

        /// <summary>
        /// Gets or sets the customer reference filter.
        /// </summary>
        /// <remarks>
        /// Use this to filter results by a specific customer reference value.
        /// </remarks>
        [JsonPropertyName("filter[customer_reference]")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the voice usage payment method filter.
        /// </summary>
        /// <remarks>
        /// Use this to filter results by a specific payment method for voice usage.
        /// </remarks>
        [JsonPropertyName("filter[voice.usage_payment_method]")]
        public string? UsagePaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets the sorting order for the results.
        /// </summary>
        /// <remarks>
        /// Use <see cref="SortNumberConfiguration"/> to specify ascending or descending order for the results.
        /// </remarks>
        [JsonPropertyName("sort")]
        public SortNumberConfiguration? Sort { get; set; }
    }
}