using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.NumberPortout.Responses
{
    /// <summary>
    /// Represents the response returned when a specific port-out order is retrieved.
    /// This response contains details of the port-out order, including its status, associated data, and relevant metadata.
    /// </summary>
    public class GetPortoutResponse : TelnyxResponse<PortoutData>
    {
    }
}
