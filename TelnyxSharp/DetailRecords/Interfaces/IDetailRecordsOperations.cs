using TelnyxSharp.DetailRecords.Models.Requests;
using TelnyxSharp.DetailRecords.Models.Responses;

namespace TelnyxSharp.DetailRecords.Interfaces
{
    public interface IDetailRecordsOperations
    {
        /// <summary>
        /// Searches for detail records with the specified filters
        /// </summary>
        /// <param name="request">The search request parameters</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>A paginated list of detail records</returns>
        Task<DetailRecordSearchResponse?> Search(DetailRecordSearchRequest request, CancellationToken cancellationToken = default);
    }
}
