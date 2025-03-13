using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.Messages.Responses
{
    /// <summary>
    /// Represents the response received from the Telnyx API after sending a long code message.
    /// Includes data about the message and any errors encountered during the API call.
    /// </summary>
    public class LongCodeMessageResponse : TelnyxResponse<LongCodeMessageData>
    {
    }

    /// <summary>
    /// Contains detailed information about the message sent via the Telnyx API.
    /// </summary>
    public class LongCodeMessageData : MessageBaseResponse
    {
    }
}