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
        public int? PageSize { get; set; } = 20;

        /// <summary>
        /// Gets or sets the phone number filter.
        /// </summary>
        /// <remarks>
        /// Use this to filter results by a specific phone number.
        /// </remarks>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a substring to filter connection names that contain this value.
        /// </summary>
        /// <remarks>
        /// Useful for partial matches in connection names.
        /// </remarks>
        public string? ConnectionNameContains { get; set; }

        /// <summary>
        /// Gets or sets the customer reference filter.
        /// </summary>
        /// <remarks>
        /// Use this to filter results by a specific customer reference value.
        /// </remarks>
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the voice usage payment method filter.
        /// </summary>
        /// <remarks>
        /// Use this to filter results by a specific payment method for voice usage.
        /// </remarks>
        public string? UsagePaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets the sorting order for the results.
        /// </summary>
        /// <remarks>
        /// Use <see cref="SortNumberConfiguration"/> to specify ascending or descending order for the results.
        /// </remarks>
        public SortNumberConfiguration? Sort { get; set; }
    }
}