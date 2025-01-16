namespace Telnyx.NET.Voice.Interfaces
{
    /// <summary>
    /// Interface for programmable voice operations.
    /// Provides access to operations related to call commands and conference commands.
    /// </summary>
    public interface IProgrammableVoiceOperations : IDisposable
    {
        /// <summary>
        /// Gets the operations for call commands.
        /// </summary>
        ICallCommandsOperations CallCommands { get; }

        /// <summary>
        /// Gets the operations for conference commands.
        /// </summary>
        IConferenceCommandsOperations ConferenceCommands { get; }


        /// <summary>
        /// Gets the debugging operations for troubleshooting and analyzing voice operations.
        /// Includes operations like listing call events for monitoring and diagnostics.
        /// </summary>
        IDebuggingOperations Debugging { get; }

        /// <summary>
        /// Gets the operations for retrieving call information.
        /// Provides access to retrieving the status, details, and metadata of specific calls.
        /// </summary>
        ICallInformationOperations CallInformation { get; }

        /// <summary>
        /// Gets the operations for managing call control applications.
        /// Includes operations to create, update, retrieve, list, and delete call control applications.
        /// </summary>
        ICallControlApplicationsOperations CallControlApplications { get; }

        /// <summary>
        /// Gets the operations for queue commands.
        /// Includes operations related to managing queues, such as retrieving information about call queues or managing queue states.
        /// </summary>
        IQueueCommandsOperations QueueCommands { get; }
    }
}