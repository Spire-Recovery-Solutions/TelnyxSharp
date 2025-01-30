using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response when retrieving a LOA (Letter of Authorization) configuration.
    /// Inherits from TelnyxResponse and includes a single LoaConfiguration object.
    /// </summary>
    public class GetLoaConfigurationResponse : TelnyxResponse<LoaConfiguration>
    {
    }
}