using Telnyx.NET.Interfaces;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents a request to transfer a call to a specified destination.
    /// This includes various options for customization such as caller ID, audio playback, and timeout settings.
    /// </summary>
    public class TransferCallRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the destination number (DID or SIP URI) to dial out to. This is a required field.
        /// </summary>
        [JsonPropertyName("to")]
        public string To { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the caller ID number presented to the destination (to number).
        /// If omitted, the to number of the original call will be used. Should be in +E164 format.
        /// </summary>
        [JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// Gets or sets the caller ID name (SIP From Display Name) presented to the destination.
        /// The string can have a maximum of 128 characters and can include letters, numbers, spaces, and -_~!.+ special characters.
        /// If omitted, it will default to the number in the from field.
        /// </summary>
        [JsonPropertyName("from_display_name")]
        public string? FromDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the URL of a file to be played back when the transfer destination answers before bridging the call.
        /// The URL must point to a WAV or MP3 file. This cannot be used together with media_name in one request.
        /// </summary>
        [JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Gets or sets the number of seconds Telnyx will wait for the call to be answered by the destination.
        /// Minimum value is 5 seconds, maximum is 120 seconds. Default is 30 seconds.
        /// </summary>
        [JsonPropertyName("timeout_secs")]
        public int? TimeoutSecs { get; set; }

        /// <summary>
        /// Gets or sets the maximum duration of a Call Control Leg in seconds.
        /// Minimum value is 30 seconds, maximum is 14400 seconds (4 hours). Default is 14400 seconds.
        /// </summary>
        [JsonPropertyName("time_limit_secs")]
        public int? TimeLimitSecs { get; set; }

        /// <summary>
        /// Gets or sets the Answering Machine Detection setting.
        /// Possible values include: premium, detect, detect_beep, detect_words, greeting_end, disabled.
        /// Default is disabled.
        /// </summary>
        [JsonPropertyName("answering_machine_detection")]
        public string? AnsweringMachineDetection { get; set; }

        /// <summary>
        /// Gets or sets optional configuration parameters to modify Answering Machine Detection performance.
        /// </summary>
        [JsonPropertyName("answering_machine_detection_config")]
        public AnsweringMachineDetectionConfig? AnsweringMachineDetectionConfig { get; set; }

        /// <summary>
        /// Gets or sets custom headers to be added to the SIP INVITE.
        /// </summary>
        [JsonPropertyName("custom_headers")]
        public List<CustomHeader>? CustomHeaders { get; set; }

        /// <summary>
        /// Gets or sets the client state to be added to every subsequent webhook.
        /// Must be a valid Base-64 encoded string.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the state to be added to every subsequent webhook for the new leg.
        /// Must be a valid Base-64 encoded string.
        /// </summary>
        [JsonPropertyName("target_leg_client_state")]
        public string? TargetLegClientState { get; set; }

        /// <summary>
        /// Gets or sets the command ID to avoid duplicate commands.
        /// Telnyx will ignore any command with the same command_id for the same call_control_id.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Gets or sets the media encryption setting for the new call leg.
        /// Possible values are: disabled, SRTP. Default is disabled.
        /// </summary>
        [JsonPropertyName("media_encryption")]
        public string? MediaEncryption { get; set; }

        /// <summary>
        /// Gets or sets the SIP Authentication username used for SIP challenges.
        /// </summary>
        [JsonPropertyName("sip_auth_username")]
        public string? SipAuthUsername { get; set; }

        /// <summary>
        /// Gets or sets the SIP Authentication password used for SIP challenges.
        /// </summary>
        [JsonPropertyName("sip_auth_password")]
        public string? SipAuthPassword { get; set; }

        /// <summary>
        /// Gets or sets SIP headers to be added to the SIP INVITE.
        /// Currently, only User-to-User header is supported.
        /// </summary>
        [JsonPropertyName("sip_headers")]
        public List<SipHeader>? SipHeaders { get; set; }

        /// <summary>
        /// Gets or sets the SIP transport protocol to be used on the call.
        /// Possible values: UDP, TCP, TLS. Default is UDP.
        /// </summary>
        [JsonPropertyName("sip_transport_protocol")]
        public string? SipTransportProtocol { get; set; }

        /// <summary>
        /// Gets or sets the URL to which Telnyx will send subsequent webhooks for this call.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Gets or sets the HTTP request type used for the webhook_url.
        /// Possible values: POST, GET. Default is POST.
        /// </summary>
        [JsonPropertyName("webhook_url_method")]
        public string? WebhookUrlMethod { get; set; }

        /// <summary>
        /// Gets or sets the URL for streaming audio.
        /// This field can be used to provide a streaming source for audio playback during the call.
        /// </summary>
        [JsonPropertyName("stream_url")]
        public string? StreamUrl { get; set; }

         /// <summary>
        /// Gets or sets the track to which the sound modifications will be applied.
        /// Accepted values are inbound or outbound.
        /// Default is outbound.
        /// </summary>
        [JsonPropertyName("stream_track")]
        public string? StreamTrack { get; set; }
    }
}