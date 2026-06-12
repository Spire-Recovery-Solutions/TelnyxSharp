using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.BrandedCalling.Models.PhoneNumbers.Responses
{
    /// <summary>
    /// Represents the partial-success response for bulk-deleting phone numbers from a DIR.
    /// The data list holds the phone numbers that were soft-deleted; per-number failures that
    /// did not block the call are reported in the meta errors list. When every number in the
    /// request fails, the endpoint instead returns 400 with the canonical Telnyx error envelope.
    /// </summary>
    public class DeleteDirPhoneNumbersResponse : TelnyxResponse<List<string>, DeleteDirPhoneNumbersMeta>
    {
    }

    /// <summary>
    /// Represents the meta envelope of a bulk phone-number delete response.
    /// </summary>
    public class DeleteDirPhoneNumbersMeta
    {
        /// <summary>
        /// Per-number failures that did not block the call.
        /// </summary>
        [JsonPropertyName("errors")]
        public List<DirPhoneNumberItemError>? Errors { get; set; }
    }

    /// <summary>
    /// Represents a per-number error returned by the bulk-delete endpoint.
    /// </summary>
    public class DirPhoneNumberItemError
    {
        /// <summary>
        /// The phone number the error applies to.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Stable per-number error code (currently only "not_associated").
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Short human-readable title of the error.
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Detailed explanation of the error.
        /// </summary>
        [JsonPropertyName("detail")]
        public string? Detail { get; set; }
    }
}
