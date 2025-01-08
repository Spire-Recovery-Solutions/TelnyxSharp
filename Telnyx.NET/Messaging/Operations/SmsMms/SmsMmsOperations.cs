using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Messaging.Interfaces;
using Telnyx.NET.Messaging.Operations.TenDlc;

namespace Telnyx.NET.Messaging.Operations.SmsMms
{
    /// <summary>
    /// Provides operations for managing SMS/MMS-related resources including messaging profiles, messages, short codes, URL domains, and number configurations.
    /// Implements the <see cref="ISmsMmsOperations"/> interface.
    /// </summary>
    public class SmsMmsOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy) : BaseOperations(client, rateLimitRetryPolicy), ISmsMmsOperations
    {
        // Lazy initialization for various operations, ensuring thread safety and lazy loading of instances.

        private readonly Lazy<IMessagingProfileOperations> _profiles = new(() =>
            new MessagingProfileOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IMessagesOperations> _messages = new(() =>
            new MessagesOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IMessagingUrlDomainOperations> _urlDomains = new(() =>
            new MessagingUrlDomainOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IShortCodeOperations> _shortCodes = new(() =>
            new ShortCodeOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<INumberConfigurationOperations> _numberConfiguration = new(() =>
            new NumberConfigurationOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IMessagingHostedNumbersOperations> _messagingHostedNumbersOperations = new(() =>
            new MessagingHostedNumbersOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IAdvancedOptInOptOutOperations> _advancedOptInOptOutOperations = new(() =>
            new AdvancedOptInOptOutOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        public IMessagingProfileOperations Profiles => _profiles.Value;

        public IMessagesOperations Messages => _messages.Value;

        public IShortCodeOperations ShortCodes => _shortCodes.Value;

        public IMessagingUrlDomainOperations UrlDomains => _urlDomains.Value;

        public INumberConfigurationOperations NumberConfiguration => _numberConfiguration.Value;

        public IMessagingHostedNumbersOperations MessagingHostedNumbers => _messagingHostedNumbersOperations.Value;

        public IAdvancedOptInOptOutOperations AdvancedOptInOptOut => _advancedOptInOptOutOperations.Value;


        /// <summary>
        /// Disposes of all resources and underlying disposable operations.
        /// Ensures proper cleanup of resources to avoid memory leaks.
        /// </summary>
        public void Dispose()
        {
            // Dispose of each lazy-loaded resource if it's been created and implements IDisposable
            if (_profiles.IsValueCreated && _profiles.Value is IDisposable disposableProfiles)
                disposableProfiles.Dispose();

            if (_messages.IsValueCreated && _messages.Value is IDisposable disposableSms)
                disposableSms.Dispose();

            if (_shortCodes.IsValueCreated && _shortCodes.Value is IDisposable disposableShortCodes)
                disposableShortCodes.Dispose();

            if (_urlDomains.IsValueCreated && _urlDomains.Value is IDisposable disposableUrlDomains)
                disposableUrlDomains.Dispose();

            if (_numberConfiguration.IsValueCreated && _numberConfiguration.Value is IDisposable disposableNumberConfig)
                disposableNumberConfig.Dispose();

            if (_messagingHostedNumbersOperations.IsValueCreated && _messagingHostedNumbersOperations.Value is IDisposable disposableMessageHostedNumbers)
                 disposableMessageHostedNumbers.Dispose();

            if (_advancedOptInOptOutOperations.IsValueCreated && _advancedOptInOptOutOperations.Value is IDisposable disposableAdvancedOptInOptOut)
                disposableAdvancedOptInOptOut.Dispose();

            // Suppress finalization to avoid redundant cleanup when the object is collected by garbage collection
            GC.SuppressFinalize(this);
        }
    }
}
