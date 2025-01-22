namespace Telnyx.NET.Numbers.Interfaces
{
    /// <summary>
    /// Provides operations related to phone number management, including searching, reserving, ordering, configuring, and retrieving phone numbers.
    /// </summary>
    public interface IPhoneNumberOperations : IDisposable
    {
        /// <summary>
        /// Gets the operations related to phone number search, such as searching for available phone numbers.
        /// </summary>
        IPhoneNumberSearchOperations PhoneNumberSearch { get; }

        /// <summary>
        /// Gets the operations for phone number reservations, including creating and managing reserved numbers.
        /// </summary>
        IPhoneNumberReservationsOperations PhoneNumberReservations { get; }

        /// <summary>
        /// Gets the operations for managing phone number orders, including listing and creating orders.
        /// </summary>
        IPhoneNumberOrdersOperations PhoneNumberOrders { get; }

        /// <summary>
        /// Gets the operations for configuring phone numbers, including updating voice and other settings.
        /// </summary>
        IPhoneNumberConfigurationOperations PhoneNumberConfiguration { get; }

        /// <summary>
        /// Gets the operations for performing bulk updates on phone numbers.
        /// This allows you to modify settings or configurations for multiple phone numbers in a single request, improving efficiency.
        /// </summary>
        IBulkPhoneNumberOperations BulkPhoneNumber { get; }

        /// <summary>
        /// Gets the operations for inventory-level queries.
        /// This includes checking the coverage and availability of phone numbers based on various filters, such as location or number type.
        /// </summary>
        IInventoryLevelOperations InventoryLevel { get; }

        /// <summary>
        /// Gets the operations for managing phone number block background jobs, 
        /// including creating, retrieving, and managing jobs related to phone number blocks.
        /// </summary>
        IPhoneNumberBlocksBackgroundJobsOperations PhoneNumberBlocksBackgroundJobs { get; }
    }
}