using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.PhoneNumber.Interfaces;
using Telnyx.NET.PhoneNumber.Operations.PhoneNumber;

namespace Telnyx.NET.Messaging.Operations.TollFreeVerification
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


        private readonly Lazy<IPhoneNumberOperations> _phoneNumberOperations = new(() =>
                new PhoneNumberOperations(client, rateLimitRetryPolicy),
                    LazyThreadSafetyMode.ExecutionAndPublication);


        private readonly Lazy<IPhoneNumberConfigurationOperations> _phoneNumberConfigurationOperations = new(() =>
                new PhoneNumberConfigurationOperations(client, rateLimitRetryPolicy),
                        LazyThreadSafetyMode.ExecutionAndPublication);

        public IPhoneNumberSearchOperations PhoneNumberSearch => _phoneNumberSearchOperations.Value;

        public IPhoneNumberReservationsOperations PhoneNumberReservations => _phoneNumberReservationsOperations.Value;

        public IPhoneNumberOrdersOperations PhoneNumberOrders => _phoneNumberOrdersOperations.Value;

        public IPhoneNumberOperations PhoneNumber => _phoneNumberOperations.Value;

        public IPhoneNumberConfigurationOperations PhoneNumberConfiguration => _phoneNumberConfigurationOperations.Value;

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

            if (_phoneNumberOperations.IsValueCreated && _phoneNumberOperations.Value is IDisposable disposablePhoneNumber)
                disposablePhoneNumber.Dispose();

            if (_phoneNumberConfigurationOperations.IsValueCreated && _phoneNumberConfigurationOperations.Value is IDisposable disposablePhoneNumberConfiguration)
                disposablePhoneNumberConfiguration.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}