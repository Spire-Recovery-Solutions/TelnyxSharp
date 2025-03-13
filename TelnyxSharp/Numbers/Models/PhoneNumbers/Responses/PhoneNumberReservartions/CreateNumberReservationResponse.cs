using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberReservartions
{
    /// <summary>
    /// Response model for creating a number reservation.
    /// This class contains information about the number reservation creation response, including metadata and associated phone numbers.
    /// </summary>
    public partial class CreateNumberReservationResponse : TelnyxResponse<NumberReservationData>
    {
    }

    /// <summary>
    /// Contains the data returned in a number reservation creation response.
    /// Includes information such as reservation ID, phone numbers reserved, status, and timestamps.
    /// </summary>
    public partial class NumberReservationData
    {   
        /// <summary>
        /// Gets or sets the unique identifier of the number reservation.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the type of record for this reservation.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets a reference to the customer associated with this reservation.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the reservation was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the status of the reservation (e.g., active, pending, etc.).
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the reservation was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// List of phone numbers associated with this reservation.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<ReservedPhoneNumber>? PhoneNumbers { get; set; }
    }

    /// <summary>
    /// Represents a single phone number in a number reservation response.
    /// Includes metadata, status, and expiration details for each phone number.
    /// </summary>
    public partial class ReservedPhoneNumber
    {
        /// <summary>
        /// Gets or sets the timestamp when the phone number was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the actual phone number that was reserved.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the status of the phone number (e.g., reserved, assigned, etc.).
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the phone number was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for this phone number reservation.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the phone number expired.
        /// </summary>
        [JsonPropertyName("expired_at")]
        public DateTimeOffset? ExpiredAt { get; set; }

        /// <summary>
        /// Gets or sets the type of record for this phone number.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }
    }
}