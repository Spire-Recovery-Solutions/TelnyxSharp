using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.Voice.Interfaces;
using Telnyx.NET.Voice.Models.CallCommands.Requests;
using Telnyx.NET.Voice.Models.CallCommands.Responses;

namespace Telnyx.NET.Voice.Operations.ProgrammableVoice
{
    public class CallCommandsOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), ICallCommandsOperations
    {
        /// <inheritdoc />
        public async Task<DialResponse> Dial(DialRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("calls", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<DialResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<AnswerCallResponse> AnswerCall(string callControlId, AnswerCallRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/answer", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<AnswerCallResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<HangupCallResponse> HangupCall(string callControlId, HangupCallRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/hangup", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<HangupCallResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RejectCallResponse> RejectCall(string callControlId, RejectCallRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/reject", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<RejectCallResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<SpeakTextResponse?> SpeakText(string callControlId, SpeakTextRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/speak", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<SpeakTextResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<PlaybackStartResponse?> PlaybackStart(string callControlId, PlaybackStartRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/playback_start", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<PlaybackStartResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<StopAudioPlaybackResponse?> StopAudioPlayback(string callControlId,
            StopAudioPlaybackRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/playback_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<StopAudioPlaybackResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<EnqueueCallResponse?> EnqueueCall(string callControlId, EnqueueCallRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/enqueue", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            var result = await ExecuteAsync<EnqueueCallResponse>(req, cancellationToken);
            return result;
        }

        /// <inheritdoc />
        public async Task<RemoveCallFromQueueResponse?> RemoveCallFromQueue(string callControlId,
            RemoveCallFromQueueRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/leave_queue", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<RemoveCallFromQueueResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<TransferCallResponse?> TransferCall(string callControlId, TransferCallRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/transfer", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<TransferCallResponse>(req, cancellationToken);
        }
    }
}
