using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders;

namespace TelnyxSharp.Numbers.Interfaces
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

        /// <summary>
        /// Updates a phone number order with the provided details.
        /// </summary>
        /// <param name="numberOrderId">The unique ID of the phone number order to update.</param>
        /// <param name="request">The request object containing the details for updating the phone number order.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the response with the details of the updated phone number order.</returns>
        Task<UpdateNumberOrderResponse> Update(string numberOrderId, UpdateNumberOrderRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of sub-number orders based on the provided filters.
        /// </summary>
        /// <param name="request">The filter criteria for listing sub-number orders.</param>
        /// <param name="cancellationToken">Optional cancellation token for the asynchronous operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of sub-number orders.</returns>
        Task<ListSubNumberOrdersResponse> ListSubNumber(ListSubNumberOrdersRequest request, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the details of a specific sub-number order by its ID.
        /// </summary>
        /// <param name="subNumberOrderId">The unique identifier of the sub-number order.</param>
        /// <param name="request">The request containing additional filtering options.</param>
        /// <param name="cancellationToken">Optional cancellation token for task cancellation.</param>
        /// <returns>A response containing the details of the sub-number order.</returns>
        Task<GetSubNumberOrderResponse> GetSubNumber(string subNumberOrderId, GetSubNumberOrderRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an existing sub-number order with the specified details.
        /// </summary>
        /// <param name="subNumberOrderId">The unique identifier of the sub-number order to update.</param>
        /// <param name="request">The request containing updated details for the sub-number order.</param>
        /// <param name="cancellationToken">Optional cancellation token for task cancellation.</param>
        /// <returns>A response containing the updated sub-number order details.</returns>
        Task<UpdateSubNumberOrderResponse> UpdateSubNumber(string subNumberOrderId, UpdateSubNumberOrderRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancels a specific sub-number order by its ID.
        /// </summary>
        /// <param name="subNumberOrderId">The unique identifier of the sub-number order to cancel.</param>
        /// <param name="cancellationToken">Optional cancellation token for task cancellation.</param>
        /// <returns>A response indicating the cancellation status of the sub-number order.</returns>
        Task<CancelNumberOrderResponse> CancelSubNumber(string subNumberOrderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists all phone numbers associated with number orders based on the provided filtering options.
        /// </summary>
        /// <param name="request">The request containing filtering parameters.</param>
        /// <param name="cancellationToken">Optional cancellation token for task cancellation.</param>
        /// <returns>A response containing a list of associated phone numbers.</returns>
        Task<ListNumberOrderPhonesResponse> ListNumberAssociatedOrders(ListNumberOrderPhonesRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves details of a specific phone number associated with a number order by its ID.
        /// </summary>
        /// <param name="numberOrderPhoneNumberId">The unique identifier of the phone number.</param>
        /// <param name="cancellationToken">Optional cancellation token for task cancellation.</param>
        /// <returns>A response containing details of the associated phone number.</returns>
        Task<SingleNumberOrderPhoneResponse> GetNumberAssociatedOrders(string numberOrderPhoneNumberId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates details of a specific phone number associated with a number order.
        /// </summary>
        /// <param name="numberOrderPhoneNumberId">The unique identifier of the phone number to update.</param>
        /// <param name="request">The request containing updated details for the phone number.</param>
        /// <param name="cancellationToken">Optional cancellation token for task cancellation.</param>
        /// <returns>A response containing the updated details of the associated phone number.</returns>
        Task<UpdateNumberOrderPhoneResponse> UpdateNumberAssociatedOrders(string numberOrderPhoneNumberId, UpdateNumberOrderPhoneRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new comment on a number order or related entity.
        /// </summary>
        /// <param name="request">The request containing the comment details.</param>
        /// <param name="cancellationToken">Optional cancellation token for task cancellation.</param>
        /// <returns>A response containing the created comment details.</returns>
        Task<CreateCommentResponse> CreateComment(CreateCommentRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists all comments based on the provided filtering options.
        /// </summary>
        /// <param name="request">The request containing filtering parameters.</param>
        /// <param name="cancellationToken">Optional cancellation token for task cancellation.</param>
        /// <returns>A response containing a list of comments.</returns>
        Task<ListCommentsResponse> ListComment(ListCommentsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the details of a specific comment by its ID.
        /// </summary>
        /// <param name="id">The unique identifier of the comment.</param>
        /// <param name="cancellationToken">Optional cancellation token for task cancellation.</param>
        /// <returns>A response containing the details of the comment.</returns>
        Task<GetCommentResponse> GetComment(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Marks a specific comment as read.
        /// </summary>
        /// <param name="id">The unique identifier of the comment to mark as read.</param>
        /// <param name="cancellationToken">Optional cancellation token for task cancellation.</param>
        /// <returns>A response indicating the status of marking the comment as read.</returns>
        Task<MarkCommentReadResponse> MarkCommentAsRead(string id, CancellationToken cancellationToken = default);
    }
}
