using TelnyxSharp.Enums;
using TelnyxSharp.Messaging.Models.Enums.Responses;

namespace TelnyxSharp.Messaging.Interfaces
{
    /// <summary>
    /// Defines operations for interacting with enumeration endpoints related to Telnyx messaging.
    /// </summary>
    public interface IEnumOperations
    {
        /// <summary>
        /// Retrieves information from a specific enumeration endpoint.
        /// </summary>
        /// <param name="endpoint">The enumeration endpoint to query.</param>
        /// <param name="cancellationToken">An optional cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response from the enumeration endpoint.</returns>
        Task<GetEnumResponse?> Get(EnumEndpoint endpoint, CancellationToken cancellationToken = default);
    }
}
