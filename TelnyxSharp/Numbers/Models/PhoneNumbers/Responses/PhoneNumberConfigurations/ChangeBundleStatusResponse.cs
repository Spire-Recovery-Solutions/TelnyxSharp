using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberConfigurations;

/// <summary>
/// Represents the response received after changing the status of a bundle.
/// </summary>
/// <remarks>
/// This response contains the updated voice settings for a phone number, encapsulated in the <see cref="PhoneNumberVoiceSettings"/> model.
/// Inherits from <see cref="TelnyxResponse{TData}"/>, where T is <see cref="PhoneNumberVoiceSettings"/>.
/// </remarks>
public class ChangeBundleStatusResponse : TelnyxResponse<PhoneNumberVoiceSettings>
{
}