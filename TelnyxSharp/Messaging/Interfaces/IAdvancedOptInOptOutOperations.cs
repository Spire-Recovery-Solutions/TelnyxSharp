using TelnyxSharp.Messaging.Models.AdvancedOptInOptOut.Requests;
using TelnyxSharp.Messaging.Models.AdvancedOptInOptOut.Responses;

namespace TelnyxSharp.Messaging.Interfaces
{
    public interface IAdvancedOptInOptOutOperations
    {
        /// <summary>
        /// Lists auto-response settings for a messaging profile.
        /// </summary>
        /// <param name="profileId">The ID of the messaging profile.</param>
        /// <param name="request">The filter and pagination request parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<ListAutoResponseSettingsResponse?> List(
            string profileId,
            ListAutoResponseSettingsRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new auto-response setting for a messaging profile.
        /// </summary>
        /// <param name="profileId">The ID of the messaging profile.</param>
        /// <param name="request">The request to create a new auto-response setting.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<CreateAutoResponseSettingResponse?> Create(
            string profileId,
            CreateAutoResponseSettingRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a specific auto-response setting for a messaging profile.
        /// </summary>
        /// <param name="profileId">The ID of the messaging profile.</param>
        /// <param name="autorespCfgId">The ID of the auto-response configuration.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<GetAutoResponseSettingResponse?> Retrieve(
            string profileId,
            string autorespCfgId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an existing auto-response setting for a messaging profile.
        /// </summary>
        /// <param name="profileId">The ID of the messaging profile.</param>
        /// <param name="autorespCfgId">The ID of the auto-response configuration.</param>
        /// <param name="request">The update request containing new configuration details.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<UpdateAutoResponseSettingResponse?> Update(
            string profileId,
            string autorespCfgId,
            UpdateAutoResponseSettingRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a specific auto-response setting for a messaging profile.
        /// </summary>
        /// <param name="profileId">The ID of the messaging profile.</param>
        /// <param name="autorespCfgId">The ID of the auto-response configuration.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response.</returns>
        Task<DeleteAutoResponseSettingResponse?> Delete(
            string profileId,
            string autorespCfgId,
            CancellationToken cancellationToken = default);
    }
}
