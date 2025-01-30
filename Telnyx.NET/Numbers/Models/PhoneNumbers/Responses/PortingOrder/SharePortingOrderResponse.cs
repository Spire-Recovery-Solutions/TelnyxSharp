using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for sharing a porting order.
    /// Inherits from <see cref="TelnyxResponse{PortingOrderSharingToken}"/> 
    /// which includes the shared porting order token details.
    /// </summary>
    public class SharePortingOrderResponse : TelnyxResponse<PortingOrderSharingToken>
    {
    }

    /// <summary>
    /// Represents a porting order sharing token.
    /// This token provides access details for the shared porting order.
    /// </summary>
    public class PortingOrderSharingToken
    {
        /// <summary>
        /// Gets or sets the unique identifier of the sharing token.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the porting order that the token is sharing.
        /// </summary>
        [JsonPropertyName("porting_order_id")]
        public string? PortingOrderId { get; set; }

        /// <summary>
        /// Gets or sets the expiration time in seconds for the token.
        /// </summary>
        [JsonPropertyName("expires_in_seconds")]
        public int? ExpiresInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the list of permissions granted by the token.
        /// </summary>
        [JsonPropertyName("permissions")]
        public List<string>? Permissions { get; set; }

        /// <summary>
        /// Gets or sets the sharing token used for accessing the porting order.
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Gets or sets the exact expiration date and time for the token.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// Gets or sets the type of record associated with the token.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp of the sharing token.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
    }
}