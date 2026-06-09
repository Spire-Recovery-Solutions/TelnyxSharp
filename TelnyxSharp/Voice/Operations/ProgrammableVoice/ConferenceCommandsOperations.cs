using Polly.Retry;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Voice.Interfaces;
using TelnyxSharp.Voice.Models.ConferenceCommands.Requests;
using TelnyxSharp.Voice.Models.ConferenceCommands.Responses;

namespace TelnyxSharp.Voice.Operations.ProgrammableVoice
{
    public class ConferenceCommandsOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IConferenceCommandsOperations
    {
        /// <inheritdoc />
        public async Task<CreateConferenceResponse?> Create(CreateConferenceRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("conferences", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CreateConferenceResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListConferencesResponse?> List(ListConferencesRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("conferences")
                           .AddFilter("filter[name]", request.Name)
                           .AddFilter("filter[status]", request.Status)
                           .AddPagination(request.PageSize);

            return await ExecuteAsync<ListConferencesResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrieveConferenceResponse?> Retrieve(string conferenceId, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}");
            return await ExecuteAsync<RetrieveConferenceResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListConferenceParticipantsResponse?> ListParticipants(string conferenceId, ListConferenceParticipantsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}/participants")
                        .AddFilter("filter[muted]", request.Muted)
                        .AddFilter("filter[on_hold]", request.OnHold)
                        .AddFilter("filter[whispering]", request.Whispering)
                        .AddPagination(request.PageSize);

            return await ExecuteAsync<ListConferenceParticipantsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ConferenceCommandResponse?> JoinConference(string conferenceId, JoinConferenceRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}/actions/join", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ConferenceCommandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ConferenceCommandResponse?> LeaveConference(string conferenceId, LeaveConferenceRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}/actions/leave", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ConferenceCommandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ConferenceCommandResponse?> UpdateConference(string conferenceId, UpdateConferenceRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}/actions/update", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ConferenceCommandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ConferenceCommandResponse?> MuteParticipants(string conferenceId, MuteConferenceParticipantsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}/actions/mute", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ConferenceCommandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ConferenceCommandResponse?> UnmuteParticipants(string conferenceId, UnmuteConferenceParticipantsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}/actions/unmute", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ConferenceCommandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ConferenceCommandResponse?> HoldParticipants(string conferenceId, HoldConferenceParticipantsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}/actions/hold", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ConferenceCommandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ConferenceCommandResponse?> UnholdParticipants(string conferenceId, UnholdConferenceParticipantsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}/actions/unhold", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ConferenceCommandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ConferenceCommandResponse?> StartRecording(string conferenceId, StartConferenceRecordingRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}/actions/record_start", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ConferenceCommandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ConferenceCommandResponse?> StopRecording(string conferenceId, StopConferenceRecordingRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}/actions/record_stop", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ConferenceCommandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ConferenceCommandResponse?> PauseRecording(string conferenceId, PauseConferenceRecordingRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}/actions/record_pause", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ConferenceCommandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ConferenceCommandResponse?> ResumeRecording(string conferenceId, ResumeConferenceRecordingRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}/actions/record_resume", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ConferenceCommandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ConferenceCommandResponse?> SpeakTextToParticipants(string conferenceId, SpeakTextToConferenceRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}/actions/speak", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ConferenceCommandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ConferenceCommandResponse?> PlayAudioToParticipants(string conferenceId, PlayAudioToConferenceRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}/actions/play", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ConferenceCommandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ConferenceCommandResponse?> StopAudioToParticipants(string conferenceId, StopAudioToConferenceRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"conferences/{conferenceId}/actions/stop", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ConferenceCommandResponse>(req, cancellationToken);
        }

    }
}
