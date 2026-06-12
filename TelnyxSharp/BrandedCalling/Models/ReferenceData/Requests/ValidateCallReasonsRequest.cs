using TelnyxSharp.Base;

namespace TelnyxSharp.BrandedCalling.Models.ReferenceData.Requests
{
    /// <summary>
    /// Represents a request to validate candidate call reasons against the pre-vetted library.
    /// The API expects a bare JSON array of strings as the request body; the operation serializes
    /// <see cref="CallReasons"/> directly (there is no top-level object on the wire).
    /// </summary>
    public class ValidateCallReasonsRequest : ITelnyxRequest
    {
        /// <summary>
        /// 1-10 candidate call-reason strings, each at most 64 characters. Required.
        /// </summary>
        public List<string>? CallReasons { get; set; }
    }
}
