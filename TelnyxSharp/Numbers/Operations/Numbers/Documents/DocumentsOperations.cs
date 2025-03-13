using Polly.Retry;
using RestSharp;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;

namespace TelnyxSharp.Numbers.Operations.Numbers.Documents
{
    public class DocumentsOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IDocumentsOperations
    {
        private readonly Lazy<IDocumentOperations> _documentOperations = new(() =>
            new DocumentOperations(client, rateLimitRetryPolicy),
             LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IRequirementsOperations> requirementsOperations = new(() =>
            new RequirementsOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IRequirementTypesOperations> _requirementTypesOperations = new(() =>
            new RequirementTypesOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        public IDocumentOperations Document => _documentOperations.Value;

        public IRequirementsOperations Requirements => requirementsOperations.Value;

        public IRequirementTypesOperations RequirementTypes => _requirementTypesOperations.Value;

        public void Dispose()
        {
            if (_documentOperations.IsValueCreated && _documentOperations.Value is IDisposable disposableDocumentOperations)
                disposableDocumentOperations.Dispose();

            if (requirementsOperations.IsValueCreated && requirementsOperations.Value is IDisposable disposableRequirementsOperations)
                disposableRequirementsOperations.Dispose();

            if (_requirementTypesOperations.IsValueCreated && _requirementTypesOperations.Value is IDisposable disposableRequirementTypesOperations)
                disposableRequirementTypesOperations.Dispose();
        }
    }
}
