using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.AdvancedNumberOrders;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.AdvancedNumberOrders;

namespace TelnyxSharp.Numbers.Interfaces
{
    /// <summary>
    /// Defines the operations available for managing advanced number orders in the Telnyx API.
    /// Advanced number orders allow for more complex configurations when ordering phone numbers.
    /// </summary>
    public interface IAdvancedNumberOrdersOperations
    {
        /// <summary>
        /// Creates a new advanced number order with the specified configuration.
        /// </summary>
        /// <param name="request">The request object containing the details of the advanced number order to create.</param>
        /// <param name="cancellationToken">A cancellation token for managing request cancellation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response for the created advanced number order.</returns>
        Task<CreateAdvancedOrderResponse> Create(CreateAdvancedOrderRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of advanced number orders.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for managing request cancellation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of advanced number orders.</returns>
        Task<ListAdvancedOrdersResponse> List(CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves details of a specific advanced number order by its ID.
        /// </summary>
        /// <param name="orderId">The unique identifier of the advanced number order to retrieve.</param>
        /// <param name="cancellationToken">A cancellation token for managing request cancellation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the details of the specified advanced number order.</returns>
        Task<GetAdvancedOrderResponse> Get(string orderId, CancellationToken cancellationToken = default);
    }
}
