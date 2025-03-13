using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.AdvancedOptInOptOut.Requests
{
    /// <summary>
    /// Represents a request to list Auto Response Settings in the Telnyx API.
    /// This model includes various filter parameters to narrow down the results
    /// based on creation and update dates, country code, and pagination options.
    /// </summary>
    public class ListAutoResponseSettingsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the country code to filter auto response settings.
        /// This is an optional field.
        /// </summary>
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the start date for filtering auto response settings by creation date.
        /// This will only include settings created on or after this date.
        /// This is an optional field.
        /// </summary>
        public DateTimeOffset? CreatedAtGte { get; set; }

        /// <summary>
        /// Gets or sets the end date for filtering auto response settings by creation date.
        /// This will only include settings created on or before this date.
        /// This is an optional field.
        /// </summary>
        public DateTimeOffset? CreatedAtLte { get; set; }

        /// <summary>
        /// Gets or sets the start date for filtering auto response settings by update date.
        /// This will only include settings updated on or after this date.
        /// This is an optional field.
        /// </summary>
        public DateTimeOffset? UpdatedAtGte { get; set; }

        /// <summary>
        /// Gets or sets the end date for filtering auto response settings by update date.
        /// This will only include settings updated on or before this date.
        /// This is an optional field.
        /// </summary>
        public DateTimeOffset? UpdatedAtLte { get; set; }
    }
}