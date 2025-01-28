using Telnyx.NET.Models;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.Requirements;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.RequirementTypes
{
    /// <summary>
    /// Represents the response returned when retrieving a specific requirement type.
    /// Inherits from TelnyxResponse to encapsulate the requirement type data.
    /// </summary>
    public class RetrieveRequirementTypeResponse : TelnyxResponse<RequirementType>
    {
    }
}
