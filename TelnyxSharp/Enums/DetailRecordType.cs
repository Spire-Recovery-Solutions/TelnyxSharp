using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Specifies the allowed detail record types for filtering.
    /// These values correspond to different Telnyx product-specific record schemas.
    /// For example, "messaging" returns message detail records.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DetailRecordType
    {
        /// <summary>
        /// Detail record for AI voice assistant events.
        /// </summary>
        [JsonStringEnumMemberName("ai-voice-assistant")]
        AiVoiceAssistant,

        /// <summary>
        /// Detail record for Automated Media Distribution events.
        /// </summary>
        [JsonStringEnumMemberName("amd")]
        Amd,

        /// <summary>
        /// Detail record for call control events.
        /// </summary>
        [JsonStringEnumMemberName("call-control")]
        CallControl,

        /// <summary>
        /// Detail record for conference events.
        /// </summary>
        [JsonStringEnumMemberName("conference")]
        Conference,

        /// <summary>
        /// Detail record for conference participant events.
        /// </summary>
        [JsonStringEnumMemberName("conference-participant")]
        ConferenceParticipant,

        /// <summary>
        /// Detail record for embedding events.
        /// </summary>
        [JsonStringEnumMemberName("embedding")]
        Embedding,

        /// <summary>
        /// Detail record for fax events.
        /// </summary>
        [JsonStringEnumMemberName("fax")]
        Fax,

        /// <summary>
        /// Detail record for inference events.
        /// </summary>
        [JsonStringEnumMemberName("inference")]
        Inference,

        /// <summary>
        /// Detail record for inference speech-to-text events.
        /// </summary>
        [JsonStringEnumMemberName("inference-speech-to-text")]
        InferenceSpeechToText,

        /// <summary>
        /// Detail record for media storage events.
        /// </summary>
        [JsonStringEnumMemberName("media_storage")]
        MediaStorage,

        /// <summary>
        /// Detail record for media streaming events.
        /// </summary>
        [JsonStringEnumMemberName("media-streaming")]
        MediaStreaming,

        /// <summary>
        /// Detail record for messaging events.
        /// </summary>
        [JsonStringEnumMemberName("messaging")]
        Messaging,

        /// <summary>
        /// Detail record for noise suppression events.
        /// </summary>
        [JsonStringEnumMemberName("noise-suppression")]
        NoiseSuppression,

        /// <summary>
        /// Detail record for recording events.
        /// </summary>
        [JsonStringEnumMemberName("recording")]
        Recording,

        /// <summary>
        /// Detail record for SIP trunking events.
        /// </summary>
        [JsonStringEnumMemberName("sip-trunking")]
        SipTrunking,

        /// <summary>
        /// Detail record for SIPREC client events.
        /// </summary>
        [JsonStringEnumMemberName("siprec-client")]
        SiprecClient,

        /// <summary>
        /// Detail record for speech-to-text (STT) events.
        /// </summary>
        [JsonStringEnumMemberName("stt")]
        Stt,

        /// <summary>
        /// Detail record for text-to-speech (TTS) events.
        /// </summary>
        [JsonStringEnumMemberName("tts")]
        Tts,

        /// <summary>
        /// Detail record for verification events.
        /// </summary>
        [JsonStringEnumMemberName("verify")]
        Verify,

        /// <summary>
        /// Detail record for WebRTC events.
        /// </summary>
        [JsonStringEnumMemberName("webrtc")]
        Webrtc,

        /// <summary>
        /// Detail record for wireless events.
        /// </summary>
        [JsonStringEnumMemberName("wireless")]
        Wireless
    }
}