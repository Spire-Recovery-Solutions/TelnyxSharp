using System.Text.Json.Serialization;
using System.Reflection;
using RestSharp;

namespace Telnyx.NET
{
    /// <summary>
    /// Provides extension methods for <see cref="RestRequest"/> to add query parameters, filters, 
    /// pagination, and other request-specific configurations to an API call.
    /// </summary>
    public static class RestRequestQueryBuilderExtensions
    {
        /// <summary>
        /// Adds a filter with an enum value to the request query parameters.
        /// If the enum has a <see cref="JsonPropertyNameAttribute"/>, its value is used in the query.
        /// </summary>
        /// <param name="request">The RestRequest object to which the filter is added.</param>
        /// <param name="key">The key for the query parameter.</param>
        /// <param name="value">The enum value to be converted to string and added as the value for the filter.</param>
        /// <returns>The updated RestRequest object.</returns>
        public static RestRequest AddFilter(this RestRequest request, string key, Enum? value)
        {
            if (value == null) return request;
            var stringValue = GetEnumValue(value);
            if (!string.IsNullOrEmpty(stringValue))
            {
                request.AddParameter(key, stringValue, ParameterType.QueryString);
            }
            return request;
        }
        
        /// <summary>
        /// Adds a filter with a string value to the request query parameters.
        /// Only non-null, non-empty string values are added as query parameters.
        /// </summary>
        /// <param name="request">The RestRequest object to which the filter is added.</param>
        /// <param name="key">The key for the query parameter.</param>
        /// <param name="value">The string value to be added as the value for the filter.</param>
        /// <returns>The updated RestRequest object.</returns>
        public static RestRequest AddFilter(this RestRequest request, string key, string? value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                request.AddParameter(key, value, ParameterType.QueryString);
            }
            return request;
        }

        /// <summary>
        /// Retrieves the string value of an enum, using its <see cref="JsonPropertyNameAttribute"/>
        /// if available, otherwise returns the enum name.
        /// </summary>
        /// <param name="value">The enum value whose string representation is needed.</param>
        /// <returns>The string representation of the enum value.</returns>
        private static string GetEnumValue(Enum value)
        {
            var memberInfo = value.GetType().GetMember(value.ToString())[0];
            var attribute = memberInfo.GetCustomAttribute<JsonPropertyNameAttribute>();
            return attribute?.Name ?? value.ToString();
        }

        /// <summary>
        /// Adds a list of values as query parameters to the request.
        /// Each value in the list is added as an individual query parameter with the key suffixed with "[]".
        /// </summary>
        /// <param name="request">The RestRequest object to which the filters are added.</param>
        /// <param name="key">The key for the query parameter.</param>
        /// <param name="values">The list of string values to be added as query parameters.</param>
        /// <returns>The updated RestRequest object.</returns>
        public static RestRequest AddFilterList(this RestRequest request, string key, List<string>? values)
        {
            if (values is null or { Count: 0 }) return request;
            foreach (var value in values.Where(v => !string.IsNullOrEmpty(v)))
            {
                request.AddParameter($"{key}[]", value, ParameterType.QueryString);
            }

            return request;
        }

        /// <summary>
        /// Adds pagination parameters to the request query.
        /// The page size is constrained to a maximum of 250, and the page number is set to 1 by default.
        /// </summary>
        /// <param name="request">The RestRequest object to which the pagination parameters are added.</param>
        /// <param name="pageSize">The number of items per page (optional).</param>
        /// <returns>The updated RestRequest object with pagination parameters.</returns>
        public static RestRequest AddPagination(this RestRequest request, int? pageSize)
        {
            var size = Math.Min(pageSize ?? 50, 250);
            request.AddParameter("page[size]", size, ParameterType.QueryString);
            request.AddParameter("page[number]", 1, ParameterType.QueryString); // Always start with page 1
        
            return request;
        }
    }
}