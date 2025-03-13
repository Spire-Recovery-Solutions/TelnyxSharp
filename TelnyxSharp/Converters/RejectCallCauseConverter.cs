using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="RejectCallCause"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class RejectCallCauseConverter : JsonConverter<RejectCallCause>
    {
        public override RejectCallCause Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "UNKNOWN" => RejectCallCause.Unknown,
                "CALL_REJECTED" => RejectCallCause.CallRejected,
                "USER_BUSY" => RejectCallCause.UserBusy,
                _ => throw new JsonException($"Value '{value}' is not supported for RejectCallCause enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, RejectCallCause value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                RejectCallCause.Unknown => "UNKNOWN",
                RejectCallCause.CallRejected => "CALL_REJECTED",
                RejectCallCause.UserBusy => "USER_BUSY",
                _ => throw new JsonException($"Value '{value}' is not supported for RejectCallCause enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
