using Telnyx.NET.Messaging.Models.MessagingUrlDomain.Requests;
using Telnyx.NET.Messaging.Models.MessagingUrlDomain.Responses;

namespace Telnyx.NET.Messaging.Interfaces
{
    public interface IMessagingUrlDomainOperations
    {
        /// <summary>
        /// Lists all messaging URL domains based on the provided request criteria.
        /// </summary>
        /// <param name="request">The request containing filters and options for listing messaging URL domains.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A response containing a list of messaging URL domains matching the request criteria.</returns>
        Task<ListMessagingUrlDomainsResponse?> List(ListMessagingUrlDomainsRequest request, CancellationToken cancellationToken = default);
    }
}