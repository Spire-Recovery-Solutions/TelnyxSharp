using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Sort
    {
        [JsonPropertyName("assignedCampaignsCount")]
        AssignedCampaignsCount,

        [JsonPropertyName("-assignedCampaignsCount")]
        AssignedCampaignsCountDesc,

        [JsonPropertyName("brandId")]
        BrandId,

        [JsonPropertyName("-brandId")]
        BrandIdDesc,

        [JsonPropertyName("createdAt")]
        CreatedAt,

        [JsonPropertyName("-createdAt")]
        CreatedAtDesc,

        [JsonPropertyName("displayName")]
        DisplayName,

        [JsonPropertyName("-displayName")]
        DisplayNameDesc,

        [JsonPropertyName("identityStatus")]
        IdentityStatus,

        [JsonPropertyName("-identityStatus")]
        IdentityStatusDesc,

        [JsonPropertyName("status")]
        Status,

        [JsonPropertyName("-status")]
        StatusDesc,

        [JsonPropertyName("tcrBrandId")]
        TcrBrandId,

        [JsonPropertyName("-tcrBrandId")]
        TcrBrandIdDesc
    }
}
