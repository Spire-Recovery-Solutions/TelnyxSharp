using System.Text.Json.Serialization;
using TelnyxSharp.Converters;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Specifies the allowed detail record types for filtering.
    /// These values correspond to different Telnyx product-specific record schemas.
    /// For example, "messaging" returns message detail records.
    /// </summary>
    [JsonConverter(typeof(DetailRecordTypeConverter))]
    public enum DetailRecordType
    {
        /// <summary>
        /// Detail record for AI voice assistant events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ai-voice-assistant")]
        AiVoiceAssistant,
        
        /// <summary>
        /// Detail record for Automated Media Distribution events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("amd")]
        Amd,
        
        /// <summary>
        /// Detail record for call control events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("call-control")]
        CallControl,
        
        /// <summary>
        /// Detail record for conference events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("conference")]
        Conference,
        
        /// <summary>
        /// Detail record for conference participant events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("conference-participant")]
        ConferenceParticipant,
        
        /// <summary>
        /// Detail record for embedding events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("embedding")]
        Embedding,
        
        /// <summary>
        /// Detail record for fax events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("fax")]
        Fax,
        
        /// <summary>
        /// Detail record for inference events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("inference")]
        Inference,
        
        /// <summary>
        /// Detail record for inference speech-to-text events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("inference-speech-to-text")]
        InferenceSpeechToText,
        
        /// <summary>
        /// Detail record for media storage events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("media_storage")]
        MediaStorage,
        
        /// <summary>
        /// Detail record for media streaming events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("media-streaming")]
        MediaStreaming,
        
        /// <summary>
        /// Detail record for messaging events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("messaging")]
        Messaging,
        
        /// <summary>
        /// Detail record for noise suppression events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("noise-suppression")]
        NoiseSuppression,
        
        /// <summary>
        /// Detail record for recording events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("recording")]
        Recording,
        
        /// <summary>
        /// Detail record for SIP trunking events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sip-trunking")]
        SipTrunking,
        
        /// <summary>
        /// Detail record for SIPREC client events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("siprec-client")]
        SiprecClient,
        
        /// <summary>
        /// Detail record for speech-to-text (STT) events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("stt")]
        Stt,
        
        /// <summary>
        /// Detail record for text-to-speech (TTS) events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("tts")]
        Tts,
        
        /// <summary>
        /// Detail record for verification events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("verify")]
        Verify,
        
        /// <summary>
        /// Detail record for WebRTC events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("webrtc")]
        Webrtc,
        
        /// <summary>
        /// Detail record for wireless events.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("wireless")]
        Wireless
    }
}