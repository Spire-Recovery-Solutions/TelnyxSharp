using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response model for retrieving a hosted number order.
    /// </summary>
    public class RetrieveHostedNumberOrderResponse : TelnyxResponse<RetrieveHostedNumberOrderData>
    {
    }

    public class RetrieveHostedNumberOrderData : BaseHostedNumberOrderData
    {
    }
}