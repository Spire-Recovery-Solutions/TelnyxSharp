namespace Telnyx.NET.PhoneNumber.Interfaces
{
    /// <summary>
    /// Provides operations related to phone number management, including searching, reserving, ordering, configuring, and retrieving phone numbers.
    /// </summary>
    public interface IPhoneNumberOperations
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
        /// Gets the operations for managing phone number configurations, including updating voice settings and other configurations.
        /// </summary>
        IPhoneNumberOperations PhoneNumber { get; }

        /// <summary>
        /// Gets the operations for configuring phone numbers, including updating voice and other settings.
        /// </summary>
        IPhoneNumberConfigurationOperations PhoneNumberConfiguration { get; }
    }
}