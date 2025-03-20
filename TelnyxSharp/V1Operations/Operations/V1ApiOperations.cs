using Polly.Retry;
using RestSharp;
using TelnyxSharp.Base;
using TelnyxSharp.V1Operations.Interfaces;

namespace TelnyxSharp.V1Operations.Operations
{
    /// <summary>
    /// Provides operations for interacting with Telnyx v1 endpoints.
    /// Currently exposes only the CDR Request operations.
    /// </summary>
    public class V1ApiOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy) : BaseOperations(client, rateLimitRetryPolicy), IV1ApiOperations
    {
        private readonly Lazy<ICdrRequestsOperations> _cdrRequests = new(() =>
            new CdrRequestsOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        /// <summary>
        /// Gets the v1 CDR Requests operations.
        /// </summary>
        public ICdrRequestsOperations CdrRequests => _cdrRequests.Value;

        /// <summary>
        /// Disposes of the v1 operations.
        /// </summary>
        public void Dispose()
        {
            if (_cdrRequests.IsValueCreated && _cdrRequests.Value is IDisposable disposableCdrRequests)
            {
                disposableCdrRequests.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
