﻿using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.Messages.Responses
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