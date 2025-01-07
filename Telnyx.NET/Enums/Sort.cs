using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the available sorting options for the data.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Sort
    {
        /// <summary>
        /// Sort by the count of assigned campaigns in ascending order.
        /// </summary>
        [JsonPropertyName("assignedCampaignsCount")]
        AssignedCampaignsCountAsc,

        /// <summary>
        /// Sort by the count of assigned campaigns in descending order.
        /// </summary>
        [JsonPropertyName("-assignedCampaignsCount")]
        AssignedCampaignsCountDesc,

        /// <summary>
        /// Sort by the brand ID in ascending order.
        /// </summary>
        [JsonPropertyName("brandId")]
        BrandIdAsc,

        /// <summary>
        /// Sort by the brand ID in descending order.
        /// </summary>
        [JsonPropertyName("-brandId")]
        BrandIdDesc,

        /// <summary>
        /// Sort by the creation date in ascending order.
        /// </summary>
        [JsonPropertyName("createdAt")]
        CreatedAtAsc,

        /// <summary>
        /// Sort by the creation date in descending order.
        /// </summary>
        [JsonPropertyName("-createdAt")]
        CreatedAtDesc,

        /// <summary>
        /// Sort by the display name in ascending order.
        /// </summary>
        [JsonPropertyName("displayName")]
        DisplayNameAsc,

        /// <summary>
        /// Sort by the display name in descending order.
        /// </summary>
        [JsonPropertyName("-displayName")]
        DisplayNameDesc,

        /// <summary>
        /// Sort by the identity status in ascending order.
        /// </summary>
        [JsonPropertyName("identityStatus")]
        IdentityStatusAsc,

        /// <summary>
        /// Sort by the identity status in descending order.
        /// </summary>
        [JsonPropertyName("-identityStatus")]
        IdentityStatusDesc,

        /// <summary>
        /// Sort by the status in ascending order.
        /// </summary>
        [JsonPropertyName("status")]
        StatusAsc,

        /// <summary>
        /// Sort by the status in descending order.
        /// </summary>
        [JsonPropertyName("-status")]
        StatusDesc,

        /// <summary>
        /// Sort by the TCR brand ID in ascending order.
        /// </summary>
        [JsonPropertyName("tcrBrandId")]
        TcrBrandIdAsc,

        /// <summary>
        /// Sort by the TCR brand ID in descending order.
        /// </summary>
        [JsonPropertyName("-tcrBrandId")]
        TcrBrandIdDesc
    }
}