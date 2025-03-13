using TelnyxSharp.Messaging.Models.MessagesProfile.Requests;
using TelnyxSharp.Messaging.Models.MessagesProfile.Responses;

namespace TelnyxSharp.Messaging.Interfaces
{
    public interface IMessagingProfileOperations
    {
        /// <summary>
        /// Lists all messaging profiles based on the provided request criteria.
        /// </summary>
        /// <param name="request">The request containing filters and options for listing messaging profiles.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A response containing a list of messaging profiles matching the request criteria.</returns>
        Task<MessagingProfilesResponse?> List(MessagingProfilesRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new messaging profile with the provided details.
        /// </summary>
        /// <param name="request">The request containing the details for the new messaging profile.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A response confirming the creation of the messaging profile.</returns>
        Task<CreateMessagingProfileResponse?> Create(CreateMessagingProfileRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a messaging profile by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the messaging profile to retrieve.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A response containing the details of the retrieved messaging profile.</returns>
        Task<RetrieveMessagingProfileResponse> Retrieve(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an existing messaging profile with the provided details.
        /// </summary>
        /// <param name="id">The unique identifier of the messaging profile to update.</param>
        /// <param name="request">The request containing the updated details for the messaging profile.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A response confirming the update of the messaging profile.</returns>
        Task<UpdateMessagingProfileResponse?> Update(string id, UpdateMessagingProfileRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a messaging profile by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the messaging profile to delete.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A response confirming the deletion of the messaging profile.</returns>
        Task<DeleteMessagingProfileResponse?> Delete(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists the phone numbers associated with a specific messaging profile.
        /// </summary>
        /// <param name="id">The unique identifier of the messaging profile.</param>
        /// <param name="request">The request containing filters and options for listing phone numbers.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A response containing a list of phone numbers associated with the specified messaging profile.</returns>
        Task<MessagingProfilePhoneNumberResponse?> ListPhoneNumbers(string id, MessagingProfilePhoneNumberRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists the short codes associated with a specific messaging profile.
        /// </summary>
        /// <param name="id">The unique identifier of the messaging profile.</param>
        /// <param name="request">The request containing filters and options for listing short codes.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A response containing a list of short codes associated with the specified messaging profile.</returns>
        Task<MessagingProfileShortCodeResponse?> ListShortCodes(string id, MessagingProfileShortCodeRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the metrics for a specific messaging profile.
        /// </summary>
        /// <param name="id">The unique identifier of the messaging profile.</param>
        /// <param name="request">The request containing criteria for retrieving metrics.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A response containing the metrics for the specified messaging profile.</returns>
        Task<RetrieveMessagingProfileMetricsResponse?> RetrieveMetrics(string id, RetrieveMessagingProfileMetricsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists metrics for messaging profiles based on the provided request criteria.
        /// </summary>
        /// <param name="request">The request containing filters and options for listing metrics.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A response containing a list of metrics for messaging profiles.</returns>
        Task<MessagingProfileMetricsResponse?> ListMetrics(MessagingProfileMetricsRequest request, CancellationToken cancellationToken = default);
    }
}