﻿using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.TollFreeVerificationOperations.Responses
{
    /// <summary>
    /// Represents the response for a list of verification requests.
    /// </summary>
    public class ListVerificationRequestsResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the collection of verification request records.
        /// </summary>
        [JsonPropertyName("records")]
        public List<VerificationRequestRecord>? Records { get; set; }

        /// <summary>
        /// Gets or sets the total number of verification request records available.
        /// </summary>
        [JsonPropertyName("total_records")]
        public int? TotalRecords { get; set; }
    }

    /// <summary>
    /// Represents a single verification request record.
    /// </summary>
    public class VerificationRequestRecord : BaseVerificationRequestResponse
    {
    }
}