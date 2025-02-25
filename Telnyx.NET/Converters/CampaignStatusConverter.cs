using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="CampaignStatus"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class CampaignStatusConverter : JsonConverter<CampaignStatus>
    {
        /// <summary>
        /// Reads and deserializes a JSON string into a <see cref="CampaignStatus"/> enum value.
        /// </summary>
        /// <param name="reader">The UTF-8 JSON reader.</param>
        /// <param name="typeToConvert">The type to convert (always <see cref="CampaignStatus"/>).</param>
        /// <param name="options">Serialization options.</param>
        /// <returns>A corresponding <see cref="CampaignStatus"/> enum value.</returns>
        /// <exception cref="JsonException">Thrown when the JSON value is not recognized.</exception>
        public override CampaignStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "TCR_PENDING" => CampaignStatus.TcrPending,
                "TCR_SUSPENDED" => CampaignStatus.TcrSuspended,
                "TCR_EXPIRED" => CampaignStatus.TcrExpired,
                "TCR_ACCEPTED" => CampaignStatus.TcrAccepted,
                "TCR_FAILED" => CampaignStatus.TcrFailed,
                "TELNYX_ACCEPTED" => CampaignStatus.TelnyxAccepted,
                "TELNYX_FAILED" => CampaignStatus.TelnyxFailed,
                "MNO_PENDING" => CampaignStatus.MnoPending,
                "MNO_ACCEPTED" => CampaignStatus.MnoAccepted,
                "MNO_REJECTED" => CampaignStatus.MnoRejected,
                "MNO_PROVISIONED" => CampaignStatus.MnoProvisioned,
                "MNO_PROVISIONING_FAILED" => CampaignStatus.MnoProvisioningFailed,
                _ => throw new JsonException($"Value '{value}' is not supported for CampaignStatus enum")
            };
        }

        /// <summary>
        /// Serializes a <see cref="CampaignStatus"/> enum value into its corresponding string representation.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="CampaignStatus"/> enum value to serialize.</param>
        /// <param name="options">Serialization options.</param>
        /// <exception cref="JsonException">Thrown when an unsupported enum value is encountered.</exception>
        public override void Write(Utf8JsonWriter writer, CampaignStatus value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                CampaignStatus.TcrPending => "TCR_PENDING",
                CampaignStatus.TcrSuspended => "TCR_SUSPENDED",
                CampaignStatus.TcrExpired => "TCR_EXPIRED",
                CampaignStatus.TcrAccepted => "TCR_ACCEPTED",
                CampaignStatus.TcrFailed => "TCR_FAILED",
                CampaignStatus.TelnyxAccepted => "TELNYX_ACCEPTED",
                CampaignStatus.TelnyxFailed => "TELNYX_FAILED",
                CampaignStatus.MnoPending => "MNO_PENDING",
                CampaignStatus.MnoAccepted => "MNO_ACCEPTED",
                CampaignStatus.MnoRejected => "MNO_REJECTED",
                CampaignStatus.MnoProvisioned => "MNO_PROVISIONED",
                CampaignStatus.MnoProvisioningFailed => "MNO_PROVISIONING_FAILED",
                _ => throw new JsonException($"Value '{value}' is not supported for CampaignStatus enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
