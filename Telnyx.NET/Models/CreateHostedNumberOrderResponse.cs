using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for creating a messaging hosted number order.
    /// </summary>
    public class CreateHostedNumberOrderResponse : TelnyxResponse<CreateHostedNumberOrder>
    {
    }
    public class CreateHostedNumberOrder : BaseHostedNumberOrderData
    {
    }
}
