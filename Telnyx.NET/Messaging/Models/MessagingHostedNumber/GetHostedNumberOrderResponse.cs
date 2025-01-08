using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.MessagingHostedNumber
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
