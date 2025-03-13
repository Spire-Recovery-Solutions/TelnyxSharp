using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="MessageType"/> enum.
    /// </summary>
    public class MessageTypeConverter : JsonConverter<MessageType>
    {
        public override MessageType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "long-code"   => MessageType.LongCode,
                "toll-free"   => MessageType.TollFree,
                "short-code"  => MessageType.ShortCode,
                "longcode"    => MessageType.Longcode,
                "tollfree"    => MessageType.Tollfree,
                "shortcode"   => MessageType.Shortcode,
                "SMS"         => MessageType.Sms,
                "MMS"         => MessageType.Mms,
                "Unknown"     => MessageType.Unknown,
                _             => throw new JsonException($"Value '{value}' is not supported for MessageType enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, MessageType value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                MessageType.LongCode   => "long-code",
                MessageType.TollFree   => "toll-free",
                MessageType.ShortCode  => "short-code",
                MessageType.Longcode   => "longcode",
                MessageType.Tollfree   => "tollfree",
                MessageType.Shortcode  => "shortcode",
                MessageType.Sms        => "SMS",
                MessageType.Mms        => "MMS",
                MessageType.Unknown    => "Unknown",
                _                      => throw new JsonException($"Value '{value}' is not supported for MessageType enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}