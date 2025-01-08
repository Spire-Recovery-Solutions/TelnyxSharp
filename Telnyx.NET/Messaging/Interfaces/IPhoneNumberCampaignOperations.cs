using Telnyx.NET.Messaging.Models.PhoneNumberCampaign;

namespace Telnyx.NET.Messaging.Interfaces
{
    /// <summary>
    /// Provides operations for managing 10DLC phone number campaigns through the Telnyx API.
    /// This interface handles all CRUD operations for phone number campaign management,
    /// including creating new campaigns, retrieving campaign details, updating existing campaigns,
    /// and removing campaigns from phone numbers.
    /// </summary>
    public interface IPhoneNumberCampaignOperations
    {
        /// <summary>
        /// Retrieves a paginated list of phone number campaigns based on specified filters.
        /// </summary>
        /// <param name="request">The request containing filter parameters such as campaign IDs, brand IDs, sorting preferences, and pagination options.</param>
        /// <param name="cancellationToken">A token to cancel the ongoing operation (optional).</param>
        /// <returns>A response containing the list of phone number campaigns matching the specified criteria.</returns>
        Task<RetrievePhoneNumberCampaignsResponse?> Retrieve(
            RetrievePhoneNumberCampaignsRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new phone number campaign association.
        /// </summary>
        /// <param name="request">The request containing the campaign details and configuration.</param>
        /// <param name="cancellationToken">A token to cancel the ongoing operation (optional).</param>
        /// <returns>A response containing the details of the newly created phone number campaign.</returns>
        Task<CreatePhoneNumberCampaignResponse?> Create(
            CreatePhoneNumberCampaignRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the campaign details for a specific phone number.
        /// This method provides detailed information about the 10DLC campaign associated
        /// with the specified phone number, including campaign status and configuration.
        /// </summary>
        /// <param name="phoneNumber">The phone number to retrieve campaign details for.</param>
        /// <param name="cancellationToken">A token to cancel the ongoing operation (optional).</param>
        /// <returns>A response containing the campaign details for the specified phone number.</returns>
        /// <remarks>
        /// Use this method when you need to get campaign information for a single phone number.
        /// The phone number should be in E.164 format (e.g., +1234567890).
        /// </remarks>
        Task<GetPhoneNumberCampaignResponse?> Get(
            string phoneNumber,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the campaign association for a specific phone number.
        /// </summary>
        /// <param name="phoneNumber">The phone number whose campaign details need to be updated.</param>
        /// <param name="request">The request containing the updated campaign details.</param>
        /// <param name="cancellationToken">A token to cancel the ongoing operation (optional).</param>
        /// <returns>A response containing the updated campaign details.</returns>
        Task<UpdatePhoneNumberCampaignResponse?> Update(
            string phoneNumber,
            UpdatePhoneNumberCampaignRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Removes a campaign association from a specific phone number.
        /// </summary>
        /// <param name="phoneNumber">The phone number whose campaign association needs to be removed.</param>
        /// <param name="cancellationToken">A token to cancel the ongoing operation (optional).</param>
        /// <returns>A response confirming the deletion of the campaign association.</returns>
        Task<DeletePhoneNumberCampaignResponse?> Delete(
            string phoneNumber,
            CancellationToken cancellationToken = default);
    }

}
