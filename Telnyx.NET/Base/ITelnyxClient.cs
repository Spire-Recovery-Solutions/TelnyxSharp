using Telnyx.NET.Messaging.Interfaces;

namespace Telnyx.NET.Base
{
    /// <summary>
    /// Represents the Telnyx client interface, providing access to various Telnyx API operations.
    /// The client manages communication with the Telnyx API and encapsulates operations related to SMS/MMS, toll-free, and 10DLC services.
    /// </summary>
    public interface ITelnyxClient : IDisposable
    {
        /// <summary>
        /// Gets the operations related to SMS and MMS messaging, including sending, receiving, and managing messages.
        /// </summary>
        ISmsMmsOperations SmsMms { get; }

        /// <summary>
        /// Gets the operations for toll-free verification services, including managing toll-free numbers and their verification status.
        /// </summary>
        ITollFreeOperations TollFreeVerification { get; }

        /// <summary>
        /// Gets the operations for 10DLC services, including managing campaigns and phone number configurations for 10DLC.
        /// </summary>
        ITenDlcOperations TenDlcOperations { get; }
    }
}