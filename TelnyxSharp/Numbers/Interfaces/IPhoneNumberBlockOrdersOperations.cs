using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberBlockOrders;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberBlockOrders;

namespace TelnyxSharp.Numbers.Interfaces
{
    /// <summary>
    /// Defines the operations available for managing phone number block orders.
    /// This includes listing, creating, and retrieving details of phone number block orders.
    /// </summary>
    public interface IPhoneNumberBlockOrdersOperations
    {
        /// <summary>
        /// Lists phone number block orders based on the specified filtering and pagination criteria.
        /// </summary>
        /// <param name="request">The request object containing filtering and pagination options.</param>
        /// <param name="cancellationToken">A token to cancel the operation if needed.</param>
        /// <returns>A task representing the asynchronous operation, returning a response containing the list of phone number block orders.</returns>
        Task<ListNumberBlockOrdersResponse> List(
            ListNumberBlockOrdersRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new phone number block order.
        /// </summary>
        /// <param name="request">The request object containing details for creating the phone number block order.</param>
        /// <param name="cancellationToken">A token to cancel the operation if needed.</param>
        /// <returns>A task representing the asynchronous operation, returning the response containing the details of the created phone number block order.</returns>
        Task<CreateNumberBlockOrderResponse> Create(
            CreateNumberBlockOrderRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the details of a specific phone number block order by its ID.
        /// </summary>
        /// <param name="numberBlockOrderId">The unique identifier of the phone number block order to retrieve.</param>
        /// <param name="cancellationToken">A token to cancel the operation if needed.</param>
        /// <returns>A task representing the asynchronous operation, returning the response containing the details of the phone number block order.</returns>
        Task<GetNumberBlockOrderResponse> Get(
            string numberBlockOrderId,
            CancellationToken cancellationToken = default);
    }
}
