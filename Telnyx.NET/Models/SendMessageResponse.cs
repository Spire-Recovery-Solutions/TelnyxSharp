using System.Text.Json.Serialization;
using Telnyx.NET.Messaging.Models;

namespace Telnyx.NET.Models
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
