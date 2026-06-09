using Polly.Retry;
using TelnyxSharp.Base;
using TelnyxSharp.Messaging.Interfaces;
using TelnyxSharp.Messaging.Models.MessagingUrlDomain.Requests;
using TelnyxSharp.Messaging.Models.MessagingUrlDomain.Responses;

namespace TelnyxSharp.Messaging.Operations.SmsMms;

public class MessagingUrlDomainOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IMessagingUrlDomainOperations
{
    /// <inheritdoc />
    public async Task<ListMessagingUrlDomainsResponse?> List(ListMessagingUrlDomainsRequest request, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest("messaging_url_domains")
            .AddPagination(request.PageSize);

        return await ExecuteAsync<ListMessagingUrlDomainsResponse>(req, cancellationToken);
    }
}