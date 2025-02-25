using System.Text;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;
using System.Text.Json;
namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="Sort"/> enum.
    /// This converter handles serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class SortConverter : JsonConverter<Sort>
    {
        public override Sort Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "assignedCampaignsCount" => Sort.AssignedCampaignsCountAsc,
                "-assignedCampaignsCount" => Sort.AssignedCampaignsCountDesc,
                "brandId" => Sort.BrandIdAsc,
                "-brandId" => Sort.BrandIdDesc,
                "createdAt" => Sort.CreatedAtAsc,
                "-createdAt" => Sort.CreatedAtDesc,
                "displayName" => Sort.DisplayNameAsc,
                "-displayName" => Sort.DisplayNameDesc,
                "identityStatus" => Sort.IdentityStatusAsc,
                "-identityStatus" => Sort.IdentityStatusDesc,
                "status" => Sort.StatusAsc,
                "-status" => Sort.StatusDesc,
                "tcrBrandId" => Sort.TcrBrandIdAsc,
                "-tcrBrandId" => Sort.TcrBrandIdDesc,
                _ => throw new JsonException($"Value '{value}' is not supported for Sort enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, Sort value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                Sort.AssignedCampaignsCountAsc => "assignedCampaignsCount",
                Sort.AssignedCampaignsCountDesc => "-assignedCampaignsCount",
                Sort.BrandIdAsc => "brandId",
                Sort.BrandIdDesc => "-brandId",
                Sort.CreatedAtAsc => "createdAt",
                Sort.CreatedAtDesc => "-createdAt",
                Sort.DisplayNameAsc => "displayName",
                Sort.DisplayNameDesc => "-displayName",
                Sort.IdentityStatusAsc => "identityStatus",
                Sort.IdentityStatusDesc => "-identityStatus",
                Sort.StatusAsc => "status",
                Sort.StatusDesc => "-status",
                Sort.TcrBrandIdAsc => "tcrBrandId",
                Sort.TcrBrandIdDesc => "-tcrBrandId",
                _ => throw new JsonException($"Value '{value}' is not supported for Sort enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
