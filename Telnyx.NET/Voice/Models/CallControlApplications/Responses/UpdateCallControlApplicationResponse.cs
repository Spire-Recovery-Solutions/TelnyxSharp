using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallControlApplications.Responses
{
    /// <summary>
    /// Represents the response for updating a call control application.
    /// </summary>
    public class UpdateCallControlApplicationResponse : TelnyxResponse<UpdateCallControlApplicationData>
    {
    }

    /// <summary>
    /// Contains the data for an updated call control application.
    /// Inherits common properties from <see cref="BaseCallControlApplications"/>.
    /// </summary>
    public class UpdateCallControlApplicationData : BaseCallControlApplications
    {
    }
}