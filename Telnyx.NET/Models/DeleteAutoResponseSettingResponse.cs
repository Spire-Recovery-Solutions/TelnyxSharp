using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response received after attempting to delete an auto-response setting.
    /// Implements the ITelnyxResponse interface to maintain consistency with Telnyx's API response structure.
    /// </summary>
    public class DeleteAutoResponseSettingResponse : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets the array of errors encountered during the deletion process.
        /// If the deletion is successful, this property will be null or empty.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }
}