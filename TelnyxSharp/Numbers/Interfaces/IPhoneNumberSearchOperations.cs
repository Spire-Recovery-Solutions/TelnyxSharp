using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberSearch;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberSearch;

namespace TelnyxSharp.Numbers.Interfaces
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

        /// <summary>
        /// Retrieves a list of available phone number blocks based on the specified filters.
        /// </summary>
        /// <param name="request">The request containing filters for searching phone number blocks.</param>
        /// <param name="cancellationToken">A token to cancel the operation if needed.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the available phone number blocks.</returns>
        Task<ListAvailablePhoneNumberBlocksResponse> ListAvailableNumberBlocks(ListAvailablePhoneNumberBlocksRequest request, CancellationToken cancellationToken = default);
    }
}