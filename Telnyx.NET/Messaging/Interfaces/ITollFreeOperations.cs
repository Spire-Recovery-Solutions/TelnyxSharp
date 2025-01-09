namespace Telnyx.NET.Messaging.Interfaces
{
    /// <summary>
    /// Provides operations for managing toll-free numbers and related verification processes.
    /// </summary>
    public interface ITollFreeOperations : IDisposable
    {
        /// <summary>
        /// Gets the operations related to verifying toll-free numbers.
        /// </summary>
        ITollFreeVerificationOperations Verification { get; }
    }
}