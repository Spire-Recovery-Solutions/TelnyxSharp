using Polly.Retry;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.RequirementGroups;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.RequirementGroups;

namespace TelnyxSharp.Numbers.Operations.Numbers.PhoneNumbers
{
    public class RequirementGroupsOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IRequirementGroupsOperations
    {
        /// <inheritdoc />
        public async Task<UpdateSubNumberOrderRequirementResponse> UpdateSubNumber(string subNumberOrderId, UpdateSubNumberOrderRequirementRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"sub_number_orders/{subNumberOrderId}/requirement_group", TelnyxMethod.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdateSubNumberOrderRequirementResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdatePhoneNumberOrderRequirementResponse> UpdatePhoneNumber(string phoneNumberOrderId, UpdatePhoneNumberOrderRequirementRequest request,
           CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"number_order_phone_numbers/{phoneNumberOrderId}/requirement_group", TelnyxMethod.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdatePhoneNumberOrderRequirementResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListRequirementGroupsResponse> List(ListRequirementGroupsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("requirement_groups")
                .AddFilter("filter[country_code]", request.CountryCode)
                .AddFilter("filter[phone_number_type]", request.PhoneNumberType)
                .AddFilter("filter[action]", request.Action)
                .AddFilter("filter[status]", request.Status)
                .AddFilter("filter[customer_reference]", request.CustomerReference);

            return await ExecuteAsync<ListRequirementGroupsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateRequirementGroupResponse> Create(CreateRequirementGroupRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("requirement_groups", TelnyxMethod.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CreateRequirementGroupResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetRequirementGroupResponse> Get(string id, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"requirement_groups/{id}");
            return await ExecuteAsync<GetRequirementGroupResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteRequirementGroupResponse> Delete(string id, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"requirement_groups/{id}", TelnyxMethod.Delete);
            return await ExecuteAsync<DeleteRequirementGroupResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateRequirementGroupResponse> Update(string id, UpdateRequirementGroupRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"requirement_groups/{id}", TelnyxMethod.Patch);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdateRequirementGroupResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<SubmitRequirementGroupApprovalResponse> SubmitForApproval(string id,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"requirement_groups/{id}/submit_for_approval", TelnyxMethod.Post);
            return await ExecuteAsync<SubmitRequirementGroupApprovalResponse>(req, cancellationToken);
        }
    }
}
