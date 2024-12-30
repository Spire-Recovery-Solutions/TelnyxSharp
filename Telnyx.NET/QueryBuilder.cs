using System.Text;
using System.Text.Json.Serialization;
using System.Reflection;

namespace Telnyx.NET
{
    public class QueryBuilder
    {
        private readonly StringBuilder _builder = new();

        public QueryBuilder AddFilter(string key, Enum? value)
        {
            if (value != null)
            {
                var stringValue = GetEnumValue(value);
                if (!string.IsNullOrEmpty(stringValue))
                {
                    _builder.Append($"&filter[{key}]={Uri.EscapeDataString(stringValue)}");
                }
            }
            return this;
        }

        public QueryBuilder AddFilter(string key, string? value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                _builder.Append($"&filter[{key}]={Uri.EscapeDataString(value)}");
            }
            return this;
        }

        private static string GetEnumValue(Enum value)
        {
            var memberInfo = value.GetType().GetMember(value.ToString())[0];
            var attribute = memberInfo.GetCustomAttribute<JsonPropertyNameAttribute>();
            return attribute?.Name ?? value.ToString();
        }

        public QueryBuilder AddFilterList(string key, IEnumerable<string>? values)
        {
            if (values?.Any() == true)
            {
                foreach (var value in values.Where(v => !string.IsNullOrEmpty(v)))
                {
                    _builder.Append($"&filter[{key}][]={Uri.EscapeDataString(value)}");
                }
            }
            return this;
        }

        public QueryBuilder AddPagination(int? pageNumber, int? pageSize)
        {
            if (pageNumber.HasValue)
            {
                _builder.Append($"&page[number]={pageNumber.Value}");
            }
            if (pageSize.HasValue)
            {
                var size = Math.Min(pageSize.Value, 250);
                _builder.Append($"&page[size]={size}");
            }
            return this;
        }

        public override string ToString() => _builder.ToString().TrimStart('&');
    }
}