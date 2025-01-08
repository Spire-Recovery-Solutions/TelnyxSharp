using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.MessagingHostedNumber.Responses
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