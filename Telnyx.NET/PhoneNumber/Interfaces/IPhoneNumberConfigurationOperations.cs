using System.Threading;
using System.Threading.Tasks;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Requests;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Responses;

namespace Telnyx.NET.PhoneNumber.Interfaces
{
    /// <summary>
    /// Defines operations for managing phone number configurations.
    /// </summary>
    public interface IPhoneNumberConfigurationOperations
    {
        /// <summary>
        /// Updates the voice settings for a specific phone number.
        /// </summary>
        /// <param name="phoneNumberId">The ID of the phone number to update.</param>
        /// <param name="request">The request object containing the updated voice settings.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with updated voice settings.</returns>
        Task<UpdateNumberVoiceSettingsResponse> UpdateNumberVoiceSettings(string phoneNumberId, UpdateNumberVoiceSettingsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of phone numbers based on specified filters.
        /// </summary>
        /// <param name="request">The request object containing filtering options.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with the list of phone numbers.</returns>
        Task<ListNumbersResponse> List(ListNumbersRequest request, CancellationToken cancellationToken = default);

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