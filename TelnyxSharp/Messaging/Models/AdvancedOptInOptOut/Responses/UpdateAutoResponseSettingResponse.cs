﻿using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.AdvancedOptInOptOut.Responses
{
    public class UpdateAutoResponseSettingResponse : TelnyxResponse<UpdateAutoResponseSetting>
    {
    }

    /// <summary>
    /// Represents a single auto-response setting retrieved from the Telnyx API.
    /// </summary>
    public class UpdateAutoResponseSetting : BaseAutoResponseSetting
    {
        /// <summary>
        /// The unique identifier for the auto-response setting.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// The timestamp when the auto-response setting was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the auto-response setting was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}