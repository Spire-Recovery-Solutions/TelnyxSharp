using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders
{
    /// <summary>
    /// Represents a request to list comments associated with a specific record.
    /// </summary>
    public class ListCommentsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the type of the record for which comments are being retrieved.
        /// </summary>
        /// <remarks>
        /// This field specifies the type of record (e.g., "PhoneNumberOrder") whose comments are being requested.
        /// </remarks>
        public string? CommentRecordType { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the record for which comments are being retrieved.
        /// </summary>
        /// <remarks>
        /// This field specifies the unique ID of the record (e.g., a phone number order ID) to filter the comments.
        /// </remarks>
        public string? CommentRecordId { get; set; }
    }
}