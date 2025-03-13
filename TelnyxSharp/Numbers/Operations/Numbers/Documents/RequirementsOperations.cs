using Polly.Retry;
using RestSharp;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.Requirements;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.Requirements;


namespace TelnyxSharp.Numbers.Operations.Numbers.Documents
{
    public class RequirementsOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IRequirementsOperations
    {
        /// <inheritdoc />
        public async Task<ListRequirementResponse> List(ListRequirementsRequest request,CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("requirements")
                        .AddFilter("filter[country_code]", request.CountryCode)
                        .AddFilter("filter[phone_number_type]", request.PhoneNumberType)
                        .AddFilter("filter[action]", request.Action)
                        .AddFilter("sort[]", request.Sort)
                        .AddPagination(request.PageSize);
           
            return await ExecuteAsync<ListRequirementResponse>(req, cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<RetrieveDocumentRequirementResponse> Retrieve(string requirementId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"requirements/{requirementId}");

            return await ExecuteAsync<RetrieveDocumentRequirementResponse>(req, cancellationToken);
        }
    }
}
