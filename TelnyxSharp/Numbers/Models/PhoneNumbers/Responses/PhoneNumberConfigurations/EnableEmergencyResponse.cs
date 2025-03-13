using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberConfigurations
{
    /// <summary>
    /// Represents the response for enabling emergency services for a specific phone number configuration.
    /// </summary>
    /// <remarks>
    /// This class extends <see cref="TelnyxResponse{TData}"/> and provides the details of the voice settings 
    /// associated with the phone number, encapsulated in a <see cref="PhoneNumberVoiceSettings"/> object.
    /// </remarks>
    public class EnableEmergencyResponse : TelnyxResponse<PhoneNumberVoiceSettings>
    {
    }
}
