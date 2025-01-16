using System.Text.Json.Serialization;

namespace Telnyx.NET.Voice.Models.CallCommands.Requests;

/// <summary>
/// Configuration settings for managing a conference call in the Telnyx API.
/// This class defines various parameters to control conference behavior, 
/// including participant management, hold and mute settings, 
/// and conference lifecycle options.
/// </summary>
public class ConferenceConfig
{
    /// <summary>
    /// The unique identifier for the conference that the participant will join.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The name of the conference to be joined.
    /// </summary>
    [JsonPropertyName("conference_name")]
    public string? ConferenceName { get; set; }

    /// <summary>
    /// If set to true, the conference will end and all remaining participants will be hung up when the participant exits. Defaults to false.
    /// </summary>
    [JsonPropertyName("end_conference_on_exit")]
    public bool? EndConferenceOnExit { get; set; }

    /// <summary>
    /// If set to true, the conference will end after the participant leaves, but other participants will not be hung up. Defaults to false.
    /// </summary>
    [JsonPropertyName("soft_end_conference_on_exit")]
    public bool? SoftEndConferenceOnExit { get; set; }

    /// <summary>
    /// If set to true, the participant will be placed on hold immediately after joining the conference. Defaults to false.
    /// </summary>
    [JsonPropertyName("hold")]
    public bool? Hold { get; set; }

    /// <summary>
    /// The URL of the audio file to be played to the participant while on hold. This property takes effect only if "hold" is set to true and "start_conference_on_create" is false.
    /// </summary>
    [JsonPropertyName("hold_audio_url")]
    public string? HoldAudioUrl { get; set; }

    /// <summary>
    /// The media name of a file to be played during hold. This must point to a previously uploaded file and takes effect only if "hold" is set to true and "start_conference_on_create" is false.
    /// </summary>
    [JsonPropertyName("hold_media_name")]
    public string? HoldMediaName { get; set; }

    /// <summary>
    /// If set to true, the participant will be muted immediately upon joining the conference. Defaults to false.
    /// </summary>
    [JsonPropertyName("mute")]
    public bool? Mute { get; set; }

    /// <summary>
    /// If set to true, the conference will automatically start when the participant joins. Defaults to false.
    /// </summary>
    [JsonPropertyName("start_conference_on_enter")]
    public bool? StartConferenceOnEnter { get; set; }

    /// <summary>
    /// If set to true, the conference will start immediately upon creation. If false, all participants who join will be put on hold. Defaults to true.
    /// </summary>
    [JsonPropertyName("start_conference_on_create")]
    public bool? StartConferenceOnCreate { get; set; }

    /// <summary>
    /// The role assigned to a supervisor in the conference. Possible values include:
    /// - <c>barge</c>: The supervisor enters as a normal participant.
    /// - <c>monitor</c>: The supervisor is muted but can hear all participants.
    /// - <c>whisper</c>: Only specified participants can hear the supervisor.
    /// - <c>none</c>: The supervisor has no special role. Defaults to none.
    /// </summary>
    [JsonPropertyName("supervisor_role")]
    public string? SupervisorRole { get; set; }

    /// <summary>
    /// An array of unique call control IDs that the joining supervisor can whisper to. If none are provided, the supervisor will join as a monitoring participant only.
    /// </summary>
    [JsonPropertyName("whisper_call_control_ids")]
    public List<string>? WhisperCallControlIds { get; set; }

    /// <summary>
    /// Specifies whether a beep sound should be played when the participant joins or leaves the conference. Possible values include:
    /// - <c>always</c>: Beep is played on both join and exit.
    /// - <c>never</c>: No beep is played.
    /// - <c>on_enter</c>: Beep is played only when joining.
    /// - <c>on_exit</c>: Beep is played only when leaving.
    /// </summary>
    [JsonPropertyName("beep_enabled")]
    public string? BeepEnabled { get; set; }
}
