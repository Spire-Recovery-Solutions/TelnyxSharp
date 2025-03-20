using TelnyxSharp.CdrReports.Models.Requests;
using TelnyxSharp.CdrReports.Models.Responses;

namespace TelnyxSharp.CdrReports.Interfaces
{
    /// <summary>
    /// Defines operations for managing CDR requests.
    /// </summary>
    public interface ICdrRequestsOperations
    {
        /// <summary>
        /// Creates a new CDR request.
        /// </summary>
        /// <param name="request">The CDR request parameters.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>A task that represents the asynchronous operation, containing the created CDR request response.</returns>
        Task<CreateCdrRequestsResponse> Create(CreateCdrRequestsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of all CDR requests.
        /// </summary>
        /// <param name="request">The request parameters for listing CDR requests (e.g., pagination settings).</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>A task that represents the asynchronous operation, containing a list of CDR request responses.</returns>
        Task<ListCdrRequestsResponse> List(ListCdrRequestsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the status and details of a specific CDR request.
        /// </summary>
        /// <param name="id">The unique identifier of the CDR request to retrieve.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>A task that represents the asynchronous operation, containing the CDR request response.</returns>
        Task<GetCdrRequestsResponse> Get(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a specific CDR request.
        /// </summary>
        /// <param name="id">The unique identifier of the CDR request to delete.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>A task that represents the asynchronous operation, containing the delete response.</returns>
        Task<DeleteCdrRequestsResponse> Delete(string id, CancellationToken cancellationToken = default);
    }
}
