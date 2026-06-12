using TelnyxSharp.Models;

namespace TelnyxSharp.BrandedCalling.Models.PhoneNumbers.Responses
{
    /// <summary>
    /// Represents the paginated response for listing the phone numbers attached to a DIR.
    /// </summary>
    public class ListDirPhoneNumbersResponse : TelnyxResponse<List<DirPhoneNumber>>
    {
    }
}
