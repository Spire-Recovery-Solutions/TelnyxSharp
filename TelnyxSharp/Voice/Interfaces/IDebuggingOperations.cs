using TelnyxSharp.Voice.Models.Debugging.Requests;
using TelnyxSharp.Voice.Models.Debugging.Responses;

namespace TelnyxSharp.Voice.Interfaces
{
    /// <summary>
    /// Interface for debugging operations related to call events.
    /// Provides methods to list call events based on various filters.
    /// </summary>
    public interface IDebuggingOperations
    {
        /// <summary>
        /// Lists call events with optional filters and pagination.
        /// </summary>
        /// <param name="request">The request containing filters for call events.</param>
        /// <param name="cancellationToken">A cancellation token to cancel the request.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with call event details.</returns>
        Task<ListCallEventsResponse?> ListCallEvents(ListCallEventsRequest request, CancellationToken cancellationToken = default);
    }
}