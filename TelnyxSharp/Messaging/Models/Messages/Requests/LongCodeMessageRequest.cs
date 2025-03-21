﻿using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Messaging.Models.Messages.Requests
{
    /// <summary>
    /// Represents a request to send a long code message using the Telnyx API.
    /// Includes various properties for message configuration, such as recipients, message content, media, and webhooks.
    /// </summary>
    public class LongCodeMessageRequest : MessageBaseRequest, ITelnyxRequest
    {

        /// <summary>
        /// The type of message being sent (e.g., "sms", "mms").
        /// </summary>
        [JsonPropertyName("type")]
        public MessageType? Type { get; set; }

        /// <summary>
        /// Indicates whether to automatically detect the message type.
        /// </summary>
        [JsonPropertyName("auto_detect")]
        public bool? AutoDetect { get; set; }

        /// <summary>
        /// The phone number the message will be sent from.
        /// This is a required field and should be a valid long code number.
        /// </summary>
        [JsonPropertyName("from")]
        public required string From { get; set; }
    }
}