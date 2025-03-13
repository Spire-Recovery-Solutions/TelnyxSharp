namespace TelnyxSharp.Messaging.Interfaces
{
    /// <summary>
    /// Provides operations for managing 10DLC (10-digit long code) campaigns and related resources.
    /// </summary>
    public interface ITenDlcOperations : IDisposable
    {
        /// <summary>
        /// Gets the operations for managing brand-related resources.
        /// A brand represents an entity (e.g., a business or organization) associated with 10DLC campaigns.
        /// </summary>
        IBrandOperations Brand { get; }

        /// <summary>
        /// Gets the operations related to managing campaigns.
        /// </summary>
        ICampaignOperations Campaign { get; }

        /// <summary>
        /// Gets the operations for managing phone number campaigns.
        /// </summary>
        IPhoneNumberCampaignOperations PhoneNumberCampaign { get; }

        /// <summary>
        /// Gets the operations for managing bulk phone number campaigns.
        /// </summary>
        IBulkPhoneNumberCampaignOperations BulkPhoneNumberCampaign { get; }

        /// <summary>
        /// Gets the operations related to managing shared campaigns.
        /// </summary>
        ISharedCampaignOperations SharedCampaign { get; }

        /// <summary>
        /// Gets the operations for managing ENUM (E.164 number mapping) services.
        /// </summary>
        IEnumOperations Enum { get; }
    }
}