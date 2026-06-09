using Polly.Retry;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberPorting;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberPorting;

namespace TelnyxSharp.Numbers.Operations.Numbers.PhoneNumberPorting
{
    public class PhoneNumberPortingOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IPhoneNumberPortingOperations
    {
        /// <inheritdoc />
        public async Task<PortabilityCheckResponse> RunPortabilityCheck(PortabilityCheckRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("portability_checks", TelnyxMethod.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<PortabilityCheckResponse>(req, cancellationToken);
        }
    }
}
