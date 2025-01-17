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
        ITenDlcOperations TenDlc { get; }

        /// <summary>
        /// Gets the operations related to identity management, such as identity verification and operations tied to user identification.
        /// </summary>
        IIdentityOperations Identity { get; }

        /// <summary>
        /// Gets the operations related to phone number management.
        /// This includes various operations for managing phone numbers, such as purchasing, configuring, and releasing phone numbers.
        /// </summary>
        IPhoneNumberOperations PhoneNumbers { get; }

        /// <summary>
        /// Provides operations for programmable voice calls.
        /// Includes initiating, answering, and managing calls programmatically via the Telnyx API.
        /// </summary>
        IProgrammableVoiceOperations ProgrammableVoice { get; }
    }
}