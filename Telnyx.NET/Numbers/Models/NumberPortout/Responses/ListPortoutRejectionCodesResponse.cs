using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.NumberPortout.Responses
{
    /// <summary>
    /// Represents the response returned when retrieving a list of port-out rejection codes.
    /// This response contains a list of rejection codes, providing details such as code, description, and reason requirement.
    /// </summary>
    public class ListPortoutRejectionCodesResponse : TelnyxResponse<List<PortoutRejectionCode>>
    {
    }

    /// <summary>
    /// Represents a single port-out rejection code.
    /// This contains the code itself, a description, and whether a reason is required for rejection.
    /// </summary>
    public class PortoutRejectionCode
    {
        /// <summary>
        /// Gets or sets the rejection code.
        /// The unique identifier for this rejection reason.
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets the description for the rejection code.
        /// Describes the reason for the port-out rejection.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether a reason is required for the rejection.
        /// </summary>
        [JsonPropertyName("reason_required")]
        public bool ReasonRequired { get; set; }
    }
}
