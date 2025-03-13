using TelnyxSharp.Voice.Models.QueueCommands.Requests;
using TelnyxSharp.Voice.Models.QueueCommands.Responses;

namespace TelnyxSharp.Voice.Interfaces
{
    /// <summary>
    /// Provides methods for managing and retrieving information about queues and their associated calls.
    /// </summary>
    public interface IQueueCommandsOperations
    {
        /// <summary>
        /// Retrieves information about a specific queue by its name.
        /// </summary>
        /// <param name="queueName">The name of the queue to retrieve information for.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A <see cref="RetrieveQueueResponse"/> containing details about the specified queue.</returns>
        Task<RetrieveQueueResponse?> Retrieve(string queueName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves details of a specific call within a queue by queue name and call control ID.
        /// </summary>
        /// <param name="queueName">The name of the queue containing the call.</param>
        /// <param name="callControlId">The unique identifier of the call to retrieve.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A <see cref="RetrieveCallQueueResponse"/> containing details of the specified call.</returns>
        Task<RetrieveCallQueueResponse?> RetrieveQueueCall(string queueName, string callControlId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of calls currently in a specified queue.
        /// </summary>
        /// <param name="queueName">The name of the queue to retrieve calls for.</param>
        /// <param name="request">An object containing pagination parameters for the request.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A <see cref="RetrieveCallsQueueResponse"/> containing a list of calls in the specified queue.</returns>
        Task<RetrieveCallsQueueResponse?> RetrieveQueueCalls(string queueName, RetrieveCallsQueueRequest request, CancellationToken cancellationToken = default);
    }
}
