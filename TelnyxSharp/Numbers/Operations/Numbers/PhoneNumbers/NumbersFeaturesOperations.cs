using Polly.Retry;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.NumbersFeatures;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.NumbersFeatures;

namespace TelnyxSharp.Numbers.Operations.Numbers.PhoneNumbers
{
    public class NumbersFeaturesOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), INumbersFeaturesOperations
    {
        /// <inheritdoc />
        public async Task<GetNumbersFeaturesResponse> Get(GetNumbersFeaturesRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("numbers_features", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<GetNumbersFeaturesResponse>(req, cancellationToken);
        }
    }
}
