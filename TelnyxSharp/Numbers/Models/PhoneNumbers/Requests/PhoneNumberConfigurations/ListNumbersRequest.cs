using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberConfigurations
{
    /// <summary>
    /// Request model for listing phone numbers.
    /// This class is used to specify filters and pagination options when retrieving phone numbers.
    /// </summary>
    public class ListNumbersRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of results to return per page for pagination.
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets a list of tags associated with the phone numbers to filter by.
        /// </summary>
        public List<string>? Tags { get; set; }

        /// <summary>
        /// Gets or sets the specific phone number to search for.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the status of the phone number (e.g., active, reserved).
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the connection ID associated with the phone number to filter by.
        /// </summary>
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the partial name of the voice connection to filter phone numbers by.
        /// </summary>
        public string? VoiceConnectionNameContains { get; set; }

        /// <summary>
        /// Gets or sets the prefix of the voice connection name to filter phone numbers by.
        /// </summary>
        public string? VoiceConnectionNameStartsWith { get; set; }

        /// <summary>
        /// Gets or sets the suffix of the voice connection name to filter phone numbers by.
        /// </summary>
        public string? VoiceConnectionNameEndsWith { get; set; }

        /// <summary>
        /// Gets or sets the exact voice connection name to filter phone numbers by.
        /// </summary>
        public string? VoiceConnectionNameEquals { get; set; }

        /// <summary>
        /// Gets or sets the usage payment method associated with the phone numbers.
        /// </summary>
        public string? UsagePaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets the billing group ID to filter the phone numbers by.
        /// </summary>
        public string? BillingGroupId { get; set; }

        /// <summary>
        /// Gets or sets the emergency address ID associated with the phone number.
        /// </summary>
        public string? EmergencyAddressId { get; set; }

        /// <summary>
        /// Gets or sets the customer reference to filter phone numbers by.
        /// </summary>
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the number type to filter by.
        /// Examples include "local," "mobile," or "toll-free."
        /// </summary>
        public string? NumberType { get; set; }

        /// <summary>
        /// Gets or sets the sorting order for the results (e.g., ascending or descending).
        /// </summary>
        public string? Sort { get; set; }
    }
}