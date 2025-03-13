using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberBlocksBackgroundJobs
{
    /// <summary>
    /// Represents a request to delete a specific phone number block.
    /// </summary>
    public class DeletePhoneNumberBlockRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier of the phone number block to delete.
        /// </summary>
        public required string PhoneNumberBlockId { get; set; }
    }
}