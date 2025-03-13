using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.Messages.Responses
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
