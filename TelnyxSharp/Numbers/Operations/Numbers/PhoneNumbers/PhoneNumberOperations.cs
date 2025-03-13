using Polly.Retry;
using RestSharp;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;

namespace TelnyxSharp.Numbers.Operations.Numbers.PhoneNumbers
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

        private readonly Lazy<IRequirementGroupsOperations> _requirementGroupsOperations = new(() =>
                new RequirementGroupsOperations(client, rateLimitRetryPolicy),
                        LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<ICountryCoverageOperations> _countryCoverageOperations = new(() =>
                new CountryCoverageOperations(client, rateLimitRetryPolicy),
                        LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IPhoneNumberBlockOrdersOperations> _phoneNumberBlockOrdersOperations = new(() =>
                 new PhoneNumberBlockOrdersOperations(client, rateLimitRetryPolicy),
                        LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IAdvancedNumberOrdersOperations> _advancedNumberOrdersOperations = new(() =>
                    new AdvancedNumberOrdersOperations(client, rateLimitRetryPolicy),
                            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<ICsvDownloadsOperations> _csvDownloadsOperations = new(() =>
                        new CsvDownloadsOperations(client, rateLimitRetryPolicy),
                                LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<INumbersFeaturesOperations> _numbersFeaturesOperations = new(() =>
                        new NumbersFeaturesOperations(client, rateLimitRetryPolicy),
                                LazyThreadSafetyMode.ExecutionAndPublication);

        public IPhoneNumberSearchOperations PhoneNumberSearch => _phoneNumberSearchOperations.Value;

        public IPhoneNumberReservationsOperations PhoneNumberReservations => _phoneNumberReservationsOperations.Value;

        public IPhoneNumberOrdersOperations PhoneNumberOrders => _phoneNumberOrdersOperations.Value;

        public IPhoneNumberConfigurationOperations PhoneNumberConfiguration => _phoneNumberConfigurationOperations.Value;

        public IBulkPhoneNumberOperations BulkPhoneNumber => _bulkPhoneNumberOperations.Value;

        public IInventoryLevelOperations InventoryLevel => _inventoryLevelOperations.Value;

        public IPhoneNumberBlocksBackgroundJobsOperations PhoneNumberBlocksBackgroundJobs => _phoneNumberBlocksBackgroundJobsOperations.Value;

        public IRegulatoryRequirementsOperations RegulatoryRequirements => _regulatoryRequirementsOperations.Value;

        public IRequirementGroupsOperations RequirementGroups => _requirementGroupsOperations.Value;

        public ICountryCoverageOperations CountryCoverage => _countryCoverageOperations.Value;

        public IPhoneNumberBlockOrdersOperations PhoneNumberBlockOrders => _phoneNumberBlockOrdersOperations.Value;

        public IAdvancedNumberOrdersOperations AdvancedNumberOrders => _advancedNumberOrdersOperations.Value;

        public ICsvDownloadsOperations CsvDownloads => _csvDownloadsOperations.Value;

        public INumbersFeaturesOperations NumbersFeatures => _numbersFeaturesOperations.Value;

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

            if (_requirementGroupsOperations.IsValueCreated && _requirementGroupsOperations.Value is IDisposable disposableRequirementGroups)
                disposableRequirementGroups.Dispose();

            if (_countryCoverageOperations.IsValueCreated && _countryCoverageOperations.Value is IDisposable disposableCountryCoverage)
                disposableCountryCoverage.Dispose();

            if (_phoneNumberBlockOrdersOperations.IsValueCreated && _phoneNumberBlockOrdersOperations.Value is IDisposable disposablePhoneNumberBlockOrders)
                disposablePhoneNumberBlockOrders.Dispose();

            if (_advancedNumberOrdersOperations.IsValueCreated && _advancedNumberOrdersOperations.Value is IDisposable disposableAdvancedNumberOrders)
                disposableAdvancedNumberOrders.Dispose();

            if (_csvDownloadsOperations.IsValueCreated && _csvDownloadsOperations.Value is IDisposable disposableCsvDownloads)
                disposableCsvDownloads.Dispose();

            if (_numbersFeaturesOperations.IsValueCreated && _numbersFeaturesOperations.Value is IDisposable disposableNumbersFeatures)
                disposableNumbersFeatures.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}