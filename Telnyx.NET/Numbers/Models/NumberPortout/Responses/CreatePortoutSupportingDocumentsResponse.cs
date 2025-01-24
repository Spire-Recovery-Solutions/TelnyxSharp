using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.NumberPortout.Responses
{
    /// <summary>
    /// Represents the response returned when supporting documents are successfully created for a port-out request.
    /// This response contains a list of the supporting documents associated with the port-out request.
    /// </summary>
    public class CreatePortoutSupportingDocumentsResponse : TelnyxResponse<List<PortoutSupportingDocument>>
    {
    }
}
