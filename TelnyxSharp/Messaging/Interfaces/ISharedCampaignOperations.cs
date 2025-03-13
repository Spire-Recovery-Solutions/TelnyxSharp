using TelnyxSharp.Messaging.Models.SharedCampaign.Requests;
using TelnyxSharp.Messaging.Models.SharedCampaign.Responses;

namespace TelnyxSharp.Messaging.Interfaces
{
    /// <summary>
    /// Interface defining operations for managing shared campaigns in the Telnyx API.
    /// </summary>
    public interface ISharedCampaignOperations
    {
        /// <summary>
        /// Retrieves a paginated list of shared campaigns based on the specified request.
        /// </summary>
        /// <param name="request">The request parameters for listing shared campaigns.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of shared campaigns.</returns>
        Task<ListSharedCampaignsResponse?> List(ListSharedCampaignsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the details of a single shared campaign based on its ID.
        /// </summary>
        /// <param name="campaignId">The ID of the shared campaign to retrieve.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the shared campaign details.</returns>
        Task<GetSharedCampaignRecordResponse?> Get(string campaignId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a shared campaign's details based on the specified request.
        /// </summary>
        /// <param name="campaignId">The ID of the shared campaign to update.</param>
        /// <param name="request">The update request with new campaign details.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the updated campaign details.</returns>
        Task<UpdateSingleSharedCampaignResponse?> Update(string campaignId, UpdateSingleSharedCampaignRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the sharing status of a shared campaign based on its ID.
        /// </summary>
        /// <param name="campaignId">The ID of the shared campaign to check sharing status.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the sharing status of the campaign.</returns>
        Task<GetSharingStatusResponse?> GetSharingStatus(string campaignId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of partner campaigns shared by the user.
        /// </summary>
        /// <param name="request">The request parameters for retrieving campaigns shared by the user.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of campaigns shared by the user.</returns>
        Task<GetPartnerCampaignsSharedByUserResponse?> GetPartnerCampaignsSharedByUser(GetPartnerCampaignsSharedByUserRequest request, CancellationToken cancellationToken = default);
    }
}
