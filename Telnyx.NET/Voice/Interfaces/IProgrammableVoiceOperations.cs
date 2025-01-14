namespace Telnyx.NET.Voice.Interfaces
{
    /// <summary>
    /// Interface for programmable voice operations.
    /// Provides access to operations related to call commands and conference commands.
    /// </summary>
    public interface IProgrammableVoiceOperations
    {
        /// <summary>
        /// Gets the operations for call commands.
        /// </summary>
        ICallCommandsOperations CallCommands { get; }

        /// <summary>
        /// Gets the operations for conference commands.
        /// </summary>
        IConferenceCommandsOperations ConferenceCommands { get; }
    }
}