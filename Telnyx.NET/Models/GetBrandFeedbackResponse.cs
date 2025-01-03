using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    public class GetBrandFeedbackResponse : TelnyxResponse
    {
        /// <summary>
        /// The ID of the brand being queried.
        /// </summary>
        [JsonPropertyName("brandId")]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// A list of categories containing the feedback for the brand.
        /// </summary>
        [JsonPropertyName("category")]
        public List<Category>? Category { get; set; }

        /// <summary>
        /// Represents any errors encountered during the retrieval of the auto-response setting.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }

    public class Category
    {
        /// <summary>
        /// The ID of the category (e.g., TAX_ID, STOCK_SYMBOL, etc.)
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// The human-readable version of the category ID.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; } = string.Empty;

        /// <summary>
        /// A long-form description of the issue associated with the category.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// A list of relevant fields in the originally submitted brand JSON.
        /// </summary>
        [JsonPropertyName("fields")]
        public List<string> Fields { get; set; } = new();
    }
}