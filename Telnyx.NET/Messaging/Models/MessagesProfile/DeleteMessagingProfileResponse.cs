using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.MessagesProfile
{
    public class DeleteMessagingProfileResponse : TelnyxResponse<DeleteMessagingProfileData>
    {
    }

    /// <summary>
    /// Represents the data associated with the updated messaging profile.
    /// Inherits properties from the base <see cref="MessagingProfileBase"/> class.
    /// </summary>
    public class DeleteMessagingProfileData : MessagingProfileBase
    {
    }
}