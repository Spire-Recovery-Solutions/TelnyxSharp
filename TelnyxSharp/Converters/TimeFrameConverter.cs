using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="TimeFrame"/> enum.
    /// </summary>
    public class TimeFrameConverter : JsonConverter<TimeFrame>
    {
        public override TimeFrame Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "1h" => TimeFrame.OneHour,
                "3h" => TimeFrame.ThreeHours,
                "24h" => TimeFrame.TwentyFourHours,
                "3d" => TimeFrame.ThreeDays,
                "7d" => TimeFrame.SevenDays,
                "30d" => TimeFrame.ThirtyDays,
                _ => throw new JsonException($"Value '{value}' is not supported for TimeFrame enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, TimeFrame value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                TimeFrame.OneHour => "1h",
                TimeFrame.ThreeHours => "3h",
                TimeFrame.TwentyFourHours => "24h",
                TimeFrame.ThreeDays => "3d",
                TimeFrame.SevenDays => "7d",
                TimeFrame.ThirtyDays => "30d",
                _ => throw new JsonException($"Value '{value}' is not supported for TimeFrame enum")
            };
            writer.WriteStringValue(stringValue);
        }
    }
}
