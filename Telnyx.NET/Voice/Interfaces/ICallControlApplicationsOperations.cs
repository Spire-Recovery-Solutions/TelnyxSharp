using Telnyx.NET.Voice.Models.CallControlApplications.Requests;
using Telnyx.NET.Voice.Models.CallControlApplications.Responses;

namespace Telnyx.NET.Voice.Interfaces
{
    public interface ICallControlApplicationsOperations
    {
        /// <summary>
        /// Retrieves a list of call control applications based on the provided request filters.
        /// </summary>
        /// <param name="request">The request parameters for filtering and pagination.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A task that represents the asynchronous operation, with a response containing a list of call control applications.</returns>
        Task<ListCallControlApplicationsResponse?> List(ListCallControlApplicationsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new call control application based on the provided request.
        /// </summary>
        /// <param name="request">The request parameters to create the call control application.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A task that represents the asynchronous operation, with a response containing the created call control application details.</returns>
        Task<CreateCallControlApplicationResponse?> Create(CreateCallControlApplicationRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a specific call control application by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the call control application.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A task that represents the asynchronous operation, with a response containing the retrieved call control application details.</returns>
        Task<RetrieveCallControlApplicationResponse?> Retrieve(long id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an existing call control application with the specified data.
        /// </summary>
        /// <param name="id">The unique identifier of the call control application to update.</param>
        /// <param name="request">The request parameters for updating the call control application.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A task that represents the asynchronous operation, with a response containing the updated call control application details.</returns>
        Task<UpdateCallControlApplicationResponse?> Update(long id, UpdateCallControlApplicationRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a specific call control application by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the call control application to delete.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A task that represents the asynchronous operation, with a response confirming the deletion.</returns>
        Task<DeleteCallControlApplicationResponse?> Delete(long id, CancellationToken cancellationToken = default);
    }
}
