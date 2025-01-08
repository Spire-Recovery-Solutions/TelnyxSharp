using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Requests;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Responses;

namespace Telnyx.NET.PhoneNumber.Interfaces
{
    /// <summary>
    /// Defines operations for searching available phone numbers.
    /// </summary>
    public interface IPhoneNumberSearchOperations
    {
        /// <summary>
        /// Searches for available phone numbers based on the specified criteria.
        /// </summary>
        /// <param name="request">The request object containing the criteria for searching available phone numbers.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with available phone numbers matching the criteria.</returns>
        Task<AvailablePhoneNumbersResponse> AvailableNumbers(AvailablePhoneNumbersRequest request, CancellationToken cancellationToken = default);
    }
}