using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.MessagingHostedNumber
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
