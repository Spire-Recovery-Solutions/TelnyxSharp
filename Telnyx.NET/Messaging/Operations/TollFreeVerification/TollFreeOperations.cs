using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Messaging.Interfaces;

namespace Telnyx.NET.Messaging.Operations.TollFreeVerification
{
    /// <summary>
    /// Provides operations related to managing toll-free numbers, including toll-free verification.
    /// </summary>
    public class TollFreeOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), ITollFreeOperations
    {
        private readonly Lazy<ITollFreeVerificationOperations> _verificationOperations = new(() =>
            new TollFreeVerificationOperations(client, rateLimitRetryPolicy),
        LazyThreadSafetyMode.ExecutionAndPublication);

        public ITollFreeVerificationOperations Verification => _verificationOperations.Value;

        /// <summary>
        /// Disposes of all resources and underlying disposable operations related to toll-free operations.
        /// Ensures proper cleanup of resources to avoid memory leaks.
        /// </summary>
        public void Dispose()
        {
            if (_verificationOperations.IsValueCreated && _verificationOperations.Value is IDisposable disposableTollFree)
                disposableTollFree.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}