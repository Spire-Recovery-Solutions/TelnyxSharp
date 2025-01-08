using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.Messages
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