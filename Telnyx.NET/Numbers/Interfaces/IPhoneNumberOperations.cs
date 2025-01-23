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

        /// <summary>
        /// Gets the operations for managing regulatory requirements associated with phone numbers, 
        /// including checking and fulfilling regulatory requirements based on phone number and region.
        /// </summary>
        IRegulatoryRequirementsOperations RegulatoryRequirements { get; }

        /// <summary>
        /// Gets the operations for managing requirement groups associated with phone numbers.
        /// This includes creating, updating, and deleting requirement groups, as well as submitting them for approval.
        /// </summary>
        /// <remarks>
        /// Requirement groups are used to group related requirements for phone number transactions and regulatory checks.
        /// </remarks>
        IRequirementGroupsOperations RequirementGroups { get; }

        /// <summary>
        /// Gets the operations for retrieving country coverage details, such as phone number availability and types in specific countries.
        /// This operation helps you understand which phone numbers are available in specific countries based on various filters.
        /// </summary>
        ICountryCoverageOperations CountryCoverage { get; }

        /// <summary>
        /// Gets the operations for managing phone number block orders.
        /// This includes creating, listing, and retrieving orders related to blocks of phone numbers.
        /// </summary>
        IPhoneNumberBlockOrdersOperations PhoneNumberBlockOrders { get; }

        /// <summary>
        /// Gets the operations related to advanced number orders, including creating and managing advanced orders for phone numbers.
        /// </summary>
        IAdvancedNumberOrdersOperations AdvancedNumberOrders { get; }

        /// <summary>
        /// Gets the operations for managing CSV downloads for phone numbers.
        /// This includes creating new downloads, listing existing ones, and retrieving individual CSV download records.
        /// </summary>
        ICsvDownloadsOperations CsvDownloads { get; }

        /// <summary>
        /// Gets the operations for managing features of phone numbers, such as retrieving available features.
        /// </summary>
        INumbersFeaturesOperations NumbersFeatures { get; }
    }
}