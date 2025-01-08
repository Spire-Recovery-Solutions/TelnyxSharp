namespace Telnyx.NET.Messaging.Interfaces
{
    /// <summary>
    /// Provides operations for managing SMS/MMS-related resources, including messaging profiles, messages, short codes, 
    /// URL domains, number configurations, hosted numbers, and advanced opt-in/out management.
    /// </summary>
    public interface ISmsMmsOperations : IDisposable
    {
        /// <summary>
        /// Gets the operations related to messaging profiles.
        /// Messaging profiles are configurations for sending and receiving SMS/MMS messages.
        /// </summary>
        IMessagingProfileOperations Profiles { get; }

        /// <summary>
        /// Gets the operations for sending and retrieving messages.
        /// This includes the ability to send SMS/MMS messages, retrieve message statuses, and manage message queues.
        /// </summary>
        IMessagesOperations Messages { get; }

        /// <summary>
        /// Gets the operations related to managing short codes.
        /// Short codes are special telephone numbers used to send and receive SMS/MMS messages for marketing, alerts, etc.
        /// </summary>
        IShortCodeOperations ShortCodes { get; }

        /// <summary>
        /// Gets the operations for managing messaging URL domains.
        /// URL domains are used for creating branded short links for messaging campaigns and services.
        /// </summary>
        IMessagingUrlDomainOperations UrlDomains { get; }

        /// <summary>
        /// Gets the operations related to number configurations.
        /// Number configurations include the settings for phone numbers, such as SMS/MMS enablement, compliance, etc.
        /// </summary>
        INumberConfigurationOperations NumberConfiguration { get; }

        /// <summary>
        /// Gets the operations for managing hosted numbers.
        /// Hosted numbers are phone numbers managed through the service, typically for routing or number porting.
        /// </summary>
        IMessagingHostedNumbersOperations MessagingHostedNumbers { get; }

        /// <summary>
        /// Gets the operations for advanced opt-in and opt-out management.
        /// This includes features for managing the subscription status of recipients for SMS/MMS messaging services.
        /// </summary>
        IAdvancedOptInOptOutOperations AdvancedOptInOptOut { get; }
    }
}