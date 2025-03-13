using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for updating the LOA (Letter of Authorization) configuration.
    /// Inherits from <see cref="TelnyxResponse{TData}"/> 
    /// which includes the updated LOA configuration details.
    /// </summary>
    public class UpdateLoaConfigurationResponse : TelnyxResponse<LoaConfiguration>
    {
    }
}