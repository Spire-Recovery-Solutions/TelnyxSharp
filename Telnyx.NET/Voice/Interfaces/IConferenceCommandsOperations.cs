using Telnyx.NET.Voice.Models.ConferenceCommands.Requests;
using Telnyx.NET.Voice.Models.ConferenceCommands.Responses;

namespace Telnyx.NET.Voice.Interfaces
{
    /// <summary>
    /// Provides operations for managing conference commands, such as creating conferences, updating participants,
    /// starting/stopping recordings, muting/unmuting participants, and more.
    /// </summary>

    public interface IConferenceCommandsOperations
    {
        /// <summary>
        /// Creates a new conference.
        /// </summary>
        /// <param name="request">The request parameters for creating the conference.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response indicating the result of the creation operation.</returns>
        Task<CreateConferenceResponse?> Create(CreateConferenceRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists all conferences based on the provided filters and pagination options.
        /// </summary>
        /// <param name="request">The request parameters for filtering and pagination.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response containing the list of conferences.</returns>
        Task<ListConferencesResponse?> List(ListConferencesRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves information about a specific conference.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to retrieve.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response containing the details of the conference.</returns>
        Task<RetrieveConferenceResponse?> Retrieve(string conferenceId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists participants in a specific conference with filtering and pagination options.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference.</param>
        /// <param name="request">The request parameters for filtering and pagination.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response containing the list of conference participants.</returns>
        Task<ListConferenceParticipantsResponse?> ListParticipants(string conferenceId, ListConferenceParticipantsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Joins a participant to a conference.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to join.</param>
        /// <param name="request">The request parameters for joining the conference.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response indicating the result of the join operation.</returns>
        Task<ConferenceCommandResponse?> JoinConference(string conferenceId, JoinConferenceRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Removes a participant from a conference.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to leave.</param>
        /// <param name="request">The request parameters for leaving the conference.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response indicating the result of the leave operation.</returns>
        Task<ConferenceCommandResponse?> LeaveConference(string conferenceId, LeaveConferenceRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates settings or properties of an existing conference.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to update.</param>
        /// <param name="request">The request parameters for updating the conference.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response indicating the result of the update operation.</returns>
        Task<ConferenceCommandResponse?> UpdateConference(string conferenceId, UpdateConferenceRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Mutes specified participants in a conference.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to mute participants.</param>
        /// <param name="request">The request parameters for muting participants.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response indicating the result of the mute operation.</returns>
        Task<ConferenceCommandResponse?> MuteParticipants(string conferenceId, MuteConferenceParticipantsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Unmutes specified participants in a conference.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to unmute participants.</param>
        /// <param name="request">The request parameters for unmuting participants.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response indicating the result of the unmute operation.</returns>
        Task<ConferenceCommandResponse?> UnmuteParticipants(string conferenceId, UnmuteConferenceParticipantsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Places participants on hold in a conference.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to place participants on hold.</param>
        /// <param name="request">The request parameters for holding participants.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response indicating the result of the hold operation.</returns>
        Task<ConferenceCommandResponse?> HoldParticipants(string conferenceId, HoldConferenceParticipantsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Removes participants from hold in a conference.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to unhold participants.</param>
        /// <param name="request">The request parameters for unholding participants.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response indicating the result of the unhold operation.</returns>
        Task<ConferenceCommandResponse?> UnholdParticipants(string conferenceId, UnholdConferenceParticipantsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Starts recording a conference.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to start recording.</param>
        /// <param name="request">The request parameters for starting the recording.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response indicating the result of the start recording operation.</returns>
        Task<ConferenceCommandResponse?> StartRecording(string conferenceId, StartConferenceRecordingRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Stops recording a conference.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to stop recording.</param>
        /// <param name="request">The request parameters for stopping the recording.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response indicating the result of the stop recording operation.</returns>
        Task<ConferenceCommandResponse?> StopRecording(string conferenceId, StopConferenceRecordingRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Pauses recording a conference.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to pause recording.</param>
        /// <param name="request">The request parameters for pausing the recording.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response indicating the result of the pause recording operation.</returns>
        Task<ConferenceCommandResponse?> PauseRecording(string conferenceId, PauseConferenceRecordingRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Resumes recording a conference.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to resume recording.</param>
        /// <param name="request">The request parameters for resuming the recording.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response indicating the result of the resume recording operation.</returns>
        Task<ConferenceCommandResponse?> ResumeRecording(string conferenceId, ResumeConferenceRecordingRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Speaks text to the participants in a conference.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to speak text to participants.</param>
        /// <param name="request">The request parameters for speaking the text.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response indicating the result of the speak text operation.</returns>
        Task<ConferenceCommandResponse?> SpeakTextToParticipants(string conferenceId, SpeakTextToConferenceRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Plays audio to the participants in a conference.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to play audio to participants.</param>
        /// <param name="request">The request parameters for playing the audio.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response indicating the result of the play audio operation.</returns>
        Task<ConferenceCommandResponse?> PlayAudioToParticipants(string conferenceId, PlayAudioToConferenceRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Stops audio from being played to participants in a conference.
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to stop audio for participants.</param>
        /// <param name="request">The request parameters for stopping the audio.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A response indicating the result of the stop audio operation.</returns>
        Task<ConferenceCommandResponse?> StopAudioToParticipants(string conferenceId, StopAudioToConferenceRequest request, CancellationToken cancellationToken = default);
    }
}
