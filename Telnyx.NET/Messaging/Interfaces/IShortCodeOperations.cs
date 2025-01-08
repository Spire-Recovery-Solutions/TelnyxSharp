using Telnyx.NET.Messaging.Models.ShortCodes;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Interfaces
{
    public interface IShortCodeOperations
    {
        /// <summary>
        /// Lists all short codes based on the provided request criteria.
        /// </summary>
        /// <param name="request">The request containing filters and options for listing short codes.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A response containing a list of short codes matching the request criteria.</returns>
        Task<ListShortCodesResponse?> List(ListShortCodesRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a short code by its unique identifier.
        /// </summary>
        /// <param name="shortCodeId">The unique identifier of the short code to retrieve.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A response containing the details of the retrieved short code.</returns>
        Task<RetrieveShortCodeResponse?> Retrieve(string shortCodeId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an existing short code with the provided details.
        /// </summary>
        /// <param name="shortCodeId">The unique identifier of the short code to update.</param>
        /// <param name="request">The request containing the updated details for the short code.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A response confirming the update of the short code.</returns>
        Task<UpdateShortCodeResponse?> Update(string shortCodeId, UpdateShortCodeRequest request, CancellationToken cancellationToken = default);
    }
}