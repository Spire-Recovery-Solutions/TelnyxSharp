using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallControlApplications.Responses
{
    /// <summary>
    /// Represents the response for retrieving a specific call control application.
    /// </summary>
    public class RetrieveCallControlApplicationResponse : TelnyxResponse<RetrieveCallControlApplicationData>
    {
    }

    /// <summary>
    /// Contains the data for a retrieved call control application.
    /// Inherits common properties from <see cref="BaseCallControlApplications"/>.
    /// </summary>
    public class RetrieveCallControlApplicationData : BaseCallControlApplications
    {
    }
}