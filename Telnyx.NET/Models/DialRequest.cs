using Telnyx.NET.Interfaces;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Models;

/// <summary>
/// Represents a request to initiate a dial operation through Telnyx API, containing 
/// various parameters like phone numbers, media settings, and call configurations.
/// </summary>
public class DialRequest : ITelnyxRequest
{
    /// <summary>
    /// The destination phone number to be dialed, provided in E.164 format.
    /// </summary>
    [JsonPropertyName("to")]
    public required string To { get; set; }

    /// <summary>
    /// The caller's phone number (caller ID), provided in E.164 format.
    /// </summary>
    [JsonPropertyName("from")]
    public required string From { get; set; }

    /// <summary>
    /// Optional display name for the 'From' caller ID, visible to the recipient.
    /// </summary>
    [JsonPropertyName("from_display_name")]
    public string? FromDisplayName { get; set; }

    /// <summary>
    /// Unique identifier for the connection profile used for the call. 
    /// It associates the call with a specific Telnyx connection.
    /// </summary>
    [JsonPropertyName("connection_id")]
    public required string ConnectionId { get; set; }

    /// <summary>
    /// Optional URL of the audio file to be played when the call is answered.
    /// </summary>
    [JsonPropertyName("audio_url")]
    public string? AudioUrl { get; set; }

    /// <summary>
    /// Optional media file name to play during the call, such as a hold or greeting message.
    /// </summary>
    [JsonPropertyName("media_name")]
    public string? MediaName { get; set; }

    /// <summary>
    /// A comma-separated list of preferred audio codecs (e.g., G.711, G.722) for the call.
    /// </summary>
    [JsonPropertyName("preferred_codecs")]
    public string? PreferredCodecs { get; set; }

    /// <summary>
    /// Time in seconds before the call times out if unanswered. Defaults to Telnyx's standard timeout if not specified.
    /// </summary>
    [JsonPropertyName("timeout_secs")]
    public int? TimeoutSecs { get; set; }

    /// <summary>
    /// Maximum allowed duration of the call in seconds. The call will be disconnected when the time limit is reached.
    /// </summary>
    [JsonPropertyName("time_limit_secs")]
    public int? TimeLimitSecs { get; set; }

    /// <summary>
    /// Enables Answering Machine Detection (AMD) to distinguish between human answers and voicemail. 
    /// Possible values include:
    /// - <c>premium</c>: Real-time detection with detailed webhook results (human_residence, human_business, machine, silence, fax_detected).
    /// - <c>detect</c>: Basic detection to identify human or machine answers.
    /// - <c>detect_beep</c>: Triggers additional webhook on beep detection.
    /// - <c>detect_words</c>: Analyzes word detection for machine identification.
    /// - <c>greeting_end</c>: Sends a webhook when the answering machine greeting ends.
    /// - <c>disabled</c>: Disables detection (default).
    /// </summary>
    [JsonPropertyName("answering_machine_detection")]
    public string? AnsweringMachineDetection { get; set; }

    /// <summary>
    /// Optional configuration for customizing the behavior of answering machine detection (AMD).
    /// </summary>
    [JsonPropertyName("answering_machine_detection_config")]
    public AnsweringMachineDetectionConfig? AnsweringMachineDetectionConfig { get; set; }

    /// <summary>
    /// Optional configuration for conference calling, such as conference name and exit settings.
    /// </summary>
    [JsonPropertyName("conference_config")]
    public ConferenceConfig? ConferenceConfig { get; set; }

    /// <summary>
    /// List of custom SIP headers to be included in the request for the call.
    /// </summary>
    [JsonPropertyName("custom_headers")]
    public List<CustomHeader>? CustomHeaders { get; set; }

    /// <summary>
    /// Optional billing group identifier to associate the call with a specific billing account.
    /// </summary>
    [JsonPropertyName("billing_group_id")]
    public string? BillingGroupId { get; set; }

    /// <summary>
    /// Custom state information associated with the client for this call. 
    /// This data will be passed back in callbacks.
    /// </summary>
    [JsonPropertyName("client_state")]
    public string? ClientState { get; set; }

    /// <summary>
    /// Optional unique command ID for tracking the request. It can be used to identify and reference this call later.
    /// </summary>
    [JsonPropertyName("command_id")]
    public string? CommandId { get; set; }

    /// <summary>
    /// Identifier to link this call with another call or object (e.g., for call transfer scenarios).
    /// </summary>
    [JsonPropertyName("link_to")]
    public string? LinkTo { get; set; }

    /// <summary>
    /// Specifies media encryption options for the call (e.g., SRTP).
    /// </summary>
    [JsonPropertyName("media_encryption")]
    public string? MediaEncryption { get; set; }

