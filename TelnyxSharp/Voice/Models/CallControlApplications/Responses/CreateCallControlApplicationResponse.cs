using TelnyxSharp.Models;

namespace TelnyxSharp.Voice.Models.CallControlApplications.Responses
{
    /// <summary>
    /// Represents the response for creating a call control application.
    /// </summary>
    public class CreateCallControlApplicationResponse : TelnyxResponse<CreateCallControlApplicationData>
    {
    }

    /// <summary>
    /// Contains the data for a created call control application.
    /// Inherits common properties from <see cref="BaseCallControlApplications"/>.
    /// </summary>
    public class CreateCallControlApplicationData : BaseCallControlApplications
    {
    }
}