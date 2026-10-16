using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// Reads an integer that the Telnyx API sends either as a JSON number or as a JSON string.
    /// Telnyx error envelopes send <c>code</c> as a string (for example <c>"10005"</c>), which the
    /// default <see cref="int"/> handling rejects, discarding the whole error body.
    /// A string that is not a valid integer reads as 0.
    /// </summary>
    public class StringOrNumberIntConverter : JsonConverter<int>
    {
        /// <inheritdoc />
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.TokenType switch
            {
                JsonTokenType.Number => reader.GetInt32(),
                JsonTokenType.String => int.TryParse(reader.GetString(), NumberStyles.Integer,
                    CultureInfo.InvariantCulture, out var value) ? value : 0,
                JsonTokenType.Null => 0,
                _ => throw new JsonException($"Unexpected token {reader.TokenType} for an integer value.")
            };
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value);
    }
}
