using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="Track"/> enum.
    /// </summary>
    public class TrackConverter : JsonConverter<Track>
    {
        public override Track Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "inbound_track" => Track.InboundTrack,
                "outbound_track" => Track.OutboundTrack,
                "both_tracks" => Track.BothTracks,
                _ => throw new JsonException($"Value '{value}' is not supported for Track enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, Track value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                Track.InboundTrack => "inbound_track",
                Track.OutboundTrack => "outbound_track",
                Track.BothTracks => "both_tracks",
                _ => throw new JsonException($"Value '{value}' is not supported for Track enum")
            };
            writer.WriteStringValue(stringValue);
        }
    }
}
