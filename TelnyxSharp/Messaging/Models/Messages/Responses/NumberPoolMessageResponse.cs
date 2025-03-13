using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.Messages.Responses
{
    /// <summary>
    /// Represents the response received after sending a message using a number pool.
    /// </summary>
    public class NumberPoolMessageResponse : TelnyxResponse<NumberPoolMessageData>
    {
    }

    /// <summary>
    /// Represents the detailed information about a message sent through the number pool.
    /// </summary>
    public class NumberPoolMessageData : MessageBaseResponse
    {
    }
}