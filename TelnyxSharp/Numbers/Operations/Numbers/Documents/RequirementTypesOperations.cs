using Polly.Retry;
using RestSharp;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.RequirementTypes;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.RequirementTypes;

namespace TelnyxSharp.Numbers.Operations.Numbers.Documents
{
    public class RequirementTypesOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IRequirementTypesOperations
    {
        /// <inheritdoc />
        public async Task<ListRequirementTypesResponse> List(ListRequirementTypesRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("requirement_types")
                          .AddFilter("filter[name][contains]", request.NameContains)
                          .AddFilter("sort[]", request.Sort);
           
            return await ExecuteAsync<ListRequirementTypesResponse>(req, cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<RetrieveRequirementTypeResponse> Get(string requirementTypeId, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest($"requirement_types/{requirementTypeId}");

            return await ExecuteAsync<RetrieveRequirementTypeResponse>(request, cancellationToken);
        }
    }
}
