using Telnyx.NET.Models;

namespace Telnyx.NET.Interfaces
{
    /// <summary>
    /// Interface for interacting with the Telnyx API.
    /// Provides methods for managing phone numbers, making calls, and sending messages.
    /// </summary>
    public interface ITelnyxClient
    {
        /// <summary>
        /// Looks up information for a given phone number.
        /// </summary>
        /// <param name="request">The request containing the phone number to look up.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="NumberLookupResponse"/> containing the result of the lookup.</returns>
        Task<NumberLookupResponse?> NumberLookup(NumberLookupRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of available phone numbers based on specified criteria.
        /// </summary>
        /// <param name="request">The request specifying the criteria for available numbers.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="AvailablePhoneNumbersResponse"/> containing the available phone numbers.</returns>
        Task<AvailablePhoneNumbersResponse?> AvailablePhoneNumbers(AvailablePhoneNumbersRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists all number orders made by the user.
        /// </summary>
        /// <param name="request">The request containing filters for listing number orders.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="ListNumberOrdersResponse"/> containing the list of number orders.</returns>
        Task<ListNumberOrdersResponse?> ListNumberOrders(ListNumberOrdersRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves details of a specific number order by its ID.
        /// </summary>
        /// <param name="numberOrderId">The ID of the number order to retrieve.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="GetNumberOrderResponse"/> containing details of the specified number order.</returns>
        Task<GetNumberOrderResponse?> GetNumberOrder(string numberOrderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new number order based on the provided request.
        /// </summary>
        /// <param name="request">The request containing details for creating the number order.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="CreateNumberOrderResponse"/> containing the result of the creation.</returns>
        Task<CreateNumberOrderResponse?> CreateNumberOrder(CreateNumberOrderRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the voice settings for a specified phone number.
        /// </summary>
        /// <param name="phoneNumberId">The ID of the phone number to update.</param>
        /// <param name="request">The request containing the new voice settings.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="UpdateNumberVoiceSettingsResponse"/> containing the result of the update.</returns>
        Task<UpdateNumberVoiceSettingsResponse?> UpdateNumberVoiceSettings(string phoneNumberId, UpdateNumberVoiceSettingsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists all phone numbers associated with the user's account.
        /// </summary>
        /// <param name="request">The request containing filters for listing phone numbers.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="ListNumbersResponse"/> containing the list of phone numbers.</returns>
        Task<ListNumbersResponse?> ListNumbers(ListNumbersRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists all porting orders made by the user.
        /// </summary>
        /// <param name="request">The request containing filters for listing porting orders.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="ListPortingOrdersResponse"/> containing the list of porting orders.</returns>
        Task<ListPortingOrdersResponse?> ListPortingOrders(ListPortingOrdersRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists all phone numbers associated with porting orders.
        /// </summary>
        /// <param name="request">The request containing filters for listing porting phone numbers.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="ListPortingPhoneNumbersResponse"/> containing the list of porting phone numbers.</returns>
        Task<ListPortingPhoneNumbersResponse?> ListPortingPhoneNumbers(ListPortingPhoneNumbersRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new number reservation based on the provided request.
        /// </summary>
        /// <param name="request">The request containing details for creating the number reservation.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="CreateNumberReservationResponse"/> containing the result of the creation.</returns>
        Task<CreateNumberReservationResponse?> CreateNumberReservation(CreateNumberReservationRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the configuration for a specified phone number.
        /// </summary>
        /// <param name="phoneNumberId">The ID of the phone number to update.</param>
        /// <param name="request">The request containing the new configuration settings.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="UpdateNumberConfigurationResponse"/> containing the result of the update.</returns>
        Task<UpdateNumberConfigurationResponse?> UpdateNumberConfiguration(string phoneNumberId, UpdateNumberConfigurationRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Removes a specified phone number or object by its ID.
        /// </summary>
        /// <param name="numberOrObjectId">The ID of the number or object to remove.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A boolean indicating the success of the removal operation.</returns>
        Task<bool> RemoveNumber(string numberOrObjectId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends a message to a specified recipient.
        /// </summary>
        /// <param name="request">The request containing the message details.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="SendMessageResponse"/> containing the result of the send operation.</returns>
        Task<SendMessageResponse?> SendMessage(SendMessageRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates a call based on the provided request details.
        /// </summary>
        /// <param name="request">The request containing the call details.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="DialResponse"/> containing the result of the dial operation.</returns>
        Task<DialResponse?> Dial(DialRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Answers an incoming call based on the provided call control ID.
        /// </summary>
        /// <param name="callControlId">The ID of the call to answer.</param>
        /// <param name="request">The request containing details for answering the call.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="AnswerCallResponse"/> containing the result of the answer operation.</returns>
        Task<AnswerCallResponse?> AnswerCall(string callControlId, AnswerCallRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Hangs up a call based on the provided call control ID.
        /// </summary>
        /// <param name="callControlId">The ID of the call to hang up.</param>
        /// <param name="request">The request containing details for hanging up the call.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="HangupCallResponse"/> containing the result of the hangup operation.</returns>
        Task<HangupCallResponse?> HangupCall(string callControlId, HangupCallRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Rejects an incoming call based on the provided call control ID.
        /// </summary>
        /// <param name="callControlId">The ID of the call to reject.</param>
        /// <param name="request">The request containing details for rejecting the call.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="RejectCallResponse"/> containing the result of the reject operation.</returns>
        Task<RejectCallResponse?> RejectCall(string callControlId, RejectCallRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Speaks text on a specified call based on the provided call control ID.
        /// </summary>
        /// <param name="callControlId">The ID of the call for speaking text.</param>
        /// <param name="request">The request containing the text to speak.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="SpeakTextResponse"/> containing the result of the speak operation.</returns>
        Task<SpeakTextResponse?> SpeakText(string callControlId, SpeakTextRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Starts audio playback on a specified call based on the provided call control ID.
        /// </summary>
        /// <param name="callControlId">The ID of the call for starting playback.</param>
        /// <param name="request">The request containing details for the playback.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="PlaybackStartResponse"/> containing the result of the playback start operation.</returns>
        Task<PlaybackStartResponse?> PlaybackStart(string callControlId, PlaybackStartRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Stops audio playback on a specified call based on the provided call control ID.
        /// </summary>
        /// <param name="callControlId">The ID of the call for stopping playback.</param>
        /// <param name="request">The request containing details for stopping playback.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="StopAudioPlaybackResponse"/> containing the result of the stop playback operation.</returns>
        Task<StopAudioPlaybackResponse?> StopAudioPlayback(string callControlId, StopAudioPlaybackRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Enqueues a call based on the provided call control ID.
        /// </summary>
        /// <param name="callControlId">The ID of the call to enqueue.</param>
        /// <param name="request">The request containing details for the enqueue operation.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="EnqueueCallResponse"/> containing the result of the enqueue operation.</returns>
        Task<EnqueueCallResponse?> EnqueueCall(string callControlId, EnqueueCallRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Removes a call from a queue based on the provided call control ID.
        /// </summary>
        /// <param name="callControlId">The ID of the call to remove from the queue.</param>
        /// <param name="request">The request containing details for the removal.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="RemoveCallFromQueueResponse"/> containing the result of the remove operation.</returns>
        Task<RemoveCallFromQueueResponse?> RemoveCallFromQueue(string callControlId, RemoveCallFromQueueRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Transfers a call based on the provided call control ID.
        /// </summary>
        /// <param name="callControlId">The ID of the call to transfer.</param>
        /// <param name="request">The request containing details for the transfer operation.</param>
        /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
        /// <returns>A <see cref="TransferCallResponse"/> containing the result of the transfer operation.</returns>
        Task<TransferCallResponse?> TransferCall(string callControlId, TransferCallRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves messaging profiles based on the given request parameters.
        /// </summary>
        /// <param name="request">The request containing parameters for filtering and pagination.</param>
        /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response with messaging profiles or null if the operation fails.</returns>
        Task<MessagingProfilesResponse?> GetMessagingProfiles(MessagingProfilesRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new messaging profile based on the provided request.
        /// </summary>
        /// <param name="request">The request object containing the details needed to create the messaging profile.</param>
        /// <param name="cancellationToken">A token to cancel the asynchronous operation. Default is `CancellationToken.None`.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response of type `CreateMessagingProfileResponse` if the operation is successful, or `null` if it fails.</returns>
        Task<CreateMessagingProfileResponse?> CreateMessagingProfile(CreateMessagingProfileRequest request, CancellationToken cancellationToken = default);
    }
}