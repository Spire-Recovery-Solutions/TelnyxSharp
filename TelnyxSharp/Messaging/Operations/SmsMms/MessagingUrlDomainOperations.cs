using Polly.Retry;
using RestSharp;
using TelnyxSharp.Base;
using TelnyxSharp.Messaging.Interfaces;
using TelnyxSharp.Messaging.Models.MessagingUrlDomain.Requests;
using TelnyxSharp.Messaging.Models.MessagingUrlDomain.Responses;

namespace TelnyxSharp.Messaging.Operations.SmsMms;

public class MessagingUrlDomainOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IMessagingUrlDomainOperations
{
    /// <inheritdoc />
    public async Task<ListMessagingUrlDomainsResponse?> List(ListMessagingUrlDomainsRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messaging_url_domains")
            .AddPagination(request.PageSize);

        return await ExecuteAsync<ListMessagingUrlDomainsResponse>(req, cancellationToken);
    }
}