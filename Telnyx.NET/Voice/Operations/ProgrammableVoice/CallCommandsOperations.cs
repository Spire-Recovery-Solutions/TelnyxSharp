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
        public async Task<BridgeCallResponse?> BridgeCall(string callControlId, BridgeCallRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/bridge", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<BridgeCallResponse>(req, cancellationToken);
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
        public async Task<ForkMediaResponse?> StartForking(string callControlId, ForkMediaRequest request,
             CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/fork_start", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<ForkMediaResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ForkStopResponse?> StopForking(string callControlId, ForkStopRequest request,
                CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/fork_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<ForkStopResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GatherResponse?> Gather(string callControlId, GatherRequest request,
                 CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/gather", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<GatherResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GatherUsingAudioResponse?> GatherUsingAudio(string callControlId, GatherUsingAudioRequest request,
                CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/gather_using_audio", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<GatherUsingAudioResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GatherUsingSpeakResponse?> GatherUsingSpeak(string callControlId, GatherUsingSpeakRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/gather_using_speak", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<GatherUsingSpeakResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GatherUsingAiResponse?> GatherUsingAi(
            string callControlId,
            GatherUsingAiRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/gather_using_ai", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<GatherUsingAiResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GatherStopResponse?> GatherStop(
            string callControlId,
            GatherStopRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/gather_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<GatherStopResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<AiAssistantStartResponse> StartAIAssistant(
            string callControlId,
            AiAssistantStartRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/ai_assistant_start", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<AiAssistantStartResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<AiAssistantStopResponse> StopAIAssistant(
            string callControlId,
            AiAssistantStartRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/ai_assistant_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<AiAssistantStopResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateClientStateResponse> UpdateClientState(
            string callControlId,
            UpdateClientStateRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/client_state_update", Method.Put);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdateClientStateResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<SipReferResponse> SipRefer(
            string callControlId,
            SipReferRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/refer", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<SipReferResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<SiprecStartResponse?> SiprecStart(
            string callControlId,
            SiprecStartRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/siprec_start", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<SiprecStartResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<SiprecStopResponse?> SiprecStop(
            string callControlId,
            SiprecStopRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/siprec_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<SiprecStopResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<StreamingStartResponse?> StreamingStart(
            string callControlId,
            StreamingStartRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/streaming_start", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<StreamingStartResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<StreamingStopResponse> StreamingStop(
               string callControlId,
               StreamingStopRequest request,
               CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/streaming_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<StreamingStopResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<NoiseSuppressionStartResponse> NoiseSuppressionStart(
            string callControlId,
            NoiseSuppressionStartRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/suppression_start", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<NoiseSuppressionStartResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<NoiseSuppressionStopResponse> StopNoiseSuppression(
                string callControlId,
                NoiseSuppressionStopRequest request,
                CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/suppression_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<NoiseSuppressionStopResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<TranscriptionStopResponse> TranscriptionStop(
            string callControlId,
            TranscriptionStopRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/transcription_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<TranscriptionStopResponse>(req, cancellationToken);
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
        public async Task<RecordingStartResponse> StartRecording(
            string callControlId,
            RecordingStartRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/record_start", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<RecordingStartResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RecordPauseResponse?> PauseRecording(
            string callControlId,
            RecordPauseRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/record_pause", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<RecordPauseResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RecordResumeResponse?> ResumeRecording(
            string callControlId,
            RecordResumeRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/record_resume", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<RecordResumeResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RecordStopResponse?> StopRecording(
            string callControlId,
            RecordStopRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/record_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<RecordStopResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<SendDtmfResponse?> SendDtmf(
            string callControlId,
            SendDtmfRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/send_dtmf", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<SendDtmfResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<SendSipInfoResponse?> SendSipInfo(
            string callControlId,
            SendSipInfoRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/send_sip_info", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<SendSipInfoResponse>(req, cancellationToken);
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
