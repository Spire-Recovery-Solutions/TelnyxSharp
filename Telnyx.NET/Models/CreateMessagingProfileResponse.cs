using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from a Messaging Profile API call.
    /// </summary>
    public class CreateMessagingProfileResponse : ITelnyxResponse
    {
        /// <summary>
        /// The data containing the messaging profile details.
        /// </summary>
        [JsonPropertyName("data")]
        public CreateMessagingProfileData? Data { get; set; }

        /// <summary>
        /// List of errors, if any occurred during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Contains the details of a messaging profile.
    /// </summary>
    public class CreateMessagingProfileData : MessagingProfileBase
    {
    }
}
