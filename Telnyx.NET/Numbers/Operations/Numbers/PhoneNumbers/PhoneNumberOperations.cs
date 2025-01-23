using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Interfaces;

namespace Telnyx.NET.Numbers.Operations.Numbers.PhoneNumbers
{
    /// <summary>
    /// Provides operations related to managing toll-free numbers, including toll-free verification.
    /// </summary>
    public class PhoneNumberOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IPhoneNumberOperations
    {
        private readonly Lazy<IPhoneNumberSearchOperations> _phoneNumberSearchOperations = new(() =>
            new PhoneNumberSearchOperations(client, rateLimitRetryPolicy),
        LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IPhoneNumberReservationsOperations> _phoneNumberReservationsOperations = new(() =>
            new PhoneNumberReservationsOperations(client, rateLimitRetryPolicy),
        LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IPhoneNumberOrdersOperations> _phoneNumberOrdersOperations = new(() =>
                new PhoneNumberOrdersOperations(client, rateLimitRetryPolicy),
                LazyThreadSafetyMode.ExecutionAndPublication);


        private readonly Lazy<IPhoneNumberConfigurationOperations> _phoneNumberConfigurationOperations = new(() =>
                new PhoneNumberConfigurationOperations(client, rateLimitRetryPolicy),
                        LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IBulkPhoneNumberOperations> _bulkPhoneNumberOperations = new(() =>
                new BulkPhoneNumberOperations(client, rateLimitRetryPolicy),
                        LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IInventoryLevelOperations> _inventoryLevelOperations = new(() =>
                new InventoryLevelOperations(client, rateLimitRetryPolicy),
                        LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IPhoneNumberBlocksBackgroundJobsOperations> _phoneNumberBlocksBackgroundJobsOperations = new(() =>
                new PhoneNumberBlocksBackgroundJobsOperations(client, rateLimitRetryPolicy),
                        LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IRegulatoryRequirementsOperations> _regulatoryRequirementsOperations = new(() =>
                new RegulatoryRequirementsOperations(client, rateLimitRetryPolicy),
                        LazyThreadSafetyMode.ExecutionAndPublication);

        public IPhoneNumberSearchOperations PhoneNumberSearch => _phoneNumberSearchOperations.Value;

        public IPhoneNumberReservationsOperations PhoneNumberReservations => _phoneNumberReservationsOperations.Value;

        public IPhoneNumberOrdersOperations PhoneNumberOrders => _phoneNumberOrdersOperations.Value;

        public IPhoneNumberConfigurationOperations PhoneNumberConfiguration => _phoneNumberConfigurationOperations.Value;

        public IBulkPhoneNumberOperations BulkPhoneNumber => _bulkPhoneNumberOperations.Value;

        public IInventoryLevelOperations InventoryLevel => _inventoryLevelOperations.Value;

        public IPhoneNumberBlocksBackgroundJobsOperations PhoneNumberBlocksBackgroundJobs => _phoneNumberBlocksBackgroundJobsOperations.Value;

        public IRegulatoryRequirementsOperations RegulatoryRequirements => _regulatoryRequirementsOperations.Value;

        /// <summary>
        /// Disposes of all resources and underlying disposable operations related to toll-free operations.
        /// Ensures proper cleanup of resources to avoid memory leaks.
        /// </summary>
        public void Dispose()
        {
            if (_phoneNumberSearchOperations.IsValueCreated && _phoneNumberSearchOperations.Value is IDisposable disposablePhoneNumberSearch)
                disposablePhoneNumberSearch.Dispose();

            if (_phoneNumberReservationsOperations.IsValueCreated && _phoneNumberReservationsOperations.Value is IDisposable disposablePhoneNumberReservations)
                disposablePhoneNumberReservations.Dispose();

            if (_phoneNumberOrdersOperations.IsValueCreated && _phoneNumberOrdersOperations.Value is IDisposable disposablePhoneNumberOrders)
                disposablePhoneNumberOrders.Dispose();

            if (_phoneNumberConfigurationOperations.IsValueCreated && _phoneNumberConfigurationOperations.Value is IDisposable disposablePhoneNumberConfiguration)
                disposablePhoneNumberConfiguration.Dispose();

            if (_bulkPhoneNumberOperations.IsValueCreated && _bulkPhoneNumberOperations.Value is IDisposable disposableBulkPhoneNumber)
                disposableBulkPhoneNumber.Dispose();

            if (_inventoryLevelOperations.IsValueCreated && _inventoryLevelOperations.Value is IDisposable disposableInventoryLevel)
                disposableInventoryLevel.Dispose();

            if (_phoneNumberBlocksBackgroundJobsOperations.IsValueCreated && _phoneNumberBlocksBackgroundJobsOperations.Value is IDisposable disposablePhoneNumberBlocksBackgroundJobs)
                disposablePhoneNumberBlocksBackgroundJobs.Dispose();

            if (_regulatoryRequirementsOperations.IsValueCreated && _regulatoryRequirementsOperations.Value is IDisposable disposableRegulatoryRequirements)
                disposableRegulatoryRequirements.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}