    /// <summary>
    /// Username for SIP authentication, if the call requires SIP credentials.
    /// </summary>
    [JsonPropertyName("sip_auth_username")]
    public string? SipAuthUsername { get; set; }

    /// <summary>
    /// Password for SIP authentication, used with the SIP username.
    /// </summary>
    [JsonPropertyName("sip_auth_password")]
    public string? SipAuthPassword { get; set; }

    /// <summary>
    /// List of additional SIP headers to send along with the call.
    /// </summary>
    [JsonPropertyName("sip_headers")]
    public List<SipHeader>? SipHeaders { get; set; }

    /// <summary>
    /// Specifies the transport protocol for SIP communication (e.g., TCP or UDP).
    /// </summary>
    [JsonPropertyName("sip_transport_protocol")]
    public string? SipTransportProtocol { get; set; }

    /// <summary>
    /// Optional configuration for modifying sound during the call, such as volume adjustment.
    /// </summary>
    [JsonPropertyName("sound_modifications")]
    public SoundModifications? SoundModifications { get; set; }

    /// <summary>
    /// URL for streaming audio data from the call in real-time.
    /// </summary>
    [JsonPropertyName("stream_url")]
    public string? StreamUrl { get; set; }

    /// <summary>
    /// Specifies which audio tracks to include in the media stream (e.g., inbound, outbound).
    /// </summary>
    [JsonPropertyName("stream_track")]
    public string? StreamTrack { get; set; }

    /// <summary>
    /// Enables bidirectional media streaming if required.
    /// </summary>
    [JsonPropertyName("stream_bidirectional_mode")]
    public string? StreamBidirectionalMode { get; set; }

    /// <summary>
    /// Specifies the codec used for bidirectional streaming, if enabled.
    /// </summary>
    [JsonPropertyName("stream_bidirectional_codec")]
    public string? StreamBidirectionalCodec { get; set; }

    /// <summary>
    /// Specifies whether to send silence during idle periods of the call.
    /// </summary>
    [JsonPropertyName("send_silence_when_idle")]
    public bool? SendSilenceWhenIdle { get; set; }

    /// <summary>
    /// Webhook URL where call-related events (e.g., status updates) are posted.
    /// </summary>
    [JsonPropertyName("webhook_url")]
    public string? WebhookUrl { get; set; }

    /// <summary>
    /// The HTTP method (GET or POST) used when sending requests to the webhook URL.
    /// </summary>
    [JsonPropertyName("webhook_url_method")]
    public string? WebhookUrlMethod { get; set; }

    /// <summary>
    /// Specifies whether the call should be recorded.
    /// </summary>
    [JsonPropertyName("record")]
    public string? Record { get; set; }

    /// <summary>
    /// Specifies the audio channels (e.g., single or dual-channel) for recording.
    /// </summary>
    [JsonPropertyName("record_channels")]
    public string? RecordChannels { get; set; }

    /// <summary>
    /// Specifies the format for recording audio files (e.g., WAV, MP3).
    /// </summary>
    [JsonPropertyName("record_format")]
    public string? RecordFormat { get; set; }

    /// <summary>
    /// Maximum recording duration in seconds.
    /// </summary>
    [JsonPropertyName("record_max_length")]
    public int? RecordMaxLength { get; set; }

    /// <summary>
    /// Time in seconds before the recording times out if no audio is detected.
    /// </summary>
    [JsonPropertyName("record_timeout_secs")]
    public int? RecordTimeoutSecs { get; set; }

    /// <summary>
    /// Specifies whether silence should be trimmed from the call recording.
    /// </summary>
    [JsonPropertyName("record_trim")]
    public string? RecordTrim { get; set; }

    /// <summary>
    /// Custom file name for storing the recorded call.
    /// </summary>
    [JsonPropertyName("record_custom_file_name")]
    public string? RecordCustomFileName { get; set; }

    /// <summary>
    /// Specifies whether to enable Dialogflow integration for AI-based interactions during the call.
    /// </summary>
    [JsonPropertyName("enable_dialogflow")]
    public bool? EnableDialogflow { get; set; }

    /// <summary>
    /// Configuration options for Dialogflow integration, such as project details and language settings.
    /// </summary>
    [JsonPropertyName("dialogflow_config")]
    public DialDialogflowConfig? DialogflowConfig { get; set; }

    /// <summary>
    /// Enables transcription of the call audio if required.
    /// </summary>
    [JsonPropertyName("transcription")]
    public bool? EnableTranscription { get; set; }

    /// <summary>
    /// Configuration options for transcription services, such as language and accuracy preferences.
    /// </summary>
    [JsonPropertyName("transcription_config")]
    public TranscriptionConfig? TranscriptionConfig { get; set; }
}