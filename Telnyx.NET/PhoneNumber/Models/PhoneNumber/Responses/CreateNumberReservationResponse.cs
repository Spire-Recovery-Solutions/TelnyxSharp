using System.Text.Json.Serialization;

namespace Telnyx.NET.PhoneNumber.Models.PhoneNumber.Responses
{
    using System;
    using System.Collections.Generic;
    using Telnyx.NET.Models;

    /// <summary>
    /// Response model for creating a number reservation.
    /// This class contains information about the number reservation creation response, including metadata and associated phone numbers.
    /// </summary>
    public partial class CreateNumberReservationResponse : TelnyxResponse<CreateNumberReservationResponseData>
    {
    }

    /// <summary>
    /// Contains the data returned in a number reservation creation response.
    /// Includes information such as reservation ID, phone numbers reserved, status, and timestamps.
    /// </summary>
    public partial class CreateNumberReservationResponseData
    {
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
        /// Gets or sets the unique identifier of the number reservation.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// List of phone numbers associated with this reservation.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<CreateNumberReservationResponsePhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or sets the type of record for this reservation.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }
    }

    /// <summary>
    /// Represents a single phone number in a number reservation response.
    /// Includes metadata, status, and expiration details for each phone number.
    /// </summary>
    public partial class CreateNumberReservationResponsePhoneNumber
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
        public string? PhoneNumberPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets any error messages associated with the phone number.
        /// </summary>
        [JsonPropertyName("errors")]
        public string? Errors { get; set; }

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
        /// Gets or sets a value indicating whether the phone number has expired.
        /// </summary>
        [JsonPropertyName("expired")]
        public bool? Expired { get; set; }

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