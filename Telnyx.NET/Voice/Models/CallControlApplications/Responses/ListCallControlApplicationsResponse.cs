using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallControlApplications.Responses
{
    /// <summary>
    /// Represents the response for listing call control applications.
    /// </summary>
    public class ListCallControlApplicationsResponse : TelnyxResponse<ListCallControlApplicationsData>
    {
    }

    /// <summary>
    /// Contains the data for a listed call control application.
    /// Inherits common properties from <see cref="BaseCallControlApplications"/>.
    /// </summary>
    public class ListCallControlApplicationsData : BaseCallControlApplications
    {
    }
}