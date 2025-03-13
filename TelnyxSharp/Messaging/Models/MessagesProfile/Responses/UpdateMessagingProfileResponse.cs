using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.MessagesProfile.Responses
{
    /// <summary>
    /// Represents the response received when updating a messaging profile using the Telnyx API.
    /// </summary>
    public class UpdateMessagingProfileResponse : TelnyxResponse<UpdateMessagingProfileData>
    {
    }

    /// <summary>
    /// Represents the data associated with the updated messaging profile.
    /// Inherits properties from the base <see cref="MessagingProfileBase"/> class.
    /// </summary>
    public class UpdateMessagingProfileData : MessagingProfileBase
    {
    }
}