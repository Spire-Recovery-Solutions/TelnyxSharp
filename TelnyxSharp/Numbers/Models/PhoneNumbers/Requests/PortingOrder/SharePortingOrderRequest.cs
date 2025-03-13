using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to share a porting order with specific permissions and expiration settings.
    /// This is used to grant access to a porting order to other users with defined permissions.
    /// </summary>
    public class SharePortingOrderRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the expiration time for the shared access in seconds.
        /// This defines how long the shared porting order remains accessible.
        /// </summary>
        [JsonPropertyName("expires_in_seconds")]
        public int? ExpiresInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the list of permissions associated with the shared porting order.
        /// This specifies what actions the user can perform on the porting order (e.g., view, edit).
        /// </summary>
        [JsonPropertyName("permissions")]
        public List<PortingOrderPermission>? Permissions { get; set; }
    }
}