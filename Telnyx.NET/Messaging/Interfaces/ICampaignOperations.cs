using Telnyx.NET.Messaging.Models.Campaign.Requests;
using Telnyx.NET.Messaging.Models.Campaign.Responses;

namespace Telnyx.NET.Messaging.Interfaces
{
    public interface ICampaignOperations
    {
        /// <summary>
        /// Lists campaigns with optional filters and pagination.
        /// </summary>
        /// <param name="request">The request containing filters and pagination options for listing campaigns.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A list of campaigns based on the provided filters and pagination.</returns>
        Task<ListCampaignsResponse?> List(ListCampaignsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a campaign by its unique identifier.
        /// </summary>
        /// <param name="campaignId">The unique identifier of the campaign to retrieve.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response containing the details of the requested campaign.</returns>
        Task<GetCampaignResponse?> Get(string campaignId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an existing campaign with new details.
        /// </summary>
        /// <param name="campaignId">The unique identifier of the campaign to update.</param>
        /// <param name="request">The request containing the updated campaign details.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response containing the updated campaign details.</returns>
        Task<UpdateCampaignResponse?> Update(string campaignId, UpdateCampaignRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deactivates a campaign by its unique identifier.
        /// </summary>
        /// <param name="campaignId">The unique identifier of the campaign to deactivate.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response confirming the deactivation of the campaign.</returns>
        Task<DeactivateCampaignResponse?> Deactivate(string campaignId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the operation status of a campaign.
        /// </summary>
        /// <param name="campaignId">The unique identifier of the campaign to retrieve the operation status for.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response containing the operation status of the specified campaign.</returns>
        Task<GetCampaignOperationStatusResponse?> RetrieveOperationStatus(string campaignId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the OSR (Operating System Requirement) attributes for a specific campaign.
        /// </summary>
        /// <param name="campaignId">The unique identifier of the campaign to retrieve OSR attributes for.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response containing the OSR attributes of the specified campaign.</returns>
        Task<GetCampaignOsrAttributesResponse?> RetrieveOsrAttributes(string campaignId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the cost details for a specific campaign.
        /// </summary>
        /// <param name="request">The request containing the campaign cost query details.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response containing the cost details of the specified campaign.</returns>
        Task<GetCampaignCostResponse?> GetCost(GetCampaignCostRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Submits a campaign for approval or processing.
        /// </summary>
        /// <param name="request">The request containing the details of the campaign to submit.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response confirming the submission of the campaign.</returns>
        Task<SubmitCampaignResponse?> Submit(SubmitCampaignRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Qualifies a campaign by its use case to determine its eligibility.
        /// </summary>
        /// <param name="brandId">The unique identifier of the brand associated with the campaign.</param>
        /// <param name="usecase">The use case to qualify the campaign for.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response indicating the qualification status of the campaign for the given use case.</returns>
        Task<QualifyCampaignByUsecaseResponse?> QualifyByUsecase(string brandId, string usecase, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the MNO (Mobile Network Operator) metadata for a campaign.
        /// </summary>
        /// <param name="campaignId">The unique identifier of the campaign to retrieve MNO metadata for.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response containing the MNO metadata for the specified campaign.</returns>
        Task<GetCampaignMnoMetadataResponse?> GetCampaignMnoMetadataAsync(string campaignId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Accepts a shared campaign from another brand or entity.
        /// </summary>
        /// <param name="campaignId">The unique identifier of the shared campaign to accept.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response confirming the acceptance of the shared campaign.</returns>
        Task<AcceptSharedCampaignResponse?> AcceptSharedCampaignAsync(string campaignId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the sharing status of a campaign.
        /// </summary>
        /// <param name="campaignId">The unique identifier of the campaign to retrieve sharing status for.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response containing the sharing status of the specified campaign.</returns>
        Task<GetCampaignSharingStatusResponse?> GetSharingStatus(string campaignId, CancellationToken cancellationToken = default);
    }
}