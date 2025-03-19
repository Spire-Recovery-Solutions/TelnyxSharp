using RestSharp;
using System.Text.Json;
using TelnyxSharp.Enums;
namespace TelnyxSharp
{
    /// <summary>
    /// Provides extension methods for RestRequest to add query parameters and filters.
    /// </summary>
    public static class RestRequestQueryBuilderExtensions
    {
        private const int DefaultPageSize = 50;
        private const int MaxPageSize = 250;
        private const int MinPageSize = 1;

        /// <summary>
        /// Adds a filter with an enum value to the request query parameters.
        /// Uses JsonPropertyName attribute value if available.
        /// </summary>
        public static RestRequest AddFilter(this RestRequest request, string key, object? value = null, FilterOperator? filterOperator = null)
        {
            if (value == null || (value is string strValue && string.IsNullOrWhiteSpace(strValue)))
            {
                return request;
            }

            string? filterOperatorStr = filterOperator.HasValue
                ? JsonSerializer.Serialize(filterOperator.Value).Trim('"')
                : null;

            var finalKey = string.IsNullOrWhiteSpace(filterOperatorStr)
                ? key
                : $"{key}[{filterOperatorStr}]";

            switch (value)
            {
                case Enum @enum:
                    var enumType = @enum.GetType();
                    var stringValue = JsonSerializer.Serialize(@enum, enumType).Trim('"');
                    request.AddParameter(finalKey, stringValue, ParameterType.QueryString);
                    break;
                default:
                    request.AddParameter(finalKey, value, ParameterType.QueryString);
                    break;
            }
            return request;
        }

        /// <summary>
        /// Adds a list of values as query parameters with array notation.
        /// Filters out null, empty, or whitespace-only values.
        /// </summary>
        public static RestRequest AddFilterList(this RestRequest request, string key, List<string>? values)
        {
            if (values == null || values.Count == 0) return request;
            foreach (var value in values.Where(v => !string.IsNullOrWhiteSpace(v)))
            {
                request.AddParameter($"{key}[]", value, ParameterType.QueryString);
            }
            return request;
        }
        /// <summary>
        /// Adds pagination parameters to the request.
        /// Page size is constrained between 1 and 250, defaulting to 50.
        /// Page number always starts at 1.
        /// </summary>
        public static RestRequest AddPagination(this RestRequest request, int? pageSize)
        {
            var size = Math.Min(MaxPageSize,
                      Math.Max(MinPageSize,
                      pageSize ?? DefaultPageSize));
            request.AddParameter("page[size]", size, ParameterType.QueryString);
            request.AddParameter("page[number]", 1, ParameterType.QueryString);

            return request;
        }
    }
}