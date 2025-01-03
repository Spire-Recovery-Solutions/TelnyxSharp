using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for retrieving hosted number orders.
    /// </summary>
    public class GetHostedNumberOrderResponse : TelnyxResponse<List<HostedNumberOrderData>>
    {
    }

    public class HostedNumberOrderData : BaseHostedNumberOrderData
    {
    }
    
}
