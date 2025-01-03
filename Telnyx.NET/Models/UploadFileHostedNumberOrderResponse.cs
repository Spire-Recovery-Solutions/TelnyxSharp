using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response received after uploading files for a hosted number order.
    /// </summary>
    public class UploadFileHostedNumberOrderResponse : TelnyxResponse<UploadFileHostedNumberOrderData>
    {
    }

    /// <summary>
    /// Represents the detailed data returned in response to a file upload for a hosted number order.
    /// </summary>
    public class UploadFileHostedNumberOrderData : BaseHostedNumberOrderData
    {
    }
}