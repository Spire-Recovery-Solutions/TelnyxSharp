using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Voice.Interfaces;

namespace Telnyx.NET.Voice.Operations.ProgrammableVoice
{
    /// <summary>
    /// Implementation of programmable voice operations.
    /// Provides access to call commands and manages resource disposal.
    /// </summary>
    public class ProgrammableVoiceOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
        : BaseOperations(client, rateLimitRetryPolicy), IProgrammableVoiceOperations
    {
        /// <summary>
        /// Lazy initialization of call command operations.
        /// Ensures the operations are created only when accessed.
        /// </summary>
        private readonly Lazy<ICallCommandsOperations> _callCommandsOperations = new(() =>
            new CallCommandsOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly Lazy<IConferenceCommandsOperations> _conferenceCommandsOperations = new(() =>
            new ConferenceCommandsOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        /// <inheritdoc />
        public ICallCommandsOperations CallCommands => _callCommandsOperations.Value;

        /// <inheritdoc />
        public IConferenceCommandsOperations ConferenceCommands => _conferenceCommandsOperations.Value;

        /// <summary>
        /// Disposes of all resources and underlying disposable operations related to toll-free operations.
        /// Ensures proper cleanup of resources to avoid memory leaks.
        /// </summary>
        public void Dispose()
        {
            // Check if the lazy-initialized operations are created and are disposable, then dispose of them.
            if (_callCommandsOperations.IsValueCreated && _callCommandsOperations.Value is IDisposable disposableCallCmd)
                disposableCallCmd.Dispose();

            if (_conferenceCommandsOperations.IsValueCreated && _conferenceCommandsOperations.Value is IDisposable disposableConfCmd)
                disposableConfCmd.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}