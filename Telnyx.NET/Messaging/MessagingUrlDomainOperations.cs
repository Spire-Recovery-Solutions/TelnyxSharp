using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging;

public interface IMessagingUrlDomainOperations
{
    Task<ListMessagingUrlDomainsResponse?> List(ListMessagingUrlDomainsRequest request, CancellationToken cancellationToken = default);
}
public class MessagingUrlDomainOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IMessagingUrlDomainOperations
{
    public async Task<ListMessagingUrlDomainsResponse?> List(ListMessagingUrlDomainsRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messaging_url_domains")
            .AddPagination(request.PageSize);
            
        return await ExecuteAsync<ListMessagingUrlDomainsResponse>(req, cancellationToken);
    }
}