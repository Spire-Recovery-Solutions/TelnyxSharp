using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response received when updating a messaging profile using the Telnyx API.
    /// </summary>
    public class UpdateMessagingProfileResponse : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets the data for the updated messaging profile.
        /// </summary>
        [JsonPropertyName("data")]
        public UpdateMessagingProfileData Data { get; set; }

        /// <summary>
        /// Gets or sets the list of errors, if any occurred during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents the data associated with the updated messaging profile.
    /// Inherits properties from the base <see cref="MessagingProfileBase"/> class.
    /// </summary>
    public class UpdateMessagingProfileData : MessagingProfileBase
    {
    }
}