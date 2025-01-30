using Telnyx.NET.Models;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.Requirements;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.RequirementTypes
{
    /// <summary>
    /// Represents the response returned when listing requirement types.
    /// Inherits from TelnyxResponse to encapsulate the list of requirement types.
    /// </summary>
    public class ListRequirementTypesResponse : TelnyxResponse<List<RequirementType>>
    {
    }
}
