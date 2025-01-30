﻿using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.Voicemail.Requests
{
    /// <summary>
    /// Represents the request model for creating or configuring voicemail settings for a phone number.
    /// </summary>
    public class CreateVoicemailRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the PIN code required to access voicemail.
        /// </summary>
        /// <remarks>
        /// This PIN code is typically used for authenticating the user when they access voicemail settings or messages.
        /// </remarks>
        [JsonPropertyName("pin")]
        public string? Pin { get; set; }

        /// <summary>
        /// Gets or sets whether voicemail is enabled or not for the phone number.
        /// </summary>
        /// <remarks>
        /// If set to <c>true</c>, voicemail is enabled for the phone number; otherwise, it is disabled.
        /// </remarks>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}