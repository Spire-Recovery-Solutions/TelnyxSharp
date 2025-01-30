using Telnyx.NET.Identity.Models.NumberLookup.Requests;
using Telnyx.NET.Identity.Models.NumberLookup.Responses;

namespace Telnyx.NET.Identity.Interfaces
{
    /// <summary>
    /// Defines the operations for performing number lookups, including fetching details such as carrier or caller name.
    /// </summary>
    public interface INumberLookupOperations
    {
        /// <summary>
        /// Retrieves detailed information about a phone number, including carrier and caller name information.
        /// </summary>
        /// <param name="request">The request object containing the phone number and lookup types.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the phone number lookup response.</returns>
        Task<NumberLookupResponse> LookupPhoneData(NumberLookupRequest request, CancellationToken cancellationToken = default);
    }
}
