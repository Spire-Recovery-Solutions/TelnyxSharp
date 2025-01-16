using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.PhoneNumber.Interfaces;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Requests;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Responses;

namespace Telnyx.NET.PhoneNumber.Operations.PhoneNumber
{
    public class PhoneNumberReservationsOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IPhoneNumberReservationsOperations
    {
        /// <inheritdoc />
        public async Task<CreateNumberReservationResponse> Create(
            CreateNumberReservationRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"number_reservations", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CreateNumberReservationResponse>(req, cancellationToken);
        }

    }
}
