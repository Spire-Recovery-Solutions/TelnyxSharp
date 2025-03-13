using Polly.Retry;
using RestSharp;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Voice.Interfaces;
using TelnyxSharp.Voice.Models.CallCommands.Requests;
using TelnyxSharp.Voice.Models.CallCommands.Responses;

namespace TelnyxSharp.Voice.Operations.ProgrammableVoice
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
        public async Task<CallCommandsResponse> AnswerCall(string callControlId, AnswerCallRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/answer", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> BridgeCall(string callControlId, BridgeCallRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/bridge", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> EnqueueCall(string callControlId, EnqueueCallRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/enqueue", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            var result = await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
            return result;
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> StartForking(string callControlId, ForkMediaRequest request,
             CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/fork_start", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> StopForking(string callControlId, ForkStopRequest request,
                CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/fork_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> Gather(string callControlId, GatherRequest request,
                 CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/gather", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> GatherUsingAudio(string callControlId, GatherUsingAudioRequest request,
                CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/gather_using_audio", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> GatherUsingSpeak(string callControlId, GatherUsingSpeakRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/gather_using_speak", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> GatherUsingAi(
            string callControlId,
            GatherUsingAiRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/gather_using_ai", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> GatherStop(
            string callControlId,
            GatherStopRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/gather_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse> StartAIAssistant(
            string callControlId,
            AiAssistantStartRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/ai_assistant_start", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse> StopAIAssistant(
            string callControlId,
            AiAssistantStartRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/ai_assistant_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse> UpdateClientState(
            string callControlId,
            UpdateClientStateRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/client_state_update", Method.Put);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse> SipRefer(
            string callControlId,
            SipReferRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/refer", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> SiprecStart(
            string callControlId,
            SiprecStartRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/siprec_start", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> SiprecStop(
            string callControlId,
            SiprecStopRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/siprec_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> StreamingStart(
            string callControlId,
            StreamingStartRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/streaming_start", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse> StreamingStop(
               string callControlId,
               StreamingStopRequest request,
               CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/streaming_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse> NoiseSuppressionStart(
            string callControlId,
            NoiseSuppressionStartRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/suppression_start", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse> StopNoiseSuppression(
                string callControlId,
                NoiseSuppressionStopRequest request,
                CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/suppression_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse> TranscriptionStop(
            string callControlId,
            TranscriptionStopRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/transcription_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse> HangupCall(string callControlId, HangupCallRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/hangup", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse> RejectCall(string callControlId, RejectCallRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/reject", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> SpeakText(string callControlId, SpeakTextRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/speak", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> PlaybackStart(string callControlId, PlaybackStartRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/playback_start", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> StopAudioPlayback(string callControlId,
            StopAudioPlaybackRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/playback_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse> StartRecording(
            string callControlId,
            RecordingStartRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/record_start", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> PauseRecording(
            string callControlId,
            RecordPauseRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/record_pause", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> ResumeRecording(
            string callControlId,
            RecordResumeRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/record_resume", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> StopRecording(
            string callControlId,
            RecordStopRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/record_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> SendDtmf(
            string callControlId,
            SendDtmfRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/send_dtmf", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> SendSipInfo(
            string callControlId,
            SendSipInfoRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/send_sip_info", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> RemoveCallFromQueue(string callControlId,
            RemoveCallFromQueueRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/leave_queue", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CallCommandsResponse?> TransferCall(string callControlId, TransferCallRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/transfer", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CallCommandsResponse>(req, cancellationToken);
        }
    }
}
