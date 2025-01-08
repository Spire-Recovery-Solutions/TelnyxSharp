using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Messaging.Interfaces;

namespace Telnyx.NET.Messaging
{
    /// <summary>
    /// Provides operations related to TenDLC (10-Digit Long Code) messaging campaigns.
    /// This includes managing campaigns, phone number campaigns, bulk phone number campaigns, shared campaigns, and ENUM operations.
    /// </summary>
    public class TenDlcOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy) : BaseOperations(client, rateLimitRetryPolicy), ITenDlcOperations
    {
        private readonly Lazy<CampaignOperations> _campaignOperations = new(() =>
            new CampaignOperations(client, rateLimitRetryPolicy), LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<PhoneNumberCampaignOperations> _phoneNumberCampaignOperations = new(() =>
            new PhoneNumberCampaignOperations(client, rateLimitRetryPolicy), LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<BulkPhoneNumberCampaignOperations> _bulkPhoneNumberCampaignOperations = new(() =>
            new BulkPhoneNumberCampaignOperations(client, rateLimitRetryPolicy), LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<SharedCampaignOperations> _sharedCampaignOperations = new(() =>
            new SharedCampaignOperations(client, rateLimitRetryPolicy), LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IEnumOperations> _enumOperations = new(() =>
            new EnumOperations(client, rateLimitRetryPolicy), LazyThreadSafetyMode.ExecutionAndPublication);

        public ICampaignOperations Campaign => _campaignOperations.Value;

        public IPhoneNumberCampaignOperations PhoneNumberCampaign => _phoneNumberCampaignOperations.Value;

        public IBulkPhoneNumberCampaignOperations BulkPhoneNumberCampaign => _bulkPhoneNumberCampaignOperations.Value;

        public ISharedCampaignOperations SharedCampaign => _sharedCampaignOperations.Value;

        public IEnumOperations Enum => _enumOperations.Value;

        /// <summary>
        /// Disposes of all resources and underlying disposable operations related to TenDLC.
        /// Ensures proper cleanup of resources to avoid memory leaks.
        /// </summary>
        public void Dispose()
        {
            if (_campaignOperations.IsValueCreated && _campaignOperations.Value is IDisposable disposableCampaign)
                disposableCampaign.Dispose();

            if (_phoneNumberCampaignOperations.IsValueCreated && _phoneNumberCampaignOperations.Value is IDisposable disposablePhoneCampaign)
                disposablePhoneCampaign.Dispose();

            if (_bulkPhoneNumberCampaignOperations.IsValueCreated && _bulkPhoneNumberCampaignOperations.Value is IDisposable disposableBulkPhoneCampaign)
                disposableBulkPhoneCampaign.Dispose();

            if (_sharedCampaignOperations.IsValueCreated && _sharedCampaignOperations.Value is IDisposable disposableSharedCampaign)
                disposableSharedCampaign.Dispose();

            if (_enumOperations.IsValueCreated && _enumOperations.Value is IDisposable disposableEnum)
                disposableEnum.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
