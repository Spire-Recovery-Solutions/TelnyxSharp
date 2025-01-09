using Telnyx.NET.Messaging.Interfaces;
using Telnyx.NET.PhoneNumber.Interfaces;
using Telnyx.NET.Voice.Interfaces;

namespace Telnyx.NET.Base
{
    /// <summary>
    /// Represents the Telnyx client interface, providing access to various Telnyx API operations.
    /// The client manages communication with the Telnyx API and encapsulates operations related to messaging, phone numbers, and programmable voice commands.
    /// </summary>
    public interface ITelnyxClient : IDisposable
    {
        /// <summary>
        /// Gets the operations related to SMS and MMS messaging.
        /// This includes sending, receiving, and managing SMS and MMS messages.
        /// </summary>
        ISmsMmsOperations SmsMms { get; }

        /// <summary>
        /// Gets the operations for toll-free verification services.
        /// This includes managing toll-free numbers and their verification status through the Telnyx API.
        /// </summary>
        ITollFreeOperations TollFreeVerification { get; }

        /// <summary>
        /// Gets the operations for 10DLC services.
        /// This includes managing 10DLC campaigns and configuring phone numbers for 10DLC services.
        /// </summary>
        ITenDlcOperations TenDlcOperations { get; }

        /// <summary>
        /// Gets the operations related to identity management, such as identity verification and operations tied to user identification.
        /// </summary>
        IIdentityOperations IdentityOperations { get; }

        /// <summary>
        /// Gets the operations related to phone number management.
        /// This includes various operations for managing phone numbers, such as purchasing, configuring, and releasing phone numbers.
        /// </summary>
        IPhoneNumberOperations PhoneNumberOperations { get; }

        /// <summary>
        /// Gets the operations for programmable voice call commands.
        /// This includes operations such as dialing, answering, and managing calls programmatically via the Telnyx API.
        /// </summary>
        ICallCommandsOperations CallCommandsOperations { get; }
    }
}