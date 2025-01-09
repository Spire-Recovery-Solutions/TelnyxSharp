using Telnyx.NET.Voice.Models.CallCommands.Requests;
using Telnyx.NET.Voice.Models.CallCommands.Responses;

namespace Telnyx.NET.Voice.Interfaces
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
        /// <returns>A <see cref="AnswerCallResponse"/> containing the response details of the answered call.</returns>
        Task<AnswerCallResponse> AnswerCall(string callControlId, AnswerCallRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Hangs up an ongoing call.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call to be hung up.</param>
        /// <param name="request">The request payload for hanging up the call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="HangupCallResponse"/> containing the response details of the call hang-up.</returns>
        Task<HangupCallResponse> HangupCall(string callControlId, HangupCallRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Rejects an incoming call.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call to be rejected.</param>
        /// <param name="request">The request payload for rejecting the call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="RejectCallResponse"/> containing the response details of the rejected call.</returns>
        Task<RejectCallResponse> RejectCall(string callControlId, RejectCallRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Plays text-to-speech audio on a call.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call.</param>
        /// <param name="request">The request payload for speaking text on the call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="SpeakTextResponse"/> containing the response details of the text-to-speech operation.</returns>
        Task<SpeakTextResponse?> SpeakText(string callControlId, SpeakTextRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Starts audio playback on a call.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call.</param>
        /// <param name="request">The request payload for starting audio playback on the call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="PlaybackStartResponse"/> containing the response details of the audio playback operation.</returns>
        Task<PlaybackStartResponse?> PlaybackStart(string callControlId, PlaybackStartRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Stops ongoing audio playback on a call.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call.</param>
        /// <param name="request">The request payload for stopping audio playback on the call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="StopAudioPlaybackResponse"/> containing the response details of the stop audio playback operation.</returns>
        Task<StopAudioPlaybackResponse?> StopAudioPlayback(string callControlId, StopAudioPlaybackRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Enqueues a call into a queue.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call to be enqueued.</param>
        /// <param name="request">The request payload for enqueuing the call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="EnqueueCallResponse"/> containing the response details of the enqueued call.</returns>
        Task<EnqueueCallResponse?> EnqueueCall(string callControlId, EnqueueCallRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Removes a call from a queue.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call to be removed from the queue.</param>
        /// <param name="request">The request payload for removing the call from the queue.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="RemoveCallFromQueueResponse"/> containing the response details of the removed call.</returns>
        Task<RemoveCallFromQueueResponse?> RemoveCallFromQueue(string callControlId, RemoveCallFromQueueRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Transfers a call to another destination.
        /// </summary>
        /// <param name="callControlId">The unique identifier of the call to be transferred.</param>
        /// <param name="request">The request payload for transferring the call.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A <see cref="TransferCallResponse"/> containing the response details of the transferred call.</returns>
        Task<TransferCallResponse?> TransferCall(string callControlId, TransferCallRequest request, CancellationToken cancellationToken = default);
    }
}
