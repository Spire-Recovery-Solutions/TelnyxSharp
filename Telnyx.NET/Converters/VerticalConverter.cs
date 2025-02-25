using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="Vertical"/> enum.
    /// </summary>
    public class VerticalConverter : JsonConverter<Vertical>
    {
        public override Vertical Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "REAL_ESTATE" => Vertical.RealEstate,
                "HEALTHCARE" => Vertical.Healthcare,
                "ENERGY" => Vertical.Energy,
                "ENTERTAINMENT" => Vertical.Entertainment,
                "RETAIL" => Vertical.Retail,
                "AGRICULTURE" => Vertical.Agriculture,
                "INSURANCE" => Vertical.Insurance,
                "EDUCATION" => Vertical.Education,
                "HOSPITALITY" => Vertical.Hospitality,
                "FINANCIAL" => Vertical.Financial,
                "GAMBLING" => Vertical.Gambling,
                "CONSTRUCTION" => Vertical.Construction,
                "NGO" => Vertical.NGO,
                "MANUFACTURING" => Vertical.Manufacturing,
                "GOVERNMENT" => Vertical.Government,
                "TECHNOLOGY" => Vertical.Technology,
                "COMMUNICATION" => Vertical.Communication,
                "Unknown" => Vertical.Unknown,
                _ => throw new JsonException($"Value '{value}' is not supported for Vertical enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, Vertical value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                Vertical.RealEstate => "REAL_ESTATE",
                Vertical.Healthcare => "HEALTHCARE",
                Vertical.Energy => "ENERGY",
                Vertical.Entertainment => "ENTERTAINMENT",
                Vertical.Retail => "RETAIL",
                Vertical.Agriculture => "AGRICULTURE",
                Vertical.Insurance => "INSURANCE",
                Vertical.Education => "EDUCATION",
                Vertical.Hospitality => "HOSPITALITY",
                Vertical.Financial => "FINANCIAL",
                Vertical.Gambling => "GAMBLING",
                Vertical.Construction => "CONSTRUCTION",
                Vertical.NGO => "NGO",
                Vertical.Manufacturing => "MANUFACTURING",
                Vertical.Government => "GOVERNMENT",
                Vertical.Technology => "TECHNOLOGY",
                Vertical.Communication => "COMMUNICATION",
                Vertical.Unknown => "Unknown",
                _ => throw new JsonException($"Value '{value}' is not supported for Vertical enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
