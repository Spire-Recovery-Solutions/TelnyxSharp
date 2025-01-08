using Telnyx.NET.Messaging.Models.Messages.Requests;
using Telnyx.NET.Messaging.Models.Messages.Responses;

namespace Telnyx.NET.Messaging.Interfaces
{
    public interface IMessagesOperations
    {
        /// <summary>
        /// Sends a message using the provided request details.
        /// </summary>
        /// <param name="request">The request containing the details of the message to send.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response confirming the message has been sent.</returns>
        Task<SendMessageResponse> Send(SendMessageRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends a message using a number pool.
        /// </summary>
        /// <param name="request">The request containing the details of the message to send using a number pool.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response confirming the message has been sent using a number pool.</returns>
        Task<NumberPoolMessageResponse?> SendUsingNumberPool(NumberPoolMessageRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends a message using a long code.
        /// </summary>
        /// <param name="request">The request containing the details of the message to send using a long code.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response confirming the message has been sent using a long code.</returns>
        Task<LongCodeMessageResponse?> SendLongCode(LongCodeMessageRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends a message using a short code.
        /// </summary>
        /// <param name="request">The request containing the details of the message to send using a short code.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response confirming the message has been sent using a short code.</returns>
        Task<ShortCodeMessageResponse?> SendShortCode(ShortCodeMessageRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends a group MMS (Multimedia Messaging Service) message.
        /// </summary>
        /// <param name="request">The request containing the details of the group MMS message to send.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response confirming the group MMS message has been sent.</returns>
        Task<GroupMmsMessageResponse?> SendGroupMms(GroupMmsMessageRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a message by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the message to retrieve.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response containing the details of the retrieved message.</returns>
        Task<RetrieveMessageResponse?> RetrieveMessage(string id, CancellationToken cancellationToken = default);
    }
}