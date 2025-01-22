using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberBlocksBackgroundJobs;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberBlocksBackgroundJobs;

namespace Telnyx.NET.Numbers.Interfaces
{
    public interface IPhoneNumberBlocksBackgroundJobsOperations
    {
        /// <summary>
        /// Retrieves a list of phone number block jobs based on the specified filters and pagination settings.
        /// </summary>
        /// <param name="request">The request containing filters, pagination, and sorting options for the job listing.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, containing the list of phone number block jobs.</returns>
        Task<ListPhoneNumberBlockJobsResponse> List(ListPhoneNumberBlockJobsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves details for a specific phone number block job using its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the phone number block job.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, containing details of the phone number block job.</returns>
        Task<GetPhoneNumberBlocksJobResponse> Get(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a phone number block based on the specified request parameters.
        /// </summary>
        /// <param name="request">The request containing the parameters for deleting the phone number block.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, containing the response for the delete operation.</returns>
        Task<DeletePhoneNumberBlockResponse> Delete(DeletePhoneNumberBlockRequest request, CancellationToken cancellationToken = default);
    }
}
