using System.Text.Json.Serialization;
using Telnyx.NET.Messaging.Models;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.MessagesProfile
{
    /// <summary>
    /// Represents the response for retrieving a messaging profile.
    /// </summary>
    public class RetrieveMessagingProfileResponse : TelnyxResponse<RetrieveMessagingProfileData>
    {
    }

    /// <summary>
    /// Contains details of the messaging profile.
    /// </summary>
    public class RetrieveMessagingProfileData : MessagingProfileBase
    {
    }
}
