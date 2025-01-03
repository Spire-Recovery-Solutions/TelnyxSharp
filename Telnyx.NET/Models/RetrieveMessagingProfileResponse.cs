using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for retrieving a messaging profile.
    /// </summary>
    public class RetrieveMessagingProfileResponse : TelnyxResponse
    {
        /// <summary>
        /// The data containing the details of the messaging profile.
        /// </summary>
        [JsonPropertyName("data")]
        public RetrieveMessagingProfileData? Data { get; set; }

        /// <summary>
        /// Gets or sets any errors that occurred during the API request.
        /// This property is nullable to indicate that it may not always be present.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Contains details of the messaging profile.
    /// </summary>
    public class RetrieveMessagingProfileData : MessagingProfileBase
    {
    }
}
