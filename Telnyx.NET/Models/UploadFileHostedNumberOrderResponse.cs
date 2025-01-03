using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response received after uploading files for a hosted number order.
    /// </summary>
    public class UploadFileHostedNumberOrderResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the data associated with the uploaded hosted number order files.
        /// </summary>
        [JsonPropertyName("data")]
        public UploadFileHostedNumberOrderData? Data { get; set; }

        /// <summary>
        /// Gets or sets any errors encountered during the file upload process.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents the detailed data returned in response to a file upload for a hosted number order.
    /// </summary>
    public class UploadFileHostedNumberOrderData : BaseHostedNumberOrderData
    {
    }
}