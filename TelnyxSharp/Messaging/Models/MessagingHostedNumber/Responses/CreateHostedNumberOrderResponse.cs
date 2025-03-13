using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.MessagingHostedNumber.Responses
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
