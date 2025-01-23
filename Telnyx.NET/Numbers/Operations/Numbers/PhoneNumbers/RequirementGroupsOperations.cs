using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Interfaces;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.RequirementGroups;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.RequirementGroups;

namespace Telnyx.NET.Numbers.Operations.Numbers.PhoneNumbers
{
    public class RequirementGroupsOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IRequirementGroupsOperations
    {
        /// <inheritdoc />
        public async Task<UpdateSubNumberOrderRequirementResponse> UpdateSubNumber(string subNumberOrderId, UpdateSubNumberOrderRequirementRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"sub_number_orders/{subNumberOrderId}/requirement_group", Method.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdateSubNumberOrderRequirementResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdatePhoneNumberOrderRequirementResponse> UpdatePhoneNumber(string phoneNumberOrderId, UpdatePhoneNumberOrderRequirementRequest request,
           CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"number_order_phone_numbers/{phoneNumberOrderId}/requirement_group", Method.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdatePhoneNumberOrderRequirementResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListRequirementGroupsResponse> List(ListRequirementGroupsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("requirement_groups")
                .AddFilter("filter[country_code]", request.CountryCode)
                .AddFilter("filter[phone_number_type]", request.PhoneNumberType?.ToString().ToLowerInvariant())
                .AddFilter("filter[action]", request.Action?.ToString().ToLowerInvariant())
                .AddFilter("filter[status]", request.Status?.ToString().ToLowerInvariant())
                .AddFilter("filter[customer_reference]", request.CustomerReference);

            return await ExecuteAsync<ListRequirementGroupsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateRequirementGroupResponse> Create(CreateRequirementGroupRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("requirement_groups", Method.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CreateRequirementGroupResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetRequirementGroupResponse> Get(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"requirement_groups/{id}");
            return await ExecuteAsync<GetRequirementGroupResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteRequirementGroupResponse> Delete(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"requirement_groups/{id}", Method.Delete);
            return await ExecuteAsync<DeleteRequirementGroupResponse>(req, cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<UpdateRequirementGroupResponse> Update(string id, UpdateRequirementGroupRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"requirement_groups/{id}", Method.Patch);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdateRequirementGroupResponse>(req, cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<SubmitRequirementGroupApprovalResponse> SubmitForApproval(string id,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"requirement_groups/{id}/submit_for_approval", Method.Post);
            return await ExecuteAsync<SubmitRequirementGroupApprovalResponse>(req, cancellationToken);
        }
    }
}
