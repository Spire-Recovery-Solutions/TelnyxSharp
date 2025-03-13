using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests;
/// <summary>
/// Represents a request to answer an incoming call in the Telnyx API.
/// This request includes various parameters for customizing the call handling, 
/// including billing group, client state, headers, streaming options, and transcription settings.
/// </summary>
public class AnswerCallRequest : ITelnyxRequest
{
    /// <summary>
    /// Use this field to set the Billing Group ID for the call.
    /// Must be a valid and existing Billing Group ID.
    /// </summary>
    [JsonPropertyName("billing_group_id")]
    public string? BillingGroupId { get; set; }

    /// <summary>
    /// Use this field to add state to every subsequent webhook.
    /// It must be a valid Base-64 encoded string.
    /// </summary>
    [JsonPropertyName("client_state")]
    public string? ClientState { get; set; }

    /// <summary>
    /// Use this field to avoid duplicate commands.
    /// Telnyx will ignore any command with the same command_id for the same call_control_id.
    /// </summary>
    [JsonPropertyName("command_id")]
    public string? CommandId { get; set; }

    /// <summary>
    /// Custom headers to be added to the SIP INVITE response.
    /// </summary>
    [JsonPropertyName("custom_headers")]
    public List<CustomHeader>? CustomHeaders { get; set; }

    /// <summary>
    /// The list of comma-separated codecs in a preferred order for the forked media to be received.
    /// Possible values: [G722, PCMU, PCMA, G729, OPUS, VP8, H264].
    /// </summary>
    [JsonPropertyName("preferred_codecs")]
    public string? PreferredCodecs { get; set; }

    /// <summary>
    /// SIP headers to be added to the SIP INVITE response.
    /// Currently only User-to-User header is supported.
    /// </summary>
    [JsonPropertyName("sip_headers")]
    public List<SipHeader>? SipHeaders { get; set; }

    /// <summary>
    /// Use this field to modify sound effects, for example, adjust the pitch.
    /// </summary>
    [JsonPropertyName("sound_modifications")]
    public SoundModifications? SoundModifications { get; set; }

    /// <summary>
    /// The destination WebSocket address where the stream is going to be delivered.
    /// </summary>
    [JsonPropertyName("stream_url")]
    public string? StreamUrl { get; set; }

    /// <summary>
    /// Specifies which track should be streamed.
    /// Possible values: [inbound_track, outbound_track, both_tracks].
    /// Default value: inbound_track.
    /// </summary>
    [JsonPropertyName("stream_track")]
    public string? StreamTrack { get; set; }

    /// <summary>
    /// Configures method of bidirectional streaming.
    /// Possible values: [mp3, rtp].
    /// Default value: mp3.
    /// </summary>
    [JsonPropertyName("stream_bidirectional_mode")]
    public string? StreamBidirectionalMode { get; set; }

    /// <summary>
    /// Indicates codec for bidirectional streaming RTP payloads.
    /// Used only with stream_bidirectional_mode=rtp. Case sensitive.
    /// Possible values: [PCMU, PCMA, G722].
    /// Default value: PCMU.
    /// </summary>
    [JsonPropertyName("stream_bidirectional_codec")]
    public string? StreamBidirectionalCodec { get; set; }

    /// <summary>
    /// Generate silence RTP packets when no transmission is available.
    /// </summary>
    [JsonPropertyName("send_silence_when_idle")]
    public bool? SendSilenceWhenIdle { get; set; }

    /// <summary>
    /// Use this field to override the URL for which Telnyx will send subsequent webhooks to for this call.
    /// </summary>
    [JsonPropertyName("webhook_url")]
    public string? WebhookUrl { get; set; }

    /// <summary>
    /// HTTP request type used for webhook_url.
    /// Possible values: [POST, GET].
    /// Default value: POST.
    /// </summary>
    [JsonPropertyName("webhook_url_method")]
    public string? WebhookUrlMethod { get; set; }

    /// <summary>
    /// Enable transcription upon call answer.
    /// The default value is false.
    /// </summary>
    [JsonPropertyName("transcription")]
    public bool? Transcription { get; set; }

    /// <summary>
    /// Configuration for transcription settings.
    /// </summary>
    [JsonPropertyName("transcription_config")]
    public TranscriptionConfig? TranscriptionConfig { get; set; }
}