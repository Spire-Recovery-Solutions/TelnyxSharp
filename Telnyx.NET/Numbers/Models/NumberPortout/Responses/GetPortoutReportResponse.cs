using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.NumberPortout.Responses
{
    /// <summary>
    /// Represents the response returned when a port-out report is retrieved.
    /// This response contains the details of the port-out report, including its type, status, and the associated data.
    /// </summary>
    public class GetPortoutReportResponse : TelnyxResponse<PortoutReport>
    {
    }
}
