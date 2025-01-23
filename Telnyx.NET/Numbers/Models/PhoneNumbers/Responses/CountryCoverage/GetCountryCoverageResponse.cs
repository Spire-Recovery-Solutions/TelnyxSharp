using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.CountryCoverage
{
    /// <summary>
    /// Represents the response for retrieving country coverage details, which includes information about 
    /// the availability of phone numbers and their configuration for a specific country.
    /// This class encapsulates the response from the Telnyx API when querying for coverage in a country.
    /// </summary>
    public class GetCountryCoverageResponse : TelnyxResponse<CountryCoverageDetails>
    {
    }
}
