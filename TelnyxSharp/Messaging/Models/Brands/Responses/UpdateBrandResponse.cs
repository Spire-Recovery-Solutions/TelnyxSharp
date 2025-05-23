﻿using System.Text.Json.Serialization;

namespace TelnyxSharp.Messaging.Models.Brands.Responses
{
    public class UpdateBrandResponse : BaseBrandResponse
    {

        /// <summary>
        /// Represents any errors encountered during the retrieval of the auto-response setting.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }
}
