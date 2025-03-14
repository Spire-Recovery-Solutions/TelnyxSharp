﻿using Microsoft.AspNetCore.Http;
using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.MessagingHostedNumber.Requests
{
    /// <summary>
    /// Represents the request payload for uploading files related to a hosted number order.
    /// </summary>
    public class UploadFileHostedNumberOrderRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the Letter of Authorization (LOA) file to be uploaded for the hosted number order.
        /// </summary>
        [JsonPropertyName("loa")]
        public IFormFile? Loa { get; set; }

        /// <summary>
        /// Gets or sets the bill file to be uploaded for the hosted number order.
        /// </summary>
        [JsonPropertyName("bill")]
        public IFormFile? Bill { get; set; }
    }
}
