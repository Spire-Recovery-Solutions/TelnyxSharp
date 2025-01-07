// using Telnyx.NET.Enums;
// using Telnyx.NET.Models;
//
// namespace Telnyx.NET.Interfaces
// {
//     /// <summary>
//     /// Interface for interacting with the Telnyx API.
//     /// Provides methods for managing phone numbers, making calls, and sending messages.
//     /// </summary>
//     public interface ITelnyxClient
//     {
//         /// <summary>
//         /// Looks up information for a given phone number.
//         /// </summary>
//         /// <param name="request">The request containing the phone number to look up.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="NumberLookupResponse"/> containing the result of the lookup.</returns>
//         Task<NumberLookupResponse> NumberLookup(NumberLookupRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a list of available phone numbers based on specified criteria.
//         /// </summary>
//         /// <param name="request">The request specifying the criteria for available numbers.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="AvailablePhoneNumbersResponse"/> containing the available phone numbers.</returns>
//         Task<AvailablePhoneNumbersResponse> AvailablePhoneNumbers(AvailablePhoneNumbersRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Lists all number orders made by the user.
//         /// </summary>
//         /// <param name="request">The request containing filters for listing number orders.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="ListNumberOrdersResponse"/> containing the list of number orders.</returns>
//         Task<ListNumberOrdersResponse> ListNumberOrders(ListNumberOrdersRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves details of a specific number order by its ID.
//         /// </summary>
//         /// <param name="numberOrderId">The ID of the number order to retrieve.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="GetNumberOrderResponse"/> containing details of the specified number order.</returns>
//         Task<GetNumberOrderResponse> GetNumberOrder(string numberOrderId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Creates a new number order based on the provided request.
//         /// </summary>
//         /// <param name="request">The request containing details for creating the number order.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="CreateNumberOrderResponse"/> containing the result of the creation.</returns>
//         Task<CreateNumberOrderResponse> CreateNumberOrder(CreateNumberOrderRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Updates the voice settings for a specified phone number.
//         /// </summary>
//         /// <param name="phoneNumberId">The ID of the phone number to update.</param>
//         /// <param name="request">The request containing the new voice settings.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="UpdateNumberVoiceSettingsResponse"/> containing the result of the update.</returns>
//         Task<UpdateNumberVoiceSettingsResponse> UpdateNumberVoiceSettings(string phoneNumberId, UpdateNumberVoiceSettingsRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Lists all phone numbers associated with the user's account.
//         /// </summary>
//         /// <param name="request">The request containing filters for listing phone numbers.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="ListNumbersResponse"/> containing the list of phone numbers.</returns>
//         Task<ListNumbersResponse> ListNumbers(ListNumbersRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Lists all porting orders made by the user.
//         /// </summary>
//         /// <param name="request">The request containing filters for listing porting orders.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="ListPortingOrdersResponse"/> containing the list of porting orders.</returns>
//         Task<ListPortingOrdersResponse> ListPortingOrders(ListPortingOrdersRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Lists all phone numbers associated with porting orders.
//         /// </summary>
//         /// <param name="request">The request containing filters for listing porting phone numbers.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="ListPortingPhoneNumbersResponse"/> containing the list of porting phone numbers.</returns>
//         Task<ListPortingPhoneNumbersResponse> ListPortingPhoneNumbers(ListPortingPhoneNumbersRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Creates a new number reservation based on the provided request.
//         /// </summary>
//         /// <param name="request">The request containing details for creating the number reservation.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="CreateNumberReservationResponse"/> containing the result of the creation.</returns>
//         Task<CreateNumberReservationResponse> CreateNumberReservation(CreateNumberReservationRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Updates the configuration for a specified phone number.
//         /// </summary>
//         /// <param name="phoneNumberId">The ID of the phone number to update.</param>
//         /// <param name="request">The request containing the new configuration settings.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="UpdateNumberConfigurationResponse"/> containing the result of the update.</returns>
//         Task<UpdateNumberConfigurationResponse> UpdateNumberConfiguration(string phoneNumberId, UpdateNumberConfigurationRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Asynchronously removes a phone number or an associated object identified by its unique identifier.
//         /// </summary>
//         /// <param name="numberOrObjectId">The unique identifier (ID) of the phone number or related object to be removed.</param>
//         /// <param name="cancellationToken">An optional token to monitor for cancellation requests during the operation.</param>
//         /// <returns>
//         /// A task that represents the asynchronous delete operation. 
//         /// The result contains a response object with details about the removed phone number or associated object.
//         /// </returns>
//         Task<DeletePhoneNumberResponse> DeletePhoneNumber(string numberOrObjectId, CancellationToken cancellationToken = default);
//
//
//         /// <summary>
//         /// Sends a message to a specified recipient.
//         /// </summary>
//         /// <param name="request">The request containing the message details.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="SendMessageResponse"/> containing the result of the send operation.</returns>
//         Task<SendMessageResponse> SendMessage(SendMessageRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Initiates a call based on the provided request details.
//         /// </summary>
//         /// <param name="request">The request containing the call details.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="DialResponse"/> containing the result of the dial operation.</returns>
//         Task<DialResponse> Dial(DialRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Answers an incoming call based on the provided call control ID.
//         /// </summary>
//         /// <param name="callControlId">The ID of the call to answer.</param>
//         /// <param name="request">The request containing details for answering the call.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="AnswerCallResponse"/> containing the result of the answer operation.</returns>
//         Task<AnswerCallResponse> AnswerCall(string callControlId, AnswerCallRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Hangs up a call based on the provided call control ID.
//         /// </summary>
//         /// <param name="callControlId">The ID of the call to hang up.</param>
//         /// <param name="request">The request containing details for hanging up the call.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="HangupCallResponse"/> containing the result of the hangup operation.</returns>
//         Task<HangupCallResponse> HangupCall(string callControlId, HangupCallRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Rejects an incoming call based on the provided call control ID.
//         /// </summary>
//         /// <param name="callControlId">The ID of the call to reject.</param>
//         /// <param name="request">The request containing details for rejecting the call.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="RejectCallResponse"/> containing the result of the reject operation.</returns>
//         Task<RejectCallResponse> RejectCall(string callControlId, RejectCallRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Speaks text on a specified call based on the provided call control ID.
//         /// </summary>
//         /// <param name="callControlId">The ID of the call for speaking text.</param>
//         /// <param name="request">The request containing the text to speak.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="SpeakTextResponse"/> containing the result of the speak operation.</returns>
//         Task<SpeakTextResponse> SpeakText(string callControlId, SpeakTextRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Starts audio playback on a specified call based on the provided call control ID.
//         /// </summary>
//         /// <param name="callControlId">The ID of the call for starting playback.</param>
//         /// <param name="request">The request containing details for the playback.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="PlaybackStartResponse"/> containing the result of the playback start operation.</returns>
//         Task<PlaybackStartResponse> PlaybackStart(string callControlId, PlaybackStartRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Stops audio playback on a specified call based on the provided call control ID.
//         /// </summary>
//         /// <param name="callControlId">The ID of the call for stopping playback.</param>
//         /// <param name="request">The request containing details for stopping playback.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="StopAudioPlaybackResponse"/> containing the result of the stop playback operation.</returns>
//         Task<StopAudioPlaybackResponse> StopAudioPlayback(string callControlId, StopAudioPlaybackRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Enqueues a call based on the provided call control ID.
//         /// </summary>
//         /// <param name="callControlId">The ID of the call to enqueue.</param>
//         /// <param name="request">The request containing details for the enqueue operation.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="EnqueueCallResponse"/> containing the result of the enqueue operation.</returns>
//         Task<EnqueueCallResponse> EnqueueCall(string callControlId, EnqueueCallRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Removes a call from a queue based on the provided call control ID.
//         /// </summary>
//         /// <param name="callControlId">The ID of the call to remove from the queue.</param>
//         /// <param name="request">The request containing details for the removal.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="RemoveCallFromQueueResponse"/> containing the result of the remove operation.</returns>
//         Task<RemoveCallFromQueueResponse> RemoveCallFromQueue(string callControlId, RemoveCallFromQueueRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Transfers a call based on the provided call control ID.
//         /// </summary>
//         /// <param name="callControlId">The ID of the call to transfer.</param>
//         /// <param name="request">The request containing details for the transfer operation.</param>
//         /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
//         /// <returns>A <see cref="TransferCallResponse"/> containing the result of the transfer operation.</returns>
//         Task<TransferCallResponse> TransferCall(string callControlId, TransferCallRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves messaging profiles based on the given request parameters.
//         /// </summary>
//         /// <param name="request">The request containing parameters for filtering and pagination.</param>
//         /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
//         /// <returns>A task that represents the asynchronous operation. The task result contains the response with messaging profiles or null if the operation fails.</returns>
//         Task<MessagingProfilesResponse> GetMessagingProfiles(MessagingProfilesRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Creates a new messaging profile based on the provided request.
//         /// </summary>
//         /// <param name="request">The request object containing the details needed to create the messaging profile.</param>
//         /// <param name="cancellationToken">A token to cancel the asynchronous operation. Default is `CancellationToken.None`.</param>
//         /// <returns>A task that represents the asynchronous operation. The task result contains the response of type `CreateMessagingProfileResponse` if the operation is successful, or `null` if it fails.</returns>
//         Task<CreateMessagingProfileResponse> CreateMessagingProfile(CreateMessagingProfileRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a messaging profile by its unique identifier from the Telnyx API.
//         /// </summary>
//         /// <param name="id">The unique identifier (UUID) of the messaging profile to retrieve.</param>
//         /// <param name="cancellationToken">
//         /// An optional <see cref="CancellationToken"/> to cancel the request if needed.
//         /// </param>
//         /// <returns>
//         /// A task representing the asynchronous operation.
//         /// </returns>
//         Task<RetrieveMessagingProfileResponse> RetrieveMessagingProfile(string id, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Updates an existing messaging profile with the provided data.
//         /// </summary>
//         /// <param name="id">The unique identifier of the messaging profile to update.</param>
//         /// <param name="request">The request object containing updated messaging profile details.</param>
//         /// <param name="cancellationToken">An optional token to cancel the operation.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains
//         /// </returns>
//         Task<UpdateMessagingProfileResponse> UpdateMessagingProfile(string id, UpdateMessagingProfileRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Deletes a messaging profile by its unique identifier.
//         /// </summary>
//         /// <param name="id">The unique identifier of the messaging profile to delete.</param>
//         /// <param name="cancellationToken">Optional. A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation.
//         /// The task result contains a <see cref="DeleteMessagingProfileResponse"/> if the operation is successful; otherwise, <c>null</c>.
//         /// </returns>
//         Task<DeleteMessagingProfileResponse> DeleteMessagingProfile(string id, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a list of phone numbers associated with a specific messaging profile.
//         /// </summary>
//         /// <param name="id">The unique identifier of the messaging profile.</param>
//         /// <param name="request">The request object containing pagination details.</param>
//         /// <param name="cancellationToken">An optional token to cancel the operation.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains a 
//         /// <see cref="MessagingProfilePhoneNumberResponse"/> if the request is successful; otherwise, null.
//         /// </returns>
//         Task<MessagingProfilePhoneNumberResponse> ListMessagingProfilePhoneNumbers(string id, MessagingProfilePhoneNumberRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a list of short codes associated with a specific messaging profile.
//         /// </summary>
//         /// <param name="id">The unique identifier of the messaging profile.</param>
//         /// <param name="request">The request object containing pagination details.</param>
//         /// <param name="cancellationToken">An optional token to cancel the operation.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains a 
//         /// <see cref="MessagingProfileShortCodeResponse"/> if the request is successful; otherwise, null.
//         /// </returns>
//         Task<MessagingProfileShortCodeResponse> ListMessagingProfileShortCodes(string id, MessagingProfileShortCodeRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves metrics for a specific messaging profile based on the provided criteria.
//         /// </summary>
//         /// <param name="id">The unique identifier of the messaging profile.</param>
//         /// <param name="request">The request object containing filtering and metric-related options.</param>
//         /// <param name="cancellationToken">An optional token to cancel the operation.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains a 
//         /// <see cref="MessagingProfileMetricsResponse"/> if the request is successful; otherwise, null.
//         /// </returns>
//         Task<RetrieveMessagingProfileMetricsResponse> RetrieveMessagingProfileMetrics(string id, RetrieveMessagingProfileMetricsRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a list of messaging profile metrics based on the specified request parameters.
//         /// </summary>
//         /// <param name="request">The request containing filter and pagination parameters for retrieving messaging profile metrics.</param>
//         /// <param name="cancellationToken">
//         /// A <see cref="CancellationToken"/> to observe while waiting for the task to complete.
//         /// </param>
//         /// <returns>
//         /// A <see cref="Task"/> representing the asynchronous operation, containing a 
//         /// <see cref="MessagingProfileMetricsResponse"/> if successful, or <c>null</c> if no response is available.
//         /// </returns>
//         Task<MessagingProfileMetricsResponse> ListMessagingProfileMetrics(MessagingProfileMetricsRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Sends a long code message asynchronously.
//         /// </summary>
//         /// <param name="request">
//         /// The request containing details for the long code message to be sent.
//         /// </param>
//         /// <param name="cancellationToken">
//         /// An optional cancellation token that can be used to cancel the operation.
//         /// </param>
//         /// <returns>
//         /// A task representing the asynchronous operation. The task result contains the response
//         /// with details about the sent message or <c>null</c> if the request fails.
//         /// </returns>
//         Task<LongCodeMessageResponse> SendLongCodeMessage(LongCodeMessageRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Sends a message using a number pool.
//         /// </summary>
//         /// <param name="request">The request containing the details of the message to be sent.</param>
//         /// <param name="cancellationToken">A cancellation token to cancel the operation if necessary.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation.
//         /// The task result contains the response from the API,
//         /// which includes message data and any errors that occurred.
//         /// </returns>
//         Task<NumberPoolMessageResponse> SendMessageUsingNumberPoolAsync(NumberPoolMessageRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Sends a short code message asynchronously.
//         /// </summary>
//         /// <param name="request">
//         /// The <see cref="ShortCodeMessageRequest"/> containing the details of the message to send.
//         /// </param>
//         /// <param name="cancellationToken">
//         /// A <see cref="CancellationToken"/> that can be used to cancel the request.
//         /// </param>
//         /// <returns>
//         /// A <see cref="Task"/> representing the asynchronous operation, with a result of type 
//         /// <see cref="ShortCodeMessageResponse"/> containing the response details if the operation is successful.
//         /// </returns>
//         Task<ShortCodeMessageResponse> SendShortCodeMessageAsync(ShortCodeMessageRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Sends a group MMS message asynchronously.
//         /// </summary>
//         /// <param name="request">The request containing message details, including recipients and media content.</param>
//         /// <param name="cancellationToken">
//         /// A cancellation token that can be used to cancel the operation.
//         /// Defaults to <see cref="CancellationToken.None"/>.
//         /// </param>
//         /// <returns>
//         /// A task representing the asynchronous operation. Upon completion, returns a <see cref="GroupMmsMessageResponse"/>
//         /// containing the response details, or <c>null</c> if the operation fails.
//         /// </returns>
//         Task<GroupMmsMessageResponse> SendGroupMmsMessageAsync(GroupMmsMessageRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a message by its unique identifier.
//         /// </summary>
//         /// <param name="id">The unique identifier of the message to retrieve.</param>
//         /// <param name="cancellationToken">An optional cancellation token to cancel the operation.</param>
//         /// <returns>
//         /// A task representing the asynchronous operation. The task result contains an instance 
//         /// of <see cref="RetrieveMessageResponse"/> if the message is found, or <c>null</c> if no message is found.
//         /// </returns>
//         Task<RetrieveMessageResponse> RetrieveMessageAsync(string id, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Asynchronously retrieves a list of messaging URL domains based on the provided request.
//         /// </summary>
//         /// <param name="request">The request containing the parameters to filter the messaging URL domains.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests. Default is <see cref="CancellationToken.None"/>.</param>
//         /// <returns>A task representing the asynchronous operation, containing the response with the list of messaging URL domains.</returns>
//         Task<ListMessagingUrlDomainsResponse> ListMessagingUrlDomainsAsync(ListMessagingUrlDomainsRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a list of short codes based on the specified request parameters.
//         /// </summary>
//         /// <param name="request">The request parameters for listing short codes.</param>
//         /// <param name="cancellationToken">Optional cancellation token for canceling the operation.</param>
//         /// <returns>A task representing the asynchronous operation. Returns a response containing the list of short codes.</returns>
//         Task<ListShortCodesResponse> ListShortCodesAsync(ListShortCodesRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves details about a specific short code by its unique identifier.
//         /// </summary>
//         /// <param name="shortCodeId">The unique identifier of the short code.</param>
//         /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
//         /// <returns>A task representing the asynchronous operation, containing the short code details upon completion.</returns>
//         Task<RetrieveShortCodeResponse> RetrieveShortCodeAsync(string shortCodeId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Updates a short code resource in the Telnyx system.
//         /// This method allows modification of an existing short code's properties such as its messaging profile.
//         /// </summary>
//         /// <param name="shortCodeId">The unique identifier for the short code to be updated.</param>
//         /// <param name="request">The request object containing the updated short code information.</param>
//         /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
//         /// <returns>A response object containing the updated short code details or null if the operation fails.</returns>
//         /// <exception cref="ApiException">Thrown if an error occurs during the API call.</exception>
//         Task<UpdateShortCodeResponse> UpdateShortCodeAsync(string shortCodeId, UpdateShortCodeRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a list of phone numbers with their messaging settings.
//         /// </summary>
//         /// <param name="request">The request containing pagination details.</param>
//         /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
//         /// <returns>
//         /// A task representing the asynchronous operation, containing a list of phone numbers with messaging settings.
//         /// </returns>
//         Task<ListPhoneMessageSettingsResponse> ListPhoneNumbersWithMessagingSettingsAsync(ListPhoneMessageSettingsRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves details about a specific phone number with messaging settings.
//         /// </summary>
//         /// <param name="id">The unique identifier of the phone number.</param>
//         /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
//         /// <returns>
//         /// A task representing the asynchronous operation, containing the phone number details with messaging settings.
//         /// </returns>
//         Task<RetrievePhoneMessageSettingsResponse> GetPhoneNumberWithMessagingSettingsAsync(string id, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Updates the messaging profile and/or messaging product of a phone number.
//         /// </summary>
//         /// <param name="id">The unique identifier of the phone number to update.</param>
//         /// <param name="request">The request containing the new messaging profile and/or product configuration.</param>
//         /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
//         /// <returns>
//         /// A task representing the asynchronous operation, containing the updated phone number details with messaging settings.
//         /// </returns>
//         Task<UpdatePhoneNumberMessagingResponse> UpdatePhoneNumberMessagingSettingsAsync(string id, UpdatePhoneNumberMessagingRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Updates the messaging profile of multiple phone numbers.
//         /// </summary>
//         /// <param name="request">The request containing the messaging profile and the list of phone numbers to update.</param>
//         /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
//         /// <returns>
//         /// A task representing the asynchronous operation, containing the bulk update status details.
//         /// </returns>
//         Task<UpdateNumbersMessagingBulkResponse> UpdateMessagingProfileForMultipleNumbersAsync(UpdateNumbersMessagingBulkRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves the status of a bulk update operation for messaging profiles.
//         /// </summary>
//         /// <param name="orderId">The unique identifier of the bulk update order.</param>
//         /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
//         /// <returns>
//         /// A task representing the asynchronous operation, containing the bulk update status details.
//         /// </returns>
//         Task<RetrieveBulkUpdateStatusResponse> RetrieveBulkUpdateStatusAsync(string orderId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Deletes a messaging hosted number.
//         /// </summary>
//         /// <param name="id">The unique identifier of the messaging hosted number to delete.</param>
//         /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
//         /// <returns>
//         /// A task representing the asynchronous operation, containing the status of the delete operation.
//         /// </returns>
//         Task<DeleteHostedNumberResponse> DeleteHostedNumberAsync(string id, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a list of hosted number orders with pagination support.
//         /// </summary>
//         /// <param name="request">
//         /// The request containing parameters for retrieving hosted number orders, such as page number and page size.
//         /// </param>
//         /// <param name="cancellationToken">
//         /// An optional token for cancelling the asynchronous operation.
//         /// </param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. 
//         /// The task result contains a response with the list of hosted number orders.
//         /// </returns>
//         Task<GetHostedNumberOrderResponse> ListHostedNumberOrdersAsync(GetHostedNumberOrderRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Creates a new hosted number order.
//         /// </summary>
//         /// <param name="request">The request payload containing details for the hosted number order.</param>
//         /// <param name="cancellationToken">A token to observe for cancellation of the asynchronous operation.</param>
//         /// <returns>
//         /// A task representing the asynchronous operation. 
//         /// The task result contains the response of the hosted number order creation.
//         /// </returns>
//         Task<CreateHostedNumberOrderResponse> CreateHostedNumberOrderAsync(CreateHostedNumberOrderRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a messaging hosted number order by its unique identifier.
//         /// </summary>
//         /// <param name="id">The unique identifier of the messaging hosted number order.</param>
//         /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
//         /// <returns>
//         /// A task representing the asynchronous operation, containing details about the messaging hosted number order.
//         /// </returns>
//         Task<RetrieveHostedNumberOrderResponse> RetrieveHostedNumberOrderAsync(string id, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Uploads the required files (e.g., Letter of Authorization and bill) for a specified hosted number order.
//         /// </summary>
//         /// <param name="id">The unique identifier of the hosted number order.</param>
//         /// <param name="request">The request payload containing the files to be uploaded.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response 
//         /// with details about the uploaded files or any errors encountered during the process.
//         /// </returns>
//         Task<UploadFileHostedNumberOrderResponse> UploadFileRequiredForHostedNumberOrderAsync(string id, UploadFileHostedNumberOrderRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a list of auto-response settings for a given messaging profile.
//         /// </summary>
//         /// <param name="profileId">The unique identifier of the messaging profile.</param>
//         /// <param name="request">The request parameters for the auto-response settings query.</param>
//         /// <param name="cancellationToken">An optional token to cancel the operation.</param>
//         /// <returns>A task that represents the asynchronous operation, with a response containing the list of auto-response settings.</returns>
//         Task<ListAutoResponseSettingsResponse> ListAutoResponseSettingsAsync(string profileId, ListAutoResponseSettingsRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Creates a new auto-response setting for the given messaging profile in the Telnyx API.
//         /// </summary>
//         /// <param name="profileId">The unique identifier of the messaging profile where the auto-response setting will be created.</param>
//         /// <param name="request">The request object containing the details of the auto-response setting to be created.</param>
//         /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
//         /// <returns>A task that represents the asynchronous operation. The task result is the response from the Telnyx API containing the details of the created auto-response setting.</returns>
//         Task<CreateAutoResponseSettingResponse> CreateAutoResponseSettingAsync(string profileId, CreateAutoResponseSettingRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves an auto-response setting for the given messaging profile and auto-response configuration ID.
//         /// </summary>
//         /// <param name="profileId">The unique identifier of the messaging profile for which the auto-response setting is being retrieved.</param>
//         /// <param name="autorespCfgId">The unique identifier of the auto-response configuration to retrieve.</param>
//         /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
//         /// <returns>A task that represents the asynchronous operation. The task result is the response from the Telnyx API containing the details of the requested auto-response setting.</returns>
//         Task<GetAutoResponseSettingResponse> GetAutoResponseSettingAsync(string profileId, string autorespCfgId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Updates an existing Auto Response Setting configuration for a specified profile.
//         /// </summary>
//         /// <param name="profileId">The unique identifier for the messaging profile.</param>
//         /// <param name="autorespCfgId">The unique identifier for the auto-response configuration to be updated.</param>
//         /// <param name="request">The request containing the data to update the auto-response configuration.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests. Defaults to <c>default</c>.</param>
//         /// <returns>A task that represents the asynchronous operation. The task result is an <see cref="UpdateAutoResponseSettingResponse"/> representing the updated configuration.</returns>
//         Task<UpdateAutoResponseSettingResponse> UpdateAutoResponseSettingAsync(string profileId, string autorespCfgId, UpdateAutoResponseSettingRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Deletes an existing Auto Response Setting configuration for a specified profile.
//         /// </summary>
//         /// <param name="profileId">The unique identifier for the messaging profile.</param>
//         /// <param name="autorespCfgId">The unique identifier for the auto-response configuration to be deleted.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests. Defaults to <c>default</c>.</param>
//         /// <returns>A task that represents the asynchronous operation. The task result is a <see cref="DeleteAutoResponseSettingResponse"/> representing the result of the delete operation.</returns>
//         Task<DeleteAutoResponseSettingResponse> DeleteAutoResponseSettingAsync(string profileId, string autorespCfgId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a paginated list of verification requests based on the specified filters.
//         /// </summary>
//         /// <param name="request">The request object containing pagination and filter parameters.</param>
//         /// <param name="cancellationToken">A token to cancel the operation if needed.</param>
//         /// <returns>
//         /// A <see cref="ListVerificationRequestsResponse"/> containing the list of verification requests and additional metadata,
//         /// or <c>null</c> if the request fails.
//         /// </returns>
//         Task<ListVerificationRequestsResponse> ListVerificationRequestsAsync(ListVerificationRequestsRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Submits a new verification request for processing.
//         /// </summary>
//         /// <param name="request">The verification request details to be submitted.</param>
//         /// <param name="cancellationToken">A token to cancel the operation if necessary.</param>
//         /// <returns>
//         /// A <see cref="SubmitVerificationRequestResponse"/> containing the result of the submission,
//         /// or <c>null</c> if the request fails.
//         /// </returns>
//         Task<SubmitVerificationRequestResponse> SubmitVerificationRequestAsync(SubmitVerificationRequestRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a verification request by its unique identifier.
//         /// </summary>
//         /// <param name="id">The unique identifier of the verification request to retrieve.</param>
//         /// <param name="cancellationToken">An optional cancellation token to cancel the operation.</param>
//         /// <returns>
//         /// A <see cref="Task"/> that represents the asynchronous operation, containing a <see cref="GetVerificationRequestResponse"/> if found, or <c>null</c> if the request does not exist.
//         /// </returns>
//         Task<GetVerificationRequestResponse> GetVerificationRequestAsync(string id, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Updates an existing verification request with the specified details.
//         /// </summary>
//         /// <param name="id">The unique identifier of the verification request to update.</param>
//         /// <param name="request">The details of the update to apply to the verification request.</param>
//         /// <param name="cancellationToken">An optional cancellation token to cancel the operation.</param>
//         /// <returns>
//         /// A <see cref="Task"/> that represents the asynchronous operation, containing a <see cref="UpdateVerificationRequestResponse"/> with the updated information, or <c>null</c> if the request does not exist.
//         /// </returns>
//         Task<UpdateVerificationRequestResponse> UpdateVerificationRequestAsync(string id, UpdateVerificationRequestRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Asynchronously lists all brands.
//         /// </summary>
//         /// <param name="request">The request containing filtering or pagination details for listing brands.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>A <see cref="ListBrandsResponse"/> containing the list of brands, or null if the operation fails.</returns>
//         Task<ListBrandsResponse> ListBrandsAsync(ListBrandsRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Asynchronously creates a new brand.
//         /// </summary>
//         /// <param name="request">The request containing details for the new brand.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>A <see cref="CreateBrandResponse"/> containing the response data, or null if the operation fails.</returns>
//         Task<CreateBrandResponse> CreateBrandAsync(CreateBrandRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a brand's details asynchronously using the brand ID.
//         /// </summary>
//         /// <param name="brandId">The unique identifier of the brand to retrieve.</param>
//         /// <param name="cancellationToken">An optional token to cancel the asynchronous operation.</param>
//         /// <returns>
//         /// A task representing the asynchronous operation. The task result contains 
//         /// a <see cref="GetBrandResponse"/> object with the brand details if found; otherwise, null.
//         /// </returns>
//         Task<GetBrandResponse> GetBrandAsync(string brandId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Updates a 10DLC brand.
//         /// </summary>
//         /// <param name="brandId">The ID of the brand to update.</param>
//         /// <param name="request">The updated brand details.</param>
//         /// <param name="cancellationToken">Optional token to cancel the operation.</param>
//         /// <returns>
//         /// A task that returns the updated brand details or <c>null</c> if the update fails.
//         /// </returns>
//         Task<UpdateBrandResponse> UpdateBrandAsync(string brandId, UpdateBrandRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Deletes a brand by its unique identifier.
//         /// </summary>
//         /// <param name="brandId">The unique identifier of the brand to be deleted.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// of the delete operation, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<DeleteBrandResponse> DeleteBrandAsync(string brandId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Resends the two-factor authentication (2FA) email for a specified brand.
//         /// </summary>
//         /// <param name="brandId">The unique identifier of the brand for which the 2FA email should be resent.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// of the resend operation, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<ResendBrand2FAEmailResponse> ResendBrand2FAEmailAsync(string brandId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Reverts the changes made to a specified brand, restoring it to a previous state.
//         /// </summary>
//         /// <param name="brandId">The unique identifier of the brand to revert.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// of the revert operation, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<RevetBrandResponse> RevetBrandAsync(string brandId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a list of external vetting information associated with a specified brand.
//         /// </summary>
//         /// <param name="brandId">The unique identifier of the brand whose external vetting information is to be retrieved.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// with external vetting information, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<ListExternalVettingResponse> ListExternalVettingAsync(string brandId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Imports an external vetting record for the specified brand.
//         /// </summary>
//         /// <param name="brandId">The unique identifier of the brand for which the external vetting record is to be imported.</param>
//         /// <param name="request">The request object containing the details of the external vetting record to be imported.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// indicating the status of the import operation, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<ImportExternalVettingResponse> ImportExternalVettingRecordAsync(string brandId, ImportExternalVettingRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Places an order for external vetting for the specified brand.
//         /// </summary>
//         /// <param name="brandId">The unique identifier of the brand for which external vetting is to be ordered.</param>
//         /// <param name="request">The request object containing the details of the external vetting order.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// indicating the status of the external vetting order, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<OrderExternalVettingResponse> OrderExternalVettingAsync(string brandId, OrderExternalVettingRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves feedback for the specified brand.
//         /// </summary>
//         /// <param name="brandId">The unique identifier of the brand for which feedback is to be retrieved.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// with the feedback details for the specified brand, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<GetBrandFeedbackResponse> GetBrandFeedbackAsync(string brandId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Asynchronously retrieves a list of campaigns based on the provided request parameters.
//         /// </summary>
//         /// <param name="request">The request object containing the necessary parameters for listing campaigns.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests (optional).</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// with a list of campaigns, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<ListCampaignsResponse> ListCampaignsAsync(ListCampaignsRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Asynchronously retrieves a specific campaign based on its unique identifier.
//         /// </summary>
//         /// <param name="campaignId">The unique identifier of the campaign to retrieve.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests (optional).</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// with the details of the specified campaign, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<GetCampaignResponse> GetCampaignAsync(string campaignId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Asynchronously updates a specific campaign with the provided update request details.
//         /// </summary>
//         /// <param name="campaignId">The unique identifier of the campaign to update.</param>
//         /// <param name="request">The request object containing the updated campaign details.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests (optional).</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// confirming the update of the campaign, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<UpdateCampaignResponse> UpdateCampaignAsync(string campaignId, UpdateCampaignRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Asynchronously deactivates a specific campaign by its identifier.
//         /// </summary>
//         /// <param name="campaignId">The unique identifier of the campaign to deactivate.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests (optional).</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// confirming the deactivation of the campaign, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<DeactivateCampaignResponse> DeactivateCampaignAsync(string campaignId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Asynchronously retrieves the status of a campaign's operation.
//         /// </summary>
//         /// <param name="campaignId">The unique identifier of the campaign to check the operation status.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests (optional).</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// with the campaign operation status, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<GetCampaignOperationStatusResponse> GetCampaignOperationStatusAsync(string campaignId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Asynchronously retrieves the OSR (Onboarding Status Report) attributes for a specific campaign.
//         /// </summary>
//         /// <param name="campaignId">The unique identifier of the campaign to retrieve OSR attributes.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests (optional).</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// with the OSR attributes of the specified campaign, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<GetCampaignOsrAttributesResponse> GetCampaignOsrAttributesAsync(string campaignId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Asynchronously retrieves the cost details for a specific campaign based on the provided request.
//         /// </summary>
//         /// <param name="request">The request object containing the campaign cost details to retrieve.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests (optional).</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// with the cost details of the specified campaign, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<GetCampaignCostResponse> GetCampaignCostAsync(GetCampaignCostRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Asynchronously submits a new campaign based on the provided submission request details.
//         /// </summary>
//         /// <param name="request">The request object containing the details of the campaign to submit.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests (optional).</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// confirming the submission of the campaign, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<SubmitCampaignResponse> SubmitCampaignAsync(SubmitCampaignRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Asynchronously qualifies a campaign based on a specific use case and brand identifier.
//         /// </summary>
//         /// <param name="brandId">The unique identifier of the brand for which the campaign is qualified.</param>
//         /// <param name="usecase">The specific use case to qualify the campaign for.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests (optional).</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// confirming the qualification of the campaign, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<QualifyCampaignByUsecaseResponse> QualifyCampaignByUsecaseAsync(string brandId, string usecase, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Asynchronously retrieves the MNO (Mobile Network Operator) metadata for a specific campaign.
//         /// </summary>
//         /// <param name="campaignId">The unique identifier of the campaign to retrieve MNO metadata.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests (optional).</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// with the MNO metadata of the specified campaign, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<GetCampaignMnoMetadataResponse> GetCampaignMnoMetadataAsync(string campaignId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves phone number campaigns based on the specified criteria.
//         /// </summary>
//         /// <param name="request">The request object containing filter and pagination details.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// with the list of phone number campaigns matching the criteria, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<RetrievePhoneNumberCampaignsResponse> RetrievePhoneNumberCampaignsAsync(RetrievePhoneNumberCampaignsRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Creates a new phone number campaign.
//         /// </summary>
//         /// <param name="request">The request object containing the phone number and campaign ID details.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// with the details of the created phone number campaign, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<CreatePhoneNumberCampaignResponse> CreatePhoneNumberCampaignAsync(CreatePhoneNumberCampaignRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a specific phone number campaign by its phone number.
//         /// </summary>
//         /// <param name="phoneNumber">The phone number associated with the campaign.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// with the details of the phone number campaign, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<GetPhoneNumberCampaignResponse> GetPhoneNumberCampaignAsync(string phoneNumber, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Updates an existing phone number campaign.
//         /// </summary>
//         /// <param name="phoneNumber">The phone number associated with the campaign to update.</param>
//         /// <param name="request">The request object containing the updated details for the campaign.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// with the details of the updated phone number campaign, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<UpdatePhoneNumberCampaignResponse> UpdatePhoneNumberCampaignAsync(string phoneNumber, UpdatePhoneNumberCampaignRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Deletes an existing phone number campaign.
//         /// </summary>
//         /// <param name="phoneNumber">The phone number associated with the campaign to delete.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task that represents the asynchronous operation. The task result contains the response
//         /// confirming the deletion of the phone number campaign, or <c>null</c> if no response is received.
//         /// </returns>
//         Task<DeletePhoneNumberCampaignResponse> DeletePhoneNumberCampaignAsync(string phoneNumber, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Assigns a messaging profile to a campaign asynchronously.
//         /// </summary>
//         /// <param name="request">The request object containing the details of the messaging profile assignment.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task representing the asynchronous operation. The task result contains the response 
//         /// for the messaging profile assignment or <c>null</c> if the operation fails.
//         /// </returns>
//         Task<AssignMessagingProfileToCampaignResponse> AssignMessagingProfileToCampaignAsync(AssignMessagingProfileToCampaignRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves the status of a task assignment asynchronously.
//         /// </summary>
//         /// <param name="taskId">The unique identifier of the task.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task representing the asynchronous operation. The task result contains the status
//         /// of the assignment task or <c>null</c> if the operation fails.
//         /// </returns>
//         Task<GetAssignmentTaskStatusResponse> GetAssignmentTaskStatusAsync(string taskId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves the status of phone numbers associated with a specific task asynchronously.
//         /// </summary>
//         /// <param name="taskId">The unique identifier of the task.</param>
//         /// <param name="request">The request object containing query parameters for the operation.</param>
//         /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
//         /// <returns>
//         /// A task representing the asynchronous operation. The task result contains the response 
//         /// for the phone number status or <c>null</c> if the operation fails.
//         /// </returns>
//         Task<GetPhoneNumberStatusResponse> GetPhoneNumberStatusAsync(string taskId, GetPhoneNumberStatusRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a list of shared campaigns.
//         /// </summary>
//         /// <param name="request">The request object containing the criteria for listing shared campaigns.</param>
//         /// <param name="cancellationToken">Cancellation token to cancel the operation, if needed.</param>
//         /// <returns>A task representing the asynchronous operation, with a list of shared campaigns.</returns>
//         Task<ListSharedCampaignsResponse> ListSharedCampaignsAsync(ListSharedCampaignsRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a single shared campaign by its ID.
//         /// </summary>
//         /// <param name="campaignId">The unique identifier of the campaign to retrieve.</param>
//         /// <param name="cancellationToken">Cancellation token to cancel the operation, if needed.</param>
//         /// <returns>A task representing the asynchronous operation, with the details of the requested campaign.</returns>
//         Task<GetSharedCampaignRecordResponse> GetSingleSharedCampaignAsync(string campaignId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Updates a shared campaign by its ID.
//         /// </summary>
//         /// <param name="campaignId">The unique identifier of the campaign to update.</param>
//         /// <param name="request">The request object containing the updated information for the campaign.</param>
//         /// <param name="cancellationToken">Cancellation token to cancel the operation, if needed.</param>
//         /// <returns>A task representing the asynchronous operation, with the result of the update operation.</returns>
//         Task<UpdateSingleSharedCampaignResponse> UpdateSingleSharedCampaignAsync(string campaignId, UpdateSingleSharedCampaignRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves the sharing status of a specific campaign.
//         /// </summary>
//         /// <param name="campaignId">The unique identifier of the campaign to check the sharing status.</param>
//         /// <param name="cancellationToken">Cancellation token to cancel the operation, if needed.</param>
//         /// <returns>A task representing the asynchronous operation, with the sharing status of the campaign.</returns>
//         Task<GetSharingStatusResponse> GetSharingStatusAsync(string campaignId, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Retrieves a list of campaigns shared by a user with their partners.
//         /// </summary>
//         /// <param name="request">The request object containing the criteria for listing campaigns shared by the user.</param>
//         /// <param name="cancellationToken">Cancellation token to cancel the operation, if needed.</param>
//         /// <returns>A task representing the asynchronous operation, with a list of campaigns shared by the user.</returns>
//         Task<GetPartnerCampaignsSharedByUserResponse> GetPartnerCampaignsSharedByUserAsync(GetPartnerCampaignsSharedByUserRequest request, CancellationToken cancellationToken = default);
//
//         /// <summary>
//         /// Asynchronously retrieves enumeration values based on the specified endpoint.
//         /// </summary>
//         /// <param name="endpoint">
//         /// The <see cref="EnumEndpoint"/> specifying the target endpoint from which to retrieve enumeration values.
//         /// </param>
//         /// <param name="cancellationToken">
//         /// An optional <see cref="CancellationToken"/> to cancel the operation.
//         /// </param>
//         /// <returns>
//         /// A <see cref="Task"/> representing the asynchronous operation.
//         /// </returns>
//         Task<GetEnumResponse> GetEnumAsync(EnumEndpoint endpoint, CancellationToken cancellationToken = default);
//
//     }
// }