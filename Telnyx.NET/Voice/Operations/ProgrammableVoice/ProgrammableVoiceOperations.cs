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

         private readonly Lazy<IDebuggingOperations> _debuggingOperations = new(() =>
            new DebuggingOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);
        
         private readonly Lazy<ICallInformationOperations> _callInformationOperations = new(() =>
            new CallInformationOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

         private readonly Lazy<ICallControlApplicationsOperations> _callControlApplicationsOperations = new(() =>
            new CallControlApplicationsOperations(client, rateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        /// <inheritdoc />
        public ICallCommandsOperations CallCommands => _callCommandsOperations.Value;

        /// <inheritdoc />
        public IConferenceCommandsOperations ConferenceCommands => _conferenceCommandsOperations.Value;

        /// <inheritdoc />
        public IDebuggingOperations Debugging => _debuggingOperations.Value;

        /// <inheritdoc />
        public ICallInformationOperations CallInformation => _callInformationOperations.Value;
        
        /// <inheritdoc />
        public ICallControlApplicationsOperations CallControlApplications => _callControlApplicationsOperations.Value;

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

            if (_debuggingOperations.IsValueCreated && _debuggingOperations.Value is IDisposable disposableDebugging)
                disposableDebugging.Dispose();

            if (_callInformationOperations.IsValueCreated && _callInformationOperations.Value is IDisposable disposableCallInfo)
                disposableCallInfo.Dispose();

            if (_callControlApplicationsOperations.IsValueCreated && _callControlApplicationsOperations.Value is IDisposable disposableCallControlApps)
                disposableCallControlApps.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}