using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.NumberPortout.Responses
{
    /// <summary>
    /// Represents the response returned when a specific port-out event is retrieved.
    /// This response contains the details of the port-out event, including event type and other relevant information.
    /// </summary>
    public class GetPortoutEventResponse : TelnyxResponse<PortoutEvent>
    {
    }
}
