using TelnyxSharp.Models;

namespace TelnyxSharp.BrandedCalling.Models.PhoneNumbers.Responses
{
    /// <summary>
    /// Represents the response for bulk-adding phone numbers to a DIR (HTTP 201).
    /// All numbers in the request were accepted into a single new batch; every entry in the data
    /// list shares the same batch id. This is an all-or-nothing payload: if any number fails,
    /// the entire request is rejected with HTTP 400.
    /// </summary>
    public class AddDirPhoneNumbersResponse : TelnyxResponse<List<DirPhoneNumber>>
    {
    }
}
