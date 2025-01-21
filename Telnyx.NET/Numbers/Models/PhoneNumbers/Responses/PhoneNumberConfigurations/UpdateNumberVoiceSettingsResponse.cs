using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberConfigurations
{
    /// <summary>
    /// Response model for updating the voice settings of a phone number.
    /// This class represents the response received after updating the voice settings, including details such as call forwarding, CNAM listing, and media features.
    /// </summary>
    public class UpdateNumberVoiceSettingsResponse : TelnyxResponse<PhoneNumberVoiceSettings>
    {
    }
}