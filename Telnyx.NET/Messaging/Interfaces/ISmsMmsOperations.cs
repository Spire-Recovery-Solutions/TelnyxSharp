namespace Telnyx.NET.Messaging.Interfaces
{
    /// <summary>
    /// Provides operations for managing SMS/MMS-related resources including profiles, messages, short codes, URL domains, and number configurations.
    /// </summary>
    public interface ISmsMmsOperations : IDisposable
    {
        /// <summary>
        /// Gets the operations related to messaging profiles.
        /// </summary>
        IMessagingProfileOperations Profiles { get; }

        /// <summary>
        /// Gets the operations for sending and retrieving messages.
        /// </summary>
        IMessagesOperations Messages { get; }

        /// <summary>
        /// Gets the operations related to managing short codes.
        /// </summary>
        IShortCodeOperations ShortCodes { get; }

        /// <summary>
        /// Gets the operations for managing messaging URL domains.
        /// </summary>
        IMessagingUrlDomainOperations UrlDomains { get; }

        /// <summary>
        /// Gets the operations related to number configurations.
        /// </summary>
        INumberConfigurationOperations NumberConfiguration { get; }
    }
}