using RestSharp;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Tests
{
    public class RestRequestQueryBuilderTests
    {
        private readonly RestRequest _sut = new();

        [JsonConverter(typeof(JsonStringEnumConverter))]
        private enum TestStatus
        {
            [JsonStringEnumMemberName("active_status")]
            Active,

            [JsonStringEnumMemberName("inactive_status")]
            Inactive
        }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        private enum PlainEnum
        {
            First,
            Second,
            Third
        }

        private string GetQueryString(RestRequest request)
        {
            var parameters = request.Parameters
                .Where(p => p.Type == ParameterType.QueryString)
                .OrderBy(p => p.Name)
                .Select(p => $"{p.Name}={p.Value?.ToString()}");

            return string.Join("&", parameters);
        }

        [Fact]
        public void AddFilter_WithEnum_GeneratesCorrectQueryString()
        {
            var request = _sut.AddFilter("status", TestStatus.Active);
            Assert.Equal("status=active_status", GetQueryString(request));
        }

        [Fact]
        public void AddFilter_WithPlainEnum_GeneratesCorrectQueryString()
        {
            var request = _sut.AddFilter("level", PlainEnum.First);
            Assert.Equal("level=First", GetQueryString(request));
        }

        [Fact]
        public void AddFilter_WithNullEnum_GeneratesEmptyQueryString()
        {
            var request = _sut.AddFilter("status", null as TestStatus?);
            Assert.Equal("", GetQueryString(request));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("   ")]
        [InlineData("\t")]
        [InlineData("\n")]
        [InlineData("\r\n")]
        public void AddFilter_WithNullOrWhitespace_GeneratesEmptyQueryString(string? value)
        {
            var request = _sut.AddFilter("key", value);
            Assert.Equal("", GetQueryString(request));
        }

        [Theory]
        [InlineData("simple", "value", "simple=value")]
        [InlineData("key with space", "value with space", "key with space=value with space")]
        [InlineData("key", "!@#$%", "key=!@#$%")]
        [InlineData("key", "value&more", "key=value&more")]
        [InlineData("key", " value ", "key= value ")] // Preserves meaningful whitespace
        public void AddFilter_WithValidString_GeneratesCorrectQueryString(string key, string value, string expected)
        {
            var request = _sut.AddFilter(key, value);
            Assert.Equal(expected, GetQueryString(request));
        }

        [Fact]
        public void AddFilterList_WithNullList_GeneratesEmptyQueryString()
        {
            var request = _sut.AddFilterList("tags", null);
            Assert.Equal("", GetQueryString(request));
        }

        [Fact]
        public void AddFilterList_WithEmptyList_GeneratesEmptyQueryString()
        {
            var request = _sut.AddFilterList("tags", new List<string>());
            Assert.Equal("", GetQueryString(request));
        }

        [Fact]
        public void AddFilterList_WithValues_GeneratesArrayStyleQueryString()
        {
            var values = new List<string> { "one", "two", "three" };
            var request = _sut.AddFilterList("items", values);
            Assert.Equal("items[]=one&items[]=two&items[]=three", GetQueryString(request));
        }

        [Fact]
        public void AddFilterList_WithMixedValues_FiltersOutInvalidValues()
        {
            var values = new List<string> { "valid", "", null, "also-valid", " ", "\t", "  valid-too  " };
            var request = _sut.AddFilterList("tags", values);
            Assert.Equal("tags[]=valid&tags[]=also-valid&tags[]=  valid-too  ", GetQueryString(request));
        }

        [Theory]
        [InlineData(10, "page[number]=1&page[size]=10")]
        [InlineData(0, "page[number]=1&page[size]=1")]    // Below minimum
        [InlineData(-1, "page[number]=1&page[size]=1")]   // Below minimum
        [InlineData(300, "page[number]=1&page[size]=250")] // Above maximum
        [InlineData(null, "page[number]=1&page[size]=50")] // Default value
        public void AddPagination_GeneratesCorrectQueryString(int? pageSize, string expected)
        {
            var request = _sut.AddPagination(pageSize);
            Assert.Equal(expected, GetQueryString(request));
        }

        [Fact]
        public void QueryBuilder_CombiningMultipleFilters_GeneratesCorrectQueryString()
        {
            var request = _sut
                .AddFilter("status", TestStatus.Active)
                .AddFilter("type", "customer")
                .AddFilterList("tags", new List<string> { "new", "vip" })
                .AddPagination(50);

            var queryString = GetQueryString(request);
            Assert.Equal("page[number]=1&page[size]=50&status=active_status&tags[]=new&tags[]=vip&type=customer", queryString);
        }

        [Fact]
        public void QueryBuilder_WithSpecialCharacters_GeneratesCorrectQueryString()
        {
            var request = _sut.AddFilter("complex", "Hello & World!")
                            .AddFilterList("tags", new List<string> { "tag&value", "special!char" });

            Assert.Equal("complex=Hello & World!&tags[]=tag&value&tags[]=special!char", GetQueryString(request));
        }


        [Fact]
        public void AddFilter_WithOperator_GeneratesCorrectQueryString()
        {
            var request = _sut.AddFilter("filter[created_at]", "2023-01-01", FilterOperator.StartsWith);
            Assert.Equal("filter[created_at][starts_with]=2023-01-01", GetQueryString(request));
        }

        [Fact]
        public void AddFilter_WithEnumAndOperator_GeneratesCorrectQueryString()
        {
            var request = _sut.AddFilter("filter[status]", TestStatus.Active, FilterOperator.Equals);
            Assert.Equal("filter[status][eq]=active_status", GetQueryString(request));
        }

        [Fact]
        public void AddFilter_WithPreformattedKeyAndOperator_AppendsOperatorCorrectly()
        {
            var request = _sut.AddFilter("custom_key", "value", FilterOperator.Contains);
            Assert.Equal("custom_key[contains]=value", GetQueryString(request));
        }

        [Fact]
        public void AddFilter_WithMultipleOperators_GeneratesDistinctParameters()
        {
            var request = _sut
                .AddFilter("filter[created_at]", "2023-01-01", FilterOperator.GreaterThanOrEqualTo)
                .AddFilter("filter[created_at]", "2023-12-31", FilterOperator.LessThanOrEqualTo);
            Assert.Equal("filter[created_at][gte]=2023-01-01&filter[created_at][lte]=2023-12-31", GetQueryString(request));
        }

        [Fact]
        public void AddFilter_WithComplexFilterChain_GeneratesCorrectQueryString()
        {
            var request = _sut
                .AddFilter("filter[record_type]", DetailRecordType.Conference)
                .AddFilter("filter[direction]", "inbound")
                .AddFilter("filter[created_at]", "2023-01-01", FilterOperator.GreaterThanOrEqualTo)
                .AddFilter("filter[created_at]", "2023-12-31", FilterOperator.LessThanOrEqualTo)
                .AddFilter("filter[status]", TestStatus.Active)
                .AddFilter("sort", "created_at");

            Assert.Equal("filter[created_at][gte]=2023-01-01&filter[created_at][lte]=2023-12-31&filter[direction]=inbound&filter[record_type]=conference&filter[status]=active_status&sort=created_at", GetQueryString(request));
        }

        [Fact]
        public void AddFilter_MultipleConditionsForSameField_GeneratesCorrectQueryString()
        {
            var request = _sut
                .AddFilter("filter[started_at]", "2022-02-02", FilterOperator.GreaterThan)
                .AddFilter("filter[started_at]", "2022-03-01", FilterOperator.LessThan);

            Assert.Equal("filter[started_at][gt]=2022-02-02&filter[started_at][lt]=2022-03-01", GetQueryString(request));
        }
    }
}