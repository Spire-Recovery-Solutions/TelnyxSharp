using TelnyxSharp.Numbers.Models.Voicemail.Requests;
using TelnyxSharp.Numbers.Models.Voicemail.Responses;

namespace TelnyxSharp.Numbers.Interfaces
{
    /// <summary>
    /// Provides operations for managing voicemail settings for phone numbers.
    /// This includes retrieving, creating, and updating voicemail configurations.
    /// </summary>
    public interface IVoicemailOperations
    {
        /// <summary>
        /// Retrieves the voicemail settings for a given phone number.
        /// </summary>
        /// <param name="phoneNumberId">The unique identifier for the phone number.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>The voicemail settings for the phone number.</returns>
        Task<GetVoicemailResponse> Get(string phoneNumberId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new voicemail configuration for a given phone number.
        /// </summary>
        /// <param name="phoneNumberId">The unique identifier for the phone number.</param>
        /// <param name="request">The voicemail configuration to create.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>The response containing details about the created voicemail configuration.</returns>
        Task<CreateVoicemailResponse> Create(string phoneNumberId, CreateVoicemailRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the voicemail configuration for a given phone number.
        /// </summary>
        /// <param name="phoneNumberId">The unique identifier for the phone number.</param>
        /// <param name="request">The voicemail settings to update.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>The response containing details about the updated voicemail configuration.</returns>
        Task<UpdateVoicemailResponse> Update(string phoneNumberId, UpdateVoicemailRequest request, CancellationToken cancellationToken = default);
    }
}
