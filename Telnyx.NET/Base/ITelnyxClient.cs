using Telnyx.NET.Identity.Interfaces;
using Telnyx.NET.Messaging.Interfaces;
using Telnyx.NET.Numbers.Interfaces;
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
        /// Provides operations related to phone number lookup, including retrieving information about a phone number 
        /// such as carrier details, line type, and geographical information.
        /// </summary>
        ILookUpNumberOperations LookUpNumber { get; }

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

        /// <summary>
        /// Provides operations for managing voicemail services.
        /// Includes configuring voicemail settings for phone numbers.
        /// </summary>
        IVoicemailOperations Voicemail { get; }

        /// <summary>
        /// Provides operations related to channel zones management.
        /// This includes listing, retrieving, updating, assigning, and unassigning phone numbers within channel zones.
        /// </summary>
        IChannelZonesOperations ChannelZones { get; }

        /// <summary>
        /// Provides operations for managing inbound channels.
        /// Supports operations for configuring and retrieving inbound channel settings.
        /// </summary>
        IInboundChannelsOperations InboundChannels { get; }

        /// <summary>
        /// Provides operations for managing number port-out requests.
        /// Includes listing, retrieving, updating, and managing port-out requests and related events.
        /// </summary>
        INumberPortoutOperations NumberPortout { get; }
    }
}