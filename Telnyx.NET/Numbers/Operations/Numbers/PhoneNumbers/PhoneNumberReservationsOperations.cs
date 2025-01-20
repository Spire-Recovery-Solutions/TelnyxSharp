using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Interfaces;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberReservations;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberReservartions;

namespace Telnyx.NET.Numbers.Operations.Numbers.PhoneNumbers
{
    public class PhoneNumberReservationsOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IPhoneNumberReservationsOperations
    {
        /// <inheritdoc />
        public async Task<ListNumberReservationsResponse> List(ListNumberReservationsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("number_reservations")
                .AddFilter("filter[status]", request.Status)
                .AddFilter("filter[created_at][gt]", request.CreatedAfter)
                .AddFilter("filter[created_at][lt]", request.CreatedBefore)
                .AddFilter("filter[phone_numbers.phone_number]", request.PhoneNumber)
                .AddFilter("filter[customer_reference]", request.CustomerReference)
                .AddPagination(request.PageSize);

            return await ExecuteAsync<ListNumberReservationsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateNumberReservationResponse> Create(
            CreateNumberReservationRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"number_reservations", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CreateNumberReservationResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetNumberReservationResponse> Get(string numberReservationId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"number_reservations/{numberReservationId}");
            return await ExecuteAsync<GetNumberReservationResponse>(req, cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<ExtendNumberReservationResponse> Extend(string numberReservationId, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest($"number_reservations/{numberReservationId}/actions/extend", Method.Post);

            return await ExecuteAsync<ExtendNumberReservationResponse>(request, cancellationToken);
        }
    }
}
