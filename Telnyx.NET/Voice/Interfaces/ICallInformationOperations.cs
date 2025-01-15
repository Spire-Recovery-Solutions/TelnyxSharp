using Telnyx.NET.Voice.Models.CallInformation.Requests;
using Telnyx.NET.Voice.Models.CallInformation.Responses;

namespace Telnyx.NET.Voice.Interfaces
{
    /// <summary>
    /// Interface for retrieving call information.
    /// Provides access to operations related to retrieving information for a specific call using its call control ID.
    /// </summary>
    public interface ICallInformationOperations
    {
        /// <summary>
        /// Retrieves detailed information for a specific call by its call control ID.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests. Defaults to <c>default</c>.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the <see cref="RetrieveCallResponse"/> object with call information.</returns>
        Task<RetrieveCallResponse?> RetrieveCall(string callControlId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists all active calls for a given connection, with pagination support.
        /// </summary>
        /// <param name="connectionId">The unique identifier for the Telnyx connection.</param>
        /// <param name="request">The request parameters, including pagination options.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the request if needed.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing the list of active calls.</returns>
        Task<ListActiveCallsResponse?> ListActiveCalls(string connectionId, ListActiveCallsRequest request, CancellationToken cancellationToken = default);
    }
}