using System.Text.Json.Serialization;
using TelnyxSharp.Converters;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the available sorting options for the data.
    /// </summary>
    [JsonConverter(typeof(SortConverter))]
    public enum Sort
    {
        /// <summary>
        /// Sort by the count of assigned campaigns in ascending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("assignedCampaignsCount")]
        AssignedCampaignsCountAsc,

        /// <summary>
        /// Sort by the count of assigned campaigns in descending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("-assignedCampaignsCount")]
        AssignedCampaignsCountDesc,

        /// <summary>
        /// Sort by the brand ID in ascending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("brandId")]
        BrandIdAsc,

        /// <summary>
        /// Sort by the brand ID in descending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("-brandId")]
        BrandIdDesc,

        /// <summary>
        /// Sort by the creation date in ascending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("createdAt")]
        CreatedAtAsc,

        /// <summary>
        /// Sort by the creation date in descending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("-createdAt")]
        CreatedAtDesc,

        /// <summary>
        /// Sort by the display name in ascending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("displayName")]
        DisplayNameAsc,

        /// <summary>
        /// Sort by the display name in descending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("-displayName")]
        DisplayNameDesc,

        /// <summary>
        /// Sort by the identity status in ascending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("identityStatus")]
        IdentityStatusAsc,

        /// <summary>
        /// Sort by the identity status in descending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("-identityStatus")]
        IdentityStatusDesc,

        /// <summary>
        /// Sort by the status in ascending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("status")]
        StatusAsc,

        /// <summary>
        /// Sort by the status in descending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("-status")]
        StatusDesc,

        /// <summary>
        /// Sort by the TCR brand ID in ascending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("tcrBrandId")]
        TcrBrandIdAsc,

        /// <summary>
        /// Sort by the TCR brand ID in descending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("-tcrBrandId")]
        TcrBrandIdDesc
    }
}