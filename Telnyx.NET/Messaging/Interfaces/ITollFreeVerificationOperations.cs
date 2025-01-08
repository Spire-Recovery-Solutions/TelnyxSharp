using Telnyx.NET.Messaging.Models.TollFreeVerificationOperations.Requests;
using Telnyx.NET.Messaging.Models.TollFreeVerificationOperations.Responses;

namespace Telnyx.NET.Messaging.Interfaces
{
    public interface ITollFreeVerificationOperations
    {
        /// <summary>
        /// Lists toll-free verification requests with optional filters and pagination.
        /// </summary>
        /// <param name="request">The request containing filters and pagination parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<ListVerificationRequestsResponse?> List(
            ListVerificationRequestsRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Submits a new toll-free verification request.
        /// </summary>
        /// <param name="request">The request containing the details for the verification.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<SubmitVerificationRequestResponse?> Submit(
            SubmitVerificationRequestRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a toll-free verification request by its ID.
        /// </summary>
        /// <param name="id">The ID of the verification request.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<GetVerificationRequestResponse?> Retrieve(
            string id,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a toll-free verification request by its ID.
        /// </summary>
        /// <param name="id">The ID of the verification request to delete.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<DeleteVerificationRequestResponse?> Delete(
            string id,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an existing toll-free verification request by its ID.
        /// </summary>
        /// <param name="id">The ID of the verification request to update.</param>
        /// <param name="request">The request containing updated details.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<UpdateVerificationRequestResponse?> Update(
            string id,
            UpdateVerificationRequestRequest request,
            CancellationToken cancellationToken = default);
    }
}
