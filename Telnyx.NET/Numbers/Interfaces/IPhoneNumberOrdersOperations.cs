using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders;

namespace Telnyx.NET.Numbers.Interfaces
{
    /// <summary>
    /// Defines operations for managing phone number orders.
    /// </summary>
    public interface IPhoneNumberOrdersOperations
    {
        /// <summary>
        /// Retrieves a list of phone number orders based on specified filters.
        /// </summary>
        /// <param name="request">The request object containing filtering options for the phone number orders.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the list of phone number orders.</returns>
        Task<ListNumberOrdersResponse> List(ListNumberOrdersRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves details of a specific phone number order.
        /// </summary>
        /// <param name="numberOrderId">The unique ID of the phone number order to retrieve.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the details of the phone number order.</returns>
        Task<GetNumberOrderResponse> Get(string numberOrderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new phone number order.
        /// </summary>
        /// <param name="request">The request object containing the details for the new phone number order.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the details of the created phone number order.</returns>
        Task<CreateNumberOrderResponse> Create(CreateNumberOrderRequest request, CancellationToken cancellationToken = default);
    }
}