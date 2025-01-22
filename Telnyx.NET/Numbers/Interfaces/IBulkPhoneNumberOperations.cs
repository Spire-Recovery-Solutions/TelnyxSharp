using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.BulkPhoneNumberOperations;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.BulkPhoneNumberOperations;

namespace Telnyx.NET.Numbers.Interfaces
{
    /// <summary>
    /// Defines operations for bulk phone number management in the Telnyx API.
    /// </summary>
    public interface IBulkPhoneNumberOperations
    {
        /// <summary>
        /// Lists all phone number jobs with optional filters, pagination, and sorting.
        /// </summary>
        /// <param name="request">The request containing filtering, pagination, and sorting options.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A response containing a list of phone number jobs.</returns>
        Task<ListNumbersJobsResponse> ListPhoneNumbersJobs(
            ListNumbersJobsRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a specific phone number job by its unique identifier.
        /// </summary>
        /// <param name="jobId">The unique identifier of the phone number job.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A response containing details of the specified phone number job.</returns>
        Task<RetrieveNumbersJobResponse> GetPhoneNumbersJob(
            string jobId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a batch of phone numbers with the specified properties.
        /// </summary>
        /// <param name="request">The request containing details for updating phone numbers.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A response indicating the status of the update operation.</returns>
        Task<UpdateNumbersBatchResponse> UpdateNumbersBatch(
            UpdateNumbersBatchRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a batch of phone numbers based on the specified criteria.
        /// </summary>
        /// <param name="request">The request containing details of the phone numbers to delete.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A response indicating the status of the delete operation.</returns>
        Task<DeleteNumbersBatchResponse> DeleteNumbersBatch(
            DeleteNumbersBatchRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the emergency settings for a batch of phone numbers.
        /// </summary>
        /// <param name="request">The request containing details for updating emergency settings.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A response indicating the status of the emergency settings update operation.</returns>
        Task<UpdateEmergencySettingsResponse> UpdateEmergencySettings(
            UpdateEmergencySettingsRequest request, 
            CancellationToken cancellationToken = default);
    }
}
