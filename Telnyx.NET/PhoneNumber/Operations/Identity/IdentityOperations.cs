using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.PhoneNumber.Interfaces;
using Telnyx.NET.PhoneNumber.Operations.Identity;

namespace Telnyx.NET.Messaging.Operations.TollFreeVerification
{
    /// <summary>
    /// Provides operations related to managing toll-free numbers, including toll-free verification.
    /// </summary>
    public class IdentityOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IIdentityOperations
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