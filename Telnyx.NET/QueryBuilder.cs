using System.Text;

namespace Telnyx.NET
{
    public class QueryBuilder
    {
        private readonly StringBuilder _builder = new();

        public QueryBuilder AddFilter(string key, string? value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                _builder.Append($"&filter[{key}]={Uri.EscapeDataString(value)}");
            }
            return this;
        }

        public QueryBuilder AddFilterList(string key, IEnumerable<string>? values)
        {
            if (values != null)
            {
                foreach (var value in values)
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
