using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberConfigurations
{
    /// <summary>
    /// Represents the response for retrieving the configuration details of a specific phone number.
    /// </summary>
    /// <remarks>
    /// This class extends <see cref="TelnyxResponse{TData}"/> and provides the configuration details 
    /// of the phone number, encapsulated in a <see cref="NumberConfigurationData"/> object.
    /// </remarks>
    public class GetNumberResponse : TelnyxResponse<NumberConfigurationData>
    {
    }
}
