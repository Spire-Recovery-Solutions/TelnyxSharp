using System.Text.Json.Serialization;
using Telnyx.NET.Models;
using System.Collections.Generic;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.CsvDownloads
{
    /// <summary>
    /// Represents the response for listing CSV downloads.
    /// Contains a list of <see cref="CsvDownload"/> objects.
    /// </summary>
    public class ListCsvDownloadsResponse : TelnyxResponse<List<CsvDownload>>
    {
    }

    /// <summary>
    /// Represents details of a CSV download.
    /// </summary>
    public class CsvDownload
    {
        /// <summary>
        /// Gets or sets the unique identifier for the CSV download.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the record type of the CSV download.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the URL to download the CSV file.
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Gets or sets the status of the CSV download process (e.g., pending, completed).
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }
}