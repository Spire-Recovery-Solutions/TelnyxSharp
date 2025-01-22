using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberReservations
{
    /// <summary>
    /// Represents a request for listing phone number reservations with optional filtering and pagination.
    /// Implements <see cref="ITelnyxRequest"/>.
    /// </summary>
    public class ListNumberReservationsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Filter by reservation status (e.g., active, expired).
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Filter reservations created after this timestamp.
        /// Use ISO 8601 format (e.g., "2025-01-20T00:00:00Z").
        /// </summary>
        public string? CreatedAfter { get; set; }

        /// <summary>
        /// Filter reservations created before this timestamp.
        /// Use ISO 8601 format (e.g., "2025-01-20T23:59:59Z").
        /// </summary>
        public string? CreatedBefore { get; set; }

        /// <summary>
        /// Filter by a specific reserved phone number.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Filter by a customer-provided reference for the reservation.
        /// </summary>
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Specifies the number of items to return per page in a paginated response.
        /// </summary>
        public int? PageSize { get; set; }
    }
}
