using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to update a porting activation job in the Telnyx system.
    /// This class is used when modifying the activation date for a porting job.
    /// </summary>
    public class UpdatePortingActivationJobRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the date and time when the porting activation job should be activated.
        /// This field is optional. If provided, it overrides the default activation time.
        /// </summary>
        [JsonPropertyName("activate_at")]
        public DateTimeOffset? ActivateAt { get; set; }
    }
}