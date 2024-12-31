using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for the "List messaging URL domains" API.
    /// </summary>
    public class ListMessagingUrlDomainsResponse : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets the list of messaging URL domain data.
        /// </summary>
        [JsonPropertyName("data")]
        public List<MessagingUrlDomain>? Data { get; set; }

        /// <summary>
        /// Gets or sets the metadata for the pagination information.
        /// </summary>
        [JsonPropertyName("meta")]
        public PaginationMeta? Meta { get; set; }

        /// <summary>
        /// Represents any errors encountered during the message sending process.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents the details of a messaging URL domain.
    /// </summary>
    public class MessagingUrlDomain
    {
        /// <summary>
        /// Gets or sets the record type for the messaging URL domain.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier for the messaging URL domain.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL domain for messaging.
        /// </summary>
        [JsonPropertyName("url_domain")]
        public string UrlDomain { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the use case for the messaging URL domain.
        /// </summary>
        [JsonPropertyName("use_case")]
        public string UseCase { get; set; } = string.Empty;
    }

}
