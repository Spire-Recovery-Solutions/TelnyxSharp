using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.MessagesProfile.Responses
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
