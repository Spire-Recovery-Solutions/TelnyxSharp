using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.Messages
{
    /// <summary>
    /// Represents the response returned after sending a group MMS message.
    /// </summary>
    public class GroupMmsMessageResponse : TelnyxResponse<GroupMmsMessageData>
    {
    }

    /// <summary>
    /// Contains the detailed message data for a group MMS message response.
    /// Inherits common response properties from <see cref="MessageBaseResponse"/>.
    /// </summary>
    public class GroupMmsMessageData : MessageBaseResponse
    {
    }
}