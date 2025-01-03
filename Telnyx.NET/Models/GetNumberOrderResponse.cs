using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    

    public partial class GetNumberOrderResponse : TelnyxResponse
    {
        [JsonPropertyName("data")]
        public NumberOrder Data { get; set; }
    }

}
