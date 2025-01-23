using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.CsvDownloads;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.CsvDowloads;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.CsvDownloads;

namespace Telnyx.NET.Numbers.Interfaces
{
    /// <summary>
    /// Defines operations related to CSV downloads for phone numbers.
    /// Provides methods for listing, creating, and retrieving CSV download records.
    /// </summary>
    public interface ICsvDownloadsOperations
    {
        /// <summary>
        /// Retrieves a paginated list of CSV downloads.
        /// This method allows you to fetch records of CSV download requests, filtered and paginated based on the provided request parameters.
        /// </summary>
        /// <param name="request">The request parameters for filtering and pagination.</param>
        /// <param name="cancellationToken">An optional cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="ListCsvDownloadsResponse"/> containing the paginated list of CSV download records.</returns>
        Task<ListCsvDownloadsResponse> List(ListCsvDownloadsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new CSV download request.
        /// This method initiates a request to generate a CSV file containing phone number data.
        /// </summary>
        /// <param name="cancellationToken">An optional cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CreateCsvDownloadResponse"/> containing details about the created CSV download request.</returns>
        Task<CreateCsvDownloadResponse> Create(CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves details of a specific CSV download by its ID.
        /// This method allows you to fetch metadata and status information about a previously created CSV download request.
        /// </summary>
        /// <param name="id">The unique identifier of the CSV download request.</param>
        /// <param name="cancellationToken">An optional cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="GetCsvDownloadResponse"/> containing details about the specified CSV download.</returns>
        Task<GetCsvDownloadResponse> Get(string id, CancellationToken cancellationToken = default);
    }
}
