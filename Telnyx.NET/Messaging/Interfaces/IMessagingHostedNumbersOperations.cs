using Telnyx.NET.Messaging.Models.MessagingHostedNumber.Requests;
using Telnyx.NET.Messaging.Models.MessagingHostedNumber.Responses;

namespace Telnyx.NET.Messaging.Interfaces
{
    public interface IMessagingHostedNumbersOperations
    {
        /// <summary>
        /// Deletes a hosted number.
        /// </summary>
        /// <param name="id">The ID of the hosted number to delete.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<DeleteHostedNumberResponse?> Delete(
            string id,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists hosted number orders with pagination support.
        /// </summary>
        /// <param name="request">Request parameters for listing hosted number orders.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<GetHostedNumberOrderResponse?> List(
            GetHostedNumberOrderRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a hosted number order.
        /// </summary>
        /// <param name="request">Request parameters for creating a hosted number order.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<CreateHostedNumberOrderResponse?> Create(
            CreateHostedNumberOrderRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves details of a specific hosted number order.
        /// </summary>
        /// <param name="id">The ID of the hosted number order to retrieve.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<RetrieveHostedNumberOrderResponse?> Retrieve(
            string id,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Uploads a file required for a hosted number order.
        /// </summary>
        /// <param name="id">The ID of the hosted number order.</param>
        /// <param name="request">Request containing the file upload details.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<UploadFileHostedNumberOrderResponse?> UploadFileRequired(
            string id,
            UploadFileHostedNumberOrderRequest request,
            CancellationToken cancellationToken = default);

    }
}
