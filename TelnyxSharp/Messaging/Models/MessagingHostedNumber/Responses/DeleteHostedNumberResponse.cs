using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.MessagingHostedNumber.Responses
{
    /// <summary>
    /// Represents the response after deleting a messaging hosted number.
    /// </summary>
    public class DeleteHostedNumberResponse : TelnyxResponse<DeleteHostedNumberData>
    {
    }

    public class DeleteHostedNumberData : BaseHostedNumberOrderData
    {
    }
}
