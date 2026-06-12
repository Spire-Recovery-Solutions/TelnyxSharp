using Polly.Retry;
using TelnyxSharp.Base;
using TelnyxSharp.BrandedCalling.Interfaces;

namespace TelnyxSharp.BrandedCalling.Operations
{
    /// <summary>
    /// Provides operations for the Telnyx Branded Calling API, grouping enterprise management,
    /// Display Identity Records (DIRs), DIR phone numbers and batches, comments, infringement
    /// claims, reference data, and Terms of Service.
    /// Implements the <see cref="IBrandedCallingOperations"/> interface.
    /// </summary>
    public class BrandedCallingOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
        : BaseOperations(client, rateLimitRetryPolicy), IBrandedCallingOperations
    {
        // Lazy initialization for various operations, ensuring thread safety and lazy loading of instances.

        private readonly Lazy<IEnterpriseOperations> _enterprises = new(() =>
            new EnterpriseOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IDisplayIdentityRecordsOperations> _displayIdentityRecords = new(() =>
            new DisplayIdentityRecordsOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IDirPhoneNumberOperations> _phoneNumbers = new(() =>
            new DirPhoneNumberOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IDirPhoneNumberBatchOperations> _phoneNumberBatches = new(() =>
            new DirPhoneNumberBatchOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IDirCommentOperations> _comments = new(() =>
            new DirCommentOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IInfringementClaimOperations> _infringementClaims = new(() =>
            new InfringementClaimOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IBrandedCallingReferenceOperations> _referenceData = new(() =>
            new BrandedCallingReferenceOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IBrandedCallingTosOperations> _termsOfService = new(() =>
            new BrandedCallingTosOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        public IEnterpriseOperations Enterprises => _enterprises.Value;

        public IDisplayIdentityRecordsOperations DisplayIdentityRecords => _displayIdentityRecords.Value;

        public IDirPhoneNumberOperations PhoneNumbers => _phoneNumbers.Value;

        public IDirPhoneNumberBatchOperations PhoneNumberBatches => _phoneNumberBatches.Value;

        public IDirCommentOperations Comments => _comments.Value;

        public IInfringementClaimOperations InfringementClaims => _infringementClaims.Value;

        public IBrandedCallingReferenceOperations ReferenceData => _referenceData.Value;

        public IBrandedCallingTosOperations TermsOfService => _termsOfService.Value;

        /// <summary>
        /// Disposes of all resources and underlying disposable operations.
        /// Ensures proper cleanup of resources to avoid memory leaks.
        /// </summary>
        public void Dispose()
        {
            if (_enterprises.IsValueCreated && _enterprises.Value is IDisposable disposableEnterprises)
                disposableEnterprises.Dispose();

            if (_displayIdentityRecords.IsValueCreated && _displayIdentityRecords.Value is IDisposable disposableDirs)
                disposableDirs.Dispose();

            if (_phoneNumbers.IsValueCreated && _phoneNumbers.Value is IDisposable disposablePhoneNumbers)
                disposablePhoneNumbers.Dispose();

            if (_phoneNumberBatches.IsValueCreated && _phoneNumberBatches.Value is IDisposable disposableBatches)
                disposableBatches.Dispose();

            if (_comments.IsValueCreated && _comments.Value is IDisposable disposableComments)
                disposableComments.Dispose();

            if (_infringementClaims.IsValueCreated && _infringementClaims.Value is IDisposable disposableClaims)
                disposableClaims.Dispose();

            if (_referenceData.IsValueCreated && _referenceData.Value is IDisposable disposableReference)
                disposableReference.Dispose();

            if (_termsOfService.IsValueCreated && _termsOfService.Value is IDisposable disposableTos)
                disposableTos.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
