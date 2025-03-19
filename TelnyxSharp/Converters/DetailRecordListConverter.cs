using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.DetailRecords.Models.Responses;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for a list of <see cref="DetailRecordBase"/> objects.
    /// This converter deserializes an array of JSON objects into a polymorphic list of detail records
    /// based on the "record_type" property.
    /// </summary>
    public class DetailRecordListConverter : JsonConverter<List<DetailRecordBase>>
    {
        /// <summary>
        /// Reads and deserializes a JSON array into a list of <see cref="DetailRecordBase"/> objects.
        /// </summary>
        /// <param name="reader">The UTF-8 JSON reader.</param>
        /// <param name="typeToConvert">The type to convert (should be List&lt;DetailRecordBase&gt;).</param>
        /// <param name="options">Serialization options.</param>
        /// <returns>A list of detail records.</returns>
        /// <exception cref="JsonException">Thrown when the JSON does not start with an array or when a record_type is missing or unrecognized.</exception>
        public override List<DetailRecordBase> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Ensure we have a StartArray token.
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException("Expected StartArray token for detail record list.");
            }

            var list = new List<DetailRecordBase>();

            // Read each element in the array until the EndArray token is reached.
            while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
            {
                using var doc = JsonDocument.ParseValue(ref reader);

                // Ensure the JSON object has a "record_type" property.
                if (!doc.RootElement.TryGetProperty("record_type", out JsonElement recordTypeElement))
                {
                    throw new JsonException("Missing record_type property in detail record.");
                }

                string recordType = recordTypeElement.GetString();
                // Deserialize the JSON object into the appropriate concrete type based on the record_type value.
                DetailRecordBase record = recordType switch
                {
                    "message_detail_record" => JsonSerializer.Deserialize<MessageDetailRecord>(doc.RootElement.GetRawText(), options),
                    "conference_detail_record" => JsonSerializer.Deserialize<ConferenceDetailRecord>(doc.RootElement.GetRawText(), options),
                    "conference_participant_detail_record" => JsonSerializer.Deserialize<ConferenceParticipantDetailRecord>(doc.RootElement.GetRawText(), options),
                    "amd_detail_record" => JsonSerializer.Deserialize<AmdDetailRecord>(doc.RootElement.GetRawText(), options),
                    "verification_detail_record" => JsonSerializer.Deserialize<VerificationDetailRecord>(doc.RootElement.GetRawText(), options),
                    "sim_card_usage" => JsonSerializer.Deserialize<SimCardUsageDetailRecord>(doc.RootElement.GetRawText(), options),
                    "media_storage" => JsonSerializer.Deserialize<MediaStorageDetailRecord>(doc.RootElement.GetRawText(), options),
                    _ => throw new JsonException($"Unknown record_type: {recordType}")
                };

                list.Add(record);
            }

            return list;
        }

        /// <summary>
        /// Serializes a list of <see cref="DetailRecordBase"/> objects into a JSON array.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The list of detail records.</param>
        /// <param name="options">Serialization options.</param>
        public override void Write(Utf8JsonWriter writer, List<DetailRecordBase> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            foreach (var record in value)
            {
                // Serialize each record using its runtime type.
                JsonSerializer.Serialize(writer, record, record.GetType(), options);
            }
            writer.WriteEndArray();
        }
    }
}