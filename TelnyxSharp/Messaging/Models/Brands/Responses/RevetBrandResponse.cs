using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.Brands.Responses
{
    public class RevetBrandResponse : TelnyxResponse
    {

        /// <summary>
        /// Represents any errors encountered during the retrieval of the auto-response setting.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }
}
