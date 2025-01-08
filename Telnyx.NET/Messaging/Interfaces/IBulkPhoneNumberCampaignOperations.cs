using Telnyx.NET.Messaging.Models.BulkPhoneNumberCampaign.Requests;
using Telnyx.NET.Messaging.Models.BulkPhoneNumberCampaign.Responses;

namespace Telnyx.NET.Messaging.Interfaces
{
    /// <summary>
    /// Interface defining operations for managing bulk phone number campaigns in the Telnyx platform.
    /// </summary>
    public interface IBulkPhoneNumberCampaignOperations
    {
        /// <summary>
        /// Assigns a messaging profile to a bulk campaign.
        /// </summary>
        /// <param name="request">The request containing the campaign details and messaging profile information.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation, containing the response of the assignment operation.
        /// </returns>
        Task<AssignMessagingProfileToCampaignResponse?> AssignMessagingProfile(
            AssignMessagingProfileToCampaignRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the status of a bulk phone number assignment task.
        /// </summary>
        /// <param name="taskId">The unique identifier for the assignment task.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation, containing the status of the task.
        /// </returns>
        Task<GetAssignmentTaskStatusResponse?> GetAssignmentTaskStatus(
            string taskId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the status of phone numbers assigned to a bulk campaign.
        /// </summary>
        /// <param name="taskId">The unique identifier for the assignment task.</param>
        /// <param name="request">The request containing pagination details for retrieving phone number statuses.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation, containing the response with phone number statuses.
        /// </returns>
        Task<GetPhoneNumberStatusResponse?> GetPhoneNumberStatus(
            string taskId, GetPhoneNumberStatusRequest request, CancellationToken cancellationToken = default);
    }
}
