using System.Text.Json;
using Telnyx.NET.Enums;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="PortingOrderStatus"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class PortingOrderStatusConverter : JsonConverter<PortingOrderStatus>
    {
        public override PortingOrderStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "activation-in-progress" => PortingOrderStatus.ActivationInProgress,
                "cancel-pending" => PortingOrderStatus.CancelPending,
                "cancelled" => PortingOrderStatus.Cancelled,
                "draft" => PortingOrderStatus.Draft,
                "exception" => PortingOrderStatus.Exception,
                "foc-date-confirmed" => PortingOrderStatus.FocDateConfirmed,
                "in-process" => PortingOrderStatus.InProcess,
                "ported" => PortingOrderStatus.Ported,
                "submitted" => PortingOrderStatus.Submitted,
                _ => throw new JsonException($"Value '{value}' is not supported for PortingOrderStatus enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, PortingOrderStatus value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                PortingOrderStatus.ActivationInProgress => "activation-in-progress",
                PortingOrderStatus.CancelPending => "cancel-pending",
                PortingOrderStatus.Cancelled => "cancelled",
                PortingOrderStatus.Draft => "draft",
                PortingOrderStatus.Exception => "exception",
                PortingOrderStatus.FocDateConfirmed => "foc-date-confirmed",
                PortingOrderStatus.InProcess => "in-process",
                PortingOrderStatus.Ported => "ported",
                PortingOrderStatus.Submitted => "submitted",
                _ => throw new JsonException($"Value '{value}' is not supported for PortingOrderStatus enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
