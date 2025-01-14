using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallControlApplications.Responses
{
    /// <summary>
    /// Represents the response for deleting a call control application.
    /// </summary>
    public class DeleteCallControlApplicationResponse : TelnyxResponse<DeleteCallControlApplicationData>
    {
    }

    /// <summary>
    /// Contains the data for a deleted call control application.
    /// Inherits common properties from <see cref="BaseCallControlApplications"/>.
    /// </summary>
    public class DeleteCallControlApplicationData : BaseCallControlApplications
    {
    }
}