using System.Text.Json.Serialization;

namespace Telnyx.NET.Models;

public class PaginationMeta
{
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }

    [JsonPropertyName("page_number")]
    public int PageNumber { get; set; }

    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }
}