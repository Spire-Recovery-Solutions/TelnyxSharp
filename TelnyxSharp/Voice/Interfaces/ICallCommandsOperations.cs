using TelnyxSharp.Voice.Models.CallCommands.Requests;
using TelnyxSharp.Voice.Models.CallCommands.Responses;

namespace TelnyxSharp.Voice.Interfaces
{
    /// <summary>
    /// Interface for performing call control operations using Telnyx API.
    /// </summary>
    public interface ICallCommandsOperations
    {
        /// <summary>
        /// Initiates a new outbound call.
        /// </summary>
        /// <param name="request">The request payload for dialing a call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="DialResponse"/> containing the response details of the call initiation.</returns>
        Task<DialResponse> Dial(DialRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Answers an incoming call.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call to be answered.</param>
        /// <param name="request">The request payload for answering the call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CallCommandsResponse"/> containing the response details of the answered call.</returns>
        Task<CallCommandsResponse> AnswerCall(string callControlId, AnswerCallRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Bridges a call with another call using the specified call control ID and request details.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call to be bridged.</param>
        /// <param name="request">The request payload containing the details for the bridge operation.</param>
        /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
        /// <returns>
        /// A task that represents the asynchronous operation. The task result contains the response
        /// with details of the bridged call, or <c>null</c> if the operation fails.
        /// </returns>
        Task<CallCommandsResponse?> BridgeCall(string callControlId, BridgeCallRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Starts forking media for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters for the forking action.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing forking details.</returns>
        Task<CallCommandsResponse?> StartForking(string callControlId, ForkMediaRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Stops forking media for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters for stopping the forking action.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing stop forking details.</returns>
        Task<CallCommandsResponse?> StopForking(string callControlId, ForkStopRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates a gather action for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters for the gather action.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing gather details.</returns>
        Task<CallCommandsResponse?> Gather(string callControlId, GatherRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates a gather action using audio for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters for gathering using audio.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing gather using audio details.</returns>
        Task<CallCommandsResponse?> GatherUsingAudio(string callControlId, GatherUsingAudioRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates a gather action using speech for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters for gathering using speech.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing gather using speech details.</returns>
        Task<CallCommandsResponse?> GatherUsingSpeak(string callControlId, GatherUsingSpeakRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates a gather action using AI for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters for gathering using AI.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing gather using AI details.</returns>
        Task<CallCommandsResponse?> GatherUsingAi(string callControlId, GatherUsingAiRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Stops the gather action for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters to stop the gather action.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing stop gather details.</returns>
        Task<CallCommandsResponse?> GatherStop(string callControlId, GatherStopRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Starts the AI assistant for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters for starting the AI assistant.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing AI assistant start details.</returns>
        Task<CallCommandsResponse> StartAIAssistant(string callControlId, AiAssistantStartRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Stops the AI assistant for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters to stop the AI assistant.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing AI assistant stop details.</returns>
        Task<CallCommandsResponse> StopAIAssistant(string callControlId, AiAssistantStartRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the client state for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters for updating the client state.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing the updated client state.</returns>
        Task<CallCommandsResponse> UpdateClientState(string callControlId, UpdateClientStateRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates a SIP refer action for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters for the SIP refer action.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing SIP refer details.</returns>
        Task<CallCommandsResponse> SipRefer(string callControlId, SipReferRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Starts SIP recording for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters for starting SIP recording.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing SIP recording start details.</returns>
        Task<CallCommandsResponse?> SiprecStart(string callControlId, SiprecStartRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Stops SIP recording for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters for stopping SIP recording.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing SIP recording stop details.</returns>
        Task<CallCommandsResponse?> SiprecStop(string callControlId, SiprecStopRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Starts streaming for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters for starting streaming.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing streaming start details.</returns>
        Task<CallCommandsResponse?> StreamingStart(string callControlId, StreamingStartRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Stops streaming for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters for stopping streaming.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing streaming stop details.</returns>
        Task<CallCommandsResponse> StreamingStop(string callControlId, StreamingStopRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Starts noise suppression for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters for starting noise suppression.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing noise suppression start details.</returns>
        Task<CallCommandsResponse> NoiseSuppressionStart(string callControlId, NoiseSuppressionStartRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Stops noise suppression for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters to stop noise suppression.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing noise suppression stop details.</returns>
        Task<CallCommandsResponse> StopNoiseSuppression(string callControlId, NoiseSuppressionStopRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Stops transcription for a specified call.
        /// </summary>
        /// <param name="callControlId">The unique identifier for the call control.</param>
        /// <param name="request">The request containing parameters to stop transcription.</param>
        /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a response containing transcription stop details.</returns>
        Task<CallCommandsResponse> TranscriptionStop(string callControlId, TranscriptionStopRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Hangs up an ongoing call.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call to be hung up.</param>
        /// <param name="request">The request payload for hanging up the call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CallCommandsResponse"/> containing the response details of the call hang-up.</returns>
        Task<CallCommandsResponse> HangupCall(string callControlId, HangupCallRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Rejects an incoming call.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call to be rejected.</param>
        /// <param name="request">The request payload for rejecting the call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CallCommandsResponse"/> containing the response details of the rejected call.</returns>
        Task<CallCommandsResponse> RejectCall(string callControlId, RejectCallRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Plays text-to-speech audio on a call.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call.</param>
        /// <param name="request">The request payload for speaking text on the call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CallCommandsResponse"/> containing the response details of the text-to-speech operation.</returns>
        Task<CallCommandsResponse?> SpeakText(string callControlId, SpeakTextRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Starts audio playback on a call.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call.</param>
        /// <param name="request">The request payload for starting audio playback on the call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CallCommandsResponse"/> containing the response details of the audio playback operation.</returns>
        Task<CallCommandsResponse?> PlaybackStart(string callControlId, PlaybackStartRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Stops ongoing audio playback on a call.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call.</param>
        /// <param name="request">The request payload for stopping audio playback on the call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CallCommandsResponse"/> containing the response details of the stop audio playback operation.</returns>
        Task<CallCommandsResponse?> StopAudioPlayback(string callControlId, StopAudioPlaybackRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Enqueues a call into a queue.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call to be enqueued.</param>
        /// <param name="request">The request payload for enqueuing the call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CallCommandsResponse"/> containing the response details of the enqueued call.</returns>
        Task<CallCommandsResponse?> EnqueueCall(string callControlId, EnqueueCallRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Removes a call from a queue.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call to be removed from the queue.</param>
        /// <param name="request">The request payload for removing the call from the queue.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CallCommandsResponse"/> containing the response details of the removed call.</returns>
        Task<CallCommandsResponse?> RemoveCallFromQueue(string callControlId, RemoveCallFromQueueRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Transfers a call to another destination.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call to be transferred.</param>
        /// <param name="request">The request payload for transferring the call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CallCommandsResponse"/> containing the response details of the transferred call.</returns>
        Task<CallCommandsResponse?> TransferCall(string callControlId, TransferCallRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Starts recording a call.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call to record.</param>
        /// <param name="request">The request payload for starting the recording.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CallCommandsResponse"/> containing the response details.</returns>
        Task<CallCommandsResponse> StartRecording(string callControlId, RecordingStartRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Pauses an ongoing call recording.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call.</param>
        /// <param name="request">The request payload for pausing the recording.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CallCommandsResponse"/> containing the response details.</returns>
        Task<CallCommandsResponse?> PauseRecording(string callControlId, RecordPauseRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Resumes a paused call recording.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call.</param>
        /// <param name="request">The request payload for resuming the recording.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CallCommandsResponse"/> containing the response details.</returns>
        Task<CallCommandsResponse?> ResumeRecording(string callControlId, RecordResumeRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Stops an ongoing call recording.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call.</param>
        /// <param name="request">The request payload for stopping the recording.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CallCommandsResponse"/> containing the response details.</returns>
        Task<CallCommandsResponse?> StopRecording(string callControlId, RecordStopRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends DTMF tones on a call.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call.</param>
        /// <param name="request">The request payload for sending DTMF tones.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CallCommandsResponse"/> containing the response details.</returns>
        Task<CallCommandsResponse?> SendDtmf(string callControlId, SendDtmfRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends SIP INFO on a call.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call.</param>
        /// <param name="request">The request payload for sending SIP INFO.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="CallCommandsResponse"/> containing the response details.</returns>
        Task<CallCommandsResponse?> SendSipInfo(string callControlId, SendSipInfoRequest request, CancellationToken cancellationToken = default);
    }
}
