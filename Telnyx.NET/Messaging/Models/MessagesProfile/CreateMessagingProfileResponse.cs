using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.MessagesProfile
{
    /// <summary>
    /// Represents the response from a Messaging Profile API call.
    /// </summary>
    public class CreateMessagingProfileResponse : TelnyxResponse<CreateMessagingProfileData>
    {
    }

    /// <summary>
    /// Contains the details of a messaging profile.
    /// </summary>
    public class CreateMessagingProfileData : MessagingProfileBase
    {
    }
}
