using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.Messages
{
    /// <summary>
    /// Represents the response returned after sending a message via the Telnyx API.
    /// </summary>
    public partial class SendMessageResponse : TelnyxResponse<SendMessageData>
    {
    }

    /// <summary>
    /// Contains detailed information about a sent message.
    /// </summary>
    public partial class SendMessageData : MessageBaseResponse
    {
    }


}
