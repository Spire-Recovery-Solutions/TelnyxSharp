using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// Converts <see cref="DetailRecordType"/> enum values to and from their corresponding string representations.
    /// </summary>
    public class DetailRecordTypeConverter : JsonConverter<DetailRecordType>
    {
        public override DetailRecordType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? value = reader.GetString();
            return value switch
            {
                "ai-voice-assistant" => DetailRecordType.AiVoiceAssistant,
                "amd" => DetailRecordType.Amd,
                "call-control" => DetailRecordType.CallControl,
                "conference" => DetailRecordType.Conference,
                "conference-participant" => DetailRecordType.ConferenceParticipant,
                "embedding" => DetailRecordType.Embedding,
                "fax" => DetailRecordType.Fax,
                "inference" => DetailRecordType.Inference,
                "inference-speech-to-text" => DetailRecordType.InferenceSpeechToText,
                "media_storage" => DetailRecordType.MediaStorage,
                "media-streaming" => DetailRecordType.MediaStreaming,
                "messaging" => DetailRecordType.Messaging,
                "noise-suppression" => DetailRecordType.NoiseSuppression,
                "recording" => DetailRecordType.Recording,
                "sip-trunking" => DetailRecordType.SipTrunking,
                "siprec-client" => DetailRecordType.SiprecClient,
                "stt" => DetailRecordType.Stt,
                "tts" => DetailRecordType.Tts,
                "verify" => DetailRecordType.Verify,
                "webrtc" => DetailRecordType.Webrtc,
                "wireless" => DetailRecordType.Wireless,
                _ => throw new JsonException($"Unknown DetailRecordType value: {value}")
            };
        }

        public override void Write(Utf8JsonWriter writer, DetailRecordType value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                DetailRecordType.AiVoiceAssistant => "ai-voice-assistant",
                DetailRecordType.Amd => "amd",
                DetailRecordType.CallControl => "call-control",
                DetailRecordType.Conference => "conference",
                DetailRecordType.ConferenceParticipant => "conference-participant",
                DetailRecordType.Embedding => "embedding",
                DetailRecordType.Fax => "fax",
                DetailRecordType.Inference => "inference",
                DetailRecordType.InferenceSpeechToText => "inference-speech-to-text",
                DetailRecordType.MediaStorage => "media_storage",
                DetailRecordType.MediaStreaming => "media-streaming",
                DetailRecordType.Messaging => "messaging",
                DetailRecordType.NoiseSuppression => "noise-suppression",
                DetailRecordType.Recording => "recording",
                DetailRecordType.SipTrunking => "sip-trunking",
                DetailRecordType.SiprecClient => "siprec-client",
                DetailRecordType.Stt => "stt",
                DetailRecordType.Tts => "tts",
                DetailRecordType.Verify => "verify",
                DetailRecordType.Webrtc => "webrtc",
                DetailRecordType.Wireless => "wireless",
                _ => throw new JsonException($"Unknown DetailRecordType value: {value}")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
