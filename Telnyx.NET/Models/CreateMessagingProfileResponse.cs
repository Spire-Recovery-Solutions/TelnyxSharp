using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
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
