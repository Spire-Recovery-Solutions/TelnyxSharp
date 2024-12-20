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

        /// <summary>
        /// Retrieves a messaging profile by its unique identifier from the Telnyx API.
        /// </summary>
        /// <param name="id">The unique identifier (UUID) of the messaging profile to retrieve.</param>
        /// <param name="cancellationToken">
        /// An optional <see cref="CancellationToken"/> to cancel the request if needed.
        /// </param>
        /// <returns>
        /// A task representing the asynchronous operation.
        /// </returns>
        Task<RetrieveMessagingProfileResponse?> RetrieveMessagingProfile(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an existing messaging profile with the provided data.
        /// </summary>
        /// <param name="id">The unique identifier of the messaging profile to update.</param>
        /// <param name="request">The request object containing updated messaging profile details.</param>
        /// <param name="cancellationToken">An optional token to cancel the operation.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. The task result contains
        /// </returns>
        Task<UpdateMessagingProfileResponse?> UpdateMessagingProfile(string id, UpdateMessagingProfileRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a messaging profile by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the messaging profile to delete.</param>
        /// <param name="cancellationToken">Optional. A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains a <see cref="DeleteMessagingProfileResponse"/> if the operation is successful; otherwise, <c>null</c>.
        /// </returns>
        Task<DeleteMessagingProfileResponse?> DeleteMessagingProfile(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of phone numbers associated with a specific messaging profile.
        /// </summary>
        /// <param name="id">The unique identifier of the messaging profile.</param>
        /// <param name="request">The request object containing pagination details.</param>
        /// <param name="cancellationToken">An optional token to cancel the operation.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. The task result contains a 
        /// <see cref="MessagingProfilePhoneNumberResponse"/> if the request is successful; otherwise, null.
        /// </returns>
        Task<MessagingProfilePhoneNumberResponse?> ListMessagingProfilePhoneNumbers(string id, MessagingProfilePhoneNumberRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of short codes associated with a specific messaging profile.
        /// </summary>
        /// <param name="id">The unique identifier of the messaging profile.</param>
        /// <param name="request">The request object containing pagination details.</param>
        /// <param name="cancellationToken">An optional token to cancel the operation.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. The task result contains a 
        /// <see cref="MessagingProfileShortCodeResponse"/> if the request is successful; otherwise, null.
        /// </returns>
        Task<MessagingProfileShortCodeResponse?> ListMessagingProfileShortCodes(string id, MessagingProfileShortCodeRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves metrics for a specific messaging profile based on the provided criteria.
        /// </summary>
        /// <param name="id">The unique identifier of the messaging profile.</param>
        /// <param name="request">The request object containing filtering and metric-related options.</param>
        /// <param name="cancellationToken">An optional token to cancel the operation.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. The task result contains a 
        /// <see cref="MessagingProfileMetricsResponse"/> if the request is successful; otherwise, null.
        /// </returns>
        Task<RetrieveMessagingProfileMetricsResponse?> RetrieveMessagingProfileMetrics(string id, RetrieveMessagingProfileMetricsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of messaging profile metrics based on the specified request parameters.
        /// </summary>
        /// <param name="request">The request containing filter and pagination parameters for retrieving messaging profile metrics.</param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation, containing a 
        /// <see cref="MessagingProfileMetricsResponse"/> if successful, or <c>null</c> if no response is available.
        /// </returns>
        Task<MessagingProfileMetricsResponse?> ListMessagingProfileMetrics(MessagingProfileMetricsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends a long code message asynchronously.
        /// </summary>
        /// <param name="request">
        /// The request containing details for the long code message to be sent.
        /// </param>
        /// <param name="cancellationToken">
        /// An optional cancellation token that can be used to cancel the operation.
        /// </param>
        /// <returns>
        /// A task representing the asynchronous operation. The task result contains the response
        /// with details about the sent message or <c>null</c> if the request fails.
        /// </returns>
        Task<LongCodeMessageResponse?> SendLongCodeMessage(LongCodeMessageRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends a message using a number pool.
        /// </summary>
        /// <param name="request">The request containing the details of the message to be sent.</param>
        /// <param name="cancellationToken">A cancellation token to cancel the operation if necessary.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the response from the API,
        /// which includes message data and any errors that occurred.
        /// </returns>
        Task<NumberPoolMessageResponse?> SendMessageUsingNumberPoolAsync(NumberPoolMessageRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends a short code message asynchronously.
        /// </summary>
        /// <param name="request">
        /// The <see cref="ShortCodeMessageRequest"/> containing the details of the message to send.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> that can be used to cancel the request.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation, with a result of type 
        /// <see cref="ShortCodeMessageResponse"/> containing the response details if the operation is successful.
        /// </returns>
        Task<ShortCodeMessageResponse?> SendShortCodeMessageAsync(ShortCodeMessageRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends a group MMS message asynchronously.
        /// </summary>
        /// <param name="request">The request containing message details, including recipients and media content.</param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used to cancel the operation.
        /// Defaults to <see cref="CancellationToken.None"/>.
        /// </param>
        /// <returns>
        /// A task representing the asynchronous operation. Upon completion, returns a <see cref="GroupMmsMessageResponse"/>
        /// containing the response details, or <c>null</c> if the operation fails.
        /// </returns>
        Task<GroupMmsMessageResponse?> SendGroupMmsMessageAsync(GroupMmsMessageRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a message by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the message to retrieve.</param>
        /// <param name="cancellationToken">An optional cancellation token to cancel the operation.</param>
        /// <returns>
        /// A task representing the asynchronous operation. The task result contains an instance 
        /// of <see cref="RetrieveMessageResponse"/> if the message is found, or <c>null</c> if no message is found.
        /// </returns>
        Task<RetrieveMessageResponse?> RetrieveMessageAsync(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Asynchronously retrieves a list of messaging URL domains based on the provided request.
        /// </summary>
        /// <param name="request">The request containing the parameters to filter the messaging URL domains.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests. Default is <see cref="CancellationToken.None"/>.</param>
        /// <returns>A task representing the asynchronous operation, containing the response with the list of messaging URL domains.</returns>
        Task<ListMessagingUrlDomainsResponse?> ListMessagingUrlDomainsAsync(ListMessagingUrlDomainsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of short codes based on the specified request parameters.
        /// </summary>
        /// <param name="request">The request parameters for listing short codes.</param>
        /// <param name="cancellationToken">Optional cancellation token for canceling the operation.</param>
        /// <returns>A task representing the asynchronous operation. Returns a response containing the list of short codes.</returns>
        Task<ListShortCodesResponse?> ListShortCodesAsync(ListShortCodesRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves details about a specific short code by its unique identifier.
        /// </summary>
        /// <param name="shortCodeId">The unique identifier of the short code.</param>
        /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
        /// <returns>A task representing the asynchronous operation, containing the short code details upon completion.</returns>
        Task<RetrieveShortCodeResponse?> RetrieveShortCodeAsync(string shortCodeId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a short code resource in the Telnyx system.
        /// This method allows modification of an existing short code's properties such as its messaging profile.
        /// </summary>
        /// <param name="shortCodeId">The unique identifier for the short code to be updated.</param>
        /// <param name="request">The request object containing the updated short code information.</param>
        /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
        /// <returns>A response object containing the updated short code details or null if the operation fails.</returns>
        /// <exception cref="ApiException">Thrown if an error occurs during the API call.</exception>
        Task<UpdateShortCodeResponse?> UpdateShortCodeAsync(string shortCodeId, UpdateShortCodeRequest request, CancellationToken cancellationToken = default);

         /// <summary>
        /// Retrieves a list of phone numbers with their messaging settings.
        /// </summary>
        /// <param name="request">The request containing pagination details.</param>
        /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
        /// <returns>
        /// A task representing the asynchronous operation, containing a list of phone numbers with messaging settings.
        /// </returns>
        Task<ListPhoneMessageSettingsResponse?> ListPhoneNumbersWithMessagingSettingsAsync(ListPhoneMessageSettingsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves details about a specific phone number with messaging settings.
        /// </summary>
        /// <param name="id">The unique identifier of the phone number.</param>
        /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
        /// <returns>
        /// A task representing the asynchronous operation, containing the phone number details with messaging settings.
        /// </returns>
        Task<RetrievePhoneMessageSettingsResponse?> GetPhoneNumberWithMessagingSettingsAsync(string id, CancellationToken cancellationToken = default);

         /// <summary>
        /// Updates the messaging profile and/or messaging product of a phone number.
        /// </summary>
        /// <param name="id">The unique identifier of the phone number to update.</param>
        /// <param name="request">The request containing the new messaging profile and/or product configuration.</param>
        /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
        /// <returns>
        /// A task representing the asynchronous operation, containing the updated phone number details with messaging settings.
        /// </returns>
        Task<UpdatePhoneNumberMessagingResponse?> UpdatePhoneNumberMessagingSettingsAsync(string id, UpdatePhoneNumberMessagingRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the messaging profile of multiple phone numbers.
        /// </summary>
        /// <param name="request">The request containing the messaging profile and the list of phone numbers to update.</param>
        /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
        /// <returns>
        /// A task representing the asynchronous operation, containing the bulk update status details.
        /// </returns>
        Task<UpdateNumbersMessagingBulkResponse?> UpdateMessagingProfileForMultipleNumbersAsync(UpdateNumbersMessagingBulkRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the status of a bulk update operation for messaging profiles.
        /// </summary>
        /// <param name="orderId">The unique identifier of the bulk update order.</param>
        /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
        /// <returns>
        /// A task representing the asynchronous operation, containing the bulk update status details.
        /// </returns>
        Task<RetrieveBulkUpdateStatusResponse?> RetrieveBulkUpdateStatusAsync(string orderId, CancellationToken cancellationToken = default);
    }
}