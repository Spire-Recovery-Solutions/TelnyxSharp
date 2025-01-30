using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Interfaces;
using Telnyx.NET.Numbers.Models.ChannelZones.Requests;
using Telnyx.NET.Numbers.Models.ChannelZones.Responses;

namespace Telnyx.NET.Numbers.Operations.Numbers.ChannelZones
{
    public class ChannelZonesOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IChannelZonesOperations
    {
        /// <inheritdoc />
        public async Task<ListChannelZonesResponse> List(ListChannelZonesRequest request,
           CancellationToken cancellationToken = default)
        {

            var req = new RestRequest("phone_numbers/channel_zones")
                            .AddPagination(request.PageSize);

            return await ExecuteAsync<ListChannelZonesResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetChannelZonesResponse> Get(string channelZoneId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/channel_zones/{channelZoneId}");
            return await ExecuteAsync<GetChannelZonesResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateChannelZoneResponse> Update(string channelZoneId, UpdateChannelZoneRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/channel_zones/{channelZoneId}", Method.Patch);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdateChannelZoneResponse>(req, cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<GetChannelZonePhoneNumbersResponse> ListPhoneNumbers(string channelZoneId, GetChannelZonePhoneNumbersRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/channel_zones/{channelZoneId}/channel_zone_phone_numbers")
                                .AddPagination(request.PageSize);

            return await ExecuteAsync<GetChannelZonePhoneNumbersResponse>(req, cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<AssignPhoneNumberToChannelZoneResponse> AssignPhoneNumber(string channelZoneId, AssignPhoneNumberToChannelZoneRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/channel_zones/{channelZoneId}/channel_zone_phone_numbers", Method.Post);
            
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<AssignPhoneNumberToChannelZoneResponse>(req, cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<UnassignPhoneNumberResponse> UnassignPhoneNumber(string channelZoneId, string phoneNumber,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/channel_zones/{channelZoneId}/channel_zone_phone_numbers/{phoneNumber}", Method.Delete);

            return await ExecuteAsync<UnassignPhoneNumberResponse>(req, cancellationToken);
        }
    }
}
