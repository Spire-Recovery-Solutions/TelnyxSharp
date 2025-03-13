using Polly.Retry;
using RestSharp;
using TelnyxSharp.Base;
using TelnyxSharp.Identity.Interfaces;

namespace TelnyxSharp.Identity.Operations.NumberLookup
{
    /// <summary>
    /// Provides operations related to managing toll-free numbers, including toll-free verification.
    /// </summary>
    public class LookUpNumberOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), ILookUpNumberOperations
    {
        private readonly Lazy<INumberLookupOperations> _numberLookupOperations = new(() =>
            new NumberLookupOperations(client, rateLimitRetryPolicy),
        LazyThreadSafetyMode.ExecutionAndPublication);

        public INumberLookupOperations NumberLookup => _numberLookupOperations.Value;

        /// <summary>
        /// Disposes of all resources and underlying disposable operations related to toll-free operations.
        /// Ensures proper cleanup of resources to avoid memory leaks.
        /// </summary>
        public void Dispose()
        {
            if (_numberLookupOperations.IsValueCreated && _numberLookupOperations.Value is IDisposable disposableNumberLookup)
                disposableNumberLookup.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}