namespace Telnyx.NET.PhoneNumber.Interfaces
{
    /// <summary>
    /// Provides operations related to identity management, such as number lookups and identity verification.
    /// </summary>
    public interface IIdentityOperations
    {
        /// <summary>
        /// Gets the operations for number lookup.
        /// This allows you to look up information about phone numbers, including their status, carrier information, and more.
        /// </summary>
        INumberLookupOperations NumberLookup { get; }
    }
}