using System.Text;
using System.Text.Json.Serialization;
using System.Reflection;
using RestSharp;

namespace Telnyx.NET
{

    public static class RestRequestQueryBuilderExtensions
    {
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
        
        public static RestRequest AddFilter(this RestRequest request, string key, string? value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                request.AddParameter(key, value, ParameterType.QueryString);
            }
            return request;
        }

        private static string GetEnumValue(Enum value)
        {
            var memberInfo = value.GetType().GetMember(value.ToString())[0];
            var attribute = memberInfo.GetCustomAttribute<JsonPropertyNameAttribute>();
            return attribute?.Name ?? value.ToString();
        }

        public static RestRequest AddFilterList(this RestRequest request, string key, List<string> values)
        {
            if (!values.Any()) return request;
            foreach (var value in values.Where(v => !string.IsNullOrEmpty(v)))
            {
                request.AddParameter($"{key}[]", value, ParameterType.QueryString);
            }
            return request;
        }

        public static RestRequest AddPagination(this RestRequest request, int? pageSize)
        {
            var size = Math.Min(pageSize ?? 50, 250);
            request.AddParameter("page[size]", size, ParameterType.QueryString);
            request.AddParameter("page[number]", 1, ParameterType.QueryString); // Always start with page 1
        
            return request;
        }
    }
}