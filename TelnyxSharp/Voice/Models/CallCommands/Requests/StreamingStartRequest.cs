using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to start a media stream for a call, including various configurations 
    /// such as stream URL, track type, bidirectional mode, codec, and optional Dialogflow integration.
    /// </summary>
    public class StreamingStartRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the URL of the media stream. This is the destination URL where the media stream will be sent.
        /// </summary>
        [JsonPropertyName("stream_url")]
        public string? StreamUrl { get; set; }

        /// <summary>
        /// Gets or sets the track type for the stream. Defines the direction of the stream (e.g., inbound, outbound).
        /// Default is inbound track.
        /// </summary>
        [JsonPropertyName("stream_track")]
        public Track StreamTrack { get; set; } = Track.InboundTrack;

        /// <summary>
        /// Gets or sets the bidirectional mode for the stream. This determines how the stream is handled in both directions.
        /// Default is MP3 mode.
        /// </summary>
        [JsonPropertyName("stream_bidirectional_mode")]
        public StreamBidirectionalMode StreamBidirectionalMode { get; set; } = StreamBidirectionalMode.Mp3;

        /// <summary>
        /// Gets or sets the codec for the bidirectional stream. Defines the audio codec used for the stream.
        /// Default is PCMU codec.
        /// </summary>
        [JsonPropertyName("stream_bidirectional_codec")]
        public StreamBidirectionalCodec StreamBidirectionalCodec { get; set; } = StreamBidirectionalCodec.PCMU;

        /// <summary>
        /// Gets or sets the target leg for bidirectional streaming. Determines which legs of the call will be involved.
        /// Default is the opposite leg.
        /// </summary>
        [JsonPropertyName("stream_bidirectional_target_legs")]
        public StreamBidirectionalTargetLegs StreamBidirectionalTargetLegs { get; set; } = StreamBidirectionalTargetLegs.Opposite;

        /// <summary>
        /// Gets or sets a value indicating whether Dialogflow integration is enabled for the streaming request.
        /// This allows the stream to interact with Dialogflow for speech recognition and processing.
        /// Default is false.
        /// </summary>
        [JsonPropertyName("enable_dialogflow")]
        public bool EnableDialogflow { get; set; } = false;

        /// <summary>
        /// Gets or sets the configuration for Dialogflow, which will be used if Dialogflow integration is enabled.
        /// </summary>
        [JsonPropertyName("dialogflow_config")]
        public DialDialogflowConfig? DialogflowConfig { get; set; }

        /// <summary>
        /// Gets or sets the client state associated with the streaming request.
        /// This can be used to track the state of the request from the client's perspective.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the unique command ID for the streaming start request.
        /// This ID can be used for tracking and managing multiple requests.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}