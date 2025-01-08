using System.Text.Json.Serialization;

namespace Telnyx.NET.Messaging.Models.Brands.Responses
{
    /// <summary>
    /// Response model for brand creation.
    /// </summary>
    public class CreateBrandResponse : BaseBrandResponse
    {

        /// <summary>
        /// Represents any errors encountered during the retrieval of the auto-response setting.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }
}
