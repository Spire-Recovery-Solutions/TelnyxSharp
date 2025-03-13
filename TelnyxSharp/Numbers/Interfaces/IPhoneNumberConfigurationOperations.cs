using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberConfigurations;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberConfigurations;

namespace TelnyxSharp.Numbers.Interfaces
{
    /// <summary>
    /// Defines operations for managing phone number configurations.
    /// </summary>
    public interface IPhoneNumberConfigurationOperations
    {
        /// <summary>
        /// Retrieves a list of phone numbers based on specified filters.
        /// </summary>
        /// <param name="request">The request object containing filtering options.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the list of phone numbers.</returns>
        Task<ListNumbersResponse> List(ListNumbersRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a simplified list of phone numbers with limited details.
        /// </summary>
        /// <param name="request">The request object containing filtering options.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the simplified list of phone numbers.</returns>
        Task<SlimListNumbersResponse> SlimList(SlimListNumbersRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves details of a specific phone number.
        /// </summary>
        /// <param name="id">The ID of the phone number to retrieve.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with phone number details.</returns>
        Task<GetNumberResponse> Get(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of phone numbers with voice settings based on specified filters.
        /// </summary>
        /// <param name="request">The request object containing filtering options.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the list of phone numbers and their voice settings.</returns>
        Task<ListNumbersWithVoiceSettingsResponse> ListNumbersVoiceSettings(ListNumbersWithVoiceSettingsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the voice settings for a specific phone number.
        /// </summary>
        /// <param name="phoneNumberId">The ID of the phone number.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the voice settings.</returns>
        Task<GetNumberVoiceSettingsResponse> GetNumberVoiceSettings(string phoneNumberId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the voice settings for a specific phone number.
        /// </summary>
        /// <param name="phoneNumberId">The ID of the phone number to update.</param>
        /// <param name="request">The request object containing the updated voice settings.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with updated voice settings.</returns>
        Task<UpdateNumberVoiceSettingsResponse> UpdateNumberVoiceSettings(string phoneNumberId, UpdateNumberVoiceSettingsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Enables emergency settings for a specific phone number.
        /// </summary>
        /// <param name="phoneNumberId">The ID of the phone number to update.</param>
        /// <param name="request">The request object containing the emergency settings.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with updated emergency settings.</returns>
        Task<EnableEmergencyResponse> EnableEmergency(string phoneNumberId, EnableEmergencyRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Changes the bundle status of a phone number.
        /// </summary>
        /// <param name="phoneNumberId">The ID of the phone number to update.</param>
        /// <param name="request">The request object containing the bundle status change details.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the updated bundle status.</returns>
        Task<ChangeBundleStatusResponse> ChangeBundleStatus(long phoneNumberId, ChangeBundleStatusRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the configuration for a specific phone number.
        /// </summary>
        /// <param name="phoneNumberId">The ID of the phone number to update.</param>
        /// <param name="request">The request object containing the updated configuration.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with updated configuration.</returns>
        Task<UpdateNumberConfigurationResponse> Update(string phoneNumberId, UpdateNumberConfigurationRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a phone number or phone number object.
        /// </summary>
        /// <param name="numberOrObjectId">The phone number or object ID to delete.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response for the delete operation.</returns>
        Task<DeletePhoneNumberResponse> Delete(string numberOrObjectId, CancellationToken cancellationToken = default);
    }
}