using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.Messages.Responses
{
    /// <summary>
    /// Represents the response for a short code message sent through the Telnyx API.
    /// </summary>
    public class ShortCodeMessageResponse : TelnyxResponse<ShortCodeMessageData>
    {
    }

    /// <summary>
    /// Contains detailed information about a short code message.
    /// </summary>
    public class ShortCodeMessageData : MessageBaseResponse
    {
    }
}